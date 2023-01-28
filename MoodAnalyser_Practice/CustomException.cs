using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser_Practice
{
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            NO_SUCH_FIELD,
            NO_NULL_TYPE
        }
        private readonly ExceptionType type;
        public CustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
