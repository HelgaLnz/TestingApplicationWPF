using ProjectWPF.Core;
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

namespace ProjectWPF.View
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow() =>
            InitializeComponent();

        private void btSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (UserValidator.Validate(tbLogin.Text, pbPassword.Password))
            {
                new UsersWindow().Show();
                Close();
            }
            else
                MessageBox.Show("Error", "Login or password is not correct", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}