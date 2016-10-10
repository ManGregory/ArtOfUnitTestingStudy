using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAnalyzer.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        LogAnalyzer logAnalyzer;

        [SetUp]
        public void Setup()
        {
            logAnalyzer = new LogAnalyzer();
        }

        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {
            bool result = logAnalyzer.IsValidLogFileName("badextension.yzf");

            Assert.False(result);
        }

        [TestCase("goodext.slf")]
        [TestCase("goodext.SLF")]
        public void IsValidLogFileName_ValidExtension_ReturnsTrue(string fileName)
        {          
            bool result = logAnalyzer.IsValidLogFileName(fileName);

            Assert.True(result);
        }

        [Test]
        public void IsValidLogFileName_EmptyFileName_Throws()
        {
            var ex = Assert.Catch<Exception>(() => logAnalyzer.IsValidLogFileName(string.Empty));

            StringAssert.Contains("file name should be set", ex.Message);
        }
    }
}
