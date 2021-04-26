using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {

         string message;

        /// <summary>
        /// parameterless constructor
        /// </summary>
        public MoodAnalyser()
        {
        }

        /// <summary>
        /// Parameterised constructor for initializing instance member
        /// </summary>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        
        ///Analyser method to find mood        
        public string Analyser(string message)
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be EMPTY");
                }
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException )
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be NULL");
            }
        }
       
    }
}