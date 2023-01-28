using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyser_Practice
{
    public class MoodAnalyserFactory
    {
        private string message;
        public MoodAnalyserFactory(string message)
        {
            this.message = message;
        }
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {

                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);//create object
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");

                }


            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
    }
}
