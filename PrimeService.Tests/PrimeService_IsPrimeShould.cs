using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }
        
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from test context");
            
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, $"1 should not be prime");
        }
        
        [TestMethod]
        public void TestConsoleOutput()
        {
            String propertyValue = TestContext.GetType().GetProperty("system.myVar").ToString(); 
            Console.WriteLine("system.myVar = " + propertyValue);
            
            // FORCE_NUGET_EXE_INTERACTIVE;NUGET_HTTP_CACHE_PATH;NUGET_PACKAGES;NUGET_PLUGIN_PATHS
            String nugetExe = TestContext.GetType().GetProperty("env.FORCE_NUGET_EXE_INTERACTIVE").ToString();
            Console.WriteLine("FORCE_NUGET_EXE_INTERACTIVE=" + nugetExe);
            
            Assert.IsNotNull(propertyValue);
        }

        [TestMethod]
        [Ignore]
        public void IgnoredTest()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from test context");
            
            var result = _primeService.IsPrime(1);
         
            Assert.IsFalse(result, $"1 should not be prime");
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf3()
        {            
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from test context");

            var result = _primeService.IsPrime(3);

            Assert.IsFalse(result, $"1 should not be prime");
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf2()
        {
            Console.WriteLine("some stdOut text");
            Console.Error.WriteLine("some stdErr text");
            TestContext.WriteLine("message from test context");
            
            Assert.IsFalse(true, $"1 should not be prime");
        }
    }
}