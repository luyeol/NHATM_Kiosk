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
    public partial class Form16 : Form
    {
        public static Form16 form16;
        public Form16()
        {
            InitializeComponent();
            form16 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
