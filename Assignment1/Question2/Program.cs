using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        struct Students
        {
            public int id, day, month, year;
            public string name, courseName;

        }
        static void Main(string[] args)
        {
            Students[] s = new Students[3];
            int i;
            for (i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter student id: ");
                s[i].id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your name");
                s[i].name = Console.ReadLine();
                Console.WriteLine("Enter your course name");
                s[i].courseName = Console.ReadLine();
                Console.WriteLine("Enter your day of birth (1-31)");
                s[i].day = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your month of birth (1-12)");
                s[i].month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your year of birth");
                s[i].year = int.Parse(Console.ReadLine());
                
                //Console.WriteLine(s[i].name);
            }
            Console.WriteLine("--------------Details of Student--------------");
            for (i = 0; i < s.Length; i++)
            {
                Console.WriteLine("ID: " + s[i].id);
                Console.WriteLine("Name: " + s[i].name);
                Console.WriteLine("Course Name: " + s[i].courseName);
                Console.WriteLine("Date of birth: " + s[i].day + "-" + s[i].month + "-" + s[i].year);
            }
        }
    }
}
