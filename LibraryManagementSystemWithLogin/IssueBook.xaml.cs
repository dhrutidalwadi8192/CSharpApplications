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
    /// Interaction logic for IssueBook.xaml
    /// </summary>
    public partial class IssueBook : Window
    {
        User user;
        // instantiate db context
        AppDBContext context = new AppDBContext();
        public IssueBook()
        {
            InitializeComponent();
            LoadData();
        }

        public IssueBook(User user)
        {
            InitializeComponent();
            this.user = user;
            if (user.role != "Admin")
            {
                memberSelection.Visibility = Visibility.Collapsed;
            }
            LoadData();
        }

        /// <summary>
        /// function to load data as window initalize
        /// </summary>
        private void LoadData()
        {
            try
            {
                // bind member data to combobox
                if (user.role == "Admin")
                {
                    memberCombo.ItemsSource = context.members.ToList();
                    //memberSelection.Visibility = Visibility.Collapsed;
                }


                // fetch available books to bind it in list box
                List<Book> availableBooks = new List<Book>();
                availableBooks = context.books.Where(b => b.isAvailable).OrderBy(b => b.title).ToList();

                // if books are available then bind that data to list boc
                if (availableBooks.Count > 0)
                {
                    bookList.ItemsSource = availableBooks;
                }
                // if no book available then hide list box and display message of book not available
                else
                {
                    // hide book list box
                    bookList.Visibility = Visibility.Collapsed;
                    // display label of no book available
                    noBookAvailable.Visibility = Visibility.Visible;
                    // disable issue book button
                    issueBook.IsEnabled = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading initial data {ex.ToString()}");
            }



        }

        /// <summary>
        /// function to handle issue book button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void issueBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // get selected member from combobox
                Member member;
                if (user.role == "Admin")
                {
                    member = memberCombo.SelectedItem as Member;


                }
                else
                {
                    member = context.members.Where(m => m.userID == user.userID).FirstOrDefault();

                }
                // if member is selected then check if book is selected
                if (member != null)
                {
                    // check if book is selected
                    if (bookList.SelectedItems.Count > 0)
                    {
                        // if book is selected assign each selected book to member
                        foreach (Book book in bookList.SelectedItems)
                        {

                            if (book != null)
                            {
                                // add data in book issue table
                                context.bookIssue.Add(new BookIssue { memberID = member.memberID, bookID = book.bookID, issueDate = DateTime.Now, returnDate = null });

                                // update isAvailable flag set to false in book table
                                Book dbBook = context.books.Where(b => b.bookID == book.bookID).Single();
                                if (dbBook != null)
                                {
                                    dbBook.isAvailable = false;
                                    //dbBook.memberID = member.memberID;
                                }
                            }

                        }
                        // save changes in db
                        context.SaveChanges();
                        MessageBox.Show("Book Issued To Member Successfully");
                        // function call to navigate to book list
                        navigateToBookList();
                    }
                    else
                    {
                        MessageBox.Show("Please select book you want to assign to member");
                    }
                }
                else
                {
                    MessageBox.Show("Please select member");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error while Issuing Book to Member");
            }

        }

        /// <summary>
        /// function to navigate to book home
        /// </summary>
        public void navigateToBookList()
        {
            // instantiate book home window 
            BookHome bh = new BookHome(this.user);
            // close current page
            this.Close();
            // display member home
            bh.Show();
        }

        /// <summary>
        /// function to handle cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            // instantiate main window
            Dashboard dashboard= new Dashboard(this.user);
            // close current page
            this.Close();
            // display main window
            dashboard.Show();
        }
    }
}
