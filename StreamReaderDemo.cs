using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class StreamReaderDemo
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("E:\\test.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            string s1 = s.ReadLine();
            Console.WriteLine(s1);
            f.Close();
            s.Close();
            Console.ReadLine();
        }
    }
}
