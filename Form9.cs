using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UYKiosk
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        StringBuilder sb = new StringBuilder();
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("1").ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("2").ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("3").ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("4").ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("5").ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("6").ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("7").ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("8").ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("9").ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Append("0").ToString();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            //공백시 예외처리
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = sb.Remove(textBox1.Text.Length - 1, 1).ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = sb.Clear().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //한도설정
            if(textBox1.Text.Length != 0 && int.Parse(textBox1.Text) != 0)
            {
                if(int.Parse(textBox1.Text) <= 600)
                {
                    Form1.pay = int.Parse(textBox1.Text);
                    if (Form2.StartOption == 2)  //출금 시
                    {
                        Form8 form8 = new Form8();
                        form8.Show();
                    }
                    if (Form2.StartOption == 3)  //계좌이체 시
                    {
                        Form15 form15 = new Form15();
                        form15.Show();
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("일일 이체한도(600만) 초과입니다.");
                    textBox1.Text = sb.Clear().ToString();
                }
            }
        }
    }
}
