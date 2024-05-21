using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamDhrutiben
{
    public class BookDetail
    {
        // declare class variables
        public int bookID { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string isAvailable { get; set; }

        public bool isEnableReturn { get; set; }

        public string issuedTo { get; set; }

        public int bookIssueID { get; set; }

        public int memberID { get; set; }


        // default constructor
        public BookDetail() { }
    }
}
