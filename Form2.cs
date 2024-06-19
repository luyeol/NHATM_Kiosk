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

namespace UYKiosk
{
    public partial class Form2 : Form
    {
        public static Form16 form16 = new Form16();
        public Form2()
        {
            InitializeComponent();
        }
        public static int StartOption = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            StartOption = 1; //입금
            Form3 form3 = new Form3();
            form3.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //처음으로
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartOption = 3; //계좌이체
            Form4 form4 = new Form4();
            form4.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartOption = 2; //출금
            Form3 form3 = new Form3();
            form3.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                StartOption = 4; //조회
                form16.Show();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
