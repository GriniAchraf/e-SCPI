using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using NHibernate.Criterion;

namespace dao
{
    public class SCPIDAOImpl : SCPIDAO
    {
        public void Add(SCPI e)
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

        public void AddBien(BienImmobilier b, int id)
        {
            var scpis = new SCPI();
            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    scpis = (SCPI)session.CreateCriteria<SCPI>().Add(Restrictions.Eq("ID", id)).UniqueResult();
                    scpis.AddBienImmobilier(b);
                    session.Save(scpis);
                    tx.Commit();
                }
            }
        }

        public void AddPart(Part p, int id)
        {
            var scpis = new SCPI();
            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    scpis = (SCPI)session.CreateCriteria<SCPI>().Add(Restrictions.Eq("ID", id)).UniqueResult();
                    scpis.AddPart(p);
                    session.Save(scpis);
                    tx.Commit();
                }
            }
        }

        public List<SCPI> GetAllSCPI()
        {
            var scpis = new List<SCPI>();
            
            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {    
                     scpis =(List<SCPI>) session.CreateCriteria<SCPI>().List<SCPI>();
                    tx.Commit();
                }
            }
            return scpis;
        }

        public SCPI GetSCPIByID(int id)
        {
            var scpis = new SCPI();
            var sefact = new NhibernateUtils().GetSessionFactory();
            using (var session = sefact.OpenSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    scpis = (SCPI)session.CreateCriteria<SCPI>().Add(Restrictions.Eq("ID", id)).UniqueResult();
                    tx.Commit();
                }
            }
            return scpis;
        }
    }
}
