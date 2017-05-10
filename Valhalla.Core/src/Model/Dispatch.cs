using System.Collections.Generic;

namespace Valhalla.Model.Library.Model
{
    /// <summary>
    /// Represents a dispatch that deploys resources to an Incident.
    /// </summary>
    public class Dispatch
    {
        /// <summary>
        /// Responses
        /// </summary>
        public List<Response> Responses { get; set; }

        /// <summary>
        /// Volunteer doing the dispatching
        /// </summary>
        public Volunteer Dispatcher { get; set; }

        /// <summary>
        /// Dispatch incident
        /// </summary>
        public Incident Incident { get; set; }

        /// <summary>
        /// Is this dispatch a test?
        /// </summary>
        public bool IsATest { get; set; }
    }
}
