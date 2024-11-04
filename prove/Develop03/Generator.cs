public class Generator
{
    private List<Scripture> _randomScripturePrompt;

    public Generator()
    {
        _randomScripturePrompt = new List<Scripture>();
    }

    public Scripture ScriptureGenerator()
    {
        if (_randomScripturePrompt == null || _randomScripturePrompt.Count == 0)
        {
            Console.WriteLine("No scriptures available.");
            return null;
        }

        Random random = new Random();
        int index = random.Next(_randomScripturePrompt.Count);
        return _randomScripturePrompt[index];
    }

    public void AddToPromptList(Scripture scripture)
    {
        _randomScripturePrompt.Add(scripture);
    }

    public List<Scripture> GetPromptList()
    {
        return _randomScripturePrompt;
    }
}
