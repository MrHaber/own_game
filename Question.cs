using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Question
    {
        private string theme;
        private string question;
        private List<string> answer;
        private int position;
        private int cost;
        public Question(string _theme,string _question, List<string> _answer, int position, int cost)
        {
            this.question = _question;
            this.answer = _answer;
            this.position = position;
            this.theme = _theme;
            this.cost = cost;
        }

        public int Cost
        {
            get { return cost; }
        set { cost = value; }
        }

        public string Theme {
        
            get { return this.theme; }
        set { this.theme = value; }
        }
        public int Pos
        {
            get { return this.position; }

            set { this.position = value; }
        }
        public string Quest
        {
            get { return question; }

            set { question = value; }
        }
        public List<string> Ans
        {
            get { return answer; }

            set { answer = value; }
        }
    }

