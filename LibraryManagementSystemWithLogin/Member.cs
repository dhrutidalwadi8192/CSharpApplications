using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamDhrutiben
{
    public class Member
    {
        // member id (primary key)
        public int memberID { get; set; }

        // user Id
        public int userID { get; set; }

        // first name
        public string firstName { get; set; }

        // last name
        public string lastName { get; set; }

        // birth date
        public DateTime dateOfBirth { get; set; }

        public string gender { get; set; }

        // navigation property
        public User user { get; set; }

        // Navigation property for BookIssue
        public IList<BookIssue> bookIssues { get; set; }

        // combine title and author just for display purpose not to save in database
        public string fullName => $"{firstName} {lastName}";
    }
}
