using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTest
{
    static class TestControlFactory
    {
        public static TestUserControl CreateControl(Question question)
        {
            if (question.Type == QuestionType.OneAnswer)
                return new ucOneAnswerTest(question);
            if (question.Type == QuestionType.MultipleAnswer)
                return new ucMultipleAnswerTest(question);
            return new ucCustomAnswerTest(question);
        }
    }
}
