﻿using System;
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
    /// Логика взаимодействия для ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        AppContext AC;
        public ProfileWindow()
        {
            InitializeComponent();
            AC = new AppContext();
            var r = AC.Users.Where(c => c.login == NowClass.NOW).FirstOrDefault();
            if (r.RoleID == 1)
            {
                LoginBlock.Text = "    " + r.login + "\nПользователь";
            }
            else if (r.RoleID == 2) { 
                LoginBlock.Text = "    " + r.login + "\nЭксперт";
            }
        }

        

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var r = AC.Users.Where(c => c.login == NowClass.NOW).FirstOrDefault();
            if (r.RoleID == 1)
            {
                CommunicationWindow communicationWindow = new CommunicationWindow();
                communicationWindow.Show();
                this.Close();
            }
            else if (r.RoleID == 2) { 
                AdminCommunicationWindow adminCommunicationWindow = new AdminCommunicationWindow();
                adminCommunicationWindow.Show();
                this.Close();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            editWindow.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Вы уверены что хотите удалить профиль?", "Communication", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var r = AC.Users.Where(c => c.login == NowClass.NOW).FirstOrDefault();
                if (r != null)
                {
                    AC.Users.Remove(r);
                    AC.SaveChanges();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
            }
        }
    }
}
