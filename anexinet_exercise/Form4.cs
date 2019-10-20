using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anexinet_exercise
{
    public partial class Form4 : Form
    {
        public Form4() => InitializeComponent();

        private void process_btn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(input_txt.Text))
            {
                char current_char = ' ';
                Int16 counter = 0;
                String result_str = String.Empty;
                foreach (char x in input_txt.Text)
                {
                    if (current_char == x)
                    {
                        counter++;
                    }
                    else
                    {
                        if (counter > 0)
                        {
                            result_str += current_char + counter.ToString();
                        }
                        counter = 1;
                        current_char = x;
                    }
                }
                result_str += current_char + counter.ToString();
                result_txt.Text = (input_txt.Text.Length == result_str.Length) ? input_txt.Text : result_str;
            }
            else
            {
                MessageBox.Show("Empty String", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
