using System;
using System.Collections.Generic;
// Class: 
// Attributes:  
// * _questionPrompt : List<string>

// * Behaviors/Methods:
// * RandomQuestion() : string

// Responsibilities:
//  Generate a random question from the list of questions.

public class PromptGenerator
{
    private List<string> _questionPrompt = new List<string>(){

        "Who was the most interesting person I interacted with today?",
       " What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the funniest thing I did today?",
        "What was the most challenging thing I did today?",
        "What was the most surprising thing I did today?",
        "What was the most scary thing I did today?",
        "What was the most exciting thing I did today?",
        "What was the most important thing I learned today?",
        "Any highlights of the day?",

    };
    public string RandomQuestion()
    {   
        Random random = new Random();
        int randomIndex = random.Next(0, _questionPrompt.Count);
        return _questionPrompt[randomIndex];
    }
} 
