using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHive_TestUtil
{
    class Utilities
    {
        public static Int64 UnixTime()
        {
            return (Int64) (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds;
        }
    }
}
