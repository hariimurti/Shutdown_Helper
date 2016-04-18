using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Shutdown_Helper
{
    public partial class FormSetting : Form
    {
        ChangeDriveLetter changeDriveLetter = new ChangeDriveLetter();
        static string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        IniFile settingIni = new IniFile(appPath + "\\Settings.ini");

        public FormSetting()
        {
            InitializeComponent();
        }

        public void cekPengaturan()
        {
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
            monitor.SelectedIndex = Convert.ToInt32(settingIni.Read("Monitor", "Pengaturan"));
            driveLetter.Text = @settingIni.Read("DriveLetter", "Pengaturan");
            jedaWaktu.Text = settingIni.Read("JedaWaktu", "Pengaturan");
            jedaPer.SelectedIndex = Convert.ToInt32(settingIni.Read("JedaPer", "Pengaturan"));
            if (Convert.ToInt32(settingIni.Read("Shutdown", "Pengaturan")) == 0)
                rbShutdown.Checked = true;
            else
                rbHibernate.Checked = true;
            message.Text = settingIni.Read("Pesan", "Pengaturan");
            if (Convert.ToInt32(settingIni.Read("Startup", "Pengaturan")) == 0)
                cbStartup.Checked = false;
            else
                cbStartup.Checked = true;
        }

        public void menyimpanPengaturan()
        {
            // mulai menyimpan penganturan ke Settings.ini
            settingIni.Write("Monitor", monitor.SelectedIndex.ToString(), "Pengaturan");
            settingIni.Write("DriveLetter", driveLetter.Text, "Pengaturan");
            settingIni.Write("JedaWaktu", jedaWaktu.Text, "Pengaturan");
            settingIni.Write("JedaPer", jedaPer.SelectedIndex.ToString(), "Pengaturan");
            if (rbShutdown.Checked)
                settingIni.Write("Shutdown", "0", "Pengaturan");
            else
                settingIni.Write("Shutdown", "1", "Pengaturan");
            settingIni.Write("Pesan", message.Text, "Pengaturan");
            if (cbStartup.Checked)
                settingIni.Write("Startup", "1", "Pengaturan");
            else
                settingIni.Write("Startup", "0", "Pengaturan");
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            cekPengaturan();
            mengambilPengaturan();
        }

        private void monitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monitor.SelectedIndex == 0)
            {
                label7.Text = "Pastikan drive A:\\ tidak dipakai";
                changeDrive.Text = "Change Drive Letter to A:\\";
                driveLetter.Text = "A:\\";
            }
            else
            {
                label7.Text = "Pastikan drive Z:\\ tidak dipakai";
                changeDrive.Text = "Change Drive Letter to Z:\\";
                driveLetter.Text = "Z:\\";
            }
        }

        private void driveLetter_DropDown(object sender, EventArgs e)
        {
            driveLetter.Items.Clear();
            if (monitor.SelectedIndex == 0)
                driveLetter.Items.Add("A:\\");
            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                if ((driveInfo.DriveType == DriveType.Removable) || (driveInfo.DriveType == DriveType.Unknown))
                    driveLetter.Items.Add(driveInfo.Name);
            }
            if (monitor.SelectedIndex == 1)
                driveLetter.Items.Add("Z:\\");
        }

        private void driveLetter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo driveInfo = new DriveInfo(@driveLetter.Text);
            infoTipe.Text = ": " + driveInfo.DriveType.ToString();
            try
            {
                infoLabel.Text = ": " + driveInfo.VolumeLabel + " (" + @driveLetter.Text.Substring(0, 2) + ")";
            }
            catch
            {
                infoLabel.Text = ": Unknown (" + @driveLetter.Text.Substring(0, 2) + ")";
            }
            try
            {
                infoFormat.Text = ": " + driveInfo.DriveFormat.ToString();
            }
            catch
            {
                infoFormat.Text = ": Unknown";
            }
            try
            {
                infoVolume.Text = ": " + driveInfo.TotalSize.ToString() + " bytes";
            }
            catch
            {
                infoVolume.Text = ": Unknown";
            }
            
            if (monitor.SelectedIndex == 0)
            {
                if (@driveLetter.Text == "A:\\")
                	changeDrive.Enabled = false;
                else
                {
                	changeDrive.Text = "Change Drive " + @driveLetter.Text + " to A:\\";
                	changeDrive.Enabled = true;
                }
            }
            else if (monitor.SelectedIndex == 1)
            {
                if (@driveLetter.Text == "Z:\\")
                	changeDrive.Enabled = false;
                else
                {
                	changeDrive.Text = "Change Drive " + @driveLetter.Text + " to Z:\\";
                	changeDrive.Enabled = true;
                }
            }
        }

        private void waktuJeda_KeyPress(object sender, KeyPressEventArgs e)
        {
            // input hanya boleh karakter angka
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void driveLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // melarang semua input
            e.Handled = true;
        }

        private void changeDrive_Click(object sender, EventArgs e)
        {
            if (monitor.SelectedIndex == 0)
            {
                if (changeDriveLetter.Set(driveLetter.Text, "A:\\"))
                    driveLetter.Text = "A:\\";
                else
                    MessageBox.Show("Tidak dapat mengganti Drive Letter " + driveLetter.Text + " ke A:\\");
            }
            else
            {
                if (changeDriveLetter.Set(driveLetter.Text, "Z:\\"))
                    driveLetter.Text = "Z:\\";
                else
                    MessageBox.Show("Tidak dapat mengganti Drive Letter " + driveLetter.Text + " ke Z:\\");
            }
        }

        private void buttonYA_Click(object sender, EventArgs e)
        {
            menyimpanPengaturan();
            Application.Restart();
        }

        private void buttonTidak_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
