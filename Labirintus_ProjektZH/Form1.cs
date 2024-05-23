namespace Labirintus_ProjektZH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GameForm gameform = new GameForm();
            gameform.ShowDialog();
        }
    }
}
