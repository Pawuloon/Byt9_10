using Byt9_10.Interfaces;
using Byt9_10.Models;

namespace Byt9_10.Lists;

/// <summary>
/// The SavedDefinitionList class is a list of definitions saved by the user
/// </summary>
public class SavedDefinitionList : ISavedList
{
    public int Id { get; set; }
    public User Owner { get; set; }
    public ICollection<Definition> Definitions{ get; set;}

    public SavedDefinitionList(int id, User owner, ICollection<Definition> definitions)
    {
        Id = id;
        Owner = owner;
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