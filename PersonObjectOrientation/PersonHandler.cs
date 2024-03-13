namespace PersonObjectOrientation
{
    internal class PersonHandler
    {
        static int PersonCount = 0;
        public void SetAge(Person pers, int age)
        {
            try
            {
                pers.Age = age;
            }
            catch (ArgumentException ex)
            {
                ex.Message.ToString();
            }
        }
        public Person CreatePerson(int age, string fname, string lname,
            double height, double weight)
        {
            Person person = new Person();
            try
            {
                person.Age = age;
                person.FirstName = fname;
                person.LastName = lname;

            }
            catch (ArgumentException ex)
            {
                ex.Message.ToString();
            }
            person.height = height;
            person.weight = weight;
            PersonCount++;
            return person;
        }
    }
}
