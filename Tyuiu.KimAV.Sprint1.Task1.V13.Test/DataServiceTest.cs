using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint1.Task2.V13.Lib;
namespace Tyuiu.KimAV.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService ();
            int x = 2;
            var res = ds.Sqr(x);
            Assert.AreEqual (4, res);

        }
    }
}
