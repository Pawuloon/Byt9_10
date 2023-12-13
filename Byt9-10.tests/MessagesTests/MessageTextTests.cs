﻿using Byt9_10.Lists;
using Byt9_10.Messages;
using Byt9_10.Models;

namespace Byt9_10.tests.MessagesTests;

/// <summary>
/// Tests for the MessageText class
/// </summary>
[Trait("MessageTests", "Unit")]
public class MessageTextTests
{
    private static User _user = new ("test", "test", "test", 
        new SavedDefinitionList(1, new List<Definition>()), 
        new FriendsList(1), 
        new ChatList(1, new List<Conversation>()));
    
    private MessageText _messageText = new(1, _user, new DateTime().Date, true, "test");
    
    [Fact]
    public void GetMessagesTextTest()
    {
        // arrange
        const string expected = "test";
        
        // act
        var actual = _messageText.Text;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetMessagesSenderTest()
    {
        // arrange
        const string expected = "test";
        
        // act
        var actual = _messageText.Sender.Username;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetMessagesDateTest()
    {
        // arrange
        DateTime expected = new();
        
        // act
        var actual = _messageText.TimeStamp;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetMessagesIsSentTest()
    {
        // arrange
        const bool expected = true;
        
        // act
        var actual = _messageText.IsSent;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetMessagesId()
    {
        // arrange
        const int expected = 1;
        
        // act
        var actual = _messageText.Id;
        
        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void SetMessagesTextTest()
    {
        // arrange
        const string expected = "test";
        
        // act
        _messageText.Text = expected;
        
        // assert
        Assert.Equal(expected, _messageText.Text);
    }
    
    [Fact]
    public void SetMessagesSenderTest()
    {
        // arrange
        const string expected = "test";
        
        // act
        _messageText.Sender.Username = expected;
        
        // assert
        Assert.Equal(expected, _messageText.Sender.Username);
    }
    
    [Fact]
    public void SetMessagesDateTest()
    {
        // arrange
        DateTime expected = new();
        
        // act
        _messageText.TimeStamp = expected;
        
        // assert
        Assert.Equal(expected, _messageText.TimeStamp);
    }
    
    [Fact]
    public void SetMessagesIsSentTest()
    {
        // arrange
        const bool expected = true;
        
        // act
        _messageText.IsSent = expected;
        
        // assert
        Assert.Equal(expected, _messageText.IsSent);
    }
    
    [Fact]
    public void SetMessagesId()
    {
        // arrange
        const int expected = 1;
        
        // act
        _messageText.Id = expected;
        
        // assert
        Assert.Equal(expected, _messageText.Id);
    }
    
    
    
}