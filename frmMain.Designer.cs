namespace YoutubeTool
{
    partial class frmMainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTopbar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelTopbar
            // 
            this.panelTopbar.AllowDrop = true;
            this.panelTopbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopbar.BackColor = System.Drawing.Color.DarkCyan;
            this.panelTopbar.Location = new System.Drawing.Point(0, 0);
            this.panelTopbar.Name = "panelTopbar";
            this.panelTopbar.Size = new System.Drawing.Size(1024, 24);
            this.panelTopbar.TabIndex = 0;
            this.panelTopbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopbar_MouseDown);
            this.panelTopbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopbar_MouseMove);
            this.panelTopbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopbar_MouseUp);
            // 
            // frmMainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 512);
            this.ControlBox = false;
            this.Controls.Add(this.panelTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopbar;
    }
}

