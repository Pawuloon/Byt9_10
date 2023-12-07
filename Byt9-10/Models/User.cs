namespace Byt9_10.Models;

public class User
{
    public string Username { get; set; }
    public string Password { get;set; }
    public string CurrentLang { get;set; }

    public User(string username, string password, string currentLang)
    {
        Username = username;
        Password = password;
        CurrentLang = currentLang;
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
}