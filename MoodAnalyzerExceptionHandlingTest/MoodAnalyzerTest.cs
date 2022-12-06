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
        ////TC2.1
        //[Test]
        //public void GivenNullMood_WhenAnalyzed_ShouldReturnHappy()
        //{
        //    //Arrange
        //    string message = null;
        //    string expected = "Happy";
        //    MoodAnalyzer analyse = new MoodAnalyzer(null);
        //    //Act
        //    string mood = analyse.AnalyzeMood();
        //    Assert.AreEqual(expected, mood);
        //}
        //TC3.1
        [Test]
        public void GivenNullMessage_ThrowsMoodAnalysisExceptionNullMessage()
        {
            try
            {
                //Arrange
                string message = null;
                MoodAnalyzer analyse = new MoodAnalyzer(message);
                //Act
                string mood = analyse.AnalyzeMood();
            }
            catch (MoodAnalyzerCustomException ex)
            {
                Assert.AreEqual("Message should not be null", ex.Message);
            }
        }
        //TC3.2
        [Test]
        public void GivenEmptyMessage_ThrowsMoodAnalysisExceptionEmptyMessage()
        {
            try
            {
                //Arrange
                string message = " ";
                MoodAnalyzer analyse = new MoodAnalyzer(message);
                //Act
                string mood = analyse.AnalyzeMood();
            }
            catch (MoodAnalyzerCustomException ex)
            {
                Assert.AreEqual("Message should not be Empty", ex.Message);
            }
        }
    }
}