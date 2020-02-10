using System;
using System.Threading;
using System.Windows.Forms;

namespace GameWFChineseNewYear
{
    class World
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
            while (!Chinese.IsDead)
            {
                LifeCycle(Chinese);
                Thread.Sleep(1000);
            }
            Application.Exit();
        }

        private static void LifeCycle(Chinese chineseMan)
        {
            var currentVirus = EvaluateVirus();
            currentVirus.Attack(chineseMan);
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
