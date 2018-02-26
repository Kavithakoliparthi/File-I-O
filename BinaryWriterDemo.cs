using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class BinaryWriterDemo
    {
        static void Main(string[] args)
        {
            using (BinaryWriter b = new BinaryWriter(File.Open("E:\\Sample2.dat", FileMode.OpenOrCreate)))
            {
                b.Write(true);
                b.Write(3.5);
                b.Write(20);
                b.Write("hi");
            }
            Console.WriteLine("data written sucessfully");
            Console.ReadLine();
        }
    }
}
