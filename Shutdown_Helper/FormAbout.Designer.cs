/*
 * Created by SharpDevelop.
 * User: Harimurti
 * Date: 1/10/2014
 * Time: 6:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shutdown_Helper
{
	partial class FormAbout
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(105, 215);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Shutdown Helper\r\n--------------------------------------------------";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(260, 57);
			this.label2.TabIndex = 2;
			this.label2.Text = "aplikasi ini digunakan untuk mematikan komputer secara otomatis jika trigger (det" +
			"eksi usb) terpenuhi.\r\nbekerja dengan baik jika di implementasikan bersama UPS (j" +
			"ika tidak memiliki software bawaan).";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(64, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Versi\r\nBuild Date";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(129, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = ": 1.2\r\n: 13 Januari 2014";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 188);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(260, 15);
			this.label5.TabIndex = 5;
			this.label5.Text = "Copyright © 2014";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(12, 171);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(260, 19);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://blog.harimurti.net";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(260, 15);
			this.label6.TabIndex = 7;
			this.label6.Text = "--------------------------------------------------";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 151);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(260, 15);
			this.label7.TabIndex = 8;
			this.label7.Text = "--------------------------------------------------";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 251);
			this.ControlBox = false;
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Icon = global::Shutdown_Helper.Properties.Resources.icon;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
