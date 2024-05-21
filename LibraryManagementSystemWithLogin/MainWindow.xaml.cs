using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalExamDhrutiben
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // dn context
        AppDBContext context = new AppDBContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // check user and its crendentials
            User user = context.users.Where(u => u.userName == txtUserName.Text && u.password == txtUserPassword.Password.ToString()).First();
            if(user != null)
            {
                MessageBox.Show($"Login Successful, Welcome {user.userName}");
                // open dashboard
                Dashboard dashboard = new Dashboard(user);
                    dashboard.Show();
                    this.Close();
                
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password");
            }       
        }
    }
}