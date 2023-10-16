using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint3.Task0.V22.Lib;

namespace Tyuiu.KarpovAA.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            {
               
                DataService ds = new DataService();
                double wait = 55217.446; 
                double res = ds.GetSumSeries(0.25, 1, 8);

                Assert.AreEqual(wait, res, 6);
            }

        }
    }
}
