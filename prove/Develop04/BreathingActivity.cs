public class BreathingActivity : Activity
{
    private List<string> _breathingInstructions;

    public BreathingActivity()
        : base("Breathing",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        _breathingInstructions = new List<string> { "Breathe in...", "Now breathe out..." };
    }

    public override void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            foreach (string instruction in _breathingInstructions)
            {
                Console.Clear(); // help clear countdown from previous instruction
                Console.Write($"{instruction}\nYou may begin in: ");
                ShowCountDown(4);
            }
        }
        DisplayEndingMessage();
    }
}
