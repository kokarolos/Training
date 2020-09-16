using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DICode
{
    class Program
    {
        static void Main(string[] args)
        {
            var ProductRepository = new ProductRepository(new Database<Product>(new Permission(new User() { UserName = "Admin" }), new Configuration()));
        }
    }

    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }

        public Product(Guid productId, string name)
        {
            ProductId = productId;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ProductId} / {Name}";
        }
    }

    public class ProductRepository
    {
        private Database<Product> _database;
        public ProductRepository(Database<Product> database)
        {
            _database = database;
            Display();
        }

        public IEnumerable<Product> GetAll()
        {
            return _database.GetAll();
        }

        private void Display()
        {
            var prods = GetAll();
            prods.ToList().ForEach(x => Console.WriteLine(x.ToString()));
        }
    }

    public class Database<T> where T : class
    {
        private readonly Configuration _key;
        private readonly Permission _permission;
        public Database(Permission permission, Configuration key)
        {
            _permission = permission;
            _key = key;
        }

        public IEnumerable<Product> GetAll()
        {
            if (_permission.IsAuthoraized())
            {
                return Data.GetProducts();
            }
            throw new InvalidOperationException("Permission Is not Granted");
        }
    }

    public static class Data
    {
        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(new Guid(),"P1"),
                new Product(new Guid(), "P2"),
                new Product(new Guid(), "P3")
            };
        }
    }

    public class Configuration
    {
        public string ConfigurationString { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }

    public class Permission
    {
        private User _user;
        public Permission(User user)
        {
            _user = user;
        }

        public bool IsAuthoraized()
        {
            return _user.UserName.Equals("Admin");
        }
    }

    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }

    public class DefaultContext : SomeContext
    {
        public override string SomeValue => throw new System.NotImplementedException();
    }

    public abstract class SomeContext
    {
        public static SomeContext Current
        {
            get
            {
                var ctx = Thread.GetData(Thread.GetNamedDataSlot("SomeContext")) as SomeContext;
                if (ctx == null)
                {
                    ctx = Default;
                    Thread.SetData(Thread.GetNamedDataSlot("SomeContext"), ctx);
                }
                return ctx;
            }
            set
            {
                Thread.SetData(Thread.GetNamedDataSlot("SomeContext"), value);
            }
        }

        public static SomeContext Default = new DefaultContext();
        public abstract string SomeValue { get; }
    }
}
