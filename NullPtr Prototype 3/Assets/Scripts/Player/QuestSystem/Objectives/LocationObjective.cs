using UnityEngine;

namespace QuestSystem
{
    public class LocationObjective : IQuestGoal
    {
        private string title;
        private string description;
        private string verb;
        private bool isComplete;
        private bool isSecondary; // If a branching path for the quest is required
        private int collectionAmount; //Required for completion
        private int currentAmount;
        private GameObject itemToCollect;

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public int CurrentAmount
        {
            get
            {
                return currentAmount;
            }
        }

        public int CollectionAmount
        {
            get
            {
                return collectionAmount;
            }
        }

        public GameObject ItemToCollect
        {
            get
            {
                return itemToCollect;
            }
        }

        public bool IsComplete
        {
            get
            {
                return isSecondary;
            }
        }

        public bool IsSecondary
        {
            get
            {
                return isSecondary;
            }
        }

        public void CheckProgress()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProgress()
        {
            if (currentAmount >= collectionAmount)
            {
                isComplete = true;
            }
            else
            {
                isComplete = false;
            }
        }
    }
}

