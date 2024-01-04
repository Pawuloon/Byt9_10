using Byt9_10.Interfaces;
using Byt9_10.Models;

namespace Byt9_10.Lists;


/// <summary>
/// The FriendsList class is a list of friends of the user`
/// </summary>
public class FriendsList : ISavedList
{
    public int Id { get; set; }
    public User Owner { get; set; }

    public FriendsList(int id, User owner)
    {
        Id = id;
        Owner = owner;
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
    
    public void AddFriend()
    {
        // PLACEHOLDER
    }
    
    public void RemoveFriend()
    {
        // PLACEHOLDER
    }
}