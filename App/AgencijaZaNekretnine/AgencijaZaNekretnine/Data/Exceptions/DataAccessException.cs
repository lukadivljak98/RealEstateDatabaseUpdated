namespace AgencijaZaNekretnine.Data.Exception
{
    public class DataAccessException : System.Exception
    {
        public DataAccessException(string message) : base(message) { }

        public DataAccessException(string message, System.Exception inner) : base(message, inner) { }
    }
}