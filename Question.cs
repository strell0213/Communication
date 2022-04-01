using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    class Question
    {
        public int ID { get; set; }
        private string question, answer;
        public string Questionn { get { return question; } set { question = value; } }
        public string Answer { get { return answer; } set { question = value; } }

        public Question() { }

        public Question(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}
