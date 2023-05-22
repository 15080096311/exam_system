using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private const int N = 20; //题量
        private string[] single_question;
        private string[] single_question_answer;
        private string[] multiple_question;
        private int[] multiple_question_answer;
        private string path_single;
        private string path_multiple;
        private int single_number = 0 ;
        private int multiple_number = 0;
        private int cur_num1 = 1;
        private int cur_num2 = 1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.Text = "考试系统   当前考生:" + Class1.kh;
            int j;
            string cur_question;
            single_question = new string[N];
            single_question_answer = new string[N];
            multiple_question = new string[N];
            multiple_question_answer = new int[N];
            path_single = "..\\..\\text\\dxt1.txt";
            path_multiple = "..\\..\\text\\duoxt1.txt";
            button1.Enabled = false;
            button3.Enabled = false;
            try
            {
                FileStream file_single_question, file_multiple_question;
                file_single_question = new FileStream(path_single, FileMode.Open, FileAccess.Read);
                file_multiple_question = new FileStream(path_multiple, FileMode.Open, FileAccess.Read);
                StreamReader read_single, read_multiple;
                read_single = new StreamReader(file_single_question, Encoding.Default);
                read_multiple = new StreamReader(file_multiple_question, Encoding.Default);
                for (j = 0; j < N; j++)
                {
                   
                    cur_question = read_single.ReadLine();
                    cur_question = cur_question + "\r\n" + read_single.ReadLine();
                    single_question[j] = cur_question;
                    single_question_answer[j] = read_single.ReadLine();



                }
                for (j = 0; j < N; j++)
                {
                    
                    cur_question = read_multiple.ReadLine();
                    cur_question = cur_question + "\r\n" + read_multiple.ReadLine();
                    multiple_question[j] = cur_question;
                    multiple_question_answer[j] = Convert.ToInt16(read_multiple.ReadLine());
                }
                label1.Text = "当前题号" + cur_num1;
                label2.Text = "当前题号" + cur_num2;
                read_single.Close();
                read_multiple.Close();
                file_single_question.Close();
                file_multiple_question.Close();
                textBox1.Text = single_question[0];
                textBox2.Text = multiple_question[0];
            }
            catch(Exception ee)
            {
                MessageBox.Show("文件不存在");
            }
            finally
            {

            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (single_number > 0 && single_number <= 19)
            {
                single_number--;
                textBox1.Text = single_question[single_number];
            }
            if (single_number == 0)
            {
                button1.Enabled = false;
            }
            if (single_number != 19)
            {
                button2.Enabled = true;
            }
             cur_num1 --;
            label1.Text = "当前题号" +  cur_num1 ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                single_question_answer[single_number] = "a";
                radioButton1.Checked = false;
            }

            if (radioButton2.Checked)
            {
                single_question_answer[single_number] = "b";
                radioButton2.Checked = false;
            }

            if (radioButton3.Checked)
            {
                single_question_answer[single_number] = "c";
                radioButton3.Checked = false;
            }

            if (radioButton4.Checked)
            {
                single_question_answer[single_number] = "d";
                radioButton4.Checked = false;
            }


                if (single_number <19 && single_number >= 0)
            {
                single_number++;
                textBox1.Text = single_question[single_number];
            }
            if (single_number != 0)
            {
                button1.Enabled = true;
            }

             if (single_number >= 19)
            {
                button2.Enabled = false;


            }
            cur_num1 ++;
            label1.Text = "当前题号" + cur_num1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (multiple_number > 0 && multiple_number <= 19)
            {
                multiple_number--;
                textBox2.Text =multiple_question[multiple_number];
            }
            if (multiple_number == 0)
            {
                button3.Enabled = false;
            }
            if (multiple_number != 19)
            {
                button4.Enabled = true;
            }
            cur_num2--;
            label2.Text = "当前题号" + cur_num2;
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                multiple_question_answer[multiple_number] = multiple_question_answer[multiple_number] + 1;
                checkBox1.Checked = false;
            }

            if (checkBox2.Checked)
            {
                multiple_question_answer[multiple_number] = multiple_question_answer[multiple_number] + 2;
                checkBox2.Checked = false;
            }

            if (checkBox3.Checked)
            {
                multiple_question_answer[multiple_number] = multiple_question_answer[multiple_number] + 4;
                checkBox3.Checked = false;
            }

            if (checkBox4.Checked)
            {
                multiple_question_answer[multiple_number] = multiple_question_answer[multiple_number] + 8;
                checkBox4.Checked = false;
            }

            if (multiple_number >= 0 && multiple_number < 19)
            {
                multiple_number++;
                textBox2.Text = multiple_question[multiple_number];
            }
             if (multiple_number != 0)
            {
                button3.Enabled = true;
            }
            if (multiple_number == 19)
            {
                button4.Enabled = false;
            }
            cur_num2++;
            label2.Text = "当前题号" + cur_num2;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
