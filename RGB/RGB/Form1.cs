using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB
{
    public partial class Form1 : Form
    {
        private Color zapamietanyColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            zmienColor();
        }
        private void zmienColor()
        {
            {
                panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
                string s = "R= " + hScrollBar1.Value.ToString() +
                        " G= " + hScrollBar2.Value.ToString() +
                        " B= " + hScrollBar3.Value.ToString();
                label1.Text = s;
                if (hScrollBar1.Value+ hScrollBar2.Value+ hScrollBar3.Value/3>124)
                { label1.ForeColor = Color.Black; }
                else { label1.ForeColor = Color.White; }
                
            }
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            zmienColor();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            zmienColor();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            zapamietanyColor = panel1.BackColor;
            panel1.BackColor = Color.FromArgb(
                hScrollBar1.Value + hScrollBar2.Value + hScrollBar3.Value / 3, 
                hScrollBar1.Value + hScrollBar2.Value + hScrollBar3.Value / 3, 
                hScrollBar1.Value + hScrollBar2.Value + hScrollBar3.Value / 3);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            panel1.BackColor = zapamietanyColor;
        }
    }
}
