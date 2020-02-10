using System;
using System.Windows.Forms;

namespace GameWFChineseNewYear
{
    public partial class GamePlayForm : Form
    {
        public GamePlayForm()
        {
            InitializeComponent();
            label.Parent = pictureBox1;
            buttonFeedChinece.Parent = pictureBox1;
            buttonSleepChinece.Parent = pictureBox1;
        }

        private void buttonFeedChinece_Click(object sender, EventArgs e)
        {

        }
    }
}
