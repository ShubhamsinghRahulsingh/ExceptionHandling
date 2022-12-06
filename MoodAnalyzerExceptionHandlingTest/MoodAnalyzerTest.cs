using MoodAnalyzerExceptionHandling;

namespace MoodAnalyzerExceptionHandlingTest
{
    public class MoodAnalyzerTest
    {
        //TC1.1 
        [Test]
        public void GivenSadMood_WhenAnalyzed_ShouldReturnSad()
        {
            //Arrange
            string message = "I am in Sad Mood";
            string expected = "Sad";
            MoodAnalyzer analyse = new MoodAnalyzer(message);
            //Act
            string mood = analyse.AnalyzeMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
        //TC1.2 
        [Test]
        public void GivenAnyMood_WhenAnalyzed_ShouldReturnHappy()
        {
            //Arrange
            string message = "I am in Any Mood";
            string expected = "Happy";
            MoodAnalyzer analyse = new MoodAnalyzer(message);
            //Act
            string mood = analyse.AnalyzeMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}