public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _responses;
    private Random _random;

    public ListingActivity()
        : base("Listing",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _random = new Random();
        _responses = new List<string>();
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public void AddResponse(string response)
    {
        _responses.Add(response);
    }

    public int GetResponseCount()
    {
        return _responses.Count;
    }

    public override void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---\n");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            AddResponse(response);
        }

        Console.WriteLine($"\nYou listed {GetResponseCount()} items!");
        DisplayEndingMessage();
    }
}