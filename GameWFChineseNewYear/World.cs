using System;
using System.Threading;
using System.Windows.Forms;

namespace GameWFChineseNewYear
{
    public class World
    {
        private static Random random = new Random();
        private static CoronaVirus coronaVirus = new CoronaVirus();
        private static Virus virus = new Virus();

        private int minPercentageOfImmunity = 50;
        private int maxPercentageOfImmunity = 100;
        private int percentageOfImmunity;

        public Chinese Chinese { get; private set; }

        public World(GamePlayForm gamePlayForm)
        {
            percentageOfImmunity = random.Next(minPercentageOfImmunity, maxPercentageOfImmunity);
            Chinese = new Chinese(gamePlayForm, percentageOfImmunity);
        }

        public void RunTheWorld()
        {
            //TimerCallback tm = new TimerCallback(LifeCycle);
            //Timer timer = new Timer(tm, null, 1000, 500);

            while (!Chinese.IsDead)
            {
                LifeCycle(Chinese);
                Thread.Sleep(1000);
            }
            Application.Exit();
            

        }

        private void LifeCycle(object sender)
        {
            var currentVirus = EvaluateVirus();
            currentVirus.Attack(Chinese);
        }

        private static Virus EvaluateVirus()
        {
            if (random.Next(1, 3) == 1)
            {
                return virus;
            }
            return coronaVirus;
        }
    }
}
