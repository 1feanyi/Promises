using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promises.Models
{
    public class EmailAddress
    {
        public int EmailAddressId { get; set; }
        public Profile User { get; set; }
        public EmailType Type { get; set; }
        public string Email { get; set; }
        public string Domain { get; set; }
    }

    public enum EmailType
    {
        Personal,
        Work
    }
}
