using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamDhrutiben
{
    public class Book
    {
        // declare class variables
        public int bookID { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public bool isAvailable { get; set; }


        // Navigation for BookIssue
        public List<BookIssue> bookIssues { get; set; }

        // combine title and author just for display purpose not to save in database
        public string titleAndAuthour => $"{title} By {author}";
    }
}
