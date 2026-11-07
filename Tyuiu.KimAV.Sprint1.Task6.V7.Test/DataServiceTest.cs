using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint1.Task6.V7.Lib;
namespace Tyuiu.KimAV.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "1 * 2 * 3";
            DataService ds = new DataService();
            string res = ds.WorkWithText( strTest );
            string wait = "123";
            Assert.AreEqual( wait, res);
        }
    }
}
