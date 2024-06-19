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
    public partial class Form3 : Form
    {
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        Form6 form6 = new Form6();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
