using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Timers;

namespace GameServer_Manager
{
    public class GSM_MonitoringFunctions
    {
        //===================================================================================//
        // RAM UTILIZATION INFO FUNCTIONS                                                    //
        //===================================================================================//
        public string RetrieveRAMUsage(bool OverallUsage, bool IndividualUsage)
        {
            PerformanceCounter ramCounter;
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            return Convert.ToString(ramCounter.NextValue());
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
        public double RetrieveDISKInfo(string driveName, bool TotalSize, bool TotalUsed, bool PercentUsed, bool DirectoryUsed)
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
            return -1;
        }


        //===================================================================================//
        // CPU UTILIZATION INFO FUNCTIONS                                                    //
        //===================================================================================//
        public int RetrieveCPUUsage(bool OverallUsage, bool IndividualUsage)
        {
            PerformanceCounter cpuCounter;
            cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";
            return (int)cpuCounter.NextValue();
        }


    }
}
