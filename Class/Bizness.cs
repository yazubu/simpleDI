using BT.Interface;
namespace BT.Class
{
  

    public class Bizness : IBizness
    {

        private IDataAccess _da;
        public Bizness(IDataAccess da)
        {
            _da = da;
        }
        public void Signup(string userName, string password)
        {
            Console.WriteLine("Bizness Enter");
            _da.SignUp(userName, password);
        }
    }
}