using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Linq;
using System.Reflection;
namespace model
{
    class NhibernateUtils
    {
        public NHibernate.ISessionFactory GetSessionFactory()
        {
            var cfg = new Configuration();



            cfg.DataBaseIntegration(x => {
                x.ConnectionString = "server=localhost;user id=root;password=salamanca;persistsecurityinfo=True;database=e_scpi";



                x.Driver<MySqlDataDriver>();
                x.Dialect<MySQLDialect>();
            });
            
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            var sefact = cfg.BuildSessionFactory();
        return sefact;
        }
    }
}
