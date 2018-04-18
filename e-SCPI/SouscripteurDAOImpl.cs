using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using NHibernate.Criterion;
namespace dao
{
   public class SouscripteurDAOImpl : SouscripteurDAO
    {
        public void Add(Souscripteur e)
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

        public void AddPart(Part p, int id)
        {
            var scpis = new Souscripteur();
            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    scpis = (Souscripteur)session.CreateCriteria<Souscripteur>().Add(Restrictions.Eq("ID", id)).UniqueResult();
                    scpis.AddPart(p);
                    session.Save(scpis);
                    tx.Commit();
                }
            }
        }

        public List<Souscripteur> GetAllSouscripteur()
        {
            var scpis = new List<Souscripteur>();

            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    scpis = (List<Souscripteur>)session.CreateCriteria<Souscripteur>().List<Souscripteur>();
                    tx.Commit();
                }
            }
            return scpis;
        }

        public Souscripteur getSouscripteurByID(int id)
        {
            var scpis = new Souscripteur();
            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    scpis = (Souscripteur)session.CreateCriteria<Souscripteur>().Add(Restrictions.Eq("ID", id)).UniqueResult();
                    tx.Commit();
                }
            }
            return scpis;
        }
    }
}
