using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace GameWFChineseNewYear
{
    public partial class MainForm : Form
    {
         
        private static GamePlayForm gamePlayForm = new GamePlayForm();
        private static World world = new World(gamePlayForm);

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStartGame_MouseEnter(object sender, EventArgs e)
        {
            buttonStartGame.Size = new Size(260, 60);
        }

        private void buttonStartGame_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStartGame.Size = new Size(250, 50);
        }

        private void buttonStartGame_MouseUp(object sender, MouseEventArgs e)
        {
            buttonStartGame.Size = new Size(260, 60);
        }

        private void buttonStartGame_MouseLeave(object sender, EventArgs e)
        {
            buttonStartGame.Size = new Size(255, 55);
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            gamePlayForm.Chinese = world.Chinese;
            
            gamePlayForm.Show();
            gamePlayForm.Refresh();

            Thread t = new Thread(Go);
            Control.CheckForIllegalCrossThreadCalls = false;
            t.Start();
        }

        private void Go()
        {
            world.RunTheWorld();
        }
    }
}
