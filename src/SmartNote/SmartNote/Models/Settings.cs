/*
						Settings.cs
						  Zhi Qiu
						 04/10/2017
 Object to hold settings preferences.
*/

namespace SmartNote.Models
{
    class Settings
    {
        // Member fields
        private bool enableNotifications;
        private bool downloadImages;

        // Ctor
        public Settings() { }

        // Properties
        public bool EnableNotifications
        {
            get { return enableNotifications; }
            set { enableNotifications = value; }
        }
        public bool DownloadImages
        {
            get { return downloadImages; }
            set { downloadImages = value; }
        }
    }
}
