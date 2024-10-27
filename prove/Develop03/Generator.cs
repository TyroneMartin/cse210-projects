// class: Generator
// Attributes: 
// *_RandomScripturePrompt : List

// * Behaviors/Methods:
// * ScriptureGenerator() 
// * FilterByCategory(Category : string) : List
// * FilterByBook(Book : string) : List

public class Generator
{
    private List<string> _RandomScripturePrompt;

    public Generator()
    {
        _RandomScripturePrompt = new List<string>();
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

    public List<Scripture> FilterByCategory(List<Scripture> scriptures, string category)
    {
        return scriptures.Where(s => s.GetScriptureManager().GetCategory() == category).ToList();
    }

    public List<Scripture> FilterByBook(List<Scripture> scriptures, string book)
    {
        return scriptures.Where(s => s.GetScriptureManager().GetReference().StartsWith(book)).ToList();
    }

    public void AddToPromptList(string scripture)
    {
        _RandomScripturePrompt.Add(scripture);
    }

    public List<string> GetPromptList()
    {
        return _RandomScripturePrompt;
    }
}