//DEserialization
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;  

namespace Files
{
    class EmployeeDemo
    {
        public int EId;
        public string EName;
        public EmployeeDemo(int EId, string EName)
        {
            this.EId = EId;
            this.EName = EName;
        }
    }
   public class SerializationExample
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("E:\\Employee.txt", FileMode.OpenOrCreate);
            BinaryFormatter b = new BinaryFormatter();

            EmployeeDemo e =(EmployeeDemo)b.Deserialize(f);
            Console.WriteLine("Employee Id is:" + e.EId);
            Console.WriteLine("employee Name is:" + e.EName);
            Console.ReadLine();
        }
    }
}

