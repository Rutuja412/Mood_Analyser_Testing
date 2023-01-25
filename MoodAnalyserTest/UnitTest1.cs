using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser_Practice;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //TC1.1 Given �I am in Sad Mood� message Should Return SAD
        public void GivenSadMessage_Analyzer_ShouldReturnSadMood()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //TC1.2 Given �I am in Any Mood� message Should Return Happy
        public void GivenAnyMessage_Analyzer_ShouldReturnHappyMood()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            //Act
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
