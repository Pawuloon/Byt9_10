using Byt9_10.Lists;
using Byt9_10.Models;

namespace Byt9_10.tests.ListsTests;

/// <summary>
/// Tests for the ChatList class
/// </summary>
public class ChatListTests
{
    private ChatList _chatList = new(1, new List<Conversation>());
    
    [Test]
    public void GetChatListIdTest()
    {
        Console.WriteLine(_chatList.Id);
    }
    
    [Test]
    public void GetChatListConversationsTest()
    {
        Console.WriteLine(_chatList.Conversations);
    }
    
}
