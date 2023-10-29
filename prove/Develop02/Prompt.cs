using System;

public class Prompt
{
    //https://www.adnanzameer.com/2015/05/how-to-get-random-items-from-array-or.html#:~:text=The%20simple%20way%20to%20get,get%20value%20from%20the%20array.
    public static string RandomPrompt()
    {
        Random random = new Random();
        List<string> writingPrompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the worst part of the day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How are you feeling today?",
        "What helped you get through the day?",
        "How would you describe the kind of person you were today?"};
        int randomIndex = random.Next(0, writingPrompts.Count);
        return writingPrompts[randomIndex];
    }
}