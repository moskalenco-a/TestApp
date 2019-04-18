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
            if (question is OneAnswerQuestion)
                return new ucOneAnswerTest(question as OneAnswerQuestion);
            if (question is MultipleAnswerQuestion)
                return new ucMultipleAnswerTest(question as MultipleAnswerQuestion);
            return new ucCustomAnswerTest(question as CustomAnswerQuestion);
        }
    }
}
