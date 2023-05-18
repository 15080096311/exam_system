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
            try
            {
                FileStream file_single_question, file_multiple_question;
                file_single_question = new FileStream("C://Users//Administrator//Desktop//c#//考试系统//dxt1.txt", FileMode.Open, FileAccess.Read);
                file_multiple_question = new FileStream("C://Users//Administrator//Desktop//c#//考试系统//duoxt1.txt", FileMode.Open, FileAccess.Read);
                StreamReader read_single, read_multiple;
                read_single = new StreamReader(file_single_question, Encoding.Default);
                read_multiple = new StreamReader(file_multiple_question, Encoding.Default);
                for (j = 0; j < N; j++)
                {
                    /*s = r.ReadLine();
                    s = s + "\r\n" + r.ReadLine();
                    dxt[j] = s;
                    dxt1[j] = r.ReadLine();
                    */
                    //读题目
                    cur_question = read_single.ReadLine();
                    cur_question = cur_question + "\r\n" + read_single.ReadLine();
                    single_question[j] = cur_question;
                    single_question_answer[j] = read_single.ReadLine();



                }
                for (j = 0; j < N; j++)
                {
                    /* s  = r1.ReadLine();
                    s = s + "\r\n" + r1.ReadLine();
                    duoxt[j] = s;
                    duoxt1[j] = Convert.ToInt16(r1.ReadLine());
                    */
                    cur_question = read_multiple.ReadLine();
                    cur_question = cur_question + "\r\n" + read_multiple.ReadLine();
                    multiple_question[j] = cur_question;
                    multiple_question_answer[j] = Convert.ToInt16(read_multiple.ReadLine());
                }
                read_single.Close();
                read_multiple.Close();
                file_single_question.Close();
                file_multiple_question.Close();
                textBox1.Text = single_question[5];
                textBox2.Text = multiple_question[5];
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
    }
}
