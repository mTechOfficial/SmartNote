/*
						  Group.cs
						  Zhi Qiu
						 04/10/2017
 Base class inherited by all groups including ClassGroup and StudyGroup.
*/
using System.Collections.Generic;
using SmartNote.Enums;

namespace SmartNote.Models
{
    public class Group
    {
        // Member fields
        private string name;
        private List<User> users;
        private int maxUsers;
        private int numUsers;
        private Visibility visibilityType;
        private string joinCode; // Todo: Build Code class to generate join codes

        // Properties
        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected List<User> Users
        {
            get { return users; }
            set { users = value; }
        }
        protected int MaxUsers
        {
            get { return maxUsers; }
            set { maxUsers = value; }
        }
        protected Visibility VisibilityType
        {
            get { return visibilityType; }
            set { visibilityType = value; }
        }
        protected string JoinCode
        {
            get { return joinCode; }
            set { joinCode = value; }
        }
    }
}
