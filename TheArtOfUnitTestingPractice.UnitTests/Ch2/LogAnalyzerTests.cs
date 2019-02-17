using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheArtOfUnitTestingPractice.Ch2;

namespace TheArtOfUnitTestingPractice.UnitTests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        private LogAnalyzer _logAnalyzer;

        [TestInitialize]
        public void SetUp()
        {
            _logAnalyzer = new LogAnalyzer();
        }

        [TestMethod]
        [DataRow("BadExtesion.foo")]
        public void IsValidFileName_BadExtension_ReturnFalse(string fileName)
        {
            var actual = _logAnalyzer.IsValidLogFileName(fileName);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        [DataRow("fileWithGoodExtension.slf")]
        [DataRow("fileWithGoodExtension.SLF")]
        public void IsValidFileName_GoodExtension_ReturnTrue(string fileName)
        {
            var actual = _logAnalyzer.IsValidLogFileName(fileName);

            Assert.IsTrue(actual);
        }




    }
}
