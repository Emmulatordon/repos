using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsfdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmForm2 = new Form2();
            frmForm2.TopLevel = false;
            panelMain.Controls.Add(frmForm2);
            frmForm2.BringToFront();
            frmForm2.Show();
        }
    }
}
