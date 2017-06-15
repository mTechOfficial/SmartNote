/*
						 ClassGroup.cs
						  Zhi Qiu
						 04/10/2017
 Model for groups for class notes.
*/
using System.Collections.Generic;
using Xamarin.Forms;

namespace SmartNote.Models
{
    public class ClassGroup : Group
    {
        // Member fields
        private List<Image> pictures; // Todo: find best type for importing images from aws cloud
        private List<User> blockedUsers;
        private Dictionary<int, int> reportedUsers;

        // Ctor
        public ClassGroup() { }

        // Properties
        public List<Image> Pictures
        {
            get { return pictures; }
            set { pictures = value; }
        }
        public List<User> BlockedUsers
        {
            get { return blockedUsers; }
            set { blockedUsers = value; }
        }
        /// <summary>
        /// @key = ID of user
        /// @value = Number of times blocked
        /// </summary>
        public Dictionary<int, int> ReportedUsers
        {
            get { return reportedUsers; }
            set { reportedUsers = value; }
        }
    }
}
