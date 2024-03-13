namespace PersonObjectOrientation
{
    internal class Person
    {
        //private string firstName;
        //private string lastName;
        //private int age;
        public int Age
        {
            get { return Age; }
            set
            {
                if (value >= 0)
                {
                    this.Age = value;
                }
                else
                {
                    Age = 0;
                    throw new ArgumentException("Only positiv integers are aloud!");
                }
            }
        }

        public string FirstName
        {
            get { return FirstName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Last name must be longer than two character and under " +
                        " ten, type in a correct last name ");
                }
                else
                {
                    this.FirstName = value;
                }
            }
        }
        public string LastName
        {
            get { return LastName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("The length of last name must be in the range" +
                        " between 3 and 15, the length of your last name ");
                }
                else
                {
                    this.LastName = value;
                }
            }
        }
        public double height { get; set; }
        public double weight { get; set; }


    }
}
