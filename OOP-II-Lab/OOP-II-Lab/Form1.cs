using OOP_II_Lab.Properties;
namespace OOP_II_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = usernameText;
            usernameText.Text = Settings.Default["username"].ToString();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            
            
            
            if (usernameText.Text == "admin" && passwordText.Text == "admin")
            {
                new Form2().Show();
                this.Hide();

                string user;

                user=usernameText.Text;
                Settings.Default["username"] = user;
                Settings.Default.Save();


            }

            else if (usernameText.Text == "user" && passwordText.Text == "user")
            {
                new Form2().Show();
                this.Hide();

                string user;

                user = usernameText.Text;
                Settings.Default["username"] = user;
                Settings.Default.Save();



               

            }

            else
            {
                MessageBox.Show("Kullanici Adi yada Sifre hatali");
           
           }
        
        
        
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                passwordText.PasswordChar = '\0';
            }
            //deðilse karakterlerin yerine * koy.
            else
            {
                passwordText.PasswordChar = '*';
            }
        }
    }
}