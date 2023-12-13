using Byt9_10.Lists;
using Byt9_10.Models;

namespace Byt9_10.tests.ListsTests;

/// <summary>
/// Tests for the ChatList class
/// </summary>
[Trait("ListTests", "Unit")]
public class ChatListTests
{
    private readonly ChatList _chatList = new(1, new List<Conversation>());
    
    [Fact]
    public void GetChatListIdTest()
    {
        // arrange
        const int expected = 1;

        // act
        var actual = _chatList.Id;

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetChatListConversationsTest()
    {
        // arrange
        List<Conversation> expected = new();

        // act
        var actual = _chatList.Conversations;

        // assert
        Assert.Equal(expected, actual);
    }
}
