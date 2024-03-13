using System.Drawing;
namespace PersonObjectOrientation
{
    internal class Program
    {

        /* Frågorna besvaras här: 
         * Fråga 13: Om eller ifall detta atribut är berör bara 
         * fåglar bör attributet placerasi fågelklasssen, samtliga
         * åtskilliga arter av fåglar kommer ärva detta atribut
         *
         * Fråga 14: Svar: Då bör attributet placeras i Animal klassen.
         * Förklaring: Animal klassen är abstrakt vilket och de andra 
         * klasserna antingen ärver de direkt eller indirekt.
         * 
         * Fråga 9: Typen Dog ärver från basklassen Animal och inte Horse 
         * desamma gäller för Horse vilket innebär att dessa klasser inte har några
         * kopplingar med varandra, bortsett från att de delar samma rot klass.
         * 
         * Fråga 10: Två typer måste de vara, nämligen Animals eller Object. 
         * 
         * Fråga 13: Metoden är virtualvilket innebär att alla subclasser kan 
         * men behöver inte eller är inte nödvändigt att overrida metoden. I
         * detta fall overridar samtliga underclasser metoden och printar ut
         * resultatet antingen direkt genom att ärva eller ärva och konkatenerar 
         * med en egen särskilld attribut.  
         * 
         * Fråga 17: om typen för aDog är Animal kommer man inte åt det, dock
         * om man skiftar på typen från animal till dog i rad 75, kommer man åt det.
         * Måste innebära,tror jag, att tillgängligheten av metoder utförs via typen 
         * och inte vad objektet i heapen faktiskt är.
         */
        static void Main(string[] args)
        {
            // Får error stackoverflow error vid many exceptions vet inte varföroch hur jag ska lösa detta
            //Därför kommenterar jag bort första stycket 
            /*
            Person p1 = new Person();
            try
            {
                p1.Age = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            try
            {
                p1.FirstName = "Test";
                p1.LastName = "Something";
            }
            catch (StackOverflowException ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
            */

            //Kommer åt samtliga properties i Person classen  
            /*
            Console.WriteLine("Let us test something!"); 
            PersonHandler p2 = new PersonHandler();
            Person someone = p2.CreatePerson(30, "Mohamad", "Qutbuddin Habib", 180, 89); 
            Console.WriteLine("Error should occur");
            try
            {
                p2.SetAge(someone, -1);
            }
            catch (ArgumentException ex)
            {
                ex.Message.ToString();
            }
            */


            NumericInputError nError1 = new NumericInputError();
            NumericInputError nError2 = new NumericInputError();
            TextInputError textError = new TextInputError();
            UserError textError2 = new TextInputError();

            var errorExamples = new List<UserError>
            {
                nError1,
                nError2,
                textError,
                textError2
            };

            foreach (var error in errorExamples)
            {
                string text = error.UEMessage();
                Console.WriteLine($"This is the error message: {text}");
            }

            var animals = new List<Animal>();
            animals.Add(new Horse("Full blooded arabian horse", 378, 15, 78) { });
            animals.Add(new Dog("Hubert", 20, 5, "shepard"));
            animals.Add(new Hedgehog("Olle", 2.5, 10, 8500));


            foreach (var animal in animals)
            {
                animal.DoSound();
            }

            //Implementing a method were wolfman is epressing his thought 
            Wolfman aWolfman = new Wolfman("Danger", 89, 32, 800);
            aWolfman.Talk();

            //Skapa en lista animals som tar emot djur  
            Horse aHorse = new Horse("Full blooded arabian horse", 378, 15, 78);
            Dog aDog = new Dog("Hubert", 78.3, 24, "Pitbull");
            Hedgehog aHedgehog = new Hedgehog("Spiky", 3, 18, 25000);
            Worm aWorm = new Worm("wormy", 0.1, 1, Color.Brown);
            Bird pelican = new Pelican("I adore the air", 25, 13, 50);
            Bird Flamingo = new Flamingo("I despise the air", 25, 13, 25, "earth");
            Wolf aWolf = new Wolf("Danger", 49, 15, 350);
            Wolfman aWolfMan = new Wolfman("The hostile is here", 88, 23, 780);
            Swan aSwan = new Swan("Beauty", 25, 20, 35, 1);
            Dog pitbull = new Dog("Merciles", 20, 17, "Pitbull");
            Dog chiwawa = new Dog("Beauty", 10, 12, "Chihuahua");
            Dog pharaohHound = new Dog("Ancient Egypt", 15, 10, "Pharaou Hound");

            var listOfAnimals = new List<Animal>
            {
                aHorse,
                aDog,
                aWorm,
                aHedgehog,
                aWolf,
                Flamingo,
                aWolfMan,
                aSwan,
                aWolfMan,
                pelican
            };

            foreach (Animal animal in listOfAnimals)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();
                Console.WriteLine("The answer under me is important:");
                Console.WriteLine(aDog.randomMethod());
            }
            //Fråga 14, bara hundars stats ska printas
            Console.WriteLine("Lookat me!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            foreach (Animal animal in listOfAnimals)
            {
                if (animal.GetType().ToString().ToLower().Equals(aDog.GetType().ToString().ToLower()))
                {
                    Console.WriteLine(animal.Stats());
                }

                if (animal.GetType().ToString().Equals("PersonObjectOrientation.Wolfman"))
                {
                    Console.WriteLine("I hope this functions");
                    IPerson aPerson = (IPerson)animal;
                    aPerson.Talk();
                }

            }
            //A list of dogs are created 
            var dogList = new List<Dog>();
            dogList.Add((Dog)aDog);
            dogList.Add(pitbull);
            dogList.Add(chiwawa);
            dogList.Add(pharaohHound);
            //dogList.Add((aHorse); 
            Console.WriteLine("Not able to exclude the hole pathway and just preserve the type\n" +
                " I now Imust override the ToString() method but cant exclude the pathway");
            foreach (Animal animal in listOfAnimals)
            {
                string aAnswer = animal.GetType().ToString();
                Console.WriteLine(aAnswer);
                animal.DoSound();
            }



        }
    }
}
