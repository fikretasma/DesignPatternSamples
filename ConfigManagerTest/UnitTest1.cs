using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using ConvertionLibrary;
using ConfigLibrary;

namespace ConfigManagerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convertiontest()
        {
            int a = ConversionHelper.Convert<int>(ConfigurationManager.AppSettings["retryCount"]);
        }

        [TestMethod]
        public void ConfigManagerRetryCountShouldBeFive()
        {
            int retryCount = ConfigHelper.GetValue<int>("retryCount");
            retryCount = ConfigHelper.GetValue<int>("retryCount");
            Assert.AreEqual(5, retryCount);
        }
    }
}
