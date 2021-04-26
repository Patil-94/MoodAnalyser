using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
using System;
using System.Runtime.Serialization;

namespace MSTestMoodAnalyser
{
    [TestClass]

    public class UnitTest1
    {
        //Tc5.1Given MoodAnalyser When Proper Return MoodAnalyser Object

                [TestMethod]
        public void Given_MoodAnalyser_When_Proper_Return_MoodAnalyser_Object()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
        }

        [TestMethod]
        //Tc5.2 Given Class Name When Improper Should Throw MoodAnalysisException

        public void Given_ClassName_WhenImproper_Should_Throw_MoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyzer.sampleClass", "MoodAnalyser", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        // <summary>
        /// This test case is for
        /// TC 5.3 Given Invalid constructor name should throw MoodAnalyserException.
        /// </summary>
        [TestMethod]
        public void GivenInvalidConstructorName_ShouldThrow_MoodAnalyserException_Of_ParameterizedConstructor()
        {
            string expected = "Constructor is not found";
            try
            {
                object obj = MoodAnalyserFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "sampleClass", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }


    
        /// Test Case 6.1 Given Happy Message Using Reflection When Proper Should Return HAPPY Mood 
        
        [TestMethod]
        public void GivenHappyMessage_UsingReflection_Should_ReturnHappy()
        {
            string message = MoodAnalyserFactory.InvokeMethod("MoodAnalyzer.MoodAnalyser", "GetMood", "HAPPY");
            Assert.AreEqual("HAPPY", message);
        }

        /// <summary>
        /// Test Case 6.2 
        /// Given Happy message when improper method should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenHappyMessage_UsingReflection_WhenIncorrectMethod_shouldThrow_MoodAnayserException()
        {
            try
            {
                string message = MoodAnalyserFactory.InvokeMethod("MoodAnalyzer.MoodAnalyser", "getMethod", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.Message);
            }
        }

        /// <summary>
        /// Test Case 7.1
        /// set Happy message with Reflector should return HAPPY
        /// </summary>
        [TestMethod]
        public void WhenHappyMessage_ShouldReturnHappy()
        {
            dynamic result = MoodAnalyserFactory.ChangeMoodDynamically("MoodAnalyser.MoodAnalyserMain", "HAPPY");
            Assert.AreEqual("HAPPY", result);
        }

        /// <summary>
        /// Test Case 7.2 set field when improper should throw Exception 
        /// </summary>
        [TestMethod]
        public void WhenImproperMessage_ShouldThrowException()
        {
            try
            {
                string message = MoodAnalyserFactory.ChangeMoodDynamically("MoodAnalyzer.getMood", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.Message);
            }
        }

        /// <summary>
        /// Test Case 7.3 setting Null message with Reflector should throw Exception
        /// </summary>
        [TestMethod]
        public void WhenNull_ShouldThrowException()
        {
            try
            {
                dynamic result = MoodAnalyserFactory.ChangeMoodDynamically("MoodAnalyzer.MoodAnalyser", null);
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, e.Message);
            }
        }
    }
}


