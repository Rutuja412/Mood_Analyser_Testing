using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser_Practice
{
    public class MoodAnalyzer
    {
        private string message;
        public MoodAnalyzer(string message)
        {
          this.message = message;
        }
        
        public string AnalyserMood()
        {
            try
            { 
                if(this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood Should not be Null");
            }
        }
    }
}
