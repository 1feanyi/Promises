using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Promises.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public CompanyType Type { get; set; }
        public string WebDomain { get; set; }
        public string WebUrl { get; set; }
        public CompanyIndustry Industry { get; set; }
        public CompanyStatus Status { get; set; }
        public byte Logo { get; set; }
        public string Description { get; set; }
    }

    public enum CompanyType
    {

    }

    public enum CompanyIndustry
    {

    }

    public enum CompanyStatus
    {

    }
}
