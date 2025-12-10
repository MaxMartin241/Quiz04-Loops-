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

        private void q1Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                q1OutputLabel.Text += "HO HO HO!";
            }
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            int numOfTimes = 0;
            while (numOfTimes < 5)
            {
                q2OutputLabel.Text += "HO HO HO!";
                numOfTimes++;
            }
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            int numOfTimes = 0;
            int inputNum = Convert.ToInt16(q4TextBox.Text);
            try
            {
                while (numOfTimes < inputNum)
                {
                    q4OutputLabel.Text += "HO HO HO!";
                    numOfTimes++;
                }
            }
            catch
            {
                q4OutputLabel.Text = "Enter an integer";
            }
        }

        private void q5Button_Click(object sender, EventArgs e)
        {
            int t = 1;
            int f = 0;
            for(int i = 0;i < 4;i++)
            {
                for(int j = 0;j < t;j++)
                {
                    

                q5OutputLabel.Text += t + i;
                    
                   
                }
                t++;
                
                q5OutputLabel.Text += "\n";
            }
        }
    }
}
