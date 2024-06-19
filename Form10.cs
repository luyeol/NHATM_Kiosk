using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace UYKiosk
{
    public partial class Form10 : Form
    {
        string SO = "";
        public Form10()
        {
            InitializeComponent();
        }
       
        private void Form10_Load(object sender, EventArgs e)
        {
            int nh = Form13.BankName == "농협" ? 0 : 400;

            lbDeal.Text = String.Format("{0:0,0}", (Form1.pay * 10000));
            if (Form2.StartOption == 1) //입금
                Form1.Balance += Form1.pay * 10000;
            if (Form2.StartOption == 2) //출금
                Form1.Balance -= Form1.pay * 10000;
            if (Form2.StartOption == 3) //계좌이체
            {
                Form1.Balance -= Form1.pay * 10000 + nh;
                lbCharge.Text = nh.ToString();
            }
            lbBalance.Text = String.Format("{0:0,0}", Form1.Balance);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int nh = 0;

            if (Form2.StartOption == 1)
                SO = "입금";
            if (Form2.StartOption == 2)
                SO = "출금";
            if (Form2.StartOption == 3)
            {
                nh = Form13.BankName == "농협" ? 0 : 400;
                SO = Form13.BankName + " 이체";
            }
            try
            {
                if(Form16.form16 != null)
                {
                    Form16.form16.listView1.Items.Add(new ListViewItem(new String[] { DateTime.Now.ToShortDateString(), String.Format("{0:0,0}", Form1.pay * 10000), String.Format("{0:0,0}", Form1.Balance), nh.ToString(), SO }));
                    Close();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
