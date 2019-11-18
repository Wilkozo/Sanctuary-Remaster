using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class Quest
    {
        public QuestUI questUI { get; set; }
        private List<IQuestGoal> questGoals = new List<IQuestGoal>();
        public QuestIdentifier questIdentifier { get; }

        //Example for Creating a Quest
        //Quest newQuest = new Quest (new QuestIdentifier(1), new CollectionObjective("Collect the Bread", 10, "Collect", this.gameObject, "The Baker need help with his lost bread", false));
        //QuestHolder.AddQuestToCurrent(newQuest);

        public Quest(QuestIdentifier _questIdentifier, IQuestGoal questGoal)
        {
            questIdentifier = _questIdentifier;
            questGoals.Add(questGoal);
        }

        public void AddToQuestGoals(IQuestGoal newQuestGoal)
        {
            questGoals.Add(newQuestGoal);
        }
        
        public bool IsComplete()
        {
            for (int i = 0; i < questGoals.Count; i++)
            {
                questGoals[i].UpdateProgress();
                if (questGoals[i].IsComplete == false && questGoals[i].IsSecondary == false)
                {
                    return false;
                }
                questGoals[i].Description = questGoals[i].Description + " Done!";

            }
            return true; // Quest Completed
        }
        public void CheckCollection(GameObject item)
        {
            for (int i = 0; i < questGoals.Count; i++)
            {
                questGoals[i].CheckProgress(item);
            }
        }
        public string GetString()
        {
            string temp = "";
            for (int i = 0; i < questGoals.Count; i++)
            {
                temp += questGoals[i].Title + "/n" + questGoals[i].Description + "/n" + questGoals[i].ToString() + "/n";
            }
            return temp;
        }
        public string GetTitle()
        {
            string Title = "";
            Title = questGoals[0].Title;
            return Title;
        }
        public string GetDescription()
        {
            string Description = "";
            Description = questGoals[0].Description;
            return Description;
        }
        public string GetUpdate()
        {
            string Update = "";
            Update = questGoals[0].ToString();
            return Update;
        }
    }
}

