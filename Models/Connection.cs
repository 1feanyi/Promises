using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promises.Models
{
    public class Connection
    {
        public int ConnectionId { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsBlacklist { get; set; }
        /* public Profile Requestor { get; set; }
        public Profile Recipient { get; set; } */
        public DateTime CreatedOn { get; set; }
    }
}
