using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace RandomPractiseStuff
{
    public class AutofacExample
    {
        static IContainer Container { get; set; }
        static AutofacExample()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MySqlConnection>().As<IConnection>();
            Container = builder.Build();
        }

        public static IConnection Connection => Container.Resolve<IConnection>();
    }

    public interface IConnection
    {
        void Connect();
        void Command(string command);
    }

    public class MySqlConnection : IConnection
    {
        public void Command(string command) { }
        public void Connect() { }

    }
    public class SqlConnection : IConnection
    {
        public void Command(string command) { }
        public void Connect() { }
    }
}