using Byt9_10.Messages;

namespace Byt9_10.Models;

public class Conversation
{
    public int Id { get; set; }
    public List<MessageText> TextMessages { get; set; }
    public List<MessageVoice> VoiceMessages { get; set; }

    public Conversation(int id, List<MessageText> textMessages, List<MessageVoice> voiceMessages)
    {
        Id = id;
        TextMessages = textMessages;
        VoiceMessages = voiceMessages;
    }

    public void Send()
    {
        // PLACEHOLDER
    }

    public void ToggleTranslation()
    {
        // PLACEHOLDER
    }

    public void Save()
    {
        // PLACEHOLDER
    }
}