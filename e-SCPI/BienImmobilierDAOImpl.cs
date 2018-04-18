using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace dao
{
   public class BienImmobilierDAOImpl : BienImmobilierDAO
    {
        public void AddBien(BienImmobilier b)
        {
            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(b);
                    tx.Commit();
                }
            }
        }
    }
}
