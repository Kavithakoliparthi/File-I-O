using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class TextWriterDemo
    {
        static void Main(string[] args)
        {
            using (TextWriter t = File.CreateText("E:\\Sample1.txt"))
            {
                t.WriteLine("Hello C#");
                t.WriteLine("C#.net is a dependent language");
                t.WriteLine("C#.net File Handling");
            }
            Console.WriteLine("Data written successfully...");
            Console.ReadLine();
        }
    }
}
