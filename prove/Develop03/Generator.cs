// class: Generator
// Attributes: 
// *_randomScripturePrompt : List

// * Behaviors/Methods:
// * Generator()
// * ScriptureGenerator(): void

public class Generator
{
    private List<string> _randomScripturePrompt;

    public Generator()
    {
        _randomScripturePrompt = new List<string>();
    }

    public void ScriptureGenerator(List<Scripture> scriptures)
    {
        if (scriptures == null || scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures available.");
            return;
        }

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[index];
        Console.WriteLine($"Random Scripture: {selectedScripture}");
    }

    public void AddToPromptList(string scripture)
    {
        _randomScripturePrompt.Add(scripture);
    }

    public List<string> GetPromptList()
    {
        return _randomScripturePrompt;
    }
}