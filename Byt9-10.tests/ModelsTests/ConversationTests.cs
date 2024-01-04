using Byt9_10.Lists;
using Byt9_10.Messages;
using Byt9_10.Models;

namespace Byt9_10.tests.ModelsTests;

/// <summary>
/// Tests for the Conversation class
/// </summary>
[Trait("ModelTests", "Unit")]
public class ConversationTests
{
    private readonly Conversation _conversation = new(1,
    new List<MessageText>(),
    new  List<MessageVoice>(),
    new List<User>(),
    new List<ChatList>()
    );
    
    [Fact]
    public void GetConversationIdTest()
    {
        // arrange
        const int expected = 1;

        // act
        var actual = _conversation.Id;

        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetConversationTextMessagesTest()
    {
        // arrange
        List<MessageText> expected = new();

        // act
        var actual = _conversation.TextMessages;

        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetConversationVoiceMessagesTest()
    {
        // arrange
        List<MessageVoice> expected = new();

        // act
        var actual = _conversation.VoiceMessages;

        // assert
        Assert.Equal(expected, actual);
    }   
}