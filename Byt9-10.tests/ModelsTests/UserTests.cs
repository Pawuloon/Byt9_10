using Byt9_10.Interfaces;
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
        new List<ISavedList>(), new List<Conversation>());

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
    public void GetConversationListTest()
    {
        
        // arrange
        List<Conversation> expected = new();

        // act
        var actual = _user.Conversations;

        // assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void GetSavedListsTest()
    {
        // arrange
        List<ISavedList> expected = new();

        // act
        var actual = _user.SavedLists;

        // assert
        Assert.Equal(expected, actual);
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
    public void SetConversationListTest()
    {
        // arrange
        List<Conversation> expected = new();

        // act
        _user.Conversations = new List<Conversation>();
        var actual = _user.Conversations;

        // assert
        Assert.Equal(expected, actual);
    }
}
