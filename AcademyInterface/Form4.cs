using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyInterface
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            { MessageBox.Show("Please enter info abour yourself!", "Alert"); }
            else if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "")
            {
                if (comboBox1.Text != "")
                {
                    Combo();
                    

                }
            }
        }
        Image[] images = { Properties.Resources.OOP, Properties.Resources.изтеглен_файл__3_, Properties.Resources.изтеглен_файл__4_, Properties.Resources.изтеглен_файлkur };
        Image[] mentor = { Properties.Resources.images__1_, Properties.Resources.изтеглен_файл, Properties.Resources.изтеглен_файл__2_,  Properties.Resources.изтеглен_файл__1_ };
        public void Combo()
        {
         if(comboBox1.Text == "Data Structures") { pictureBox1.Image = images[1]; label11.Text = "Tom Sandler"; pictureBox2.Image = mentor[0];label10.Text = "170$"; }
         if(comboBox1.Text == "OOP") { pictureBox1.Image = images[0]; label11.Text = "Pedro Diaz"; pictureBox2.Image = mentor[1]; label10.Text = "160$"; }
         if(comboBox1.Text == "Algorithms") { pictureBox1.Image = images[3]; label11.Text = "Sara Kirilova"; pictureBox2.Image = mentor[2]; label10.Text = "180$"; }
         if(comboBox1.Text == "UI/UX Design") { pictureBox1.Image = images[2]; label11.Text = "Anna Jonhson"; pictureBox2.Image = mentor[3]; label10.Text = "190$"; }

            MessageBox.Show("Your Name: " + textBox1.Text + "\n" + "Your Number: " + textBox2.Text + "\n" + "Your Email adress:" + textBox3.Text + "\n" + "You paid "+ label10.Text+" succesfully!" + "\n" + "Your course is: " + comboBox1.Text + "\n" + "Your mentor is: " + label11.Text, "Info");
        }
    }
}
