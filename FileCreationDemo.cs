//creating a file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class FileCreationDemo
    {
        static void Main(string[] args)
        {
                /* creating a fileInfo instance */
            FileInfo f = new FileInfo("E:\\File.txt");
            if(f.Exists)
            {
                Console.WriteLine("file already exist");
                return;
            }
                /*creating empty file*/
            f.Create();
            
            Console.WriteLine("file created successfully");
            Console.ReadLine();
        }
    }
}
