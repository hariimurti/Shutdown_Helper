namespace Shutdown_Helper
{
    partial class FormMonitor
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
        	this.components = new System.ComponentModel.Container();
        	this.label1 = new System.Windows.Forms.Label();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
        	this.timer2 = new System.Windows.Forms.Timer(this.components);
        	this.timer3 = new System.Windows.Forms.Timer(this.components);
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(12, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(221, 26);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "... form ini tidak akan tampil ...\r\n- berfungsi memonitor trigger yg sdh disettin" +
        	"g -";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// timer1
        	// 
        	this.timer1.Interval = 1000;
        	this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
        	// 
        	// contextMenuStrip1
        	// 
        	this.contextMenuStrip1.Name = "contextMenuStrip1";
        	this.contextMenuStrip1.ShowImageMargin = false;
        	this.contextMenuStrip1.Size = new System.Drawing.Size(36, 4);
        	// 
        	// notifyIcon1
        	// 
        	this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
        	this.notifyIcon1.BalloonTipText = "Memantau USB sebagai trigger jika listrik mati...";
        	this.notifyIcon1.BalloonTipTitle = "Shutdown Helper";
        	this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
        	this.notifyIcon1.Icon = global::Shutdown_Helper.Properties.Resources.icon;
        	this.notifyIcon1.Text = "Shutdown Helper";
        	this.notifyIcon1.Visible = true;
        	// 
        	// timer2
        	// 
        	this.timer2.Interval = 60000;
        	this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
        	// 
        	// timer3
        	// 
        	this.timer3.Interval = 1800000;
        	this.timer3.Tick += new System.EventHandler(this.Timer3Tick);
        	// 
        	// FormMonitor
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(237, 37);
        	this.ControlBox = false;
        	this.Controls.Add(this.label1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.Icon = global::Shutdown_Helper.Properties.Resources.monitor;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "FormMonitor";
        	this.Opacity = 0D;
        	this.ShowInTaskbar = false;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "USB Monitor";
        	this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        	this.Load += new System.EventHandler(this.FormMonitor_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

