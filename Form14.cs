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

namespace UYKiosk
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        StringBuilder sb = new StringBuilder();
        public static string Account = null;
        private void btn0_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("0").ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("1").ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("2").ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("3").ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("4").ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("5").ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("6").ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("7").ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("8").ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Append("9").ToString();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (tbAccount.Text.Length != 0)
                tbAccount.Text = sb.Remove(tbAccount.Text.Length - 1, 1).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbAccount.Text = sb.Clear().ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show(); Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (long.Parse(tbAccount.Text) != 0 && tbAccount.Text.Length >= 10 && tbAccount.Text.Length <= 14)
                {
                    Account = tbAccount.Text;
                    Form7 form7 = new Form7();
                    form7.Show(); Close();
                }
                else
                {
                    MessageBox.Show("10 ~ 14자의 계좌번호를 입력하시오");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
