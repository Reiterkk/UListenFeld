namespace UListenFeld
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.LstLinks = new System.Windows.Forms.ListBox();
            this.LstRechts = new System.Windows.Forms.ListBox();
            this.CmdRechts = new System.Windows.Forms.Button();
            this.CmdLinks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstLinks
            // 
            this.LstLinks.FormattingEnabled = true;
            this.LstLinks.ItemHeight = 32;
            this.LstLinks.Location = new System.Drawing.Point(12, 12);
            this.LstLinks.Name = "LstLinks";
            this.LstLinks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstLinks.Size = new System.Drawing.Size(240, 420);
            this.LstLinks.TabIndex = 0;
            // 
            // LstRechts
            // 
            this.LstRechts.FormattingEnabled = true;
            this.LstRechts.ItemHeight = 32;
            this.LstRechts.Location = new System.Drawing.Point(403, 12);
            this.LstRechts.Name = "LstRechts";
            this.LstRechts.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstRechts.Size = new System.Drawing.Size(240, 420);
            this.LstRechts.TabIndex = 1;
            // 
            // CmdRechts
            // 
            this.CmdRechts.Location = new System.Drawing.Point(283, 128);
            this.CmdRechts.Name = "CmdRechts";
            this.CmdRechts.Size = new System.Drawing.Size(89, 46);
            this.CmdRechts.TabIndex = 2;
            this.CmdRechts.Text = ">>";
            this.CmdRechts.UseVisualStyleBackColor = true;
            this.CmdRechts.Click += new System.EventHandler(this.CmdRechts_Click);
            // 
            // CmdLinks
            // 
            this.CmdLinks.Location = new System.Drawing.Point(283, 209);
            this.CmdLinks.Name = "CmdLinks";
            this.CmdLinks.Size = new System.Drawing.Size(89, 46);
            this.CmdLinks.TabIndex = 3;
            this.CmdLinks.Text = "<<";
            this.CmdLinks.UseVisualStyleBackColor = true;
            this.CmdLinks.Click += new System.EventHandler(this.CmdLinks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.CmdLinks);
            this.Controls.Add(this.CmdRechts);
            this.Controls.Add(this.LstRechts);
            this.Controls.Add(this.LstLinks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstLinks;
        private System.Windows.Forms.ListBox LstRechts;
        private System.Windows.Forms.Button CmdRechts;
        private System.Windows.Forms.Button CmdLinks;
    }
}

