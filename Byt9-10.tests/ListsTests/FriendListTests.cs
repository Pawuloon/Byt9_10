using Byt9_10.Lists;
using Byt9_10.Models;

namespace Byt9_10.tests.ListsTests;


/// <summary>
/// Tests for the FriendList class
/// </summary>
public class FriendListTests
{
    private FriendsList _friendsList = new(1);
    
    [Test]
    public void GetFriendListIdTest()
    {
        Console.WriteLine(_friendsList.Id);
    }
    
}
