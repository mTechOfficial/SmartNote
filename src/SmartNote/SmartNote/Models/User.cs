/*
						  User.cs
						  Zhi Qiu
						 04/10/2017
 User object to hold current user session information.
*/
using System.Collections.Generic;

namespace SmartNote.Models
{
    class User
    {
        // Member fields
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string school;
        private Settings preferences;
        private List<ClassGroup> privateClasses;
        private List<ClassGroup> publicClasses;
        private List<StudyGroup> groupStudy;

        // Ctor
        public User() { }

        // Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string School
        {
            get { return school; }
            set { school = value; }
        }
        public Settings Preferences
        {
            get { return preferences; }
            set { preferences = value; }
        }
        public List<ClassGroup> PrivateClasses
        {
            get { return privateClasses; }
            set { privateClasses = value; }
        }
        public List<ClassGroup> PublicClasses
        {
            get { return publicClasses; }
            set { publicClasses = value; }
        }
        public List<StudyGroup> GroupStudy
        {
            get { return groupStudy; }
            set { groupStudy = value; }
        }
    }
}
