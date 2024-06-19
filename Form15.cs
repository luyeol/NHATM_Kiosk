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
using static System.Windows.Forms.DataFormats;

namespace UYKiosk
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            lbAccount.Text = Form14.Account;
            lbBank.Text = Form13.BankName;
            lbPay.Text = String.Format("{0:0,0}", Form1.pay * 10000);
            lbMemo.Text = Form13.BankName + " 이체";
            if (lbBank.Text != "농협")
                lbCharge.Text = "400";
            else
                lbCharge.Text = "0";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {   
            int nh = Form13.BankName == "농협" ? 0 : 400;

            if (Form1.Balance >= Form1.pay * 10000 + nh)
            {
                Form10 form10 = new Form10();
                form10.Show();
            }
            else
            {
                MessageBox.Show("잔액이 부족합니다.");
                Form7 form7 = new Form7();
                form7.Show();
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show(); Close();
        }
    }
}
