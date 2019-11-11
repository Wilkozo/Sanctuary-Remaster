using System.Collections.Generic;

namespace QuestSystem
{
    public class Quest
    {
        private QuestIdentifier questIdentifier;
        Quest(QuestIdentifier _questIdentifier, IQuestGoal questGoal)
        {
            questIdentifier = _questIdentifier;
            questGoals.Add(questGoal);
        }

        public void AddToQuestGoals(IQuestGoal newQuestGoal)
        { 

        }
        private List<IQuestGoal> questGoals;
        private bool IsComplete()
        {
            for(int i = 0; i < questGoals.Count; i++)
            {
                if(questGoals[i].IsComplete && questGoals[i].IsSecondary == false)
                {
                    return false;
                }
            }
            return true; // Quest Completed
        }
        
    }
}

