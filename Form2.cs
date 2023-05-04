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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel1.Visible= false;
            label1.Visible= false;
            label2.Visible = false;
            label3.Visible = false;
            pictureBox11.Visible =false;
            pictureBox12.Visible=false;
            pictureBox13.Visible=false;
            pictureBox14.Visible = false;
            pictureBox15.Visible=false;
            pictureBox16.Visible=false;
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {//point 1
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            // label1.Text = "Контрольная точка 1";
            label2.Text = "МЦК Лужники";
            label3.Text = "Особенности:\n \n Напитки \n\nЭнергитические \n\nбатончики ";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            //label1.Text = "Финиш";
            label2.Text = "Финиш";
            label3.Text = " ";
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {//3 point
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            //label1.Text = "Контрольная точка 3";
            label2.Text = "Метро Киевская";
            label3.Text = "Особенности:\n\n  Напитки \n\nЭнергитические \n\nбатончики \n\n Туалеты";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {//4 point
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = true;
            // label1.Text = "Контрольная точка 4";
            label2.Text = "МИД";
            label3.Text = "Особенности:\n\n  Напитки \n\nЭнергитические \n\nбатончики \n\n Туалеты\n\n\n Мед.пункт";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {//5 point
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            //label1.Text = "Контрольная точка 5";
            label2.Text = "Парк Горького";
            label3.Text = "Особенности:\n\n Напитки \n\nЭнергитические \n\nбатончики \n\n Туалеты\n\n\nИнф. стенд ";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {//2 point
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox14.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            // label1.Text = "Контрольная точка 2";
            label2.Text = "Новодевичий монастырь";
            label3.Text = "Особенности:\n\nНапитки \n\nЭнергитические \n\nбатончики \n\n Туалеты\n\n\nИнф. стенд \n\n\n Мед.пункт  ";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {//6 point
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            // label1.Text = "Контрольная точка 6";
            label2.Text = "Здания РАН";
            label3.Text = "Особенности:\n\nНапитки \n\nЭнергитические \n\nбатончики \n\n Туалеты";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {//7 point
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            //label1.Text = "Контрольная точка 7";
            label2.Text = "Метро Воробьевы горы";
            label3.Text = "Особенности:\n\nНапитки \n\nЭнергитические \n\nбатончики \n\n Туалеты\n\n\nИнф. стенд\n\n\n Мед.пункт ";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {//8 point
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = false;
            //label1.Text = "Контрольная точка 8";
            label2.Text = "Стадион Лужники";
            label3.Text = "Особенности:\n\nНапитки \n\nЭнергитические \n\nбатончики \n\n Туалеты\n\n\nИнф. стенды \n\n\n Мед.пункт  ";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            //label1.Text = "Старт";
            label2.Text = "Старт";
            label3.Text = " ";
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            //label1.Text = "Старт";
            label2.Text = "Старт";
            label3.Text = " ";
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            //label1.Text = "Старт";
            label2.Text = "Старт";
            label3.Text = " ";
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
        }
    }
}
