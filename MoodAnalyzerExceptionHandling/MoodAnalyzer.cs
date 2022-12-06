using static MoodAnalyzerExceptionHandling.MoodAnalyzerCustomException;

namespace MoodAnalyzerExceptionHandling
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(ExceptionType.EMPTY_MOOD, "Message should not be Empty");
                }
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(ExceptionType.NULL_MOOD, "Message should not be null");
            }
        }
    }
}