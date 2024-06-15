using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CTempConverter2018;
using CTempConverter2018.Business;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        TempCalc myTempCalc = new TempCalc();

        [TestMethod]
        public void FahToCel32Test()
        {
            string Input = "32";
            string Expected = "0";

            string actual = myTempCalc.ConvertFahToCel(Input);
            // Assert.AreEqual(Expected,myTempCalc.ConvertFahToCel(Input));

            //  Assert.AreEqual("32", myTempCalc.ConvertFahToCel("0"));

            Assert.AreEqual(Expected, actual);
        }

        [TestMethod]
        public void FahToCel50Test()
        {
            string Input = "50";
            string Expected = "10";

            string actual = myTempCalc.ConvertFahToCel(Input);
            // Assert.AreEqual(Expected,myTempCalc.ConvertFahToCel(Input));

            //  Assert.AreEqual("32", myTempCalc.ConvertFahToCel("0"));

            Assert.AreEqual(Expected, actual);
        }
    }
}
