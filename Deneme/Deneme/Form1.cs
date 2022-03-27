using Deneme.Properties;
namespace Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            difficulty.Text = Settings.Default["Difficulty"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //difficulty.Text = Settings.Default["Difficulty"].ToString();
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            difficulty.Text = easyBtn.Text;
            Settings.Default["Difficulty"] = easyBtn.Text;
            Settings.Default.Save();
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            difficulty.Text = normalBtn.Text;
            Settings.Default["Difficulty"] = normalBtn.Text;
            Settings.Default.Save();
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            difficulty.Text = hardBtn.Text;
            Settings.Default["Difficulty"] = hardBtn.Text;
            Settings.Default.Save();
        }
    }
}