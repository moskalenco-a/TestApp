using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTest
{
    public static class TestControlFactory
    {
        public static ucBaseTest Create(Question question)
        {
            ucBaseTest control = null;
            if (question is OneAnswerQuestion)
            {
                control = new ucOneAnswerTest(question as OneAnswerQuestion);
            }
            if (question is MultipleAnswerQuestion)
            {
                control = new ucMultipleAnswerTest(question as MultipleAnswerQuestion);
            }
            if (question is CustomAnswerQuestion)
            {
                control = new ucCustomAnswerTest(question as CustomAnswerQuestion);
            }
            control.Dock = DockStyle.Fill;
            return control;
        }
    }
}
