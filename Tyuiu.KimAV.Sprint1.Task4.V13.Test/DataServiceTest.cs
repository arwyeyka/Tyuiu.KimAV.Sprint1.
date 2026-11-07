using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint1.Task4.V13.Lib;
namespace Tyuiu.KimAV.Sprint1.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
