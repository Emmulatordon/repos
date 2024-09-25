using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticClassDemo
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProduct;
        int num1, num2, sum, product;
        double squareNum1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            GetInfo();

            Rectangle t = new Rectangle();
            t.Width = num1;
            t.Length = num2;
            t.CalcuateArea();
            txtSum.Text = t.area.ToString();
            DisplayInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var student = new Student() {id=1,FirstName="viva",LastName="Dieudonne",Age=12 };
            var student1 = new Student() {id=2,FirstName="viva2",LastName="Dieudonne2",Age=39 };
            var students = new List<Student>() { student, student1 };
            dataGridView2.Rows.Add(1, 12, "hello");
            dataGridView1.DataSource = GetTableCustomers() ;
        }

        private void DisplayInfo()
        {
            txtProduct.Text = product.ToString();
            txtSum.Text = sum.ToString();
            txtNum1Square.Text = squareNum1.ToString();
        }
        private void Calculate()
        {
            sum= num1 + num2;
            product = num1 * num2;
        }
        private void GetInfo()
        {
            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            num2 = int.Parse(txtNum2.Text);
        }
        private DataTable GetTableCustomers()
        {
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));

            //set Primary key
            table.PrimaryKey = new DataColumn[] { table.Columns["Id"] };

            //add data
            table.Rows.Add(1, "Bashi", "Dieudonne");
            table.Rows.Add(2, "Bashi", "Gerard");


            var row = table.NewRow();
            row["id"] = 3;
            row["First Name"] = "Bashi";
            row["Last Name"] = "Rene";
            table.Rows.Add(row);

            //adding an array of object to a datable 
            object[] data = new object[3];
            data[0] = 5;
            data[1] = "Bashi";
            data[2] = "Laura";

            table.Rows.Add(data);

            return table;
        }
    }
}
