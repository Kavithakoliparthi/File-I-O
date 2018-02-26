using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class StringWriterDemo
    {
        static void Main(string[] args)
        {
            String s = "Dotnet is a platform dependent laguage\n" + "Dotnet is a framework tool\n" +
                        "Dotnet was developed by microsoft";
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();

            StringReader sr = new StringReader(sb.ToString());
            while(sr.Peek()>-1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
