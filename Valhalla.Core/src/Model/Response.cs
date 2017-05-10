using Valhalla.Time;

namespace Valhalla.Model
{
    /// <summary>
    /// Represents a response by a volunteer to a dispatch event.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Database row ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Raw text from SMS message
        /// </summary>
        public string ResponseText { get; set; }

        /// <summary>
        /// Time response was received
        /// </summary>
        public MilitaryTime ReceiveTime { get; set; }

        /// <summary>
        /// Responder first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Responder last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Responder phone number
        /// </summary>
        /// <remarks>Will be the number the response message was received from,
        /// even if the responder's phone number in the volunteer database is
        /// different.</remarks>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Responder email address
        /// </summary>
        /// <remarks>Will be the email the response message was received from,
        /// even if the responder's phone number in the volunteer database is
        /// different.</remarks>
         public string Email { get; set; }

        /// <summary>
        /// Responder ETA in 24-hour time
        /// </summary>
        public MilitaryTime ETA { get; set; }

        /// <summary>
        /// Is the response from the CDO?
        /// </summary>
        public bool IsCDO { get; set; }

        /// <summary>
        /// Is the response from the Deputy CDO?
        /// </summary>
        public bool IsDeputy { get; set; }

        /// <summary>
        /// Is the response from the first person on the scene?
        /// </summary>
        public bool IsFirstOnScene { get; set; }

        /// <summary>
        /// Is the responder off-duty/safe in quarters?
        /// </summary>
        public bool IsOffDuty { get; set; }

        /// <summary>
        /// Foreign key for response to volunteers table
        /// </summary>
        public int VolunteerID { get; set; }

        /// <summary>
        /// Foreign key for response to incidents table
        /// </summary>
        public int IncidentID { get; set; }
     }
}
