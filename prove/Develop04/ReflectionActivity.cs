public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _unusedQuestions;
    private Random _random;

    public ReflectionActivity()
        : base("Reflection",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _random = new Random();
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you were most grateful.",
            "If you can change one thing in your life, what would it be and?"
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _unusedQuestions = new List<string>(_questions);
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    // public string GetRandomQuestion()
    // {
    //     return _questions[_random.Next(_questions.Count)];
    // }

    public string GetRandomQuestion()
    {
        // reset list if all questions used, reset list to zero
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        // Get random index from remaining questions
        int index = _random.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[index];

        _unusedQuestions.RemoveAt(index);
        return question;
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("\nConsider the following prompt:");  // user given a random prompt
        Console.WriteLine($"\n--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();

        // user is ask follow-up questions based on the random prompt
        Console.Clear();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"\n> {question} ");
            Spinner(10);
        }

        DisplayEndingMessage();
    }
}
