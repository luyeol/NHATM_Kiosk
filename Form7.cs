using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace UYKiosk
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Form8 form8 = new Form8();
        Form15 form15 = new Form15();
        private void btn3_Click(object sender, EventArgs e)
        {
            Form1.pay = 3;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Form1.pay = 5;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Form1.pay = 10;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Form1.pay = 15;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Form1.pay = 20;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            Form1.pay = 30;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            Form1.pay = 40;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            Form1.pay = 50;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btn70_Click(object sender, EventArgs e)
        {
            Form1.pay = 70;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            Form1.pay = 100;
            if (Form2.StartOption == 2) //출금 시
                form8.Show();
            if (Form2.StartOption == 3)  //계좌이체시
                form15.Show();
            Close();
        }

        private void btnElse_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Form2.StartOption == 2) //출금
            {
                Form2 form2 = new Form2();
                form2.Show(); 
            }
            if (Form2.StartOption == 3) //계좌이체
            {
                Form13 form13 = new Form13();
                form13.Show(); 
            }
            Close();
        }
    }
}
