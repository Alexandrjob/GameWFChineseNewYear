using System;
using System.Collections.Generic;
using System.Text;

namespace GameWFChineseNewYear
{
    class Virus
    {
        public int Damage { get; protected set; } = 2;
        public string VirusName { get; protected set; } = "Virus";

        public void Attack(Chinese chinese)
        {
            chinese.DefenseImmunity(Damage, this);
        }

    }
}
