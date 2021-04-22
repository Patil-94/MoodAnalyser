using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {/// <summary>
     /// TC3.1 Nullmood Using CustomException Return Null
     /// </summary>
        [TestMethod]
        public void Given_Nullmood_Using_CustomException_Return_Null()
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser(null);
            string expected = "Mood should not be null";
            try
            {
                //Act
                string actual = mood.Analyser();
            }
            catch (MoodAnalyserException exception)
            {
                //Asert
                Assert.AreEqual(expected, exception.Message );
            }
        }
    }
}
