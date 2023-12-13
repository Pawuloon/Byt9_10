using Byt9_10.Lists;

namespace Byt9_10.tests.ListsTests;


/// <summary>
/// Tests for the FriendList class
/// </summary>
[Trait("ListTests", "Unit")]
public class FriendListTests
{
    private readonly FriendsList _friendsList = new(1);
    
    [Fact]
    public void GetFriendListIdTest()
    {
        // arrange
        const int expected = 1;

        // act
        var actual = _friendsList.Id;

        // assert
        Assert.Equal(expected, actual);
    }
}
