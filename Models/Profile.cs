using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Promises.Models
{
    public class Profile
    {
        [Required]
        public Guid ProfileId { get; set; }
        [Required]
        [StringLength(255)]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Alias> Aliases { get; set; }
        public ICollection<Connection> Connections { get; set; }
        public ICollection<Education> EducationHistory { get; set; }
        public ICollection<EmailAddress> EmailAddresses { get; set; }
        public ICollection<Employment> EmploymentHistory { get; set; }
        public ICollection<ExternalProfile> ExternalProfiles { get; set; }
        public ICollection<MailingAddress> MailingAddresses { get; set; }
        public ICollection<PhoneNumber> PhoneNumbers { get; set; } 
        // public ICollection<Promise> Promises { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public byte ProfilePicture { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public Profile()
        {
            Aliases = new Collection<Alias>();
            Connections = new Collection<Connection>();
            EducationHistory = new Collection<Education>();
            EmailAddresses = new Collection<EmailAddress>();
            EmploymentHistory = new Collection<Employment>(); 
            ExternalProfiles = new Collection<ExternalProfile>();
            MailingAddresses = new Collection<MailingAddress>();
            PhoneNumbers = new Collection<PhoneNumber>();
            // Promises = new Collection<Promise>();
            Skills = new Collection<Skill>();
        }
    }
}