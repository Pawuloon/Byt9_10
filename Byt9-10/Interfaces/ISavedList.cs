using Byt9_10.Models;

namespace Byt9_10.Interfaces;

public interface ISavedList
{
    public int Id { get; set; }
    public User Owner { get; set; }
    
    // delete method
    public void Delete()
    {
        // PLACEHOLDER
    }

    // add method
    public void Add()
    {
        // PLACEHOLDER    
    }
    
    // Export method
    public void Export()
    {
        // PLACEHOLDER
    }

    // Open method
    public void Open()
    {
        // PLACEHOLDER
    }
}