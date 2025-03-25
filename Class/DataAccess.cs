using BT.Interface;
namespace BT.Class
{
 
    public class DataAccess : IDataAccess
    {
        public void SignUp(string userName, string password)
        {
            Console.WriteLine("Saving to SQL");
        }
    }
}