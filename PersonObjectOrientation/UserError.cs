namespace PersonObjectOrientation
{
    internal abstract class UserError
    {
        public abstract string UEMessage();
    }
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            string answer = "You tried to use a text input in a numeric only" +
                " field. This fired an error!";
            return answer;
        }
    }
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            string message = "You tried to use a text\r" +
                "\ninput in a numeric only field. " +
                "This fired an error!";
            return message;
        }
    }

    //Create three more classes
}
