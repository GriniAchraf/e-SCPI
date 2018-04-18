using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Part
    {
        public virtual int ID { get; set; }
        public virtual Double Montant { get; set; }
        public virtual DateTime DateSouscription { get; set; }
        public virtual SCPI PartOff { get; set; }
        public virtual Souscripteur Owner { get; set; }
        public Part() { }
        public Part( double montant, DateTime dateSouscription)
        {
            
            Montant = montant;
            DateSouscription = dateSouscription;
            
            
        }
    }
}
