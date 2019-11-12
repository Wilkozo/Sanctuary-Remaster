namespace QuestSystem
{
    public interface IQuestIdentfier
    {
        int _sourceID { get; } // Could of been hexdecimal as a data type
        int _chainQuestID { get; } // If a quest is linked to another quest
        int _questID { get; }
    }
}


