//overloaded Indexer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class OverloadedIndexerDemo
    {
        int EId;
        string EName;
        string DName;
        int ESalary;

        public OverloadedIndexerDemo(int EId, string EName, string DName, int ESalary)
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
        public object this[string name]
        {
            get
            {
                if (name == "EId")
                    return EId;
                else if (name == "EName")
                    return EName;
                else if (name == "DName")
                    return DName;
                else if (name == "ESalary")
                    return ESalary;
                return null;
            }
            set
            {
                if (name == "EId")
                    EId = (int)value;
                else if (name == "EName")
                    EName = (string)value;
                else if (name == "DName")
                    DName = (string)value;
                else if (name == "ESalary")
                    ESalary = (int)value;
            }

        }
    }
    class EmployeeExample
    {
        static void Main(string[] args)
        {
            OverloadedIndexerDemo obj = new OverloadedIndexerDemo(101, "sivani", "SalesManager", 20000);
            Console.WriteLine("The employee details are:");
            Console.WriteLine("Employee Id is:" + obj[1]);
            Console.WriteLine("Employee Name is:" + obj[2]);
            Console.WriteLine("Employee Department is:" + obj[3]);
            Console.WriteLine("Employee Salary is:" + obj[4]);
            Console.WriteLine();
            Console.WriteLine("after changing the employee details are:");
            obj[1] = 103;
            obj["DName"] = "Accountant";
            Console.WriteLine("Employee Id is:" + obj[1]);
            Console.WriteLine("Employee Name is:" + obj[2]);
            Console.WriteLine("Employee Department is:" + obj[3]);
            Console.WriteLine("Employee Salary is:" + obj[4]);

            Console.ReadLine();
        }
    }
}

