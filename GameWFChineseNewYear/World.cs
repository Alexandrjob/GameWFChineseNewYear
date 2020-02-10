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

        public void RunTheWorld(GamePlayForm gamePlayForm)
        {
            int minPercentageOfImmunity = 50;
            int maxPercentageOfImmunity = 100;
            int percentageOfImmunity;

            percentageOfImmunity = random.Next(minPercentageOfImmunity, maxPercentageOfImmunity);
            Chinese chineseMan = new Chinese(gamePlayForm, percentageOfImmunity);

            while (!chineseMan.IsDead)
            {
                LifeCycle(chineseMan);
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
