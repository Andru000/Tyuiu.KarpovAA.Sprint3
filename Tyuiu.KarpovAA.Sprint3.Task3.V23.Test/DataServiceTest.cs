﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint3.Task3.V23.Lib;

namespace Tyuiu.KarpovAA.Sprint3.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string value = "fdsst siu vsrs";
            char replaceable = 's';
            char replacement = '8';

            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "fd88t 8iu v8r8";

            Assert.AreEqual(wait, res);
        }
    }
}
