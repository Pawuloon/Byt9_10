using Byt9_10.Interfaces;
using Byt9_10.Models;

namespace Byt9_10.Lists;

public class SavedDefinitionList : ISavedList
{
    public int Id { get; set; }
    public List<Definition> Definitions{ get; set;}

    public SavedDefinitionList(int id, List<Definition> definitions)
    {
        Id = id;
        Definitions = definitions;
    }

    public void Delete()
    {
        // PLACEHOLDER
    }

    public void Add()
    {
        // PLACEHOLDER
    }

    public void Export()
    {
        // PLACEHOLDER
    }

    public void Open()
    {
        // PLACEHOLDER
    }
}