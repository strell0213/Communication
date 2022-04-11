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
            string[] vs = v.questionId.Split(',', ' ');
            int a;
            foreach (string s in vs)
            {
               
                try
                {
                    a = Convert.ToInt32(s);
                    var w = AC.Questions.Where(c => c.ID == a).FirstOrDefault();
                    QueView.Items.Add(w.ID + "\nВаш вопрос: " + w.Questione + "\nОтвет: \n" + w.Answer);
                    a = 0;
                }
                catch { }

            }

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddQuestion add = new AddQuestion();
            add.Show();
            this.Close();
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
            this.Close();
        }
    }
}
