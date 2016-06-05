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
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        string bufferText;
        private const int WM_DRAWCLIPBOARD = 0x0308;        // WM_DRAWCLIPBOARD message
        // Our variable that will hold the value to identify the next window in the clipboard viewer chain
        private IntPtr _clipboardViewerNext;
        HashSet<string> textHistory = new HashSet<string>();

        public ClipCap()
        {
            InitializeComponent();
        }

        private void start_capture(object sender, EventArgs e)
        {
            addToChain();
        }

        private void stop_capture(object sender, EventArgs e)
        {
            removeFromChain();
        }

        private void clear_history(object sender, EventArgs e)
        {
            textHistory.Clear();
            ClipboardHistory.Text = "";
        }


        private void copyHistory(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(String.Join(Environment.NewLine, textHistory));
                textHistory.Clear();
                addToChain();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            removeFromChain();
        }

        public void addToChain()
        {
            _clipboardViewerNext = SetClipboardViewer(this.Handle); // Adds our form to the chain of clipboard viewers.
        }

        public void removeFromChain()
        {
            ChangeClipboardChain(this.Handle, _clipboardViewerNext); // Removes our from the chain of clipboard viewers when the form closes.
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
                    if (bufferText != "") {
                        textHistory.Add(bufferText);
                        ClipboardHistory.Text = String.Join(Environment.NewLine, textHistory);
                    }
                }
                //                else if (iData.GetDataPresent(DataFormats.Bitmap))
                //                {
                //                    Bitmap image = (Bitmap)iData.GetData(DataFormats.Bitmap);   // Clipboard image

                //               }
            }
        }
    }
}
