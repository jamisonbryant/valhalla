using System;

namespace Valhalla.Model
{
    /// <summary>
    /// Represents a volunteer that can be deployed to a dispatch event.
    /// </summary>
    public class Volunteer
    {
        /// <summary>
        /// Database row ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Volunteer first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Volunteer last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Volunteer email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Volunteer primary phone (555-555-5555)
        /// </summary>
        public string PrimaryPhone { get; set; }

        /// <summary>
        /// Volunteer alternate phone (555-555-5555)
        /// </summary>
        public string AlternatePhone { get; set; }

        /// <summary>
        /// Volunteer street address (123 Main St)
        /// </summary>
        public string StreetAddress1 { get; set; }

        /// <summary>
        /// Volunteer street address, line 2 (Apt 12)
        /// </summary>
        public string StreetAddress2 { get; set; }

        /// <summary>
        /// Volunteer city (Boston)
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Volunteer state (MA)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Volunteer zip code (02134)
        /// </summary>
        public int ZipCode { get; set; }

        /// <summary>
        /// Volunteer account type (Volunteer, Administrator...)
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Volunteer account status (Active, Inactive...)
        /// </summary>
        public string AccountStatus { get; set; }

        /// <summary>
        /// Date volunteer was created in CERVIS
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Date volunteer last accessed CERVIS
        /// </summary>
        public DateTime LastActive { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public string GetPassword()
        {
            string pword = "";

            pword += FirstName.Substring(0, 1);
            pword += LastName;
            pword += Id.ToString();
            pword = pword.ToLower();

            return pword;
        }

        /// <summary>
        ///
        /// </summary>
        public new string ToString()
        {
            return string.Format("{0} {1} ({2})", FirstName, LastName, PrimaryPhone);
        }
    }
}
