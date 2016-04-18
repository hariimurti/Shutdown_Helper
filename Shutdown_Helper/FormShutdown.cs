using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Shutdown_Helper
{
    public partial class FormShutdown : Form
    {
        static string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        IniFile settingIni = new IniFile(appPath + "\\Settings.ini");
        string appLog = appPath + "\\log.txt";
        int mati, x = 10;
        
        public FormShutdown()
        {
            InitializeComponent();
        }
        
        public void mengambilPengaturan()
        {
            // mulai mengambil pengaturan
            mati = Convert.ToInt32(settingIni.Read("Shutdown", "Pengaturan"));
            if (mati == 0)
            {
            	this.Text = "Shutdown";
            	pictureBox1.Image = Properties.Resources.shutdown_icon;
            	button1.Text = "Shutdown (" + x + ")";
            }
            else
            {
                this.Text = "Hibernate";
            	pictureBox1.Image = Properties.Resources.other_icon;
            	button1.Text = "Hibernate (" + x + ")";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        	using (StreamWriter writer = new StreamWriter(appLog, true))
			{
			    writer.WriteLine(DateTime.Now.ToString("g") + " : " + this.Text);
			}
        	if (mati == 0)
        		Process.Start("shutdown", "/s /f /t 0");
        	else
        		Process.Start("shutdown", "/h /f");
        	Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        void Timer1Tick(object sender, EventArgs e)
        {
        	x = x - 1;
        	
        	if (mati == 0)
            	button1.Text = "Shutdown (" + x + ")";
            else
                button1.Text = "Hibernate (" + x + ")";
            
        	if (x == 0)
        		button1_Click(sender, e);
        }
        
        void FormShutdownLoad(object sender, EventArgs e)
        {
        	mengambilPengaturan();
        }
    }
}
