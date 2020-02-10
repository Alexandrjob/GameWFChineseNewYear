namespace GameWFChineseNewYear
{
    sealed class Chinese
    {
        public Immunity Immunity { get; private set; }
        public bool IsDead { get; private set; }
        public GamePlayForm GamePlayForm { get; private set; }

        public Chinese(GamePlayForm playForm, int percentageOfImmunity = 70, bool isInFected = false, Virus virus = null, bool isDead = false)
        {
            Immunity = new Immunity(percentageOfImmunity, virus, isInFected);
            IsDead = isDead;
            GamePlayForm = playForm;
        }

        public void KillTheChinese()
        {
            IsDead = true;
        }

        public void DefenseImmunity(int damage, Virus virus)
        {
            Immunity.Defence(damage, this, virus);
            GamePlayForm.stateChinece.Text = this.ToString(virus);
            GamePlayForm.stateChinece.Refresh();
        }

        public string ToString(Virus virus)
        {
            GamePlayForm.labelPercentageOfImmunity.Text = Immunity.PercentageOfImmunity.ToString();
            GamePlayForm.labelIsinFacted.Text = Immunity.IsInFected.ToString();
            GamePlayForm.labelVirusName.Text = Immunity.NameInfactedVirus?.VirusName.ToString() ?? virus.VirusName.ToString();

            return string.Format("[ Immunity: {0}%; Damage: {1}; isInfected: {2}; AttackVirusName: {3}; isDead: {4} ]",
                Immunity.PercentageOfImmunity,
                Immunity.NameInfactedVirus?.Damage ?? virus.Damage,
                Immunity.IsInFected, 
                Immunity.NameInfactedVirus?.VirusName ?? virus.VirusName,
                IsDead);
        }
    }
}
