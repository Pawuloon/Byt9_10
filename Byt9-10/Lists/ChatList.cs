using Byt9_10.Interfaces;
using Byt9_10.Models;

namespace Byt9_10.Lists;

public class ChatList : ISavedList
{
    public int Id { get; set; }
    public List<Conversation> Conversations { get; set; }

    public ChatList(int id, List<Conversation> conversations)
    {
        Id = id;
        Conversations = conversations;
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