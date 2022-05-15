using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            salary s = new salary("Sandesh", 10000, 2000);
            s.disp_sal();
            s.gross_sal();
        }
    }
}
