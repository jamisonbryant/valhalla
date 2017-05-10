using Valhalla.Time;

namespace Valhalla.Model
{
    /// <summary>
    /// Represents an incident for which resources are deployed.
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// Database row ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Incident name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Incident description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Incident start time
        /// </summary>
        public MilitaryTime StartTime { get; set; }

        /// <summary>
        /// Incident end time
        /// </summary>
        public MilitaryTime EndTime { get; set; }

        /// <summary>
        /// Incident CDO
        /// </summary>
        public Volunteer Cdo { get; set; }

        /// <summary>
        /// Location (address or landmark) where responders should stage
        /// </summary>
        public string StagingLocation { get; set; }

        /// <summary>
        /// Amount of time responders have to arrive at staging area
        /// </summary>
        public int StagingTimeLimit { get; set; }
    }
}
