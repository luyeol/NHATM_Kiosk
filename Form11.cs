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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value.ToString() != "0" || numericUpDown2.Value.ToString() != "0")
            {
                Form1.pay += int.Parse(numericUpDown1.Value.ToString()) * 5;
                Form1.pay += int.Parse(numericUpDown2.Value.ToString());
                Form12 form12 = new Form12();
                form12.Show();
                Close();
                
            }
            else
                MessageBox.Show("입금 금액을 입력하세요.");
        }
    }
}
