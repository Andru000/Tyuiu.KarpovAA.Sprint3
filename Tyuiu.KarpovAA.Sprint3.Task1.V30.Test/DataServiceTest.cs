using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint3.Task1.V30.Lib;

namespace Tyuiu.KarpovAA.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 2;
            double wait = 1.629;

            
            double res = ds.GetMultiplySeries(startValue, stopValue);

            
            Assert.AreEqual(wait, res);

        }
    }
}
