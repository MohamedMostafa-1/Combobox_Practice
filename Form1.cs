using Combox_Practice.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combox_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = Resources.Boy;
                lblTitel.Text = "Boy";
            }

            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Resources.Girl;
                lblTitel.Text = "Girl";
            }

            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Resources.Book;
                lblTitel.Text = "Book";
            }

            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = Resources.Pen;
                lblTitel.Text = "Pen";
            }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }
    }
}
