using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Promises.Models
{
    public class Alias
    {
        public int AliasId { get; set; }
        [Required]
        [StringLength(255)]
        public string AliasName { get; set; }
        public Profile EnteredBy { get; set; }
        public DateTime EnteredOn { get; set; }
    }
}
