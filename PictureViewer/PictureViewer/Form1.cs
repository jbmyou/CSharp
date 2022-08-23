using System;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World! 1 ";
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World! 2 ";
        }
        private void backgroundButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World! 3 ";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World! 4 ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
