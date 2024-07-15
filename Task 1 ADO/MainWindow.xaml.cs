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

namespace Task_1_ADO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataBase.ReadToDBuser();
        }

        

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if (DataBase.Checklogpas(PasswordTXT.Text, LoginTXT.Text))
            {
                MessageBox.Show("Login Successfuly");
            }
            else
            {
                MessageBox.Show("Login Error!");
                Close();
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            Singupwindow signUpWindow = new();
            signUpWindow.ShowDialog();
        }
    }
}