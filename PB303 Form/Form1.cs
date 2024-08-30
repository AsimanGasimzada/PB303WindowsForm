using PB303_Form.Models;

namespace PB303_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname=FullnameInput.Text;

            if (fullname.Length < 3)
            {
                MessageBox.Show("Minimum uzunluq 3 olmalidir");
                return;
            }

            int age = 0;

            if(!int.TryParse(AgeInput.Text, out age) || age<0)
            {
                MessageBox.Show("Duzgun deyer daxil edin");
                return;
            }

            Person person = new(fullname,age);

            listBox1.Items.Add(person);

            FullnameInput.Text = "";
            AgeInput.Text = "";

            MessageBox.Show("User successfully created");
            
            
        }
    }
}
