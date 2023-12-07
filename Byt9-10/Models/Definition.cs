namespace Byt9_10.Models;

public class Definition
{
    public string Phrase { get; set; }
    public List<string> Meanings { get; set; }

    public Definition(string phrase, List<string> meanings)
    {
        Phrase = phrase;
        Meanings = meanings;
    }
    
    public void Explain(string phrase)
    {
        // PLACEHOLDER
    }
    
    public void Save(string phrase, List<string> meanings)
    {
        // PLACEHOLDER
    }
}