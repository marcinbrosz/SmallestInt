using System;
using System.Linq;

namespace SmallestInt.Library
{
    public class SmallestInt
    {
        public static int FindSmallestInt(int[] args)
        {
            /*int small = args[0];
            foreach(int x in args)
            {
                small = x < small ? x : small;
            }

            return small;
            */

            //return (from e in args orderby e ascending select e).FirstOrDefault();

            return args.OrderBy(x => x).FirstOrDefault();

            //return args.Min();
        }
    }
}
