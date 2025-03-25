using BT.Class;
using BT.Interface;
using Microsoft.Extensions.DependencyInjection;


//register dependencies
IServiceCollection collection = new ServiceCollection();
collection.AddScoped<IDataAccess,DataAccessOracle>();
collection.AddScoped<IBizness,Bizness>();
collection.AddScoped<UI>();

//create objects
IServiceProvider provider = collection.BuildServiceProvider();

// UI ui = new UI(biz);

UI ui = provider.GetService<UI>(); //don't have to pass the bizness class as service collection is doing this for us
ui.SignUp();
Console.Read();

