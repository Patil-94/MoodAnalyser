using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
using System;

namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_Happymood_Expecting_Happy_Results()
        {
            //    //Arrange;
            MoodAnalyser mood = new MoodAnalyser("I am in happy mood");
            string expected = "happy";

            //    //Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
