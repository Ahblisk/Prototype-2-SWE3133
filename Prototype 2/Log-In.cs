namespace Prototype_2
{
    /// -----------COLOR PALLETE ------------ ///
    ///
    ///Color Hex ARGB
    ///White #E4E6F3 (1, 228, 230, 243)
    ///Yellow #F4F880 (1, 224, 248, 128)
    ///Light Orange #F2A60A (1, 242, 166, 10)
    ///Dark Orange #D7620F (1, 215, 98, 15)
    ///Dark Red #961B06 (1, 150, 27, 6)


    public partial class login : Form
    {
        // basic log in functionality
        string admin_username = "admin";
        string admin_password = "password";

        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text == "admin" && this.richTextBox2.Text == "password")
            {

            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}