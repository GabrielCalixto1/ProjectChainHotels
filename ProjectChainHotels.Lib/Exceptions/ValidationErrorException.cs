namespace ProjectChainHotels.Lib.Exceptions
{
    public class ValidationErrorException : Exception
    {
        public ValidationErrorException()
        {

        }
        public ValidationErrorException(string msg) : base(msg)
        {

        }
    }
}