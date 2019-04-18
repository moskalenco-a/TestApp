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
    public partial class RadioTextBox : UserControl
    {
        public RadioTextBox()
        {
            InitializeComponent();
        }

        public new event EventHandler TextChanged;
        public event EventHandler CheckedChanged;

        [Description("Sets radiobutton state"),
        Category("Values"),
        DefaultValue(false),
        Browsable(true)]
        public bool Checked
        {
            get
            {
                return radioButton.Checked;
            }
            set
            {
                radioButton.Checked = value;
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

        void textBox_TextChanged(object sender, EventArgs e)
        {
            if (this.TextChanged != null)
                this.TextChanged(this, e);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton.Checked)
            {
                foreach (RadioTextBox radioTextBox in this.Parent.Controls.OfType<RadioTextBox>())
                    if (this != radioTextBox)
                        radioTextBox.Checked = false;
            }
            if (this.CheckedChanged != null)
                this.CheckedChanged(this, e);
        }
    }
}
