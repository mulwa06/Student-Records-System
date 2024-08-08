namespace Part2_Task2_
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Hide();

            Records records = new Records();
            records.Show();
        }
    }
}
