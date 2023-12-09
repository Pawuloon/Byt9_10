using Byt9_10.Lists;
using Byt9_10.Messages;
using Byt9_10.Models;

namespace Byt9_10.tests.MessagesTests;

/// <summary>
/// Tests for the MessageText class
/// </summary>
public class MessageTextTests
{
    private static User _user = new ("test", "test", "test", 
        new SavedDefinitionList(1, new List<Definition>()), 
        new FriendsList(1), 
        new ChatList(1, new List<Conversation>()));
    
    private MessageText _messageText = new(1, _user, new DateTime().Date, true, "test");
    
    [Test]
    public void GetMessagesTextTest()
    {
        Console.WriteLine(_messageText.Text);
    }
    
    [Test]
    public void GetMessagesSenderTest()
    {
        Console.WriteLine(_messageText.Sender);
    }
    
    [Test]
    public void GetMessagesDateTest()
    {
        Console.WriteLine(_messageText.TimeStamp);
    }
    
    [Test]
    public void GetMessagesIsSentTest()
    {
        Console.WriteLine(_messageText.IsSent);
    }
    
    [Test]
    public void GetMessagesId()
    {
        Console.WriteLine(_messageText.Id);
    }
    
    [Test]
    public void SetMessagesTextTest()
    {
        _messageText.Text = "test2";
        Console.WriteLine(_messageText.Text);
    }
    
    [Test]
    public void SetMessagesSenderTest()
    {
        _messageText.Sender = _user;
        Console.WriteLine(_messageText.Sender);
    }
    
    [Test]
    public void SetMessagesDateTest()
    {
        _messageText.TimeStamp = new DateTime().Date;
        Console.WriteLine(_messageText.TimeStamp);
    }
    
    [Test]
    public void SetMessagesIsSentTest()
    {
        _messageText.IsSent = true;
        Console.WriteLine(_messageText.IsSent);
    }
    
    [Test]
    public void SetMessagesId()
    {
        _messageText.Id = 2;
        Console.WriteLine(_messageText.Id);
    }
    
    
    
}