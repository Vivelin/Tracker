using System;

namespace Vivelin.Tracker.Data.Entities
{
    internal class OpinionEvent
    {
        /// <summary>
        /// Gets or sets a unique ID of the opinion event.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of the human that the event relates to.
        /// </summary>
        public Guid HumanId { get; set; }

        /// <summary>
        /// Gets or sets the human that the event relates to.
        /// </summary>
        public Human? Human { get; set; }

        /// <summary>
        /// Gets or sets the ID of the human's identity that triggered the
        /// event.
        /// </summary>
        public int? IdentityId { get; set; }

        /// <summary>
        /// Gets or sets the human's identity that triggered the event.
        /// </summary>
        public PlatformIdentity? Identity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the change in Tracker's opinion of
        /// the human as a result of this event.
        /// </summary>
        public int OpinionChange { get; set; }
    }
}
