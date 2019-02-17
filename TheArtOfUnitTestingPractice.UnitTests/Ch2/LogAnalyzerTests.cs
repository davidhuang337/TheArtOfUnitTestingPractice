using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheArtOfUnitTestingPractice.Ch2;

namespace TheArtOfUnitTestingPractice.UnitTests
{
    [TestClass]
    public class LogAnalyzerTests
    {
        [TestMethod]
        public void IsValidFileName_BadExtension_ReturnFalse()
        {
            //Arrange
            LogAnalyzer logAnalyzer = new LogAnalyzer();
            bool expected = false;

            //Act
            var actual = logAnalyzer.IsValidLogFileName("BadExtesion.foo");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
