using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class DirectoryCraetionDemo
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("E:\\Programs");
            if(d.Exists)
            {
                Console.WriteLine("directory already exists");
                Console.Read();
                return;
            }
            d.Create();
            Console.WriteLine("directory craeted successfully");
            Console.ReadLine();
        }
    }
}
