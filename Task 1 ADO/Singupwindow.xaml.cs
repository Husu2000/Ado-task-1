using System.Windows;
namespace Task_1_ADO
{

    public partial class Singupwindow : Window
    {
        public Singupwindow()
        {
            InitializeComponent();
        }
      

        public void SignUpbutton_Click(object sender, RoutedEventArgs e)
        {
            if(Passwordtext.Text == Confirm_Password.Text) 
            {
                User user = new User(Nametext.Text, Surnametext.Text, int.Parse(Agetext.Text), Logintext.Text, Passwordtext.Text);
                  DataBase.Users.Add(user);
                DataBase.WrittentoDB();
  
            }
            else
            {

                MessageBox.Show("Dont true cpassword");
            }
            Close();
        }
    }
}
