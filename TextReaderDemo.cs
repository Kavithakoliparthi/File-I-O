using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class TextReaderDemo
    {
        static void Main(string[] args)
        {
            using (TextReader t = File.OpenText("E:\\Sample1.txt"))
            {
                /*Read Complete data in the file*/
                //Console.WriteLine(t.ReadToEnd());
                /*Read Single line in the file*/
                Console.WriteLine(t.ReadLine());
                Console.WriteLine(t.ToString());
            }
            Console.ReadLine();
        }
    }
}
