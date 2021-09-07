using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace encryptor_CS_X
{
    public class Crypto
    {
        private Aes aes;
        private ICryptoTransform encryptor;
        private ICryptoTransform decryptor;

        public Crypto()
        {
            this.aes = KeyLoad("Key.key");
            this.encryptor = this.aes.CreateEncryptor(this.aes.Key, this.aes.IV);
            this.decryptor = this.aes.CreateDecryptor(this.aes.Key, this.aes.IV);
        }

        static Aes KeyGen(string fileName)
        {
            //creating the key file
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                //creating key
                var aes = Aes.Create();
                //wriing key into the file
                fileStream.Write(aes.Key, 0, aes.Key.Length);
                fileStream.Write(aes.IV, 0, aes.IV.Length);
                //returning key
                return aes;
            }
        }


        static Aes KeyLoad(string fileName)
        {
            //only if the file exists
            if (File.Exists(fileName))
            {
                //openin a file
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                {
                    //creating key
                    var aes = Aes.Create();
                    //if the file is in key size
                    if (fileStream.Length == 48)
                    {
                        //making the key parts
                        byte[] key = new byte[32];
                        byte[] iv = new byte[16];
                        //reading key parts into the key parts
                        fileStream.Read(key, 0, key.Length);
                        fileStream.Read(iv, 0, iv.Length);

                        //inserting key parts into the key
                        aes.Key = key;
                        aes.IV = iv;
                        //returning key
                        return aes;
                    }
                }
            }
            //if file does not exist or not in key size than generate key
            return KeyGen(fileName);
        }

        static async Task TransformAsync(string fileName, ICryptoTransform cryptoTransform)
        {
            //creating byte arrays
            byte[] bytes1;
            byte[] bytes2;
            //byteT is used to switch between byte 1 and byte 2
            byte[] byteT;

            //opening the targeted file
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
            {
                //readLength is made for the size that you want to read from file
                int readLength = 0;
                //giving byte array value
                bytes1 = new byte[1024];
                bytes2 = new byte[1024];
                //creating a temp file
                using (FileStream fileStream2 = new FileStream("temp.txt", FileMode.Create))
                {
                    //opening a cypto stream on the targeted file stream using the encryptor
                    using (CryptoStream cryptoStream = new CryptoStream(fileStream2, cryptoTransform, CryptoStreamMode.Write))
                    {
                        //read length = file's length - file's position
                        readLength = (int)(fileStream.Length - fileStream.Position);
                        //if read length is bigger than 1024
                        if (readLength > 1024)
                        {
                            //read length = 1024
                            readLength = 1024;
                        }
                        //reads file and puts data to byte array 1
                        fileStream.Read(bytes1, 0, readLength);
                        //aslong as file's position is smaller than file's length
                        while (fileStream.Position < fileStream.Length)
                        {
                            //read length = file's length - file's position
                            readLength = (int)(fileStream.Length - fileStream.Position);
                            //if read length is bigger than 1024
                            if (readLength > 1024)
                            {
                                //read length = 1024
                                readLength = 1024;
                            }
                            //saves file read into byte array 2 as a task. reads 1024 bytes
                            var taskRead = fileStream.ReadAsync(bytes2, 0, readLength);
                            //saves file write from byte array 2 as a task. writes 1024 bytes
                            var taskWrite = cryptoStream.WriteAsync(bytes1, 0, 1024);
                            //does both task in the same time
                            await Task.WhenAll(taskRead, taskWrite);
                            //switches between byte array 1 and byte array 2
                            byteT = bytes2;
                            bytes2 = bytes1;
                            bytes1 = byteT;
                        }
                        //writes all the rest
                        cryptoStream.Write(bytes1, 0, readLength);
                    }
                }
            }
            //moving temp.txt to the targeted file. then deletes temp
            File.Copy("temp.txt", fileName, true);
            File.Delete("temp.txt");
        }

        public async void Encrypt(string filePath, ListBox statusConsole)
        {
            StatusConsole console = new StatusConsole(statusConsole);
            var encryptor = this.encryptor;
            var decryptor = this.decryptor;
            //a variable dor a case where the key is encryoted
            bool keyEncrypted = false;
            //if the path is a file
            console.add("checking if input is file or folder");
            if (File.Exists(filePath))
            {
                console.add("input was found to be a file");
                //encypts file
                console.add($"encrypting {Path.GetFileName(filePath)}");
                await TransformAsync(filePath, encryptor);
                //if the path is the key file
                if (filePath == "key.key")
                {
                    //key encrypted is now true
                    keyEncrypted = true;
                }
            }
            //if the path is a directory
            else if (Directory.Exists(filePath))
            {
                console.add("input was found to be a folder");
                //taking files in folder
                console.add("getting all files from folder");
                string[] folder = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
                //for each file in folder
                foreach (string file in folder)
                {
                    //encrypting file with the key
                    console.add($"encrypting {Path.GetFileName(file)}");
                    await TransformAsync(file, encryptor);
                    //if the file is the key file than decrypt key
                    if (file == "key.key")
                    {
                        //key encrypted is now true
                        keyEncrypted = true;
                    }
                }
            }
            console.add("checking if the key was one of the file/s");
            if (keyEncrypted == true)
            {
                console.add("the key is one of the file/s");

                console.add("decrypting key");
                await TransformAsync("key.key", decryptor);
            }
            console.add("operation complete");
        }
        public async void Decrypt(string filePath, ListBox statusConsole)
        {
            StatusConsole console = new StatusConsole(statusConsole);

            var encryptor = this.encryptor;
            var decryptor = this.decryptor;

            console.add("checking if input is file or folder");
            //if path is a file
            if (File.Exists(filePath))
            {
                console.add("input was found to be a file");
                //decrypts the file
                console.add($"decrypting {Path.GetFileName(filePath)}");
                await TransformAsync(filePath, decryptor);
            }
            //if the path is a directory
            else if (Directory.Exists(filePath))
            {
                console.add("input was found to be a folder");
                //taking all the files in the directory
                console.add("getting all files from folder");
                string[] folder = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
                //for each file in the directory
                foreach (string file in folder)
                {
                    console.add($"decrypting {Path.GetFileName(file)}");
                    //decrypting file
                    await TransformAsync(file, decryptor);
                }
            }
            console.add("operation complete");
        }
        public void GenerateKey(ListBox statusConsole)
        {
            StatusConsole console = new StatusConsole(statusConsole);
            //generating a new key
            console.add("generating new key");
            this.aes = KeyGen("key.key");
            //updateing encryptor ans decryptor
            this.encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
            this.decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            console.add("operation complete");
        }
    }
}