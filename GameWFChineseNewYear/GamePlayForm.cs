using System;
using System.Threading;
using System.Windows.Forms;

namespace GameWFChineseNewYear
{
    public partial class GamePlayForm : Form
    {
        //private Chinese Chinese;

        public Chinese Chinese { get; set; }
        public MainForm MainForm { get; private set; }
        public World World { get; private set; }


        public GamePlayForm( MainForm mainForm, Thread thread)
        {
            InitializeComponent();
            label.Parent = pictureBox1;
            buttonFeedChinece.Parent = pictureBox1;
            buttonSleepChinece.Parent = pictureBox1;

            World = new World(this);
            Chinese = World.Chinese;


            //Запускаем World в другом потоке 
            //Это необходимо для: читабельности, прогрузки формы, быстродействия
            Thread t = new Thread(Go);
            Control.CheckForIllegalCrossThreadCalls = false;
            t.Start();

            MainForm = mainForm;
        }
        private void Go()
        {
            World.RunTheWorld();
        }



        private void ButtonFeedChinece_Click(object sender, EventArgs e)
        {
            Chinese.Immunity.BoostImmunity(3);
        }

        private void ButtonSleepChinece_Click(object sender, EventArgs e)
        {
            Chinese.Immunity.BoostImmunity(10);
        }

        private void GamePlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Dispose();
            Application.Exit();

        }
    }
}
