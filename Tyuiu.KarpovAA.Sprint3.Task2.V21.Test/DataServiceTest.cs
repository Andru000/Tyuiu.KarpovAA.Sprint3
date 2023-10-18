using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint3.Task2.V21.Lib;

namespace Tyuiu.KarpovAA.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double Value = 1.5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(Value, startValue, stopValue);

            double wait = 0.298;

            Assert.AreEqual(wait, res);
        }
    }
}
