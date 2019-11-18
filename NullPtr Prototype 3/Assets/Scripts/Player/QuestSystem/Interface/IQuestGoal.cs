using System.Collections;
using UnityEngine;

namespace QuestSystem
{
    public interface IQuestGoal
    {
        string Title { get; }
        string Description { get; set; }
        bool IsComplete { get; }
        bool IsSecondary { get; }
        void UpdateProgress();
        void CheckProgress(GameObject item);
    }
}

