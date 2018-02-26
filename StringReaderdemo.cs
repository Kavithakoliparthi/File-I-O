using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class StringReaderdemo
    {
        static void Main(string[] args)
        {
            StringWriter sw = new StringWriter();
            sw.WriteLine("this is a string reader class");
            sw.Close();
            StringReader sr = new StringReader(sw.ToString());
            while(sr.Peek()>-1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
