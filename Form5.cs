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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Form2.StartOption == 1) //입금 선택 시
            {
                Form11 form11 = new Form11();
                form11.Show();
            }
            if (Form2.StartOption == 2 || Form2.StartOption == 3) //출금/계좌이체 선택 시
            {
                Form6 form6 = new Form6();  //password 입력 창
                form6.Show();
            }
            Close();
        }
    }
}
