using Byt9_10.Models;

namespace Byt9_10.Interfaces;

public interface IMessage
{
    public int Id { get; set; }
    public User Sender { get; set; }
    public DateTime TimeStamp { get; set; }
    public bool IsSent { get; set; }
    
    public void Send()
    {
        // PLACEHOLDER
    }
    
    public void TranslateMessage()
    {
        // PLACEHOLDER
    }
    
    public void GetDefinition()
    {
        // PLACEHOLDER
    }
}