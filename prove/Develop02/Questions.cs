public class Questions
{
    private List<string> _questions = new List<string>()
        {
            "What made today a good day?", "What is one thing you're grateful for today?",
            "What did you learn today?", "What challenge did you face today and how did you overcome it?",
            "How did you take care of yourself today?", "What is the most peaceful moment you've experienced today?"
        };
    private static Random _randomGenerator = new Random();
    

    public string GetRandomQuestion()
    {
        int randomQuestion = _randomGenerator.Next(0, _questions.Count);

        return _questions[randomQuestion];
    }
}
