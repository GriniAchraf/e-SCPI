using NHibernate.Criterion;
using model;
namespace dao
{
   public class EmployeeDAOImpl : EmployeeDAO
    { 

        public void Add(Employee e)
        {  
            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(e);
                    tx.Commit();
                }
            }  
        }

        public Employee GetEmployeeByLogin(string login)
        {
            var employee = new Employee();
            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                     employee = (Employee)session.CreateCriteria<Employee>().Add(Restrictions.Eq("Email", login)).UniqueResult();
                    tx.Commit();
                }
            }return employee;
        }
    }
}
