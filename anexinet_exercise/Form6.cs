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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void claculate_btn_Click(object sender, EventArgs e)
        {
            String[] points_str = points_txt.Text.Replace("[", String.Empty).Replace("]", String.Empty).Replace(" ", String.Empty).Replace("),(", "|").Replace(")", String.Empty).Split('|');
            if (points_str.Length != 5)
            {
                MessageBox.Show("Incomplete coordenates", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int area_int = 0, coord_x, coord_y;
                String[] coordenate_int = points_str[0].Split(',');
                coordenate center = new coordenate();
                if (coordenate_int.Length == 2 && int.TryParse(coordenate_int[0], out coord_x) && int.TryParse(coordenate_int[1], out coord_y))
                {
                    center.x = coord_x;
                    center.y = coord_y;
                }
                for(int i = 1; i < 5; i++)
                {
                    coordenate_int = points_str[i].Split(',');
                    if (coordenate_int.Length == 2 && int.TryParse(coordenate_int[0], out coord_x) && int.TryParse(coordenate_int[1], out coord_y))
                    {
                        area_int += center.calculate_area(coord_x, coord_y);
                    }
                }
                MessageBox.Show("Total area is: " + area_int.ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private sealed class coordenate
        {
            public int x { get; set; }
            public int y { get; set; }
            public int calculate_area(int x1, int y1)
            {
                return Math.Abs(Math.Abs(x1) - x) * ((Math.Abs(y1) - y));
            }
        }
    }
}
