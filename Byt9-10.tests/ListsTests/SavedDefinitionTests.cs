using Byt9_10.Lists;
using Byt9_10.Models;

namespace Byt9_10.tests.ListsTests;

/// <summary>
/// Tests for the SavedDefinition class
/// </summary>
[Trait("ListTests", "Unit")]
public class SavedDefinitionTests
{
    private readonly SavedDefinitionList _savedDefinitionList = new(1, new List<Definition>());
    
    [Fact]
    public void GetSavedDefinitionListIdTest()
    {
        // arrange
        const int expected = 1;

        // act
        var actual = _savedDefinitionList.Id;

        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetSavedDefinitionListDefinitionsTest()
    {
        // arrange
        List<Definition> expected = new();

        // act
        var actual = _savedDefinitionList.Definitions;

        // assert
        Assert.Equal(expected, actual);
    }
    
}