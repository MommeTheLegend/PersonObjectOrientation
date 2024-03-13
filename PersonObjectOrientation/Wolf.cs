namespace PersonObjectOrientation
{
    internal class Wolf : Animal
    {
        private int nrOfPrey { set; get; }
        public Wolf(string aName, double aWeight, int aAge, int preyAmount) : base(aName, aWeight, aAge)
        {
            this.nrOfPrey = preyAmount;
        }
        public override void DoSound()
        {
            Console.WriteLine("I am howling, growling or barking");
        }
        internal override string Stats()
        {
            return base.Stats() + $"The number of prey I am devouring is: {this.nrOfPrey} ";
        }
    }
    internal interface IPerson
    {
        void Talk();
    }
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string aName, double aWeight, int aAge, int preyAmount) : base(aName, aWeight, aAge, preyAmount)
        {
        }
        public void Talk()
        {
            Console.WriteLine("Hello there, please do not experience any dread " +
                ", these claws won't hurt you");
        }
        public override void DoSound()
        {
            base.DoSound();
            Console.WriteLine("and able to perform a sophisticated conversation " +
                ", rather, fluently.");
        }
        internal override string Stats()
        {
            return base.Stats();
        }
    }
}
