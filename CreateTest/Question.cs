using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CreateTest
{
    [Serializable]
    public enum QuestionType
    {
        OneAnswer,      // radiobutton
        MultipleAnswer, // checkbox
        CustomAnswer    // textbox
    }

    [Serializable]
    public class Answer
    {
        [DisplayName("Ответ")]
        public string Text { get; set; }
        
        [DisplayName("Правильный ответ?")]
        public bool IsTrue { get; set; }
    }

    [Serializable]
    public class Question
    {
        public QuestionType Type;
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }
        public List<bool> AnswerCorrect { get; set; }
        public string CorrectAnswer { get; set; }

        public Question()
        {
            Type = QuestionType.CustomAnswer;
            QuestionText = "Текст вопроса";
            Answers = new List<Answer>();
            CorrectAnswer = "Правильный ответ";
        }
    }
}
