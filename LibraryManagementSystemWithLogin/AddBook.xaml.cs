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
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        User user;
        AppDBContext context = new AppDBContext();
        public AddBook()
        {
            InitializeComponent();
        }

        public AddBook(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        /// <summary>
        /// function to handle add book button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // validate required field value for book title
                if (String.IsNullOrEmpty(bookTitle.Text))
                {
                    MessageBox.Show("Please add book title");
                }
                // validate required field value for book author
                else if (String.IsNullOrEmpty(bookAuthor.Text))
                {
                    MessageBox.Show("Please add book author");
                }
                else
                {
                    // instantiate book 
                    Book book = new Book();

                    // assign user input values to book class properties
                    book.title = bookTitle.Text;
                    book.author = bookAuthor.Text;
                    book.isAvailable = true;

                    // add book data in db conext
                    context.books.Add(book);

                    // save changes to database
                    context.SaveChanges();
                    MessageBox.Show("Book Added Successfully");

                    // navigate to home page
                    navigateToBookHome();
                }

            }
            catch (Exception)

            {
                MessageBox.Show("Error while adding book");
            }


        }

        /// <summary>
        /// function to handle cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            // function call to navigate to home
            navigateToBookHome();
        }

        // function to navigate to home window
        private void navigateToBookHome()
        {
            // instantiate home window
            BookHome bh = new BookHome(this.user);
            // display home page
            bh.Show();
            // close current window
            this.Close();

        }
    }
}
