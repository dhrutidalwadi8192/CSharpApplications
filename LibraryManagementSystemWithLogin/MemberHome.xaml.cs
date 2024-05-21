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
    /// Interaction logic for MemberHome.xaml
    /// </summary>
    public partial class MemberHome : Window
    {
        User user;
        AppDBContext context = new AppDBContext();
        public MemberHome()
        {
            InitializeComponent();
            LoadData();
        }

        public MemberHome(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadData();
        }
        /// <summary>
        /// function to bind member list to grid
        /// </summary>
        public void LoadData()
        {
            try
            {

                // fetch member data with their assigned books
                var members = context.members.Select(member => new
                {
                    memberID = member.memberID,
                    fullName = member.fullName,
                    books = string.Join(", ", member.bookIssues
                        .Where(issue => issue.returnDate == null)
                        .Select(issue => issue.book.titleAndAuthour)
                        )
                }).ToList();


                if (members.Count > 0)
                {

                    // bind member data to grid
                    dataGridMembers.ItemsSource = members;

                    // show hide data grid stack panel based on data
                    noDataPanel.Visibility = Visibility.Collapsed;
                    if (memberListPanel.Visibility == Visibility.Collapsed)
                    {
                        memberListPanel.Visibility = Visibility.Visible;
                    }

                }
                else
                {
                    noDataPanel.Visibility = Visibility.Visible;
                    memberListPanel.Visibility = Visibility.Collapsed;
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show($"Error while loading member data : {ex.ToString()}");
            }


        }



        /// <summary>
        /// function to handle search member functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchMember_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // validation for empty string for search value
                if (String.IsNullOrEmpty(searchValue.Text))
                {
                    MessageBox.Show("Please enter member name to search");
                }
                else
                {
                    // fetch member data with where condition and perform join to fetch assigne dbook


                    var members = context.members.Where(m => m.firstName.Contains(searchValue.Text) || m.lastName.Contains(searchValue.Text)).Select(member => new
                    {
                        memberID = member.memberID,
                        fullName = member.fullName,
                        books = string.Join(", ", member.bookIssues
                       .Where(issue => issue.returnDate == null)
                       .Select(issue => issue.book.titleAndAuthour)
                       )
                    }).ToList();

                    if (members.Count > 0)
                    {

                        // bind member data to grid
                        dataGridMembers.ItemsSource = members;

                        // show hide data grid stack panel based on data
                        noDataPanel.Visibility = Visibility.Collapsed;
                        if (memberListPanel.Visibility == Visibility.Collapsed)
                        {
                            memberListPanel.Visibility = Visibility.Visible;
                        }

                    }
                    // collapse data grid and display no member found label
                    else
                    {
                        noDataPanel.Visibility = Visibility.Visible;
                        memberListPanel.Visibility = Visibility.Collapsed;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while searching member");
            }


        }

        /// <summary>
        /// function to handle clear search filter functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearFilter_Click(object sender, RoutedEventArgs e)
        {
            // reset search box
            searchValue.Text = string.Empty;
            LoadData();
        }


        /// <summary>
        /// function to handle add member button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMember_Click(object sender, RoutedEventArgs e)
        {
            // instantiaite add member page
            AddMember addMember = new AddMember();
            // close current page
            this.Close();
            // display add member page
            addMember.Show();
        }



        /// <summary>
        /// function to navigate to home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navigateHome_Click(object sender, RoutedEventArgs e)
        {
            // instantiate main window
            Dashboard dashboard = new Dashboard(this.user);
            // close current page
            this.Close();
            // display main page
            dashboard.Show();
        }
    }
}
