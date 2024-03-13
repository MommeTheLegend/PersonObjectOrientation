namespace PersonObjectOrientation
{
    internal class Bird : Animal
    {
        private int WingSpan { set; get; }
        public Bird(string aName, double aWeight, int aAge, int nrOfSpans) : base(aName, aWeight, aAge)
        {
            this.WingSpan = nrOfSpans;
        }
        public override void DoSound()
        {
            Console.WriteLine("I am chirping");
        }
        internal override string Stats()
        {
            return base.Stats() + $"The wing span is: {WingSpan}\n";
        }
    }
    internal class Pelican : Bird
    {
        public Pelican(string aName, double aWeight, int aAge, int nrOfSpans) : base(aName, aWeight, aAge, nrOfSpans)
        {
        }
        public override void DoSound()
        {
            base.DoSound();
        }
        internal override string Stats()
        {
            return base.Stats();
        }
    }
    internal class Flamingo : Bird
    {
        private string nestType { set; get; }
        public Flamingo(string aName, double aWeight, int aAge, int nrOfSpans, string aNestType) : base(aName, aWeight, aAge, nrOfSpans)
        {
            this.nestType = aNestType;
        }
        public override void DoSound()
        {
            base.DoSound();
        }
        internal override string Stats()
        {
            return base.Stats() + $"The nest type is: {nestType}";
        }
    }
    internal class Swan : Bird
    {
        private double sizeOfGullet { set; get; }
        public Swan(string aName, double aWeight, int aAge, int nrOfSpans, double gulletSize) : base(aName, aWeight, aAge, nrOfSpans)
        {
            this.sizeOfGullet = gulletSize;
        }
        public override void DoSound()
        {
            base.DoSound();
        }
        internal override string Stats()
        {
            return base.Stats() + $"The size of gullet: {sizeOfGullet}";
        }
    }
}
