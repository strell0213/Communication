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
    /// Логика взаимодействия для AdminCommunicationWindow.xaml
    /// </summary>
    public partial class AdminCommunicationWindow : Window
    {
        AppContext AC;
        public AdminCommunicationWindow()
        {
            InitializeComponent();
            AC = new AppContext();
            var v = AC.Users.Where(c => c.login == NowClass.NOW).FirstOrDefault();
            if (v.RoleID == 2)
            {
                TextVIEW.Text = v.login + "\nАдминистратор";
            }
            update();
          
        }
        public void update() {
            QueView.Items.Clear();
            var v = AC.Users.Where(c => c.login == NowClass.NOW).FirstOrDefault();
            string[] vs = v.questionId.Split(',', ' ');
            int a;
            var t = AC.Users.Where(c => c.questionId.Contains("")).FirstOrDefault(); ;
            foreach (string s in vs)
            {
                try
                {
                    a = Convert.ToInt32(s);
                    t = AC.Users.Where(c => c.questionId.Contains(s) && c.RoleID == 1).FirstOrDefault();

                    var w = AC.Questions.Where(c => c.ID == a).FirstOrDefault();
                    QueView.Items.Add(w.ID + ".\nВопрос от " + t.login + ": " + w.Questione);


                }
                catch { }
                a = 0;
                t = null;
            }
        }

        private void AllProfileButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void QueView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int d1;
            if (QueView.SelectedItem.ToString()[1].ToString() == "." || QueView.SelectedItem.ToString()[1].ToString() == " ")
            {
                d1 = Convert.ToInt32(QueView.SelectedItem.ToString()[0].ToString());
            }
            else
            {
                d1 = Convert.ToInt32(QueView.SelectedItem.ToString()[0].ToString()) + Convert.ToInt32(QueView.SelectedItem.ToString()[0].ToString());
            }
            var r = AC.Questions.Where(c => c.ID == d1).FirstOrDefault();
            if (r != null)
            {
                AC.Questions.Remove(r);
                AC.SaveChanges();
                update();
            }
        }
    }
}
