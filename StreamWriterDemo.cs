using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class StreamWriterDemo
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"E:\test.txt",FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("hello to c#.net language");
            s.Close();
            f.Close();
            Console.WriteLine("file created sucessfully");
            Console.ReadLine();
        }
    }
}
