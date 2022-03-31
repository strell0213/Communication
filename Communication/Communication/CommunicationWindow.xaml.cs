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

namespace Communication
{
    /// <summary>
    /// Логика взаимодействия для CommunicationWindow.xaml
    /// </summary>
    public partial class CommunicationWindow : Window
    {
        AppContext AC;
        public CommunicationWindow()
        {
            InitializeComponent();
            AC = new AppContext();
            var v = AC.Users.Where(c => c.login == NowClass.NOW).FirstOrDefault();
            if (v.RoleID == 1) {
                TextVIEW.Text = v.login + "\nПользователь";
            }
        }
    }
}
