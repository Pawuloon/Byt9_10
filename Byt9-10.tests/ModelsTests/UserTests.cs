using Byt9_10.Lists;
using Byt9_10.Models;

namespace Byt9_10.tests.ModelsTests;

/// <summary>
/// Tests for the User class
/// </summary>
[TestFixture]
public class UserTests
{
    
    private User _user = new("test", "test", "test", 
        new SavedDefinitionList(1, new List<Definition>()), 
        new FriendsList(1), 
        new ChatList(1, new List<Conversation>()));
    
    [Test]
    public void GetUsernameTest()
    {
        Console.WriteLine(_user.Username);
    }
    
    [Test]
    public void GetPasswordTest()
    {
        Console.WriteLine(_user.Password);
    }
    
    [Test]
    public void GetCurrentLangTest()
    {
        Console.WriteLine(_user.CurrentLang);
    }
    
    [Test]
    public void GetDefinitionListTest()
    {
        Console.WriteLine(_user.DefinitionList);
    }
    
    [Test]
    public void GetFriendsListTest()
    {
        Console.WriteLine(_user.FriendsList);
    }
    
    [Test]
    public void GetChatListTest()
    {
        Console.WriteLine(_user.ChatList);
    }
    
    [Test]
    public void SetUsernameTest()
    {
        _user.Username = "test2";
        Console.WriteLine(_user.Username);
    }

    [Test]
    public void SetPasswordTest()
    {
        _user.Password = "test2";
        Console.WriteLine(_user.Password);
    }
    
    [Test]
    public void SetCurrentLangTest()
    {
        _user.CurrentLang = "test2";
        Console.WriteLine(_user.CurrentLang);
    }
    
    [Test]
    public void SetDefinitionListTest()
    {
        _user.DefinitionList = new SavedDefinitionList(2, new List<Definition>());
        Console.WriteLine(_user.DefinitionList);
    }
    
    [Test]
    public void SetFriendsListTest()
    {
        _user.FriendsList = new FriendsList(2);
        Console.WriteLine(_user.FriendsList);
    }
    
    [Test]
    public void SetChatListTest()
    {
        _user.ChatList = new ChatList(2, new List<Conversation>());
        Console.WriteLine(_user.ChatList);
    }
}
