using Byt9_10.Lists;
using Byt9_10.Models;



namespace Byt9_10.tests.ModelsTests;

/// <summary>
/// Tests for the User class
/// </summary>
[Trait("ModelTests", "Unit")]
public class UserTests
{

    private readonly User _user = new("test", "test", "test",
        new SavedDefinitionList(1, new List<Definition>()),
        new FriendsList(1),
        new ChatList(1, new List<Conversation>()));

    [Fact]
    public void GetUsernameTest()
    {
        // arrange
        const string expected = "test";

        // act
        var actual = _user.Username;
        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetPasswordTest()
    {
        // arrange
        const string expected = "test";

        // act
        var actual = _user.Password;

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetCurrentLangTest()
    {
        // arrange
        const string expected = "test";

        // act
        var actual = _user.CurrentLang;

        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetDefinitionListTest()
    {
        // arrange
        SavedDefinitionList expected = new(1, new List<Definition>());

        // act
        var actual = _user.DefinitionList;

        // assert
        Assert.NotEqual(expected, actual);
    }
    
    [Fact]
    public void GetFriendsListTest()
    {
        // arrange
        FriendsList expected = new(1);

        // act
        var actual = _user.FriendsList;

        // assert
        Assert.NotEqual(expected, actual);
    }
    
    [Fact]
    public void GetChatListTest()
    {
        // arrange
        ChatList expected = new(1, new List<Conversation>());

        // act
        var actual = _user.ChatList;

        // assert
        Assert.NotEqual(expected, actual);
    }
    
    [Fact]
    public void SetUsernameTest()
    {
        // arrange
        const string expected = "test2";

        // act
        _user.Username = "test2";
        var actual = _user.Username;

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SetPasswordTest()
    {
        // arrange
        const string expected = "test2";

        // act
        _user.Password = "test2";
        var actual = _user.Password;

        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void SetCurrentLangTest()
    {
        // arrange
        const string expected = "test2";

        // act
        _user.CurrentLang = "test2";
        var actual = _user.CurrentLang;

        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void SetDefinitionListTest()
    {
        // arrange
        SavedDefinitionList expected = new(2, new List<Definition>());

        // act
        _user.DefinitionList = new SavedDefinitionList(2, new List<Definition>());
        var actual = _user.DefinitionList;

        // assert
        Assert.NotEqual(expected, actual);
    }
    
    [Fact]
    public void SetFriendsListTest()
    {
        // arrange
        FriendsList expected = new(2);

        // act
        _user.FriendsList = new FriendsList(2);
        var actual = _user.FriendsList;

        // assert
        Assert.NotEqual(expected, actual);
    }
    
    [Fact]
    public void SetChatListTest()
    {
        // arrange
        ChatList expected = new(2, new List<Conversation>());

        // act
        _user.ChatList = new ChatList(2, new List<Conversation>());
        var actual = _user.ChatList;

        // assert
        Assert.NotEqual(expected, actual);
    }
}
