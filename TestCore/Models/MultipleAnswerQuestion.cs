using System;
using System.Collections.Generic;

namespace TestCore
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
    public class MultipleAnswerQuestion : Question
    {
        public List<Answer> Answers { get; set; } = new List<Answer>();

        public override bool CheckAnswer(object ans)
        {
            var answers = ans as List<bool>;
            for (int i = 0; i < answers.Count; i++)
                if (answers[i] != Answers[i].IsTrue)
                    return false;
            return true;
        }
    }
}