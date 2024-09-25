using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testingAi
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Implement submit functionality here
            MessageBox.Show("Form submitted!");
        }
    }
}
