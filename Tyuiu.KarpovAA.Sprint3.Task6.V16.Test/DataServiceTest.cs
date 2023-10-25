using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint3.Task6.V16.Lib;

namespace Tyuiu.KarpovAA.Sprint3.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = 16;
            int wait = 42;  

            
            int res = ds.GetSumTheDivisors(startValue, stopValue);

            
            Assert.AreEqual(wait, res);
        }
    }
}
