using System.Security.Principal;
using Byt9_10.Interfaces;
using Byt9_10.Models;

namespace Byt9_10.Messages;

public class MessageText : IMessage
{
    public int Id { get; set; }
    public User Sender { get; set; }
    public DateTime TimeStamp { get; set; }
    public bool IsSent { get; set; }
    public string Text { get; set; }
    
    public MessageText(int id, User sender, DateTime timeStamp, bool isSent, string text)
    {
        Id = id;
        Sender = sender;
        TimeStamp = timeStamp;
        IsSent = isSent;
        Text = text;
    }

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