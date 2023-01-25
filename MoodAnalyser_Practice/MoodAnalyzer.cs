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
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
