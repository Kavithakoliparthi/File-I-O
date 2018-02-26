using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Files
{
    class BinaryReaderDemo
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
                        //Binarywriter
        static void WriteBinaryFile()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("E:\\test3.bar", FileMode.Create)))
            {
                bw.Write(false);
                bw.Write(3.2);
                bw.Write("dotnet");
                bw.Write(25);
            }
        }
                            //BinaryReader
        static void ReadBinaryFile()
        {
            using (BinaryReader br = new BinaryReader(File.Open("E:\\test3.bar", FileMode.Open)))
            {
                Console.WriteLine("the boolean value is:" + br.ReadBoolean());
                Console.WriteLine("the float value is:" + br.ReadDouble());
                Console.WriteLine("the string value is:" + br.ReadString());
                Console.WriteLine("the int value is:" + br.ReadInt32());
            }
        }
    }
}
