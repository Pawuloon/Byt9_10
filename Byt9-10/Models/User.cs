using Byt9_10.Interfaces;
using Byt9_10.Lists;

namespace Byt9_10.Models;

public class User
{
    public string Username { get; set; }
    public string Password { get;set; }
    public string CurrentLang { get;set; }
    public ICollection<ISavedList> SavedLists { get; set; }
    public ICollection<Conversation> Conversations { get; set; }


    public User(string username, string password, string currentLang, ICollection<ISavedList> savedLists, ICollection<Conversation> conversations)
    {
        Username = username;
        Password = password;
        CurrentLang = currentLang;
        SavedLists = savedLists;
        Conversations = conversations;
    }

    // Login method
    public void Login(string username, string password)
    {
       // PLACEHOLDER
    }
    
    // Logout method
    public void Logout(string username, int id)
    {
        // PLACEHOLDER
    }
    
    // Register method
    public void Register(string username, string password)
    {
        // PLACEHOLDER
    }
    
    // Find user method
    public void FindUser(string username)
    {
        // PLACEHOLDER
    }
    
    // Change lang method
    public void ChangeLang(string username, string lang)
    {
        // PLACEHOLDER
    }

    // ToString method
    public override string ToString()
    {
        return Username + " " + Password + " " + CurrentLang;
    }
}