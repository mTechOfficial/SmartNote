/*
						 StudyGroup.cs
						  Zhi Qiu
						 04/10/2017
 Model for study groups.
*/
using SmartNote.Enums;

namespace SmartNote.Models
{
    class StudyGroup : Group
    {
        // Member fields
        private User organizer;
        private Repeat repeatOption;

        // Ctor
        public StudyGroup() { }

        // Properties
        public User Organizer
        {
            get { return organizer; }
            set { organizer = value; }
        }
        public Repeat RepeatOption
        {
            get { return repeatOption; }
            set { repeatOption = value; }
        }
    }
}
