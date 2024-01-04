using Byt9_10.Lists;
using Byt9_10.Messages;

namespace Byt9_10.Models;

public class Conversation
{
    public int Id { get; set; }
    public ICollection<MessageText> TextMessages { get; set; }
    public ICollection<MessageVoice> VoiceMessages { get; set; }
    public ICollection<User> Participants { get; set; }
    public ICollection<ChatList> ExistsInChatLists { get; set; }

    public Conversation(int id, ICollection<MessageText> textMessages, ICollection<MessageVoice> voiceMessages, ICollection<User> participants, ICollection<ChatList> existsInChatLists)
    {
        Id = id;
        TextMessages = textMessages;
        VoiceMessages = voiceMessages;
        Participants = participants;
        ExistsInChatLists = existsInChatLists;
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