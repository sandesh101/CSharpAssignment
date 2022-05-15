using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal interface IGross
    {
        void gross_sal();
    }
    public class Employee
    {
        public string name;
        public int salary;
        public void basic_salary()
        {
            Console.WriteLine($"Salary details of {name}");
            Console.WriteLine($"The basic salary is {salary}");
        }
    }

    public class salary : Employee, IGross
    {
        int ta = 1000;
        int da = 2000;
        int hra;
        public salary(string name, int basic, int hra)
        {
            this.name = name; 
            this.salary = basic; 
            this.hra = hra;   
        }

        public void disp_sal()
        {
            basic_salary();
            Console.WriteLine($"HRA is {hra}");
        }
        public void gross_sal()
        {
            int gross_salary = ta + da + hra + salary;
            Console.WriteLine($"The gross salary is {gross_salary}");
        }
    }
}
