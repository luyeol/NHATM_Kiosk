using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UYKiosk
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int pw_cnt = 0;
        StringBuilder sb = new StringBuilder();
        private void btn1_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("1").ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("2").ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("3").ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("4").ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("5").ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("6").ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("7").ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("8").ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("9").ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (pw_cnt < 5)
                tbPassword.Text = sb.Append("0").ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbPassword.Text = sb.Clear().ToString();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            //다지웠을 때 예외처리
            if (tbPassword.Text.Length != 0)
                tbPassword.Text = sb.Remove(tbPassword.Text.Length - 1, 1).ToString();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length == 4)
            {
                pw_cnt++;
                if (pw_cnt > 4) //비밀번호 시도횟수 초과
                {
                    MessageBox.Show("🚨🚨🚨🚨🚨비밀번호 5회 불일치.🚨🚨🚨🚨🚨\n 확인 버튼을 누르면 처음으로 돌아갑니다.");
                    Close();
                }
                if (tbPassword.Text == "1111")
                {
                    if (Form2.StartOption == 2)
                    {
                        Form7 form7 = new Form7();
                        form7.Show();
                    }
                    if (Form2.StartOption == 3)
                    {
                        Form13 form13 = new Form13();
                        form13.Show();
                    }
                    Close();
                }
                else
                {
                    tbPassword.Text = sb.Clear().ToString();
                }
            }
        }
    }
}
