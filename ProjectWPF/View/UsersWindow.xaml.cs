using ProjectWPF.Model;
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
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        public UsersWindow()
        {
            InitializeComponent();
            lvUsers.ItemsSource = new List<User>()
            {
                new User(0,"hhh","lll",string.Empty,"hlglnz","16122002","hlg@"),
                new User(1,"awdq","asd","aaa","35r3sef","16122002","hqa3r@"),
                new User(2,"Симасесечка","Будябка","Финтифлюш","йцук","фывцф","124цук")
            };
        }
    }
}