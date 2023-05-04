using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double BMI;
            int rost = Convert.ToInt32(textBox1.Text) ;
            rost = rost/ 100;
            int ves = Convert.ToInt32(textBox2.Text);
            BMI = ves / (rost * rost);
            //int BMI = Convert.ToInt32(t);
            //label7.Text = BMI.ToString();
            if (BMI < 10)
            { trackBar1.Value = 10; label7.Text = "недостаточный"; label18.Text = Convert.ToString(BMI); pictureBox3.Visible = true; }
            if (BMI < 18.5 && BMI >= 10)
            { trackBar1.Value = 15; label7.Text = "недостаточный"; label18.Text = Convert.ToString(BMI); pictureBox3.Visible = true; }
            if (BMI >= 18.5 && BMI <= 24.9)
            { trackBar1.Value = 20; label7.Text = "здоровый"; label18.Text = Convert.ToString(BMI); pictureBox4.Visible = true; }
            if (BMI <= 30 && BMI > 24.9)
            { trackBar1.Value = 26; label7.Text = "избыточный"; label18.Text = Convert.ToString(BMI); pictureBox5.Visible = true; }
            if (BMI > 30 && BMI <= 35)
            { trackBar1.Value = 32; label7.Text = "ожирение"; label18.Text = Convert.ToString(BMI); pictureBox6.Visible = true; }
            else
            { trackBar1.Value = 35; label7.Text = "ожирение"; label18.Text = Convert.ToString(BMI); pictureBox6.Visible = true; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label7.Text =" " ;
            label18.Text =" ";
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double BMI;
            int rost = Convert.ToInt32(textBox1.Text);
            rost = rost / 100;
            int ves = Convert.ToInt32(textBox2.Text);
            BMI = ves / (rost * rost);
            label18.Text=Convert.ToString(BMI);
            label18.Text=BMI.ToString("N");
            //int BMI = Convert.ToInt32(t);
            //label7.Text = BMI.ToString();
            if (BMI < 10)
            { trackBar1.Value = 10; label7.Text = "недостаточный"; label18.Text = Convert.ToString(BMI); pictureBox3.Visible = true; }
            else if (BMI < 18.5 && BMI >= 10)
            { trackBar1.Value = 15; label7.Text = "недостаточный"; label18.Text = Convert.ToString(BMI); pictureBox3.Visible = true; }
             else if (BMI >= 18.5 && BMI <= 24.9)
            { trackBar1.Value = 20; label7.Text = "здоровый"; label18.Text = Convert.ToString(BMI); pictureBox4.Visible = true; }
            else if (BMI <= 30 && BMI > 24.9)
            { trackBar1.Value = 26; label7.Text = "избыточный"; label18.Text = Convert.ToString(BMI); pictureBox5.Visible = true; }
             else if (BMI > 30 && BMI <= 35)
            { trackBar1.Value = 32; label7.Text = "ожирение"; label18.Text = Convert.ToString(BMI); pictureBox6.Visible = true; }
            else
            { trackBar1.Value = 35; label7.Text = "ожирение"; label18.Text = Convert.ToString(BMI); pictureBox6.Visible = true; }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            Hide();
        }
    }
}
