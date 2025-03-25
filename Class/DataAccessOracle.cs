namespace BT.Class
{
    public class DataAccessOracle : IDataAccess
    {
        public void SignUp(string userName, string password)
        {
           Console.WriteLine($"Saved: {userName} with {password} to OracleDb");
        }
    }
}