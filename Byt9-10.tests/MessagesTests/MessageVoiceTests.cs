using Byt9_10.Lists;
using Byt9_10.Messages;
using Byt9_10.Models;

namespace Byt9_10.tests.MessagesTests;  

/// <summary>
/// Tests for the MessageAudio class
/// </summary>
[Trait("MessageTests", "Unit")]
public class MessageVoiceTests
{
    private readonly MessageVoice _messageVoice = new(1, 
        new User("test", "test", "test",
            new SavedDefinitionList(1, new List<Definition>()),
            new FriendsList(1),
            new ChatList(1, new List<Conversation>())), 
        new DateTime(), true, "test");
    
    [Fact]
    public void GetMessageIdTest()
    {
        // arrange
        const int id = 1;
        
        // act
        var actual = _messageVoice.Id;
        
        // assert
        Assert.Equal(id, actual);
    }
    
    [Fact]
    public void GetMessageSenderTest()
    {
        // arrange
        const string expected = "test";
        
        // act
        var actual = _messageVoice.Sender.Username;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetMessageDateTest()
    {
        // arrange
        DateTime expected = new();
        
        // act
        var actual = _messageVoice.TimeStamp;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetMessageIsSentTest()
    {
        // arrange
        const bool expected = true;
        
        // act
        var actual = _messageVoice.IsSent;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetMessageAudioPathTest()
    {
        // arrange
        const string expected = "test";
        
        // act
        var actual = _messageVoice.AudioFilePath;
        
        // assert
        Assert.Equal(expected, actual);
    }
}
