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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        User user;
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(User user)
        {
            InitializeComponent();
            this.user = user;
            if (user.role != "Admin")
            {
                viewMembers.Visibility = Visibility.Collapsed;
                
            }

        }

        /// <summary>
        /// function to handle add book button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBook_Click(object sender, RoutedEventArgs e)
        {

            BookHome bookHome = new BookHome(this.user);
            // hide current page
            this.Close();
            // display book home page
            bookHome.Show();
        }


        /// <summary>
        /// function to handle view member click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewMembers_Click(object sender, RoutedEventArgs e)
        {
            MemberHome memberHome = new MemberHome(this.user);
            // hide currenct page
            this.Close();
            // display member home page
            memberHome.Show();
        }

        /// <summary>
        /// function to handle issue book button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void issueBook_Click(object sender, RoutedEventArgs e)
        {
            IssueBook issueBook = new IssueBook(this.user);
            // close current page
            this.Close();
            // display issue book page
            issueBook.Show();
        }

        /// <summary>
        /// function to handle exit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            // close current page
            this.Close();
        }


    }
}
