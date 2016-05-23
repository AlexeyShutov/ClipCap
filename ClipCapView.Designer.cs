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
            this.ClipboardHistory = new System.Windows.Forms.RichTextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClipboardHistory
            // 
            this.ClipboardHistory.Location = new System.Drawing.Point(12, 12);
            this.ClipboardHistory.Name = "ClipboardHistory";
            this.ClipboardHistory.Size = new System.Drawing.Size(508, 181);
            this.ClipboardHistory.TabIndex = 1;
            this.ClipboardHistory.Text = "";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(405, 199);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(111, 23);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "Clear History";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.clear_history);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(11, 199);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(80, 23);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start Capture";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.start_capture);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(97, 199);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(80, 23);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "Stop Capture";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.stop_capture);
            // 
            // ClipCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 234);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.ClipboardHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClipCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClipCap";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox ClipboardHistory;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
    }
}

