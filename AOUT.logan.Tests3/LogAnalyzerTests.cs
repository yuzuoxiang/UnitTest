using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;

namespace AOUT.logan.Tests3
{
    [TestClass]
    public class LogAnalyzerTests
    {
        LogAnalyzer analyzer = new LogAnalyzer();

        [TestMethod]
        //[Ignore("这个测试有问题")]
        [TestCategory("运行快的测试")]
        public void IsValidFileName_validFile_ReturnsTrue()
        {
            //LogAnalyzer analyzer = new LogAnalyzer();   
            bool result = analyzer.IsValidLogFileName("wassd.slf");

            Assert.IsTrue(result, "filename should be valid");
        }

        [TestMethod] 
        [TestCategory("异常测试")]
        [ExpectedException(typeof(ArgumentException))]
        public void IsValidFileName_EmptyFileName_ThrowsException()
        {
            analyzer.IsValidLogFileName(null);
        }
    }
}
