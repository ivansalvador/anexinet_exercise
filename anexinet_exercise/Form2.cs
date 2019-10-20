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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void validate_btn_Click(object sender, EventArgs e)
        {
            if(DateTime.TryParse(date_txt.Text, out DateTime new_date))
            {
                int new_year = new_date.Year;
                if(new_year % 4 == 0 && (new_year % 100 != 0 || new_year % 400 == 0))
                {
                    MessageBox.Show("Entered year is a Leap Year", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Entered year is a not Leap Year", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid date", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
