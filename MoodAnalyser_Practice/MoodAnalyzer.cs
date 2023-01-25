using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser_Practice
{
    public class MoodAnalyzer
    {
        public string AnalyserMood(string message)
        {
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
