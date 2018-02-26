//Writing text into a file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class FileWriteDemo
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo("E:\\File.txt");
                /*creating file instance to write*/
            StreamWriter sw = f.CreateText();
            sw.WriteLine("the text is written into a file using streamwriter class");
            sw.Close();
            Console.ReadLine();
        }
    }
}
