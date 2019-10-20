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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void process_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(string_1_txt.Text) || String.IsNullOrEmpty(string_2_txt.Text))
            {
                MessageBox.Show("Empty string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string_1_txt.Text == string_2_txt.Text)
            {
                MessageBox.Show("Repeated strings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String shorter_str = (string_1_txt.Text.Length <= string_2_txt.Text.Length) ? string_1_txt.Text : string_2_txt.Text;
                String larger_str = (string_1_txt.Text.Length > string_2_txt.Text.Length) ? string_1_txt.Text : string_2_txt.Text;
                String result_str = String.Empty;
                foreach(char x in shorter_str)
                {
                    result_str += (larger_str.IndexOf(x) > -1) ? x.ToString() : "";
                }
                result_txt.Text = result_str;
            }
        }
    }
}