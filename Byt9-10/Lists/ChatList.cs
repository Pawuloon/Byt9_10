using Byt9_10.Interfaces;

namespace Byt9_10.Lists;

public class ChatList : ISavedList
{
    public int Id { get; set; }

    public ChatList(int id)
    {
        Id = id;
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
        // PLACEHOLDER;
    }

    public void Open()
    {
        // PLACEHOLDER
    }
}