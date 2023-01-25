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
                if (message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
