using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace LZMADemo._7ZipHandler
{
    public class SevenzipHandler
    {
        /// <summary>
        /// Compress file to 7Z by 7za.exe
        /// </summary>
        /// <param name="sevenzaPath"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="objectDirectorPath"></param>
        public static void CompressFile(string sevenzaPath, string sourceFilePath, string objectDirectorPath)
        {
            if (File.Exists(String.Format(sevenzaPath)) && File.Exists(sourceFilePath))
            {
                ProcessStartInfo progress = new ProcessStartInfo();
                progress.FileName = sevenzaPath;
                progress.Arguments = string.Format($@"a -t7z {String.Format($"{objectDirectorPath}\\{Path.GetFileNameWithoutExtension(sourceFilePath)}.7z")} {sourceFilePath} -mx=9 -aoa");
                Debug.WriteLine(progress.Arguments);
                progress.WindowStyle = ProcessWindowStyle.Hidden;
                System.Diagnostics.Process compressthread = System.Diagnostics.Process.Start(progress);
                compressthread.WaitForExit();
            }
        }

        /// <summary>
        /// Extral Zip File
        /// </summary>
        /// <param name="sevenzaPath"></param>
        /// <param name="sourceFilePath"></param>
        /// <param name="objectDirecotrPath"></param>
        public static void ExtraZipFile(string sevenzaPath,string sourceFilePath,string objectDirecotrPath)
        {
            if (File.Exists(String.Format(sevenzaPath)) && File.Exists(sourceFilePath))
            {
                if (!Directory.Exists(objectDirecotrPath))
                {
                    Directory.CreateDirectory(objectDirecotrPath);
                }
                ProcessStartInfo progress = new ProcessStartInfo();
                progress.FileName = sevenzaPath;
                progress.Arguments = string.Format($@" e {sourceFilePath} -o{objectDirecotrPath} -aoa ");
                progress.WindowStyle = ProcessWindowStyle.Hidden;
                System.Diagnostics.Process compressthread = System.Diagnostics.Process.Start(progress);
                compressthread.WaitForExit();
            } 
        }
    }
}
