using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    internal class User
    {
        public int ID { get; set; }

        private string Login, Password, questionID;

        public string login { get { return Login; } set { Login = value; } }
        public string password { get { return Password; } set { Password = value; } }

        public string questionId { get { return questionID; } set {questionID = value;} }

        public int RoleID { get; set; }

        public User() { }

        public User(string Login, string Password, string questionID, int RoleID) { 
            this.Login = Login;
            this.Password = Password;
            this.questionID = questionID;
            this.RoleID = RoleID;
        }
    }
}
