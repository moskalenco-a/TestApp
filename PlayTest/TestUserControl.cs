using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayTest
{
    public abstract class TestUserControl: UserControl
    {
        public abstract bool IsAnswerCorrect { get; }
    }
}
