using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    internal class Program
    {

        public void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"Integers after swapping {x} {y}");
        }
        public void Swap(float a, float b)
        {
            float temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Float value after swapping {a} {b}");
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.Swap(1, 2);
            p.Swap(1.2f,2.1f);
        }
    }
}
