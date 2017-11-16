using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Promises.Models
{
    public class Employment
    {
        public int EmploymentId { get; set; }
        public Profile User { get; set; }
        public bool IsCurrent { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Company Employer { get; set; }
    }
}
