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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public static string BankName = null;
        public void btn_INIT()
        {
            btnBank1.BackColor = Color.YellowGreen;
            btnBank2.BackColor = Color.YellowGreen;
            btnBank3.BackColor = Color.YellowGreen;
            btnBank4.BackColor = Color.YellowGreen;
            btnBank5.BackColor = Color.YellowGreen;
            btnBank6.BackColor = Color.YellowGreen;
            btnBank7.BackColor = Color.YellowGreen;
            btnBank8.BackColor = Color.YellowGreen;
            btnBank9.BackColor = Color.YellowGreen;
            btnBank10.BackColor = Color.YellowGreen;
        }
        private void btnBank1_Click(object sender, EventArgs e)
        {
            BankName = btnBank1.Text;
            btn_INIT();
            btnBank1.BackColor = Color.LimeGreen;
        }

        private void btnBank2_Click(object sender, EventArgs e)
        {
            BankName = btnBank2.Text;
            btn_INIT();
            btnBank2.BackColor = Color.LimeGreen;
        }

        private void btnBank3_Click(object sender, EventArgs e)
        {
            BankName = btnBank3.Text;
            btn_INIT();
            btnBank3.BackColor = Color.LimeGreen;
        }

        private void btnBank4_Click(object sender, EventArgs e)
        {
            BankName = btnBank4.Text;
            btn_INIT();
            btnBank4.BackColor = Color.LimeGreen;
        }

        private void btnBank5_Click(object sender, EventArgs e)
        {
            BankName = btnBank5.Text;
            btn_INIT();
            btnBank5.BackColor = Color.LimeGreen;
        }

        private void btnBank6_Click(object sender, EventArgs e)
        {
            BankName = btnBank6.Text;
            btn_INIT();
            btnBank6.BackColor = Color.LimeGreen;
        }

        private void btnBank7_Click(object sender, EventArgs e)
        {
            BankName = btnBank7.Text;
            btn_INIT();
            btnBank7.BackColor = Color.LimeGreen;
        }

        private void btnBank8_Click(object sender, EventArgs e)
        {
            BankName = btnBank8.Text;
            btn_INIT();
            btnBank8.BackColor = Color.LimeGreen;
        }

        private void btnBank9_Click(object sender, EventArgs e)
        {
            BankName = btnBank9.Text;
            btn_INIT();
            btnBank9.BackColor = Color.LimeGreen;
        }

        private void btnBank10_Click(object sender, EventArgs e)
        {
            BankName = btnBank10.Text;
            btn_INIT();
            btnBank10.BackColor = Color.LimeGreen;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (BankName != null)
            {
                Form14 form14 = new Form14();
                form14.Show(); Close();
            }
            else
                MessageBox.Show("은행을 선택하세요");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); Close();
        }
    }
}
