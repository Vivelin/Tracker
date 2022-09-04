using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivelin.Tracker.Data.Entities
{
    internal class Human
    {
        public Guid Id { get; set; }

        public virtual ICollection<PlatformIdentity> Identities { get; set; } 
            = new List<PlatformIdentity>();
    }
}
