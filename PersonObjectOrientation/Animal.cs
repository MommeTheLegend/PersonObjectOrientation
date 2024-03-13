using System.Drawing;

namespace PersonObjectOrientation
{
    internal abstract class Animal
    {
        private string name;
        public string Name { set; get; }

        private double weight;
        public double Weight { set; get; }

        private int age;
        public int Age { set; get; }

        public abstract void DoSound();

        //Testar fieldsen och kontruktorn
        public Animal(string aName, double aWeight, int aAge)
        {
            Name = aName;
            Weight = aWeight;
            Age = aAge;
        }
        //3.4 Mer polymorfism 
        internal virtual string Stats()
        {
            return $"{this.GetType()}'s attributes are: \n" +
                $"The name: {this.Name}\n" +
                $"The weight: {this.Weight} kg\n" +
                $"The age: {this.Age} years old \n";
        }
        public override string ToString()
        {
            return $"{this.GetType}";
        }
    }
    internal class Horse : Animal
    {
        private double RunningSpeed { set; get; }
        //Stoppar inget ikroppen ännu
        public Horse(string aName, double aWeight, int aAge, double speed) : base(aName, aWeight, aAge)
        {
            this.RunningSpeed = speed;
        }
        public override void DoSound()
        {
            Console.WriteLine("I am neighing");
        }
        internal override string Stats()
        {
            return base.Stats() + $"The running speed of the horse: {this.RunningSpeed} ";
        }
    }
    internal class Dog : Animal
    {
        private string Breed { set; get; }

        public Dog(string aName, double aWeight, int aAge, string aBreed) : base(aName, aWeight, aAge)
        {
            this.Breed = aBreed;
        }
        internal override string Stats()
        {
            return base.Stats() + $"The breed is: {this.Breed} ";
        }
        public override void DoSound()
        {
            Console.WriteLine("I am barking or whimpering");
        }
        public string randomMethod()
        {
            return "Let us test polymorphism";
        }
    }
    internal class Hedgehog : Animal
    {
        private int NrOfSpikes { set; get; }
        public Hedgehog(string aName, double aWeight, int aAge, int nrSpikes) : base(aName, aWeight, aAge)
        {
            this.NrOfSpikes = nrSpikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("something");
        }
        internal override string Stats()
        {
            return base.Stats() + $"The totalamount of spikes are: {NrOfSpikes}";
        }
    }
    internal class Worm : Animal
    {
        private Color ColorOfWorm { set; get; }
        public Worm(string aName, double aWeight, int aAge, Color aColor) : base(aName, aWeight, aAge)
        {
            this.ColorOfWorm = aColor;
        }
        public override void DoSound()
        {
            Console.WriteLine("ssssssss");
        }
        internal override string Stats()
        {
            return base.Stats() + $"The color of the worm is: {ColorOfWorm}";
        }
    }

}
