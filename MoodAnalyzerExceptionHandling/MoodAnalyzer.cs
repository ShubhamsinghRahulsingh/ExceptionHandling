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
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException)
            {
                return "Happy";
            }
        }
    }
}