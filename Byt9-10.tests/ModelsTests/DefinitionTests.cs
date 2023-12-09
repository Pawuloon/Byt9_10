using Byt9_10.Models;

namespace Byt9_10.tests.ModelsTests;

/// <summary>
/// Tests for the Definition class
/// </summary>
public class DefinitionTests
{
    private Definition _definition = new ("test", new List<string>());
    
    [Test]
    public void GetDefinitionPhraseTest()
    {
        Console.WriteLine(_definition.Phrase);
    }
    
    [Test]
    public void GetDefinitionMeaningsTest()
    {
        Console.WriteLine(_definition.Meanings);
    }
}