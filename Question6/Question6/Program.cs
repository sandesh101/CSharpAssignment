using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    internal class Program
    {
        class Furniture
        {
            public string material;
            public float price;
            public void showDetails()
            {
                Console.WriteLine($"Material used is {material} and price is {price}");
            }
        }
        class Table:Furniture
        {
           public float height;
           public float surface_area;
            public void showDatas()
            {
                Console.WriteLine($"The height of table is {height} feet and surface area {surface_area} sq m");
            }
        }
        static void Main(string[] args)
        {
            Table table = new Table();
            table.material = "Wood";
            table.price = 1000f;
            table.height = 2.1f;
            table.surface_area = 3.4f;
            table.showDetails();
            table.showDatas();
        }
    }
}
