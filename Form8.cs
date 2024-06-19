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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            lb5.Text = ((Form1.pay / 5) * 5).ToString();
            lb1.Text = (Form1.pay % 5).ToString();
            lbSum.Text = (int.Parse(lb5.Text) + int.Parse(lb1.Text)).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1.pay = 0;
            if(Form2.StartOption == 1) //입금
            {
                Form11 form11 = new Form11();
                form11.Show(); Close();
            }
            if (Form2.StartOption == 2) //출금
            {
                Form7 form7 = new Form7();
                form7.Show(); Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ((Form1.Balance >= Form1.pay * 10000 && Form2.StartOption == 2) || Form2.StartOption == 1 )
            {
                Form10 form10 = new Form10();
                form10.Show();
            }
            else
            {
                MessageBox.Show("잔액 부족");
                Form7 form7 = new Form7();
                form7.Show();
            }
            Close();
        }
    }
}
