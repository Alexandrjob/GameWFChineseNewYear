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
        public static World World { get; private set; }

        private Thread t = new Thread(Go);

        public GamePlayForm( MainForm mainForm, Thread thread)
        {
            InitializeComponent();
            label.Parent = pictureBox1;
            buttonFeedChinece.Parent = pictureBox1;
            buttonSleepChinece.Parent = pictureBox1;

            World = new World(this);
            Chinese = World.Chinese;
            MainForm = mainForm;

            //Запускаем World в другом потоке 
            //Это необходимо для: читабельности, прогрузки формы, быстродействия
            
            t.Priority = ThreadPriority.Lowest;
            Control.CheckForIllegalCrossThreadCalls = false;
            t.Start();     
            //Go();
        }
        private static void Go() =>World.RunTheWorld();

        private void ButtonFeedChinece_Click(object sender, EventArgs e)
        {
            Chinese.Immunity.BoostImmunity(3);
            Chinese.OutputInformation();
        }

        private void ButtonSleepChinece_Click(object sender, EventArgs e)
        {
            Chinese.Immunity.BoostImmunity(8);
        }

        private void GamePlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
            MainForm.Dispose();
            Application.Exit();
        }
    }
}
