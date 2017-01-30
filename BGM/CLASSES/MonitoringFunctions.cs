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
        // RAM UTILIZATION INFO FUNCTION                                                     //
        //===================================================================================//
        public string RetrieveRAMUsage(bool OverallUsage, bool IndividualUsage)
        {
            PerformanceCounter ramCounter;
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            return Convert.ToString(ramCounter.NextValue());
        }


        //===================================================================================//
        // DISK UTILIZATION INFO FUNCTION                                                    //
        //===================================================================================//
        public long GetDirectorySize(string path)
        {
            // 1.
            // Get array of all file names.
            string[] a = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            // 2.
            // Calculate total bytes of all files in a loop.
            long b = 0;
            foreach (string name in a)
            {
                // 3.
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            // 4.
            // Return total size
            return b;
        }

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
                    if (DirectoryUsed == true)
                    {
                        /*
                        long startDirectorySize = 0;
                        if (!Directory.Exists(driveName))
                            return startDirectorySize; //Return 0 while Directory does not exist.

                        var currentDirectory = new DirectoryInfo(driveName);
                        //Add size of files in the Current Directory to main size.
                        currentDirectory.GetFiles().ToList().ForEach(f => startDirectorySize += f.Length);

                        //Loop on Sub Directories in the Current Directory and Calculate it's files size.
                        currentDirectory.GetDirectories().ToList()
                            .ForEach(d => startDirectorySize += GetDirectorySize(d.FullName));

                        return startDirectorySize;  //Return full Size of this Directory.
                        */
                    }
                }
            }
            return -1;
        }


        //===================================================================================//
        // CPU UTILIZATION CLASSSES                                                          //
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
