using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7
{
    public partial class Form3 : Form
    {
        private float R = 100, G = 100, B = 100, A = 100;
        public Form3()
        {
            InitializeComponent();
           
            
        }
        public float getR()
        { //For Form1 to get width
            return R;
        }
        public float getG()
        {
            return G;
        }
        public float getB()
        { //For Form1 to get width
            return B;
        }
        public float getA()
        {
            return A;
        }
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
          
            R = (float)(trackBar1.Value) / 100;
            label5.Text = (R).ToString();

        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
          
            G =(float)trackBar2.Value / 100;
            label6.Text = (G).ToString();

        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            
            B =(float)trackBar3.Value / 100;
            label7.Text = (B).ToString();

        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void TrackBar2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TrackBar3_ValueChanged(object sender, EventArgs e)
        {

           
        }

        private void TrackBar4_ValueChanged(object sender, EventArgs e)
        {
          

        }

        private void TrackBar4_Scroll(object sender, EventArgs e)
        {
          
           A = (float)(trackBar4.Value) / 100;
            label8.Text = (A).ToString();

        }

    
        private void Button1_Click(object sender, EventArgs e)
        {
           
         
            
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
