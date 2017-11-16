using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promises.Models
{
    public class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public Profile User { get; set; }
        public PhoneType Type { get; set; }
        public string Number { get; set; }
    }

    public enum PhoneType
    {
        Home,
        Mobile,
        Work
    }
}
