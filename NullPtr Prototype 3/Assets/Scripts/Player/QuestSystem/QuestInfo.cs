namespace QuestSystem
{
    public class QuestInfo : IQuestInfo
    {
        private string title;
        private string questDescription;
        
        public string _title
        {
            get
            {
                return title;
            }
        }

        public string _questDescription
        {
            get
            {
                return questDescription;
            }
        }
    }

}

