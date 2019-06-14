using System;

namespace TestCore
{
    [Serializable]
    public class CustomAnswerQuestion : Question
    {
        public string CorrectAnswer { get; set; }
        public CustomAnswerQuestion()
        {
            Text = "";
            CorrectAnswer = "";
        }

        public override bool CheckAnswer(object ans)
        {
            string answer = ans as string;
            return Normalize(answer) == Normalize(CorrectAnswer);
        }

        private string Normalize(string str)
        {
            str = str.Trim().ToLower();
            while (str.Contains("  "))
                str = str.Replace("  ", " ");
            return str;
        }
    }
}