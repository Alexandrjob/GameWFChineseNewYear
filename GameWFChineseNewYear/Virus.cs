namespace GameWFChineseNewYear
{
    public class Virus
    {
        public int Damage { get; protected set; } = 1;
        public string VirusName { get; protected set; } = "Virus";

        public void Attack(Chinese chinese)
        {
            chinese.DefenseImmunity(Damage, this);
        }

    }
}
