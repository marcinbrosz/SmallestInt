using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestInt.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallestInt.Library.SmallestInt.FindSmallestInt(new int[] { 78, 56, 232, 12, 11, 43 }));
            Console.Read();

        }
    }
}
