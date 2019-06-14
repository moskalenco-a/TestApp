using System;
using System.Collections.Generic;

namespace TestCore
{
    [Serializable]
    public class OneAnswerQuestion : Question
    {
        private int correctAnswerIndex;
        public List<string> Answers { get; set; } = new List<string>();
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

        public override bool CheckAnswer(object ans)
        {
            int index = (int)ans;
            return index == correctAnswerIndex;
        }
    }
}