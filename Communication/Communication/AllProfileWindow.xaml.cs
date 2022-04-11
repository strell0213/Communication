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
    /// Логика взаимодействия для AllProfileWindow.xaml
    /// </summary>
    public partial class AllProfileWindow : Window
    {
        AppContext AC;
        public AllProfileWindow()
        {
            InitializeComponent();
            AC = new AppContext();
            updatelist();
        }
        public void updatelist() {
            var List = AC.Users.ToList();
            ListProf.ItemsSource = List;

        }

        private void DeleteProfile_Click(object sender, RoutedEventArgs e)
        {
            var buttondel = (Button)sender;
            var user = (User)buttondel.DataContext;
            AC.Users.Remove(user);
            AC.SaveChanges();
            MessageBox.Show("Успешно удалено!", "Communication", MessageBoxButton.OK, MessageBoxImage.Information);
            updatelist();
        }

        private void FullProfile_Click(object sender, RoutedEventArgs e)
        {
            var buttonprof = (Button)sender;
            var user = (User)buttonprof.DataContext;
            NowClass.newprof = user.login;
            NowProfileWindow nowProfileWindow = new NowProfileWindow();
            nowProfileWindow.Show();
            this.Close();
        }
    }
}
