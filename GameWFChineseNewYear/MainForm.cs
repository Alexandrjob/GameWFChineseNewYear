using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameWFChineseNewYear
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            GamePlayForm gamePlayForm = new GamePlayForm(this, null);

            this.Visible = false;

            gamePlayForm.Show();
            gamePlayForm.Refresh();
        }

        private void buttonStartGame_MouseEnter(object sender, EventArgs e)
        {
            buttonStartGame.Location = new Point(250, 305);
        }

        private void buttonStartGame_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStartGame.Location = new Point(250, 310);
        }

        private void buttonStartGame_MouseUp(object sender, MouseEventArgs e)
        {
            buttonStartGame.Location = new Point(250, 310);
        }

        private void buttonStartGame_MouseLeave(object sender, EventArgs e)
        {
            buttonStartGame.Location = new Point(250, 300);
        }
    }
}
