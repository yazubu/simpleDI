using BT.Interface;
namespace BT.Class
{


    public class UI : IUI
    {
        private string _userName;
        private string _userPassword;

        //interface
        private IBizness _bizness;

        public UI(IBizness bizness)
        {
            _bizness = bizness ; //<- concrete class goes here
        }
        private void GetData()
        {
            Console.WriteLine("Enter nameL");
            _userName = Console.ReadLine();
            Console.WriteLine("EnterPAss");
            _userPassword = Console.ReadLine();
        }

        public void SignUp()
        {
            GetData();            
            _bizness.Signup(_userName, _userPassword);
        }

    }

}