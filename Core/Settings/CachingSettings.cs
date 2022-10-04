using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Settings
{
    public class CachingSettings
    {
        // Sliding expiration in seconds
        public int SlidingExpiration { get; set; }

        // Absolute Expiration in seconds
        public int AbsoluteExpiration { get; set; }

        // caching priority
        public int Priority { get; set; }
    }
}
