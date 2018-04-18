using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
namespace dao
{
    public interface EmployeeDAO
    {
          void Add(Employee e);
        Employee GetEmployeeByLogin(string login);
    }
}
