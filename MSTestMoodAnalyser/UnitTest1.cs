using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MSTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {/// <summary>
     /// TC3.2 Emptymood Using CustomException Return empty
     /// </summary>
        [TestMethod]
        public void Given_Emptymood_Using_CustomException_Return_Empty()
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser("");
            string expected = "Mood should not be empty";
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
