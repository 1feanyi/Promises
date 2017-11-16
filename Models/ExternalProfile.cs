using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promises.Models
{
    public class ExternalProfile
    {
        public int ExternalProfileId { get; set; }
        public Profile User { get; set; }
        public Provider Type { get; set; }
        public string LinkedStatus { get; set; }
        public bool IsPrimary { get; set; }
        public string ProviderAccountId { get; set; }
        public string ProviderAccountName { get; set; }

        public enum Provider
        {
            Facebook,
            Google,
            LinkedIn,
            Twitter,
        }
    }
}
