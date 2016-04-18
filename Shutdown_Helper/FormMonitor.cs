using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;

namespace Shutdown_Helper
{
    public partial class FormMonitor : Form
    {
        // Win32 constants
        private const int WM_DEVICECHANGE = 0x0219; // device change event
        private const int DBT_DEVICEARRIVAL = 0x8000; // system detected a new device
        private const int DBT_DEVICEREMOVALCOMPLETE = 0x8004; // usb removed
        private const int DBT_DEVTYPVOLUME = 0x00000002; // drive type is logical volume

        // Settings.ini
        static string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        IniFile settingIni = new IniFile(appPath + "\\Settings.ini");
        string appLog = appPath + "\\log.txt";
        int monitor, jedaWaktu, jedaPer, timerDetik, timerMenit;
        string driveLetter, pesan, shutdown;
        bool pesanMati = false;

        // panggil form lain
        FormShutdown frmShutdown;
        FormSetting frmSetting;
        FormAbout frmAbout;

        public FormMonitor()
        {
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DEV_BROADCAST_VOLUME
        {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
        }

        private static char DriveMaskToLetter(int mask)
        {
            char letter;
            string drives = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //1 = A, 2 = B, 3 = C
            int cnt = 0;
            int pom = mask / 2;
            while (pom != 0)    // while there is any bit set in the mask shift it right        
            {
                pom = pom / 2;
                cnt++;
            }
            if (cnt < drives.Length)
                letter = drives[cnt];
            else
                letter = '?';
            return letter;
        }

        protected override void WndProc(ref Message m)
        {
        	if ((m.Msg == WM_DEVICECHANGE) && ((frmSetting == null) || (frmSetting.IsDisposed)))
            {
                if (m.WParam.ToInt32() == DBT_DEVICEARRIVAL)
                {
                    DEV_BROADCAST_VOLUME vol = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));
                    if (vol.dbcv_devicetype == DBT_DEVTYPVOLUME)
                    {
                        string driveInsert = DriveMaskToLetter(vol.dbcv_unitmask).ToString() + ":\\";
                        if ((monitor == 0) && (driveInsert == driveLetter))
                        {
                        	if(jedaPer == 0)
                        		timer1.Enabled = true;
                        	else
                        		timer2.Enabled = true;
                        	timer3.Enabled = true;
                            showPesanMati();
                        }
                        else if ((monitor == 1) && (driveInsert == driveLetter))
                        {
                            timer1.Enabled = false;
                            timer2.Enabled = false;
                            if (pesanMati)
                            	showPesanBatal();
                        }
                    }
                }
                if (m.WParam.ToInt32() == DBT_DEVICEREMOVALCOMPLETE)
                {
                    DEV_BROADCAST_VOLUME vol = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_VOLUME));
                    if (vol.dbcv_devicetype == DBT_DEVTYPVOLUME)
                    {
                        string driveRemove = DriveMaskToLetter(vol.dbcv_unitmask).ToString() + ":\\";
                        if ((monitor == 1) && (driveRemove == driveLetter))
                        {
                            if(jedaPer == 0)
                        		timer1.Enabled = true;
                        	else
                        		timer2.Enabled = true;
                        	timer3.Enabled = true;
                            showPesanMati();
                        }
                        else if ((monitor == 0) && (driveRemove == driveLetter))
                        {
                            timer1.Enabled = false;
                            timer2.Enabled = false;
                            if (pesanMati)
                            	showPesanBatal();
                        }
                    }
                }
            }
            base.WndProc(ref m);
        }

        public void cekPengaturan()
        {
            // cek keberadaan bbrp key di pengaturan
            if (!settingIni.KeyExists("Monitor", "Pengaturan"))
                settingIni.Write("Monitor", "0", "Pengaturan");
            if (!settingIni.KeyExists("DriveLetter", "Pengaturan"))
                settingIni.Write("DriveLetter", "A:\\", "Pengaturan");
            if (!settingIni.KeyExists("JedaWaktu", "Pengaturan"))
                settingIni.Write("JedaWaktu", "10", "Pengaturan");
            if (!settingIni.KeyExists("JedaPer", "Pengaturan"))
                settingIni.Write("JedaPer", "0", "Pengaturan");
            if (!settingIni.KeyExists("Shutdown", "Pengaturan"))
                settingIni.Write("Shutdown", "0", "Pengaturan");
            if (!settingIni.KeyExists("Pesan", "Pengaturan"))
                settingIni.Write("Pesan", "", "Pengaturan");
            if (!settingIni.KeyExists("Startup", "Pengaturan"))
                settingIni.Write("Startup", "0", "Pengaturan");
        }

        public void mengambilPengaturan()
        {
            // mulai mengambil pengaturan
            monitor = Convert.ToInt32(settingIni.Read("Monitor", "Pengaturan"));
            driveLetter = @settingIni.Read("DriveLetter", "Pengaturan");
            jedaWaktu = Convert.ToInt32(settingIni.Read("JedaWaktu", "Pengaturan"));
            jedaPer = Convert.ToInt32(settingIni.Read("JedaPer", "Pengaturan"));
            pesan = settingIni.Read("Pesan", "Pengaturan");
            if (pesan == "")
            	pesan = "dafuq! listrik mati (T-T)9";
            if (Convert.ToInt32(settingIni.Read("Shutdown", "Pengaturan")) == 0)
            	shutdown = "Shutdown";
            else
            	shutdown = "Hibernate";
            if (Convert.ToInt32(settingIni.Read("Startup", "Pengaturan")) == 0)
            	RegisterInStartup(false);
            else
            	RegisterInStartup(true);
        }
        
        private void RegisterInStartup(bool startup)
		{
		    RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
		            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
		    if (startup)
		        registryKey.SetValue("Shutdown_Helper", Application.ExecutablePath);
		    else
		    {
		    	if (registryKey.GetValue("Shutdown_Helper") != null)
		    		registryKey.DeleteValue("Shutdown_Helper");
		    }
		}
        
        public void createLog(int c)
        {
        	using (StreamWriter writer = new StreamWriter(appLog, true))
			{
        		if (c == 0)
        			writer.WriteLine("Shutdown Helper Logs\r\n" + "----------------------------------------------");
        		else if (c == 1)
        			writer.WriteLine(DateTime.Now.ToString("g") + " : Trigger On");
        		else if (c == 2)
        			writer.WriteLine(DateTime.Now.ToString("g") + " : Trigger Off");
        	}
        }

        private void FormMonitor_Load(object sender, EventArgs e)
        {
        	// cek log.txt jika lbh dari 100kb akan hapus
        	if (File.Exists(appLog))
        	{
	        	FileInfo f = new FileInfo(appLog);
	        	if (f.Length > 100*1024)
	        	{
	        		File.Delete(appLog);
	        		createLog(0);
	        	}
        	}
        	else
        		createLog(0);
        	
        	// membuat menu pada notif icon
        	contextMenuStrip1.Items.Clear();
        	contextMenuStrip1.Items.Add("Pengaturan", null, showPengaturan);
        	contextMenuStrip1.Items.Add("-", null);
        	contextMenuStrip1.Items.Add("About", null, showAbout);
        	contextMenuStrip1.Items.Add("Exit", null, keluar);
        	
        	// melakukan cek pengaturan
        	cekPengaturan();
        	
        	// mengambil pengaturan
        	mengambilPengaturan();
        }
        
        public void showPesanMati()
        {
        	pesanMati = true;
        	notifyIcon1.Icon = Properties.Resources.warning;
        	notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
        	notifyIcon1.BalloonTipText = pesan;
            notifyIcon1.ShowBalloonTip(1000);
            createLog(1);
        }
        
        public void showPesanBatal()
        {
        	pesanMati = false;
        	notifyIcon1.Icon = Properties.Resources.icon;
        	notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
        	notifyIcon1.BalloonTipText = "Listrik sudah kembali hidup \\(^^,)/";
            notifyIcon1.ShowBalloonTip(1000);
            if (!((frmShutdown == null) || (frmShutdown.IsDisposed)))
            	frmShutdown.Close();
            createLog(2);
        }
        
        void Timer1Tick(object sender, EventArgs e)
        {
        	timerDetik = timerDetik + 1;
        	if (timerDetik >= jedaWaktu)
        	{
	        	notifyIcon1.Visible = false;
	        	notifyIcon1.Visible = true;
        		if ((frmShutdown == null) || (frmShutdown.IsDisposed))
	                    frmShutdown = new FormShutdown();
	        	frmShutdown.Show();
	            timer1.Enabled = false;
        	}
        	else
        	{
        		notifyIcon1.BalloonTipText = "Warning! Komputer akan " +
        			shutdown + " dalam " + (jedaWaktu - timerDetik) + " Detik";
            	notifyIcon1.ShowBalloonTip(500);
        	}
        }
        
        void Timer2Tick(object sender, EventArgs e)
        {
        	timerMenit = timerMenit + 1;
        	if (timerMenit >= jedaWaktu)
        	{
        		notifyIcon1.Visible = false;
	        	notifyIcon1.Visible = true;
        		if ((frmShutdown == null) || (frmShutdown.IsDisposed))
	                    frmShutdown = new FormShutdown();
	        	frmShutdown.Show();
	            timer2.Enabled = false;
        	}
        	else
        	{
        		notifyIcon1.BalloonTipText = "Warning! Komputer akan "
        			+ shutdown + " dalam " + (jedaWaktu - timerMenit) + " Menit";
            	notifyIcon1.ShowBalloonTip(500);
        	}
        }
        
        void Timer3Tick(object sender, EventArgs e)
        {
        	timerDetik = 0;
        	timerMenit = 0;
        	timer2.Enabled = false;
        }
        
        public void showPengaturan(object sender, EventArgs e)
        {
        	if ((frmSetting == null) || (frmSetting.IsDisposed))
                    frmSetting = new FormSetting();
        	frmSetting.Show();
        }
        
        public void showAbout(object sender, EventArgs e)
        {
        	if ((frmAbout == null) || (frmAbout.IsDisposed))
                    frmAbout = new FormAbout();
        	frmAbout.Show();
        }
        
        public void keluar(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Shutdown Helper", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
