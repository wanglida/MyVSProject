using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELLOWORLD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbxHello.Hide();
            lbl1.Hide();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxHello.Show();
            lbl1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("(MessageBox.Show())\nWindows Forms 学习，从此开始。\nWanglida6@hotmail.com\n");
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowWindow_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();//Form2是个新的类，要新建它的对象，才能在当前控件操作它
            frm2.Show();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            FormFile ff = new FormFile();
            ff.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
