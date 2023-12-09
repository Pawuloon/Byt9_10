using Byt9_10.Messages;
using Byt9_10.Models;

namespace Byt9_10.tests.ModelsTests;

/// <summary>
/// Tests for the Conversation class
/// </summary>
public class ConversationTests
{
    private Conversation _conversation = new(1,
        new List<MessageText>(),
        new List<MessageVoice>());
    
    [Test]
    public void GetConversationIdTest()
    {
        Console.WriteLine(_conversation.Id);
    }
    
    [Test]
    public void GetConversationTextMessagesTest()
    {
        Console.WriteLine(_conversation.TextMessages);
    }
    
    [Test]
    public void GetConversationVoiceMessagesTest()
    {
        Console.WriteLine(_conversation.VoiceMessages);
    }
    
}