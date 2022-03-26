namespace OOP_II_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = usernameText;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameText.Text == "admin" && passwordText.Text == "admin")
            {
                new Form2().Show();
                this.Hide();
            }

            else if (usernameText.Text == "user" && passwordText.Text == "user")
            {
                new Form2().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanici Adi yada Sifre hatali");
            }
        }
    }
}