using System.Collections;
using UnityEngine;
namespace QuestSystem
{
    public class QuestIdentifier : IQuestIdentfier
    {
        private int questID; 
        private int sourceID; //Where the quest came from
        private int chainQuestID; //

        QuestIdentifier(int _questID)
        {
            questID = _questID;
        }
        public int _sourceID
        {
            get
            {
                return sourceID;
            }
        }
        public int _questID
        {
            get
            {
                return questID;
            }
        }
        public int _chainQuestID
        {
            get
            {
                return chainQuestID;
            }
        }
    }

}
