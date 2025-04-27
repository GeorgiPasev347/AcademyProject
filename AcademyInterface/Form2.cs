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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form1 fOne = new Form1();
            fOne.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Form3 fThree=new Form3();
            fThree.Show();
        }
    }
}
