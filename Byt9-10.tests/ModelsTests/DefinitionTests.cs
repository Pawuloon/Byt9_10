using Byt9_10.Models;

namespace Byt9_10.tests.ModelsTests;

/// <summary>
/// Tests for the Definition class
/// </summary>
[Trait("ModelTests", "Unit")]
public class DefinitionTests
{
    private readonly Definition _definition = new ("test", new List<string>());
    
    [Fact]
    public void GetDefinitionPhraseTest()
    {
        // arrange
        const string expected = "test";

        // act
        var actual = _definition.Phrase;

        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetDefinitionMeaningsTest()
    {
        // arrange
        List<string> expected = new();

        // act
        var actual = _definition.Meanings;

        // assert
        Assert.Equal(expected, actual);
    }
}