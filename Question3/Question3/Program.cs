using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        class Staff
        {
            public string name, post;

            public Staff(string name, string post)
            {
                this.name = name;
                this.post = post;
                if (post == "HOD")
                {
                    Console.WriteLine($"Name of staff is {name} and she/he is HOD");
                }
            }
        }
        static void Main(string[] args)
        {
            Staff s1 = new Staff("Sandesh", "HOD");
            Staff s2 = new Staff("Rohit", "Teacher");
            Staff s3 = new Staff("Basundhara", "HOD");
            Staff s4 = new Staff("Subham", "Assistant");
            Staff s5 = new Staff("David", "Account");
            //s1.display();
        }
    }
}
