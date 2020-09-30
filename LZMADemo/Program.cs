using LZMADemo._7ZipHandler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZMADemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sevenZipFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"7ZipHandler\7-Zip\7za.exe");

            string sourceFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"TestFile\简明py教程.pdf"); 
            SevenzipHandler.CompressFile(sevenZipFolderPath, sourceFilePath, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"TestFile\ZipFolder"));
           // System.Threading.Thread.Sleep(5000);
            SevenzipHandler.ExtraZipFile(
                sevenZipFolderPath, 
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"TestFile\ZipFolder\简明py教程.7z"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"TestFile\ZipFolder"));
        }
    }
}
