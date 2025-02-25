namespace Ytb2GithubTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Resul Bülbül";

            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Hata");
            }
        }
    }
}
