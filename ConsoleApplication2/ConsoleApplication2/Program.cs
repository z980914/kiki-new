using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 170, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 0, 0, 0, 168, 160, 169, 0, 150 };
            Random rand = new Random();
            int r = rand.Next(0, heights.Length);
            Console.WriteLine(r + ":" + heights[r]);
            Console.ReadLine();

        }
    }
}
