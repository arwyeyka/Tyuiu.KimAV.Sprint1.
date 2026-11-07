using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint1.Task7.V20.Lib;
namespace Tyuiu.KimAV.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double z = 1;
            double wait = 0.75;
            var res = ds.Calculate(x,y,z);
            Assert.AreEqual(wait, res);
        }
    }
}
