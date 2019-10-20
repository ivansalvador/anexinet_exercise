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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(input_txt.Text)){
                MessageBox.Show(check_sintax().ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean check_sintax()
        {
            char[] closing_char = new char[] { ')', ']' };
            char[] opening_char = new char[] { '(', '[' };
            var valid_enum = input_txt.Text.Where(c => opening_char.Contains(c) || closing_char.Contains(c));
            Stack<char> chars_stk = new Stack<char>();
            char current_char = ' ';
            foreach (var x in valid_enum)
            {
                if (current_char == ' ')
                {
                    current_char = x;
                    chars_stk.Push(x);
                }
                else
                {
                    switch (current_char)
                    {
                        case '(':
                            if (x == ')')
                            {
                                chars_stk.Pop();
                                current_char = (chars_stk.Count > 0) ? chars_stk.Peek() : ' ';
                            }
                            else if (x == ']')
                            {
                                return false;
                            }
                            else
                            {
                                current_char = x;
                                chars_stk.Push(x);
                            }
                            break;
                        case '[':
                            if (x == ']')
                            {
                                chars_stk.Pop();
                                current_char = (chars_stk.Count > 0) ? chars_stk.Peek() : ' ';
                            }
                            else if (x == ')')
                            {
                                return false;
                            }
                            else
                            {
                                current_char = x;
                                chars_stk.Push(x);
                            }
                            break;
                        default:
                            return false;
                    }
                }
            }
            return (chars_stk.Count > 0) ? false : true;
        }
    }
}
