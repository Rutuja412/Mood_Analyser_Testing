using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser_Practice;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //TC1.1 Given “I am in Sad Mood” message Should Return SAD
        public void GivenSadMessage_Analyzer_ShouldReturnSadMood()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer();
            string actual = analyser.AnalyserMood(message);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenAnyMessage_Analyzer_ShouldReturnHappyMood()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer();
            string actual = analyser.AnalyserMood(message);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
