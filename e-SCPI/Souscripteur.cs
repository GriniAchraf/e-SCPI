using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
   public class Souscripteur
    {
        public virtual int ID { get; set; }
        public virtual string CNI { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Prenom { get; set; }
        public virtual DateTime DateNaissance { get; set; }
        public virtual IList<Part> Parts { get; set; }
        public Souscripteur() { }
        public Souscripteur( string cNI, string nom, string prenom, DateTime dateNaissance)
        {
           
            CNI = cNI;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Parts = new List<Part>();
            
        }
        public virtual void AddPart(Part p)
        {
            Parts.Add(p);
            p.Owner = this;
        }
        public virtual double LoyetNetTrimestrielParPart(Part p)
        {
            return p.PartOff.LoyerNetParPart(p);
        }
        public virtual double LoyerNetTrimestrielTotal()
        {
            double total = 0;
            foreach (Part p in Parts)
                total += LoyetNetTrimestrielParPart(p);
            return total;
        }
    }
}
