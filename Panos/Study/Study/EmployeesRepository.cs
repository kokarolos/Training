using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{

    public interface IEmployeesRepository
    {
        IEnumerable<Employee> GetAll();
    }
    public class EmployeesRepository : IEmployeesRepository
    {
        readonly ConnectionStringProvider connectionStringProvider;
        readonly Permission permission;
        readonly UserProvider userProvider;
        public EmployeesRepository(
            ConnectionStringProvider connectionStringProvider,
            Permission permission,
            UserProvider userProvider)
        {
            this.userProvider = userProvider;
            this.permission = permission;
            this.connectionStringProvider = connectionStringProvider;
        }
        public IEnumerable<Employee> GetAll()
        {
            if (!permission.RequestAccess(userProvider.GetCurrentUser(), "Employees.GetAll"))
                throw new Exception("Unauthorized");


            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionStringProvider.MyStudyDB))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM EMPLOYEES", connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        employees.Add(new Employee()
                        {
                            ID = Convert.ToInt32(reader[0]),
                            FirstName = Convert.ToString(reader[1]),
                            LastName = Convert.ToString(reader[2])
                        });
                    }
                }
            }
            return employees;
        }
    }
    public class ConnectionStringProvider
    {
        readonly FileConfiguration fileConfiguration;
        public ConnectionStringProvider(
            FileConfiguration fileConfiguration)
        {
            this.fileConfiguration = fileConfiguration;
            this.MyStudyDB = fileConfiguration.GetKey("connectionString");
        }
        public string MyStudyDB { get; private set; }
    }
    public class FileConfiguration
    {
        public FileConfiguration()
        {

        }
        public string GetKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
    public class Permission
    {
        public Permission()
        {

        }
        public bool RequestAccess(string user, string operation)
        {
            if (user == "panos" && operation == "Employees.GetAll")
                return true;


            return false;
        }
    }
    public class UserProvider
    {

        readonly string username;
        public UserProvider(string username)
        {
            this.username = username;
        }
        public string GetCurrentUser()
        {
            return username;
        }
    }
    public class FakeEmployeesRepository : IEmployeesRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            yield return new Employee() { ID = 0, FirstName = "a", LastName = "0" };
            yield return new Employee() { ID = 1, FirstName = "a", LastName = "0" };
            yield return new Employee() { ID = 2, FirstName = "a", LastName = "0" };
        }
    }

}
