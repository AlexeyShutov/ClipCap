namespace WindowsFormsApplication1
{
    partial class ClipCap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipCap));
            this.clipboard = new System.Windows.Forms.Button();
            this.ClipboardHistory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // clipboard
            // 
            this.clipboard.Location = new System.Drawing.Point(128, 199);
            this.clipboard.Name = "clipboard";
            this.clipboard.Size = new System.Drawing.Size(107, 23);
            this.clipboard.TabIndex = 0;
            this.clipboard.Text = "paste clipboard";
            this.clipboard.UseVisualStyleBackColor = true;
            this.clipboard.Click += new System.EventHandler(this.paste_clip);
            // 
            // ClipboardHistory
            // 
            this.ClipboardHistory.Location = new System.Drawing.Point(12, 12);
            this.ClipboardHistory.Name = "ClipboardHistory";
            this.ClipboardHistory.Size = new System.Drawing.Size(341, 181);
            this.ClipboardHistory.TabIndex = 1;
            this.ClipboardHistory.Text = "";
            this.ClipboardHistory.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // ClipCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 234);
            this.Controls.Add(this.ClipboardHistory);
            this.Controls.Add(this.clipboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClipCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClipCap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clipboard;
        private System.Windows.Forms.RichTextBox ClipboardHistory;
    }
}

