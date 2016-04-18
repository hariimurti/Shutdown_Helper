using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Shutdown_Helper
{
    class ChangeDriveLetter
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GetVolumeNameForVolumeMountPoint(string
            lpszVolumeMountPoint, [Out] StringBuilder lpszVolumeName,
            uint cchBufferLength);

        [DllImport("kernel32.dll")]
        static extern bool DeleteVolumeMountPoint(string lpszVolumeMountPoint);

        [DllImport("kernel32.dll")]
        static extern bool SetVolumeMountPoint(string lpszVolumeMountPoint,
            string lpszVolumeName);

        const int MAX_PATH = 260;

        public bool Set(string awal, string akhir)
        {
            StringBuilder volume = new StringBuilder(MAX_PATH);
            if (GetVolumeNameForVolumeMountPoint(@"" + awal, volume, (uint)MAX_PATH))
            {
                if (DeleteVolumeMountPoint(@awal))
                {
                    if (!SetVolumeMountPoint(@akhir, volume.ToString()))
                    {
                        SetVolumeMountPoint(@awal, volume.ToString());
                        return false;
                    }
                    else
                        return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
