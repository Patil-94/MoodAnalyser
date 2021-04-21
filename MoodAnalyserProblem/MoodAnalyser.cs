using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        
        //instance variable
        string message;

        //parameterized constructor for initializing instance member
        public MoodAnalyser (string message)
        {
            this.message = message;
        }

        //Analyser method to find mood
        public string Analyser() //check msg passing into the constructor is contain(happy) then written happy else sad
        {
            if (this.message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return " sad";
            }
        }
    }
}

