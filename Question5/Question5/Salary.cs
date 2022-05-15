using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    internal class Salary
    {
       int basic, ta;
       int da = 10000;
       int hra = 5000;
       
        public Salary(int basic, int ta)
        {
            this.basic = basic;
            this.ta = ta;
        }
        public void display_salary()
        {
            int salary = basic + ta + da + hra;
            Console.WriteLine($"The total salary is {salary}");
        }
    }
}
