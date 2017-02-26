using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Threading;
using System.Management;
using System.Net.NetworkInformation;

namespace Borealis
{
    public class System_Monitoring
    {
        //===================================================================================//
        // RAM UTILIZATION INFO FUNCTIONS                                                    //
        //===================================================================================//
        public long RetreiveFreeRAM()
        {
            var info = new ComputerInfo();
            return (long)(info.AvailablePhysicalMemory / 1024 / 1024);
        }

        public long RetreiveTotalAvailableRAM()
        {
            var info = new ComputerInfo();
            return (long)(info.TotalPhysicalMemory / 1024 / 1024);
        }

        //===================================================================================//
        // DIRECTORY UTILIZATION INFO FUNCTIONS                                              //
        //===================================================================================//
        public long GetDirectorySize(string path)
        {
            // Get array of all file names.
            string[] a = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }

            // Return total size
            return b;
        }

        //===================================================================================//
        // DISK UTILIZATION INFO FUNCTIONS                                                   //
        //===================================================================================//
        public double RetrieveDISKInfo(string driveName, bool TotalSize, bool TotalUsed, bool PercentUsed)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    if (TotalSize == true)
                    {
                        return (drive.TotalSize / (1024 * 1024 * 1024));
                    }
                    if (TotalUsed == true)
                    {
                        return (drive.TotalSize - drive.AvailableFreeSpace) / (1024 * 1024 * 1024);
                    }
                    if (PercentUsed == true)
                    {
                        return ((((double)drive.TotalSize - (double)drive.AvailableFreeSpace) / ((double)drive.TotalSize)) * 100);
                    }
                }
            }
            MessageBox.Show("ERROR! NO DISK DATA FOUND!"); //YOU SHOULD NEVER SEE THIS.
            return -1;
        }

        //===================================================================================//
        // CPU UTILIZATION INFO FUNCTIONS                                                    //
        //===================================================================================//
        public int RetrieveCPUUsage()
        {
            // http://stackoverflow.com/questions/9777661/returning-cpu-usage-in-wmi-using-c-sharp
            using (var searcher = new ManagementObjectSearcher("select * from Win32_PerfFormattedData_PerfOS_Processor"))
            {
                var count = 0;
                var mean = 0;
                var collection = searcher.Get();
                foreach (ManagementObject obj in collection)
                {
                    //We only care about the first value
                    mean += Convert.ToInt32(obj["PercentProcessorTime"]);
                    count++;
                    obj.Dispose();
                }
                collection.Dispose();
                return mean / count;
            }
        }

        //===================================================================================//
        // LAN UTILIZATION INFO FUNCTIONS                                                    //
        //===================================================================================//
        public long RetrieveLANUsage(bool bytesIn, bool bytesOut)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

                if (bytesIn == true)
                {
                    foreach (NetworkInterface ni in interfaces)
                    {
                        return ni.GetIPv4Statistics().BytesReceived;
                    }
                }

                if (bytesOut == true)
                {
                    foreach (NetworkInterface ni in interfaces)
                    {
                        return ni.GetIPv4Statistics().BytesSent;
                    }
                }
                return 0;
            }
            return 0;
        }
    }
}