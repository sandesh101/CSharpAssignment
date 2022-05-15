using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    internal class Student
    {
       public int roll_number;
       public string name;
    }
    class Test : Student 
    { 
        public float marks1, marks2;
    }

    class Result : Test
    {
        public Result(int roll, string name, float marks1, float marks2)
        {
           this.roll_number = roll;
           this.name = name;
           this.marks1 = marks1;
           this.marks2 = marks2;
        }
        public void total()
        {
            float total_marks = marks1 + marks2;
            Console.WriteLine($"The student naming {name} got the final marks {total_marks}");
        }
    } 

}
