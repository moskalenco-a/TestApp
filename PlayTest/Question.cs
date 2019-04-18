using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Xml.Serialization;

namespace PlayTest
{
    [Serializable]
    public class Answer
    {
        public string Text { get; set; }
        public bool IsTrue { get; set; }
        public Answer()
        {
            Text = "";
            IsTrue = false;
        }
    }

    [Serializable]
    [XmlInclude(typeof(OneAnswerQuestion))]
    [XmlInclude(typeof(MultipleAnswerQuestion))]
    [XmlInclude(typeof(CustomAnswerQuestion))]
    public class Question
    {
        public string Text { get; set; }
    }

    [Serializable]
    public class CustomAnswerQuestion : Question
    {
        public string CorrectAnswer { get; set; }
        public CustomAnswerQuestion()
        {
            Text = "";
            CorrectAnswer = "";
        }
    }

    [Serializable]
    public class OneAnswerQuestion : Question
    {
        private int correctAnswerIndex;
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex
        {
            get
            {
                return correctAnswerIndex;
            }
            set
            {
                if (0 <= value && value < Answers.Count)
                    correctAnswerIndex = value;
            }
        }

        public OneAnswerQuestion()
        {
            //Answers = new List<string>() { "" };//, "" };
            //CorrectAnswerIndex = 0;
        }
    }

    [Serializable]
    public class MultipleAnswerQuestion : Question
    {
        public List<Answer> Answers { get; set; }

        public MultipleAnswerQuestion()
        {
            //Answers = new List<Answer>() {
            //    new Answer { Text = "", IsTrue = false },
            //    //new Answer { Text = "", IsTrue = false }
            //};
        }
    }
}
