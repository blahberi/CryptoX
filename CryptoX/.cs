using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryptor_CS_X
{
    public class StatusConsole
    {
        private ListBox statusConsole;

        public StatusConsole(ListBox statusConsole)
        {
            this.statusConsole = statusConsole;
        }

        public void add(string item)
        {
            this.statusConsole.Items.Add(item);
            statusConsole.SelectedIndex = statusConsole.Items.Count - 1;
            statusConsole.SelectedIndex = -1;
        }
    }
}
