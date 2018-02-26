//Indexer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class IndexerDemo
    {
        int EId;
        string EName;
        string DName;
        int ESalary;

        public IndexerDemo(int EId, string EName, string DName, int ESalary)
        {
            this.EId = EId;
            this.EName = EName;
            this.DName = DName;
            this.ESalary = ESalary;
        }
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return EId;
                else if (index == 2)
                    return EName;
                else if (index == 3)
                    return DName;
                else if (index == 4)
                    return ESalary;
                return null;
            }
            set
            {
                if (index == 1)
                    EId = (int)value;
                else if (index == 2)
                    EName = (string)value;
                else if (index == 3)
                    DName = (string)value;
                else if (index == 4)
                    ESalary = (int)value;
            }
        }
    }
     class Employee
     {
        static void Main(string[] args)
        {
            IndexerDemo obj = new IndexerDemo(101,"sivani","SalesManager",20000);
            Console.WriteLine("the employee details are:");
            Console.WriteLine("Employee Id is:" + obj[1]);
            Console.WriteLine("Employee Name is:" + obj[2]);
            Console.WriteLine("Employee Department is:" + obj[3]);
            Console.WriteLine("Employee Salary is:" + obj[4]);

            Console.WriteLine("after changing the employee details are:");

            obj[3] = "Accountant";
            Console.WriteLine("Employee Id is:" + obj[1]);
            Console.WriteLine("Employee Name is:" + obj[2]);
            Console.WriteLine("Employee Department is:" + obj[3]);
            Console.WriteLine("Employee Salary is:" + obj[4]);

            Console.ReadLine();
        }
      }
}

