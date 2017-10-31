namespace PcFilesToFlashDrive
{
    partial class Form1
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
            this.tablsettings = new System.Windows.Forms.TabPage();
            this.showonstart = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkdesktop = new System.Windows.Forms.CheckBox();
            this.chkvideos = new System.Windows.Forms.CheckBox();
            this.chkdocuments = new System.Windows.Forms.CheckBox();
            this.chkpictures = new System.Windows.Forms.CheckBox();
            this.chkdownloads = new System.Windows.Forms.CheckBox();
            this.chkmusic = new System.Windows.Forms.CheckBox();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tababout = new System.Windows.Forms.TabPage();
            this.txtabout = new System.Windows.Forms.RichTextBox();
            this.txtlimit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnset = new System.Windows.Forms.Button();
            this.tablsettings.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tababout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablsettings
            // 
            this.tablsettings.Controls.Add(this.btnset);
            this.tablsettings.Controls.Add(this.label2);
            this.tablsettings.Controls.Add(this.txtlimit);
            this.tablsettings.Controls.Add(this.showonstart);
            this.tablsettings.Controls.Add(this.label1);
            this.tablsettings.Controls.Add(this.chkdesktop);
            this.tablsettings.Controls.Add(this.chkvideos);
            this.tablsettings.Controls.Add(this.chkdocuments);
            this.tablsettings.Controls.Add(this.chkpictures);
            this.tablsettings.Controls.Add(this.chkdownloads);
            this.tablsettings.Controls.Add(this.chkmusic);
            this.tablsettings.Location = new System.Drawing.Point(4, 22);
            this.tablsettings.Name = "tablsettings";
            this.tablsettings.Padding = new System.Windows.Forms.Padding(3);
            this.tablsettings.Size = new System.Drawing.Size(395, 305);
            this.tablsettings.TabIndex = 0;
            this.tablsettings.Text = "Settings";
            this.tablsettings.UseVisualStyleBackColor = true;
            // 
            // showonstart
            // 
            this.showonstart.AutoSize = true;
            this.showonstart.Location = new System.Drawing.Point(26, 215);
            this.showonstart.Name = "showonstart";
            this.showonstart.Size = new System.Drawing.Size(264, 17);
            this.showonstart.TabIndex = 7;
            this.showonstart.Text = "Show this Window on Startup (Dont Start Copying)";
            this.showonstart.UseVisualStyleBackColor = true;
            this.showonstart.CheckedChanged += new System.EventHandler(this.showonstart_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Copy File From Selected Folders";
            // 
            // chkdesktop
            // 
            this.chkdesktop.AutoSize = true;
            this.chkdesktop.Location = new System.Drawing.Point(26, 49);
            this.chkdesktop.Name = "chkdesktop";
            this.chkdesktop.Size = new System.Drawing.Size(66, 17);
            this.chkdesktop.TabIndex = 0;
            this.chkdesktop.Text = "Desktop";
            this.chkdesktop.UseVisualStyleBackColor = true;
            this.chkdesktop.CheckedChanged += new System.EventHandler(this.chkdesktop_CheckedChanged);
            // 
            // chkvideos
            // 
            this.chkvideos.AutoSize = true;
            this.chkvideos.Location = new System.Drawing.Point(26, 164);
            this.chkvideos.Name = "chkvideos";
            this.chkvideos.Size = new System.Drawing.Size(58, 17);
            this.chkvideos.TabIndex = 5;
            this.chkvideos.Text = "Videos";
            this.chkvideos.UseVisualStyleBackColor = true;
            this.chkvideos.CheckedChanged += new System.EventHandler(this.chkvideos_CheckedChanged);
            // 
            // chkdocuments
            // 
            this.chkdocuments.AutoSize = true;
            this.chkdocuments.Location = new System.Drawing.Point(26, 72);
            this.chkdocuments.Name = "chkdocuments";
            this.chkdocuments.Size = new System.Drawing.Size(80, 17);
            this.chkdocuments.TabIndex = 1;
            this.chkdocuments.Text = "Documents";
            this.chkdocuments.UseVisualStyleBackColor = true;
            this.chkdocuments.CheckedChanged += new System.EventHandler(this.chkdocuments_CheckedChanged);
            // 
            // chkpictures
            // 
            this.chkpictures.AutoSize = true;
            this.chkpictures.Location = new System.Drawing.Point(26, 141);
            this.chkpictures.Name = "chkpictures";
            this.chkpictures.Size = new System.Drawing.Size(64, 17);
            this.chkpictures.TabIndex = 4;
            this.chkpictures.Text = "Pictures";
            this.chkpictures.UseVisualStyleBackColor = true;
            this.chkpictures.CheckedChanged += new System.EventHandler(this.chkpictures_CheckedChanged);
            // 
            // chkdownloads
            // 
            this.chkdownloads.AutoSize = true;
            this.chkdownloads.Location = new System.Drawing.Point(26, 95);
            this.chkdownloads.Name = "chkdownloads";
            this.chkdownloads.Size = new System.Drawing.Size(79, 17);
            this.chkdownloads.TabIndex = 2;
            this.chkdownloads.Text = "Downloads";
            this.chkdownloads.UseVisualStyleBackColor = true;
            this.chkdownloads.CheckedChanged += new System.EventHandler(this.chkdownloads_CheckedChanged);
            // 
            // chkmusic
            // 
            this.chkmusic.AutoSize = true;
            this.chkmusic.Location = new System.Drawing.Point(26, 118);
            this.chkmusic.Name = "chkmusic";
            this.chkmusic.Size = new System.Drawing.Size(54, 17);
            this.chkmusic.TabIndex = 3;
            this.chkmusic.Text = "Music";
            this.chkmusic.UseVisualStyleBackColor = true;
            this.chkmusic.CheckedChanged += new System.EventHandler(this.chkmusic_CheckedChanged);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tablsettings);
            this.tabSettings.Controls.Add(this.tababout);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(403, 331);
            this.tabSettings.TabIndex = 7;
            // 
            // tababout
            // 
            this.tababout.Controls.Add(this.txtabout);
            this.tababout.Location = new System.Drawing.Point(4, 22);
            this.tababout.Name = "tababout";
            this.tababout.Padding = new System.Windows.Forms.Padding(3);
            this.tababout.Size = new System.Drawing.Size(395, 305);
            this.tababout.TabIndex = 1;
            this.tababout.Text = "About";
            this.tababout.UseVisualStyleBackColor = true;
            // 
            // txtabout
            // 
            this.txtabout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtabout.Location = new System.Drawing.Point(3, 3);
            this.txtabout.Name = "txtabout";
            this.txtabout.Size = new System.Drawing.Size(389, 299);
            this.txtabout.TabIndex = 0;
            this.txtabout.Text = "";
            this.txtabout.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtabout_LinkClicked);
            // 
            // txtlimit
            // 
            this.txtlimit.Location = new System.Drawing.Point(153, 238);
            this.txtlimit.Name = "txtlimit";
            this.txtlimit.Size = new System.Drawing.Size(199, 20);
            this.txtlimit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Limit File Length (Bytes): ";
            // 
            // btnset
            // 
            this.btnset.Location = new System.Drawing.Point(276, 265);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(75, 23);
            this.btnset.TabIndex = 10;
            this.btnset.Text = "Set Limit";
            this.btnset.UseVisualStyleBackColor = true;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 331);
            this.Controls.Add(this.tabSettings);
            this.Name = "Form1";
            this.Text = "PCFilesToFlashDrive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tablsettings.ResumeLayout(false);
            this.tablsettings.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tababout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tablsettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkdesktop;
        private System.Windows.Forms.CheckBox chkvideos;
        private System.Windows.Forms.CheckBox chkdocuments;
        private System.Windows.Forms.CheckBox chkpictures;
        private System.Windows.Forms.CheckBox chkdownloads;
        private System.Windows.Forms.CheckBox chkmusic;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tababout;
        private System.Windows.Forms.RichTextBox txtabout;
        private System.Windows.Forms.CheckBox showonstart;
        private System.Windows.Forms.TextBox txtlimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnset;
    }
}

