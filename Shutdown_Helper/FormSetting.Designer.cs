namespace Shutdown_Helper
{
    partial class FormSetting
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
        	this.box1 = new System.Windows.Forms.GroupBox();
        	this.box1c = new System.Windows.Forms.GroupBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.changeDrive = new System.Windows.Forms.Button();
        	this.box1a = new System.Windows.Forms.GroupBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.monitor = new System.Windows.Forms.ComboBox();
        	this.driveLetter = new System.Windows.Forms.ComboBox();
        	this.box1b = new System.Windows.Forms.GroupBox();
        	this.infoLabel = new System.Windows.Forms.TextBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.infoVolume = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.infoFormat = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.infoTipe = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.box3 = new System.Windows.Forms.GroupBox();
        	this.rbHibernate = new System.Windows.Forms.RadioButton();
        	this.rbShutdown = new System.Windows.Forms.RadioButton();
        	this.box2 = new System.Windows.Forms.GroupBox();
        	this.jedaPer = new System.Windows.Forms.ComboBox();
        	this.jedaWaktu = new System.Windows.Forms.TextBox();
        	this.buttonYA = new System.Windows.Forms.Button();
        	this.buttonTidak = new System.Windows.Forms.Button();
        	this.box6 = new System.Windows.Forms.GroupBox();
        	this.box4 = new System.Windows.Forms.GroupBox();
        	this.message = new System.Windows.Forms.TextBox();
        	this.box5 = new System.Windows.Forms.GroupBox();
        	this.cbStartup = new System.Windows.Forms.CheckBox();
        	this.box1.SuspendLayout();
        	this.box1c.SuspendLayout();
        	this.box1a.SuspendLayout();
        	this.box1b.SuspendLayout();
        	this.box3.SuspendLayout();
        	this.box2.SuspendLayout();
        	this.box6.SuspendLayout();
        	this.box4.SuspendLayout();
        	this.box5.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// box1
        	// 
        	this.box1.Controls.Add(this.box1c);
        	this.box1.Controls.Add(this.box1a);
        	this.box1.Controls.Add(this.box1b);
        	this.box1.Location = new System.Drawing.Point(12, 12);
        	this.box1.Name = "box1";
        	this.box1.Size = new System.Drawing.Size(200, 291);
        	this.box1.TabIndex = 0;
        	this.box1.TabStop = false;
        	this.box1.Text = "USB Monitor";
        	// 
        	// box1c
        	// 
        	this.box1c.Controls.Add(this.label7);
        	this.box1c.Controls.Add(this.changeDrive);
        	this.box1c.Location = new System.Drawing.Point(9, 212);
        	this.box1c.Name = "box1c";
        	this.box1c.Size = new System.Drawing.Size(182, 69);
        	this.box1c.TabIndex = 7;
        	this.box1c.TabStop = false;
        	this.box1c.Text = "Change Drive Letter";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(6, 19);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(155, 13);
        	this.label7.TabIndex = 6;
        	this.label7.Text = "Pastikan drive A:\\ tidak dipakai";
        	// 
        	// changeDrive
        	// 
        	this.changeDrive.Enabled = false;
        	this.changeDrive.Location = new System.Drawing.Point(8, 35);
        	this.changeDrive.Name = "changeDrive";
        	this.changeDrive.Size = new System.Drawing.Size(166, 23);
        	this.changeDrive.TabIndex = 5;
        	this.changeDrive.Text = "Change Drive Letter to A:\\";
        	this.changeDrive.UseVisualStyleBackColor = true;
        	this.changeDrive.Click += new System.EventHandler(this.changeDrive_Click);
        	// 
        	// box1a
        	// 
        	this.box1a.Controls.Add(this.label4);
        	this.box1a.Controls.Add(this.label1);
        	this.box1a.Controls.Add(this.monitor);
        	this.box1a.Controls.Add(this.driveLetter);
        	this.box1a.Location = new System.Drawing.Point(9, 14);
        	this.box1a.Name = "box1a";
        	this.box1a.Size = new System.Drawing.Size(182, 81);
        	this.box1a.TabIndex = 4;
        	this.box1a.TabStop = false;
        	this.box1a.Text = "Drive";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(6, 50);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(62, 13);
        	this.label4.TabIndex = 4;
        	this.label4.Text = "Drive Letter";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(6, 23);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(40, 13);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "Trigger";
        	// 
        	// monitor
        	// 
        	this.monitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.monitor.FormattingEnabled = true;
        	this.monitor.Items.AddRange(new object[] {
        	        	        	"Inserted (A:\\)",
        	        	        	"Removed (Z:\\)"});
        	this.monitor.Location = new System.Drawing.Point(74, 19);
        	this.monitor.Name = "monitor";
        	this.monitor.Size = new System.Drawing.Size(95, 21);
        	this.monitor.TabIndex = 2;
        	this.monitor.SelectedIndexChanged += new System.EventHandler(this.monitor_SelectedIndexChanged);
        	// 
        	// driveLetter
        	// 
        	this.driveLetter.FormattingEnabled = true;
        	this.driveLetter.Location = new System.Drawing.Point(74, 46);
        	this.driveLetter.Name = "driveLetter";
        	this.driveLetter.Size = new System.Drawing.Size(95, 21);
        	this.driveLetter.TabIndex = 1;
        	this.driveLetter.DropDown += new System.EventHandler(this.driveLetter_DropDown);
        	this.driveLetter.SelectedIndexChanged += new System.EventHandler(this.driveLetter_SelectedIndexChanged);
        	this.driveLetter.TextChanged += new System.EventHandler(this.driveLetter_SelectedIndexChanged);
        	this.driveLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.driveLetter_KeyPress);
        	// 
        	// box1b
        	// 
        	this.box1b.Controls.Add(this.infoLabel);
        	this.box1b.Controls.Add(this.label6);
        	this.box1b.Controls.Add(this.infoVolume);
        	this.box1b.Controls.Add(this.label5);
        	this.box1b.Controls.Add(this.infoFormat);
        	this.box1b.Controls.Add(this.label3);
        	this.box1b.Controls.Add(this.infoTipe);
        	this.box1b.Controls.Add(this.label2);
        	this.box1b.Location = new System.Drawing.Point(9, 101);
        	this.box1b.Name = "box1b";
        	this.box1b.Size = new System.Drawing.Size(182, 105);
        	this.box1b.TabIndex = 2;
        	this.box1b.TabStop = false;
        	this.box1b.Text = "Drive Info";
        	// 
        	// infoLabel
        	// 
        	this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.infoLabel.Enabled = false;
        	this.infoLabel.Location = new System.Drawing.Point(58, 19);
        	this.infoLabel.Name = "infoLabel";
        	this.infoLabel.ReadOnly = true;
        	this.infoLabel.Size = new System.Drawing.Size(111, 13);
        	this.infoLabel.TabIndex = 7;
        	this.infoLabel.Text = ": -";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(6, 20);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(33, 13);
        	this.label6.TabIndex = 6;
        	this.label6.Text = "Label";
        	// 
        	// infoVolume
        	// 
        	this.infoVolume.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.infoVolume.Enabled = false;
        	this.infoVolume.Location = new System.Drawing.Point(58, 79);
        	this.infoVolume.Name = "infoVolume";
        	this.infoVolume.ReadOnly = true;
        	this.infoVolume.Size = new System.Drawing.Size(111, 13);
        	this.infoVolume.TabIndex = 5;
        	this.infoVolume.Text = ": -";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(6, 80);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(48, 13);
        	this.label5.TabIndex = 4;
        	this.label5.Text = "Capacity";
        	// 
        	// infoFormat
        	// 
        	this.infoFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.infoFormat.Enabled = false;
        	this.infoFormat.Location = new System.Drawing.Point(58, 59);
        	this.infoFormat.Name = "infoFormat";
        	this.infoFormat.ReadOnly = true;
        	this.infoFormat.Size = new System.Drawing.Size(111, 13);
        	this.infoFormat.TabIndex = 3;
        	this.infoFormat.Text = ": -";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(6, 60);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(39, 13);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "Format";
        	// 
        	// infoTipe
        	// 
        	this.infoTipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.infoTipe.Enabled = false;
        	this.infoTipe.Location = new System.Drawing.Point(58, 39);
        	this.infoTipe.Name = "infoTipe";
        	this.infoTipe.ReadOnly = true;
        	this.infoTipe.Size = new System.Drawing.Size(111, 13);
        	this.infoTipe.TabIndex = 1;
        	this.infoTipe.Text = ": -";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(6, 40);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(31, 13);
        	this.label2.TabIndex = 0;
        	this.label2.Text = "Type";
        	// 
        	// box3
        	// 
        	this.box3.Controls.Add(this.rbHibernate);
        	this.box3.Controls.Add(this.rbShutdown);
        	this.box3.Location = new System.Drawing.Point(218, 71);
        	this.box3.Name = "box3";
        	this.box3.Size = new System.Drawing.Size(171, 48);
        	this.box3.TabIndex = 1;
        	this.box3.TabStop = false;
        	this.box3.Text = "Aksi";
        	// 
        	// rbHibernate
        	// 
        	this.rbHibernate.AutoSize = true;
        	this.rbHibernate.Location = new System.Drawing.Point(89, 19);
        	this.rbHibernate.Name = "rbHibernate";
        	this.rbHibernate.Size = new System.Drawing.Size(71, 17);
        	this.rbHibernate.TabIndex = 1;
        	this.rbHibernate.Text = "Hibernate";
        	this.rbHibernate.UseVisualStyleBackColor = true;
        	// 
        	// rbShutdown
        	// 
        	this.rbShutdown.AutoSize = true;
        	this.rbShutdown.Checked = true;
        	this.rbShutdown.Location = new System.Drawing.Point(10, 19);
        	this.rbShutdown.Name = "rbShutdown";
        	this.rbShutdown.Size = new System.Drawing.Size(73, 17);
        	this.rbShutdown.TabIndex = 0;
        	this.rbShutdown.TabStop = true;
        	this.rbShutdown.Text = "Shutdown";
        	this.rbShutdown.UseVisualStyleBackColor = true;
        	// 
        	// box2
        	// 
        	this.box2.Controls.Add(this.jedaPer);
        	this.box2.Controls.Add(this.jedaWaktu);
        	this.box2.Location = new System.Drawing.Point(218, 12);
        	this.box2.Name = "box2";
        	this.box2.Size = new System.Drawing.Size(171, 53);
        	this.box2.TabIndex = 2;
        	this.box2.TabStop = false;
        	this.box2.Text = "Waktu Jeda sblm Aksi";
        	// 
        	// jedaPer
        	// 
        	this.jedaPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.jedaPer.FormattingEnabled = true;
        	this.jedaPer.Items.AddRange(new object[] {
        	        	        	"Detik",
        	        	        	"Menit"});
        	this.jedaPer.Location = new System.Drawing.Point(89, 20);
        	this.jedaPer.Name = "jedaPer";
        	this.jedaPer.Size = new System.Drawing.Size(74, 21);
        	this.jedaPer.TabIndex = 3;
        	// 
        	// jedaWaktu
        	// 
        	this.jedaWaktu.Location = new System.Drawing.Point(10, 20);
        	this.jedaWaktu.Name = "jedaWaktu";
        	this.jedaWaktu.Size = new System.Drawing.Size(73, 20);
        	this.jedaWaktu.TabIndex = 2;
        	this.jedaWaktu.Text = "10";
        	this.jedaWaktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	this.jedaWaktu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.waktuJeda_KeyPress);
        	// 
        	// buttonYA
        	// 
        	this.buttonYA.Location = new System.Drawing.Point(9, 19);
        	this.buttonYA.Name = "buttonYA";
        	this.buttonYA.Size = new System.Drawing.Size(75, 23);
        	this.buttonYA.TabIndex = 3;
        	this.buttonYA.Text = "YA";
        	this.buttonYA.UseVisualStyleBackColor = true;
        	this.buttonYA.Click += new System.EventHandler(this.buttonYA_Click);
        	// 
        	// buttonTidak
        	// 
        	this.buttonTidak.Location = new System.Drawing.Point(87, 19);
        	this.buttonTidak.Name = "buttonTidak";
        	this.buttonTidak.Size = new System.Drawing.Size(75, 23);
        	this.buttonTidak.TabIndex = 4;
        	this.buttonTidak.Text = "TIDAK";
        	this.buttonTidak.UseVisualStyleBackColor = true;
        	this.buttonTidak.Click += new System.EventHandler(this.buttonTidak_Click);
        	// 
        	// box6
        	// 
        	this.box6.Controls.Add(this.buttonYA);
        	this.box6.Controls.Add(this.buttonTidak);
        	this.box6.Location = new System.Drawing.Point(219, 251);
        	this.box6.Name = "box6";
        	this.box6.Size = new System.Drawing.Size(171, 52);
        	this.box6.TabIndex = 5;
        	this.box6.TabStop = false;
        	this.box6.Text = "Simpan dan Restart Aplikasi?";
        	// 
        	// box4
        	// 
        	this.box4.Controls.Add(this.message);
        	this.box4.Location = new System.Drawing.Point(218, 125);
        	this.box4.Name = "box4";
        	this.box4.Size = new System.Drawing.Size(172, 81);
        	this.box4.TabIndex = 6;
        	this.box4.TabStop = false;
        	this.box4.Text = "Pesan";
        	// 
        	// message
        	// 
        	this.message.Location = new System.Drawing.Point(10, 20);
        	this.message.Multiline = true;
        	this.message.Name = "message";
        	this.message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.message.Size = new System.Drawing.Size(153, 48);
        	this.message.TabIndex = 0;
        	// 
        	// box5
        	// 
        	this.box5.Controls.Add(this.cbStartup);
        	this.box5.Location = new System.Drawing.Point(219, 212);
        	this.box5.Name = "box5";
        	this.box5.Size = new System.Drawing.Size(171, 34);
        	this.box5.TabIndex = 7;
        	this.box5.TabStop = false;
        	this.box5.Text = "Registry";
        	// 
        	// cbStartup
        	// 
        	this.cbStartup.Location = new System.Drawing.Point(9, 15);
        	this.cbStartup.Name = "cbStartup";
        	this.cbStartup.Size = new System.Drawing.Size(152, 17);
        	this.cbStartup.TabIndex = 0;
        	this.cbStartup.Text = "Startup with Windows?";
        	this.cbStartup.UseVisualStyleBackColor = true;
        	// 
        	// FormSetting
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(402, 317);
        	this.ControlBox = false;
        	this.Controls.Add(this.box5);
        	this.Controls.Add(this.box4);
        	this.Controls.Add(this.box6);
        	this.Controls.Add(this.box2);
        	this.Controls.Add(this.box3);
        	this.Controls.Add(this.box1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = global::Shutdown_Helper.Properties.Resources.pengaturan;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "FormSetting";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Pengaturan";
        	this.Load += new System.EventHandler(this.FormSetting_Load);
        	this.box1.ResumeLayout(false);
        	this.box1c.ResumeLayout(false);
        	this.box1c.PerformLayout();
        	this.box1a.ResumeLayout(false);
        	this.box1a.PerformLayout();
        	this.box1b.ResumeLayout(false);
        	this.box1b.PerformLayout();
        	this.box3.ResumeLayout(false);
        	this.box3.PerformLayout();
        	this.box2.ResumeLayout(false);
        	this.box2.PerformLayout();
        	this.box6.ResumeLayout(false);
        	this.box4.ResumeLayout(false);
        	this.box4.PerformLayout();
        	this.box5.ResumeLayout(false);
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.CheckBox cbStartup;
        private System.Windows.Forms.GroupBox box5;
        private System.Windows.Forms.GroupBox box1c;

        #endregion

        private System.Windows.Forms.GroupBox box1;
        private System.Windows.Forms.GroupBox box3;
        private System.Windows.Forms.RadioButton rbHibernate;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.GroupBox box2;
        private System.Windows.Forms.TextBox jedaWaktu;
        private System.Windows.Forms.ComboBox jedaPer;
        private System.Windows.Forms.Button buttonYA;
        private System.Windows.Forms.Button buttonTidak;
        private System.Windows.Forms.GroupBox box6;
        private System.Windows.Forms.GroupBox box1b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox infoTipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox driveLetter;
        private System.Windows.Forms.TextBox infoVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox infoFormat;
        private System.Windows.Forms.GroupBox box1a;
        private System.Windows.Forms.GroupBox box4;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.ComboBox monitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox infoLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changeDrive;
    }
}