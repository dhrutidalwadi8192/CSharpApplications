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
    /// Interaction logic for AddMember.xaml
    /// </summary>
    public partial class AddMember : Window
    {
        // instantiate app db context
        AppDBContext context = new AppDBContext();

        // flag if while adding member need to assign book or not
        bool isAssignBook = false;

        // declare list to store available books
        List<Book> availableBooks = new List<Book>();

        // default constructor
        public AddMember()
        {
            InitializeComponent();

        }

        /// <summary>
        /// function to hadnle add member button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMember_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // empty search value validation
                if (String.IsNullOrEmpty(memberFirstName.Text))
                {
                    MessageBox.Show("Please Add First Name");
                } else if (String.IsNullOrEmpty(memberLastName.Text))
                {
                    MessageBox.Show("Please Add Last Name");
                } else if (String.IsNullOrEmpty(memberUserName.Text)) {
                    MessageBox.Show("Please Add User Name");
                } else if (String.IsNullOrEmpty(memberPassword.Password.ToString()))
                {
                    MessageBox.Show("Please Add Password");
                } else if (String.IsNullOrEmpty(memberCnfPassword.Password.ToString()))
                {
                    MessageBox.Show("Please Add Confirm Password");
                } else if (memberPassword.Password.ToString() != memberCnfPassword.Password.ToString())
                {
                    MessageBox.Show("Password and Confirm Password does not match");
                }else if(Male.IsChecked == false && Female.IsChecked == false)
                {
                    MessageBox.Show("Please Select Gender");
                }else if (!memberDOB.SelectedDate.HasValue) { 
                    MessageBox.Show("Please Add Date of Birth");
                }

                else
                {
                    // istantiate member class
                    Member member = new Member();

                    // assign member name to class property
                    member.firstName = memberFirstName.Text;
                    member.lastName = memberLastName.Text;

                    if(Male.IsChecked == true)
                    {
                        member.gender = "Male";
                    }
                    else if(Female.IsChecked == true)
                    {
                        member.gender = "Female";
                    }
                   
                   
                   
                    member.dateOfBirth = memberDOB.SelectedDate.Value;
                    User user = new User();
                    user.userName = memberUserName.Text;
                    user.password = memberPassword.Password.ToString();
                    user.role = "Member";
                    // Save User Data
                    context.users.Add(user);
                    context.SaveChanges();


                    member.userID = user.userID;
                    // Save Member Data
                    context.members.Add(member);
                    // save data in database
                    context.SaveChanges();

                    MessageBox.Show("Member Added Successfully");
                    // navigate to home
                    navigateToMemberHome();
                
                }   
               
               
            }
            catch (Exception ex)

            {
                MessageBox.Show($"Error while adding member : {ex.ToString()}");
            }



        }





        // function to navigate to home 
        private void navigateToMemberHome()
        {
            // instantiate member home
            MemberHome mh = new MemberHome();
            // close current window
            this.Close();
            // display member home window
            mh.Show();
        }


        /// <summary>
        /// function to hadle cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            // function call to navigate to home
            navigateToMemberHome();


        }
    }
}
