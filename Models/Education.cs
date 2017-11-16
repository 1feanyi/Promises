using System;

namespace Promises.Models
{
    public class Education
    {
        public int EducationId { get; set; }
        public Profile User { get; set; }
        // public School SchoolName { get; set; }
        public string FieldOfStudy { get; set; }
        public Degree Degree { get; set; }
        public string Notes { get; set; }
        public bool IsEnrolled { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public enum Degree
    {
        Certificate,
        Associate,
        Bachelor,
        Master,
        Doctorate
    }
}