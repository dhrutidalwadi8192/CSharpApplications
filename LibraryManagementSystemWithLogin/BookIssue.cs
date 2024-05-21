using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamDhrutiben
{
    public class BookIssue
    {
        // book issue id (primary key)
        public int bookIssueID { get; set; }

        // book id from book class
        public int bookID { get; set; }

        // member id from member class
        public int memberID { get; set; }

        //book issue date
        public DateTime issueDate { get; set; }

        // book return date
        public DateTime? returnDate { get; set; }

        // Navigation for book
        public Book book { get; set; }

        // Navigation for member
        public Member member { get; set; }
    }
}
