using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {/// <summary>
    /// UC2 Handle Exception
    /// </summary>
        [TestMethod]
        public void Given_nullmood_Expecting_Exception_Results()
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser(null);
            string expected = "object reference not set to an instance of an object.";

            //Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
