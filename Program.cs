using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gulyaev_AG_4
{
    class Program
    {
        public static string GetExtension(string FileName)
        {
            FileInfo inf = new FileInfo(FileName);
            return inf.Extension;
        }

        static void Main(string[] args)
        {
            try
            {
                string FileName, FileExtension;
                Console.WriteLine("Enter the full file name (with extension):");
                FileName = Console.ReadLine();
                FileExtension = GetExtension(FileName);
                switch (FileExtension)
                {
                    case ".html":
                        new Client().HTML();
                        break;
                    case ".cs":
                        new Client().Sharp();
                        break;
                    case ".sql":
                        new Client().SQL();
                        break;
                    default:
                        Console.WriteLine("Invalid data type! Load the correct file.");
                        break;
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Invalid file name.");
            }
        }
    }
}
