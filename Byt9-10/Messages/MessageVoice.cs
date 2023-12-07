using Byt9_10.Interfaces;
using Byt9_10.Models;

namespace Byt9_10.Messages;

public class MessageVoice : IMessage
{
    public int Id { get; set; }
    public User Sender { get; set; }
    public DateTime TimeStamp { get; set; }
    public bool IsSent { get; set; }
    public string AudioFilePath { get; set; }

    public MessageVoice(int id, User sender, DateTime timeStamp, bool isSent, string audioFilePath)
    {
        Id = id;
        Sender = sender;
        TimeStamp = timeStamp;
        IsSent = isSent;
        AudioFilePath = audioFilePath;
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