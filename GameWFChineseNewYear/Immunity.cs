namespace GameWFChineseNewYear
{
    public class Immunity
    {
        private readonly int extaDamage = 1;
        private int percentageOfImmunity;

        public bool IsInFected { get; set; }
        public Virus NameInfactedVirus { get; set; }

        public int PercentageOfImmunity
        {
            get { return percentageOfImmunity; }
            set
            {
                if (value < 0)
                {
                    percentageOfImmunity = 0;
                }
                else if (value > 1000)
                {
                    percentageOfImmunity = 100;
                }
                else percentageOfImmunity = value;
            }
        }

        public Immunity(int percentageOfImmunity, Virus virus, bool isInfected)
        {
            PercentageOfImmunity = percentageOfImmunity;
            NameInfactedVirus = virus;
            IsInFected = isInfected;
        }
        public void Defence(int damage, Chinese chinese, Virus virus)
        {
            DecreaseImmunity(damage, chinese);

            if (PercentageOfImmunity <= 40 && NameInfactedVirus == null)
            {
                IsInFected = true;
                NameInfactedVirus = virus;
            }
        }

        private void DecreaseImmunity(int percent, Chinese chinese)
        {
            if (NameInfactedVirus != null)
            {
                PercentageOfImmunity -= NameInfactedVirus.Damage + extaDamage;
            }
            else
            {
                PercentageOfImmunity -= percent;
            }

            if (PercentageOfImmunity == 0)
                chinese.KillTheChinese();
        }

        public void BoostImmunity(int percent)
        {
            PercentageOfImmunity += percent;
        }
    }
}
