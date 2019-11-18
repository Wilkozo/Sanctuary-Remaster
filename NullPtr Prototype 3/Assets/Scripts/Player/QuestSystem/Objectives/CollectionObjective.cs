using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class CollectionObjective : IQuestGoal
    {
        private string title;
        private string description;
        private string verb;
        private bool isComplete;
        private bool isSecondary; // If a branching path for the quest is required
        private int collectionAmount; //Required for completion
        private int currentAmount;
        private GameObject itemToCollect;
        
        /// <summary>
        /// This constructor builds a collection objective
        /// </summary>
        /// <param name="_title">Title of the objective</param>
        /// <param name="_totalAmount">Amount required to comeplete</param>
        /// <param name="_verb">Verb of the objective</param>
        /// <param name="_item">The item to collect</param>
        /// <param name="_description">description of the quest</param>
        /// <param name="secondary">Is it a secondary objective?</param>
        public CollectionObjective(string _title, int _totalAmount, string _verb, GameObject _item, string _description, bool secondary)
        {
            title = _title;
            description = _description;
            collectionAmount = _totalAmount;
            itemToCollect = _item;
            verb = _verb;
            currentAmount = 0;
            isSecondary = secondary;
            isComplete = false;
        }
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
            set
            {
                description = value;
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

        public void CheckProgress(GameObject item)
        {
            if(item.tag == "Bread")
            {
                currentAmount++;
            }
            UpdateProgress();
            if(isComplete == true)
            {
          
            }
            if(item == itemToCollect)
            {
                currentAmount++;
            }
        }

        public void UpdateProgress()
        {
            if(currentAmount >= collectionAmount)
            {
                isComplete = true;
            }
            else
            {
                isComplete = false;
            }
        }
        //Example: (0/10 Bread Collected!)
        public override string ToString()
        {
            return currentAmount + "/" + collectionAmount + " " + itemToCollect.name + " " + verb + "ed!";
        }
    }
}


