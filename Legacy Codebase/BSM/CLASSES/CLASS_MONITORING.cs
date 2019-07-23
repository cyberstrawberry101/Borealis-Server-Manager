using Microsoft.VisualBasic.Devices;
using System;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Borealis
{
    public class SystemMonitoring
    {
        private readonly ComputerInfo _computerInfo = new ComputerInfo();

        //===================================================================================//
        // RAM UTILIZATION INFO FUNCTIONS                                                    //
        //===================================================================================//
        public long RetreiveFreeRAM()
        {
            return (long)(_computerInfo.AvailablePhysicalMemory / 1024 / 1024);
        }

        public long RetreiveTotalAvailableRAM()
        {
            return (long)(_computerInfo.TotalPhysicalMemory / 1024 / 1024);
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
        public double RetrieveDISKInfo(string driveName, bool totalSize, bool totalUsed, bool percentUsed)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    if (totalSize)
                    {
                        return (drive.TotalSize / (1024 * 1024 * 1024));
                    }
                    if (totalUsed)
                    {
                        return (drive.TotalSize - drive.AvailableFreeSpace) / (1024 * 1024 * 1024);
                    }
                    if (percentUsed)
                    {
                        return (((drive.TotalSize - drive.AvailableFreeSpace) / (drive.TotalSize)) * 100);
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

                if (bytesIn)
                {
                    foreach (NetworkInterface ni in interfaces)
                    {
                        return ni.GetIPv4Statistics().BytesReceived;
                    }
                }

                if (bytesOut)
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