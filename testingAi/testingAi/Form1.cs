namespace testingAi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Subscriber t = new Subscriber();
            t.Id = 1;
            t.Description = "Test";
            t.Name = "Test";
            t.ConnectionStatus = Status.Connected;
            MessageBox.Show(t.ConnectionStatus.ToString());
        }
    }
}
