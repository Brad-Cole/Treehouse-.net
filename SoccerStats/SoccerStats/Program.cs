using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory());
            string fileName = Path.Combine(directory.FullName, "secretmessage.txt");
            var file = new FileInfo(fileName);
            if (file.Exists)
            {
                using (var reader = new StreamReader(file.FullName))
                {
                    Console.SetIn(reader);
                    Console.WriteLine(Console.ReadLine());
                }
            }
        }
    }
}
