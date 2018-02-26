//Serialization
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Files
{
    class Employee
    {
        int EId;
        string EName;
        public Employee(int EId,string EName)
        {
            this.EId = EId;
            this.EName = EName;
        }
    }
   public class SerializationDemo
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("E:\\Employee.txt",FileMode.OpenOrCreate);
            BinaryFormatter b = new BinaryFormatter();

            Employee e = new Employee(101, "anusha");
            b.Serialize(f, e);
            f.Close();
            
        }
    }
}
