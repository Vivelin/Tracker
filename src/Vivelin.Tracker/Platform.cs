using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivelin.Tracker
{
    /// <summary>
    /// Specifies the platforms Tracker can be connected to.
    /// </summary>
    public enum Platform
    {
        /// <summary>
        /// The platform is unknown or not specified.
        /// </summary>
        None = 0,

        /// <summary>
        /// The streaming website Twitch. Users can be either viewers in chat
        /// or broadcasters.
        /// </summary>
        Twitch = 1,
    }
}
