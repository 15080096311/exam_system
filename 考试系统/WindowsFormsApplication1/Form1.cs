using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("考好和密码不能为空");
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim() == "1234")
            {
                Class1.kh = textBox1.Text;
                this.Hide();
                Form2 f = new Form2();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("密码错误");

                textBox2.Text = "";
                textBox2.Focus();
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("退出否？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
                e.Cancel = true;
        }
    }
    }
