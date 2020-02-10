using System;
using System.Windows.Forms;

namespace GameWFChineseNewYear
{
    public partial class GamePlayForm : Form
    {
        //private Chinese Chinese;

        public Chinese Chinese { get; set; }

        public GamePlayForm()
        {
            InitializeComponent();
            label.Parent = pictureBox1;
            buttonFeedChinece.Parent = pictureBox1;
            buttonSleepChinece.Parent = pictureBox1;
        }

        private void ButtonFeedChinece_Click(object sender, EventArgs e)
        {
            Chinese.Immunity.BoostImmunity(3);
        }

        private void ButtonSleepChinece_Click(object sender, EventArgs e)
        {
            Chinese.Immunity.BoostImmunity(10);
        }
    }
}
