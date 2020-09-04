using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Study
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string username = "panos";

            UnityContainer container = new UnityContainer();
            container.RegisterFactory<UserProvider>(x =>
            {
                return new UserProvider(username);
            });
            container.RegisterSingleton<IEmployeesRepository, EmployeesRepository>();
            container.RegisterSingleton<MainView, MainView>();
            container.RegisterSingleton<Permission, Permission>();
            container.RegisterSingleton<FileConfiguration, FileConfiguration>();

            MainView mainView = container.Resolve<MainView>();
            Application.Run(mainView);



            //string username = "panos";
            //UserProvider userProvider = new UserProvider(username);
            //var connectionstringProvider = new ConnectionStringProvider(new FileConfiguration());
            //var employeeRepository = new EmployeesRepository(connectionstringProvider, new Permission(), userProvider);
            //Application.Run(new MainView(employeeRepository, userProvider));
        }
    }
}
