using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ClipCap : Form
    {
        string bufferText;
        private const int WM_DRAWCLIPBOARD = 0x0308;        // WM_DRAWCLIPBOARD message
        // Our variable that will hold the value to identify the next window in the clipboard viewer chain
        private IntPtr _clipboardViewerNext;

        public ClipCap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paste_clip(object sender, EventArgs e)
        {
            addToChain();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        public void addToChain()
        {
            _clipboardViewerNext = SetClipboardViewer(this.Handle); // Adds our form to the chain of clipboard viewers.
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);    // Process the message 

            if (m.Msg == WM_DRAWCLIPBOARD)
            {
                IDataObject iData = Clipboard.GetDataObject();      // Clipboard's data

                if (iData.GetDataPresent(DataFormats.Text))
                {
                    bufferText = (string)iData.GetData(DataFormats.Text);      // Clipboard text
                    ClipboardHistory.Text = ClipboardHistory.Text + bufferText + "\n";
                }
                //                else if (iData.GetDataPresent(DataFormats.Bitmap))
                //                {
                //                    Bitmap image = (Bitmap)iData.GetData(DataFormats.Bitmap);   // Clipboard image

                //               }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChangeClipboardChain(this.Handle, _clipboardViewerNext); // Removes our from the chain of clipboard viewers when the form closes.
        }
    }
}
