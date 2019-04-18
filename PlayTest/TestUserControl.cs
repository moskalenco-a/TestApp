using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayTest
{
    public class TestUserControl: UserControl
    {
        public virtual bool IsAnswerCorrect()
        {
            throw new NotImplementedException();
        }
    }
}
