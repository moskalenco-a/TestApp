using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTest
{
    public partial class CheckedTextBox : UserControl
    {
        public CheckedTextBox()
        {
            InitializeComponent();
        }

        public new event EventHandler TextChanged;
        public event EventHandler CheckedChanged;

        [Description("Sets checkbox state"), 
        Category("Values"),
        DefaultValue(false),
        Browsable(true)]
        public bool Checked
        {
            get
            {
                return checkBox.Checked;
            }
            set
            {
                checkBox.Checked = value;
            }
        }

        [Description("Sets text"),
        Category("Values"),
        DefaultValue(""),
        Browsable(true)]
        public override string Text
        {
            get
            {
                return textBox.Text;
            }

            set
            {
                textBox.Text = value;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.TextChanged != null)
                this.TextChanged(this, e);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckedChanged != null)
                this.CheckedChanged(this, e);
        }
    }
}
