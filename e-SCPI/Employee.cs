using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
   public  class Employee
    {
        public virtual int ID { get; set; }
        public virtual string Email { get; set; }
        public virtual string MotDePasse { get; set; }
        public Employee() { }
        public Employee(int iD, string email, string motDePasse)
        {
            ID = iD;
            Email = email;
            MotDePasse = motDePasse;
        }
    }
}
