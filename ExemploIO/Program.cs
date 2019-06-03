using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploIO
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            Console.WriteLine("Número de Drives: " + drives.Length.ToString());
            Console.WriteLine("Lista de Drives deste computador: ");
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("#########################################################");
                Console.WriteLine("Nome: " + drive.Name);
                if (!drive.IsReady) continue;
                Console.WriteLine("Volume Label: " + drive.VolumeLabel);
                Console.WriteLine("Total Size: " + drive.TotalSize.ToString());
                Console.WriteLine("Free Space: " + drive.TotalFreeSpace.ToString());
                Console.WriteLine("Available Free Space: " + drive.AvailableFreeSpace.ToString());
                Console.WriteLine("Is Ready: " + drive.IsReady.ToString());
                Console.WriteLine("Drive Type: " + drive.DriveType.ToString());
                Console.WriteLine("Drive Format: " + drive.DriveFormat.ToString());
                Console.WriteLine("Root Dir: " + drive.RootDirectory.ToString());
            }
            Console.ReadLine();
        }
    }
}
