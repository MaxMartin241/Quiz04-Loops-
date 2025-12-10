namespace Quiz04_Loops_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void q1OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            q05 q05 = new q05();
            q05.Show();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("In bonusLabel, answer this question in sentence form:  Provide an example where it would make sense to use a while loop instead of a for loop ");

        }
    }
}
