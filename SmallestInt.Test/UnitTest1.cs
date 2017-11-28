using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace SmallestInt.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(new int[] { 78, 56, 232, 12, 11, 43 }, 11)]
        [DataRow(new int[] { 78, 56, -2, 12, 8, -33 },  -33)]
        [DataRow(new int[] { int.MinValue, -1, 0, 1, int.MaxValue }, int.MinValue)]
        public void FixedTest(int[] args,int result)
        {
            Assert.AreEqual(result, SmallestInt.Library.SmallestInt.FindSmallestInt(args));
        }
        private int Solution(int[] args)
        {
            return new List<int>(args).OrderBy(x => x).FirstOrDefault();
        }

        [TestMethod]
        public void RandomTest()
        {
            Random r = new Random();
            List<int> listaRandom = new List<int>();
            for (int i = 0; i < r.Next(15,100); i++)
            {
                listaRandom.Add(r.Next(-100, 100));
            }
            Assert.AreEqual(Solution(listaRandom.ToArray()),
                SmallestInt.Library.SmallestInt.FindSmallestInt(listaRandom.ToArray()));
        }

    }
}
