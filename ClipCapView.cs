using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ClipCap : Form
    {
        string bufferText;

        public ClipCap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paste_clip(object sender, EventArgs e)
        {
            bufferText = Clipboard.GetText();
            ClipboardHistory.Text = ClipboardHistory.Text + bufferText + "\n";
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
