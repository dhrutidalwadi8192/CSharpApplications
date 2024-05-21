using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalExamDhrutiben
{
    /// <summary>
    /// Interaction logic for BookHome.xaml
    /// </summary>
    public partial class BookHome : Window
    {
        User user;
        AppDBContext context = new AppDBContext();
        public BookHome()
        {
            InitializeComponent();
            LoadData();
        }

        public BookHome(User user)
        {
            InitializeComponent();
            this.user = user;
            if (user.role != "Admin")
            {
                addBook.Visibility = Visibility.Collapsed;
                issuedTo.Visibility = Visibility.Collapsed;
                
            }
            LoadData();
        }
        public void LoadData()
        {
            try
            {

                // fetch book data with issued to member
                List<BookDetail> books = context.books.Select(book => new BookDetail
                {
                    bookID = book.bookID,
                    title = book.title,
                    author = book.author,
                    isAvailable = book.isAvailable ? "Yes" : "No",
                    isEnableReturn = book.isAvailable ? false : true,
                    issuedTo = book.bookIssues.Where(bookIssue => bookIssue.returnDate == null).
                    Select(bookIssue => bookIssue.member.firstName).SingleOrDefault() ?? "-",
                    bookIssueID = book.bookIssues.Where(bookIssue => bookIssue.returnDate == null)
                           .Select(bookIssue => bookIssue.bookIssueID).FirstOrDefault(),
                    memberID = book.bookIssues.Where(bookIssue => bookIssue.returnDate == null).
                      Select(bookIssue => bookIssue.member.memberID).FirstOrDefault()

                }).ToList();



                if (books.Count > 0)
                {
                    // code to enable disable return book button based on logged in member
                    if (user.role != "Admin")
                    {
                        int currentMemberID = context.members.Where(u => u.userID == this.user.userID).Select(u => u.memberID).FirstOrDefault();

                        foreach (var book in books)
                        {
                            if (book.isEnableReturn)
                            {

                                if (book.memberID == currentMemberID)
                                {
                                    book.isEnableReturn = true;
                                }
                                else
                                {
                                    book.isEnableReturn = false;
                                }
                            }

                        }
                    }
                    // bind book data to grid
                    dataGridBooks.ItemsSource = books;
                    noDataPanel.Visibility = Visibility.Collapsed;
                    if (bookListPanel.Visibility == Visibility.Collapsed)
                    {
                        // display book data grid
                        bookListPanel.Visibility = Visibility.Visible;
                    }

                }
                else
                {
                    // diplay no book found message
                    noDataPanel.Visibility = Visibility.Visible;
                    // hide grid
                    bookListPanel.Visibility = Visibility.Collapsed;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error while loading book data");
            }


        }


        /// <summary>
        /// function to handle add book click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            // instantiate add book
            AddBook addBook = new AddBook(this.user);
            // show add book window
            addBook.Show();
            // close current window
            this.Close();

        }

        /// <summary>
        /// function to handle search book event click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // validation for not empty search value
                if (string.IsNullOrEmpty(searchValue.Text))
                {
                    MessageBox.Show("Please enter book name to search");
                }
                else
                {
                    List<BookDetail> books = context.books.Where(b => b.title.Contains(searchValue.Text) || b.author.Contains(searchValue.Text)).
                        Select(book => new BookDetail
                        {
                            bookID = book.bookID,
                            title = book.title,
                            author = book.author,
                            isAvailable = book.isAvailable ? "Yes" : "No",
                            issuedTo = book.bookIssues.Where(bookIssue => bookIssue.returnDate == null).
                            Select(bookIssue => bookIssue.member.firstName).SingleOrDefault() ?? "-",
                            bookIssueID = book.bookIssues.Where(bookIssue => bookIssue.returnDate == null)
                           .Select(bookIssue => bookIssue.bookIssueID).FirstOrDefault(),
                            memberID = book.bookIssues.Where(bookIssue => bookIssue.returnDate == null).
                      Select(bookIssue => bookIssue.member.memberID).FirstOrDefault()
                        ,
                        }).ToList();

                    if (books.Count > 0)
                    {
                        if (user.role != "Admin")
                        {
                            // code to enable disable return book button based on logged in member
                            int currentMemberID = context.members.Where(u => u.userID == this.user.userID).Select(u => u.memberID).FirstOrDefault();

                            foreach (var book in books)
                            {
                                if (book.isEnableReturn)
                                {

                                    if (book.memberID == currentMemberID)
                                    {
                                        book.isEnableReturn = true;
                                    }
                                    else
                                    {
                                        book.isEnableReturn = false;
                                    }
                                }

                            }
                        }

                        // bind book data to grid
                        dataGridBooks.ItemsSource = books;
                        noDataPanel.Visibility = Visibility.Collapsed;
                        if (bookListPanel.Visibility == Visibility.Collapsed)
                        {
                            // display book data grid
                            bookListPanel.Visibility = Visibility.Visible;
                        }
                    }
                    else
                    {
                        // diplay no book found message
                        noDataPanel.Visibility = Visibility.Visible;
                        // hide grid
                        bookListPanel.Visibility = Visibility.Collapsed;
                    }

                }

            }
            catch (Exception)

            {
                MessageBox.Show("Error while searching book");
            }

        }

        /// <summary>
        /// function to handle clear filtter button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearFilter_Click(object sender, RoutedEventArgs e)
        {
            // reset search box
            searchValue.Text = string.Empty;
            // load all data without filter
            LoadData();
        }

        /// <summary>
        /// function to handle home button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeNavigate_Click(object sender, RoutedEventArgs e)
        {
            // instantiate main window
            Dashboard dashboard = new Dashboard(this.user);
            // close current window
            this.Close();
            // open home page window
            dashboard.Show();
        }

        /// <summary>
        /// function to handle return book button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // get selected book
                BookDetail selectedBook = dataGridBooks.SelectedItem as BookDetail;

                if (selectedBook != null && selectedBook.bookIssueID > 0)
                {

                    // fetch book to update isAvailable flag to true (release book)
                    Book dbBook = context.books.Where(b => b.bookID == selectedBook.bookID).Single();
                    if (dbBook != null)
                    {
                        dbBook.isAvailable = true;
                    }
                    // fetch bookissue to update book issue data, update return date
                    BookIssue dbBookIssue = context.bookIssue.Where(bi => bi.bookIssueID == selectedBook.bookIssueID).Single();
                    if (dbBookIssue != null)
                    {
                        // set return date
                        dbBookIssue.returnDate = DateTime.Now;
                    }
                    // save changes to database
                    context.SaveChanges();
                    LoadData();
                    MessageBox.Show("Book Returned Successfully");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while returning book");
            }

        }

        

        
    }
}



