using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser_Practice;
using System;

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
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        //TC1.2 Given “I am in Any Mood” message Should Return Happy
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
        [TestMethod]//TC2.1 NullMood
        public void GivenNullMood_Analyzer_ShouldHappyMood()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyzer analyser = new MoodAnalyzer(message);
            //Act
            string actual = analyser.AnalyserMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]//TC3.1 //CustomException//null
        public void GivenNullMood_Analyzer_Should_Throw_CustomException()
        {
            try
            {
                string message = null;
                MoodAnalyzer analyser = new MoodAnalyzer(message);
                string actual = analyser.AnalyserMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }

        }
        [TestMethod]//TC3.2//
        public void GivenEmptyMood_WhenAnalyzer_ShouldThrowCustomException()
        {
            try
            {
                string message = " ";
                MoodAnalyzer analyser = new MoodAnalyzer(message);
                string actual = analyser.AnalyserMood();
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
        //[TestMethod]//TC4.1// MoodAnalyserObject
        //public void GivenClassName_ShouldReturnMoodAnalyserObject()
        //{
        //    string message = null;
        //    object expected = new MoodAnalyzer(message);
        //    //object expected1 = expected;
        //    object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer_Practice.MoodAnalyzer", "MoodAnalyzer");
        //    expected.Equals(obj);
        //    // Assert.AreEqual(expected1, obj);

        //}
        //[TestMethod]//4.2
        //public void GivenClassNameWhenImproper_ShouldThrowMoodAnalyserExpection()
        //{
        //    string excepted = "Class Not Found";
        //    try
        //    {
        //        object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer_Practice.MoodAnalyzer", "MoodAnalyzer");
        //    }
        //    catch (CustomException e)
        //    {
        //        Assert.AreEqual(excepted, e.Message);
        //    }
        //}
        [TestMethod]//TC5.1
        public void GivenMoodAnalyzerWhenProperReturn_MoodAnalyserObject()
        {
            try
            {
                string message = "HAPPY";
                object actual = new MoodAnalyzer(message);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer", "MoodAnalyzer", message);
                actual.Equals(obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        [TestMethod]//5.2

        public void Given_MoodAnalyser_Class_Name_If_Improper_Should_Throw_MoodAnalyserException()
        {
            {
                string excepted = "Class Not Found";
                try
                {
                    string message = "HAPPY";
                    object actual = new MoodAnalyzer(message);
                    object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser_Practice.MoodAnalyzer", "MoodAnalyzer", message);
                }
                catch (CustomException e)
                { 
                    Assert.AreEqual(excepted, e.Message);
                }
            }

        }
        [TestMethod]//5.3
        public void GivenClassWhenConstructorNotProper_ShouldThrowMoodAnalyserExpectionUsingParametericConstructure()
        {
            string excepted = "Constructor is not found";
            try
            {
                string message = "HAPPY";
                object actual = new MoodAnalyzer(message);
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser_Practice.MoodAnalyzer", "MoodAnalyzer", message);
            }
            catch (CustomException e)
            {
                Assert.AreEqual(excepted, e.Message);
            }

        }
        [TestMethod]//TC6.1
        public void SetHappyMessagewithReflectorShouldReturnHAPPY()
        {
            string expected = "HAPPY";
            try
            {
                string mood = MoodAnalyserFactory.InvokedAnalyseMood("HAPPY", "AnalyserMood");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        [TestMethod]//TC6.3
        public void SetNullMessagewithReflectorShouldThrowException()
        {
            string expected = null;
            try
            {
                string mood = MoodAnalyserFactory.InvokedAnalyseMood("HAPPY", "AnalyserMood");
            }
            catch (CustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}

