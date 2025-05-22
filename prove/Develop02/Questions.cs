public static class Questions
{
    private static List<string> questions = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was one good thing I did for somebody today?",
        "Who did I spend the most time with today?",
        "What was the worst part of the day and how could it have gone better?",
        "Did I discover anything new about myself today?",
        "Did I wake up at a good time today?",
        "What was the most fun thing I did today?"
    };

    public static string GetQuestion()
    {
        Random random = new Random();
        int index = random.Next(questions.Count);
        return questions[index];
    }
}