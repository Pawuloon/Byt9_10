using Byt9_10.Lists;
using Byt9_10.Models;

namespace Byt9_10.tests.ListsTests;

/// <summary>
/// Tests for the SavedDefinition class
/// </summary>
public class SavedDefinitionTests
{
    private SavedDefinitionList _savedDefinitionList = new SavedDefinitionList(1, new List<Definition>());
    
    [Test]
    public void GetSavedDefinitionListIdTest()
    {
        Console.WriteLine(_savedDefinitionList.Id);
    }
    
    [Test]
    public void GetSavedDefinitionListDefinitionsTest()
    {
        Console.WriteLine(_savedDefinitionList.Definitions);
    }
    
}
