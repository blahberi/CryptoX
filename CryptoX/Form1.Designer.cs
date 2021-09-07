namespace encryptor_CS_X
{
    partial class CryptoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoForm));
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.statusConsole = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.btnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuKeyAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadKey = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveKey = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeyAsText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGetKey = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopyKey = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveKeyAsText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveKey = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadKeyFromText = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadKeyFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsKey = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripContainer1.SuspendLayout();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEncrypt.Location = new System.Drawing.Point(80, 150);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(110, 55);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDecrypt.Location = new System.Drawing.Point(290, 150);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(110, 55);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateKey.FlatAppearance.BorderSize = 0;
            this.btnGenerateKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateKey.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnGenerateKey.Location = new System.Drawing.Point(500, 150);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(110, 55);
            this.btnGenerateKey.TabIndex = 2;
            this.btnGenerateKey.Text = "generate key";
            this.btnGenerateKey.UseVisualStyleBackColor = false;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.Crimson;
            this.lblFileName.Location = new System.Drawing.Point(0, 58);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(686, 60);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "no file selected";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusConsole
            // 
            this.statusConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statusConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusConsole.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.statusConsole.FormattingEnabled = true;
            this.statusConsole.ItemHeight = 14;
            this.statusConsole.Location = new System.Drawing.Point(137, 238);
            this.statusConsole.Name = "statusConsole";
            this.statusConsole.Size = new System.Drawing.Size(412, 140);
            this.statusConsole.TabIndex = 7;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // ts
            // 
            this.ts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsKey});
            this.ts.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts.Size = new System.Drawing.Size(686, 22);
            this.ts.TabIndex = 10;
            this.ts.Text = "toolStrip1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(180, 22);
            this.btnOpenFile.Text = "open file";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(180, 22);
            this.btnOpenFolder.Text = "open folder";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // tsFile
            // 
            this.tsFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFile,
            this.btnOpenFolder});
            this.tsFile.ForeColor = System.Drawing.Color.White;
            this.tsFile.Image = ((System.Drawing.Image)(resources.GetObject("tsFile.Image")));
            this.tsFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(36, 19);
            this.tsFile.Text = "file";
            // 
            // menuKeyAsFile
            // 
            this.menuKeyAsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadKey,
            this.btnSaveKey});
            this.menuKeyAsFile.Name = "menuKeyAsFile";
            this.menuKeyAsFile.Size = new System.Drawing.Size(180, 22);
            this.menuKeyAsFile.Text = "key as file";
            // 
            // btnLoadKey
            // 
            this.btnLoadKey.Name = "btnLoadKey";
            this.btnLoadKey.Size = new System.Drawing.Size(119, 22);
            this.btnLoadKey.Text = "load Key";
            this.btnLoadKey.Click += new System.EventHandler(this.btnLoadKey_Click);
            // 
            // btnSaveKey
            // 
            this.btnSaveKey.Name = "btnSaveKey";
            this.btnSaveKey.Size = new System.Drawing.Size(119, 22);
            this.btnSaveKey.Text = "save key";
            this.btnSaveKey.Click += new System.EventHandler(this.btnSaveKey_Click);
            // 
            // menuKeyAsText
            // 
            this.menuKeyAsText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGetKey,
            this.menuSaveKey});
            this.menuKeyAsText.Name = "menuKeyAsText";
            this.menuKeyAsText.Size = new System.Drawing.Size(180, 22);
            this.menuKeyAsText.Text = "key as text";
            // 
            // menuGetKey
            // 
            this.menuGetKey.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopyKey,
            this.btnSaveKeyAsText});
            this.menuGetKey.Name = "menuGetKey";
            this.menuGetKey.Size = new System.Drawing.Size(118, 22);
            this.menuGetKey.Text = "get key";
            // 
            // btnCopyKey
            // 
            this.btnCopyKey.Name = "btnCopyKey";
            this.btnCopyKey.Size = new System.Drawing.Size(188, 22);
            this.btnCopyKey.Text = "copy key to clipboard";
            this.btnCopyKey.Click += new System.EventHandler(this.btnCopyKey_Click);
            // 
            // btnSaveKeyAsText
            // 
            this.btnSaveKeyAsText.Name = "btnSaveKeyAsText";
            this.btnSaveKeyAsText.Size = new System.Drawing.Size(188, 22);
            this.btnSaveKeyAsText.Text = "save key as file";
            this.btnSaveKeyAsText.Click += new System.EventHandler(this.btnSaveKeyAsText_Click);
            // 
            // menuSaveKey
            // 
            this.menuSaveKey.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadKeyFromText,
            this.btnLoadKeyFromFile});
            this.menuSaveKey.Name = "menuSaveKey";
            this.menuSaveKey.Size = new System.Drawing.Size(118, 22);
            this.menuSaveKey.Text = "load key";
            // 
            // btnLoadKeyFromText
            // 
            this.btnLoadKeyFromText.Name = "btnLoadKeyFromText";
            this.btnLoadKeyFromText.Size = new System.Drawing.Size(166, 22);
            this.btnLoadKeyFromText.Text = "paste in key";
            this.btnLoadKeyFromText.Click += new System.EventHandler(this.btnLoadKeyFromText_Click);
            // 
            // btnLoadKeyFromFile
            // 
            this.btnLoadKeyFromFile.Name = "btnLoadKeyFromFile";
            this.btnLoadKeyFromFile.Size = new System.Drawing.Size(166, 22);
            this.btnLoadKeyFromFile.Text = "load key from file";
            this.btnLoadKeyFromFile.Click += new System.EventHandler(this.btnLoadKeyFromFile_Click);
            // 
            // tsKey
            // 
            this.tsKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsKey.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKeyAsFile,
            this.menuKeyAsText});
            this.tsKey.ForeColor = System.Drawing.Color.White;
            this.tsKey.Image = ((System.Drawing.Image)(resources.GetObject("tsKey.Image")));
            this.tsKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKey.Name = "tsKey";
            this.tsKey.Size = new System.Drawing.Size(38, 19);
            this.tsKey.Text = "key";
            // 
            // CryptoForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.statusConsole);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CryptoForm";
            this.Text = "CryptorX";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ListBox statusConsole;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripDropDownButton tsFile;
        private System.Windows.Forms.ToolStripMenuItem btnOpenFile;
        private System.Windows.Forms.ToolStripMenuItem btnOpenFolder;
        private System.Windows.Forms.ToolStripDropDownButton tsKey;
        private System.Windows.Forms.ToolStripMenuItem menuKeyAsFile;
        private System.Windows.Forms.ToolStripMenuItem btnLoadKey;
        private System.Windows.Forms.ToolStripMenuItem btnSaveKey;
        private System.Windows.Forms.ToolStripMenuItem menuKeyAsText;
        private System.Windows.Forms.ToolStripMenuItem menuGetKey;
        private System.Windows.Forms.ToolStripMenuItem btnCopyKey;
        private System.Windows.Forms.ToolStripMenuItem btnSaveKeyAsText;
        private System.Windows.Forms.ToolStripMenuItem menuSaveKey;
        private System.Windows.Forms.ToolStripMenuItem btnLoadKeyFromText;
        private System.Windows.Forms.ToolStripMenuItem btnLoadKeyFromFile;
    }
}
