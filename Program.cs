using BT.Class;
using BT.Interface;


IDataAccess  da = new DataAccessOracle();
IBizness biz = new Bizness(da);

UI ui = new UI(biz);

ui.SignUp();
Console.Read();

