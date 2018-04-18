using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
namespace dao
{
  public  interface SCPIDAO
    {
        void Add(SCPI e);
        List<SCPI> GetAllSCPI();
        SCPI GetSCPIByID(int id);
        void AddBien(BienImmobilier b, int id);
        void AddPart(Part p, int id);
    }
}
