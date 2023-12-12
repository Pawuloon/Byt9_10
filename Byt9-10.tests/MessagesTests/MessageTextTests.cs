using Byt9_10.Lists;
using Byt9_10.Messages;
using Byt9_10.Models;

namespace Byt9_10.tests.MessagesTests;

/// <summary>
/// Tests for the MessageText class
/// </summary>
public class MessageTextTests
{
    private static readonly User User = new ("test", "test", "test", 
        new SavedDefinitionList(1, new List<Definition>()), 
        new FriendsList(1), 
        new ChatList(1, new List<Conversation>()));
    
    private readonly MessageText _messageText = new(1, User, new DateTime().Date, true, "test");
    
    [Test]
    public void GetMessagesTextTest()
    {
        // arrange
        const string expected = "test";

        // act
        var actual = _messageText.Text;

        // assert
        Assert.Equals(expected, actual);
    }
    
    [Test]
    public void GetMessagesSenderTest()
    {
        // arrange
        const string expected = "test";

        // act
        var actual = _messageText.Sender.Username;

        // assert
        Assert.Equals(expected, actual);
    }
    
    [Test]
    public void GetMessagesDateTest()
    {
        // arrange
        var expected = new DateTime().Date;

        // act
        var actual = _messageText.TimeStamp;

        // assert
        Assert.Equals(expected, actual);
    }
    
    [Test]
    public void GetMessagesIsSentTest()
    {
        // arrange
        const bool expected = true;

        // act
        var actual = _messageText.IsSent;

        // assert
        Assert.Equals(expected, actual);
    }
    
    [Test]
    public void GetMessagesId()
    {
        // arrange
        const int expected = 1;

        // act
        var actual = _messageText.Id;

        // assert
        Assert.Equals(expected, actual);
    }
    
    [Test]
    public void SetMessagesTextTest()
    {
        // arrange
        const string expected = "test";

        // act
        _messageText.Text = "test";
        var actual = _messageText.Text;

        // assert
        Assert.Equals(expected, actual);
    }
    
    [Test]
    public void SetMessagesSenderTest()
    {
        // arrange
        const string expected = "test";

        // act
        _messageText.Sender.Username = "test";
        var actual = _messageText.Sender.Username;

        // assert
        Assert.Equals(expected, actual);
    }
    
    [Test]
    public void SetMessagesDateTest()
    {
        // arrange
        var expected = new DateTime().Date;

        // act
        _messageText.TimeStamp = new DateTime().Date;
        var actual = _messageText.TimeStamp;

        // assert
        Assert.Equals(expected, actual);
    }
    
    [Test]
    public void SetMessagesIsSentTest()
    {
        // arrange
        const bool expected = true;

        // act
        _messageText.IsSent = true;
        var actual = _messageText.IsSent;

        // assert
        Assert.Equals(expected, actual);
    }
    
    [Test]
    public void SetMessagesId()
    {
        // arrange
        const int expected = 1;

        // act
        _messageText.Id = 1;
        var actual = _messageText.Id;

        // assert
        Assert.Equals(expected, actual);
    }
}
