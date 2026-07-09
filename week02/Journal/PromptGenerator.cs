using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person you talk to today?",
        "What was the best part of your day?",
        "What made you smile today?",
        "What challenge did you overcome today?",
        "What are you grateful for today?",
        "What goals did you complete today?",
        "What was the funniest thing that happened to you today?",
        "What was something you learned today?",
        "What was the best thing you ate today?",
        "What was something that you were proud of today?",
        "How did you feel today?",
        "What something nice you did for someone else?",
        "What something you did that helped you grow as a person?",
        "If you were to redo something today what would it be?",
        "What is something that you are looking forward towards?"


    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}