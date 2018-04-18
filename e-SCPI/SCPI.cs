using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
   public  class SCPI
    {
        public virtual int ID { get; set; }
        public virtual Double Capital { get; set; }
        public virtual string Nom { get; set; }
        public virtual DateTime DateCreation { get; set; }
        public virtual Double FraisGestion { get; set; }
        public virtual IList<Part> Parts { get; set; }
        public virtual IList<BienImmobilier> Biens { get; set; }
        public SCPI() { }

        

        public SCPI( string nom, DateTime dateCreation, double fraisGestion, List<Part> parts)
        {
            
            Nom = nom;
            DateCreation = dateCreation;
            FraisGestion = fraisGestion;
            Parts = parts;
            foreach(Part p in Parts)
            { Capital += p.Montant;
                p.PartOff = this;
            }
            Biens = new List<BienImmobilier>();
        }

        public virtual void AddBienImmobilier(BienImmobilier b)
        {
            Biens.Add(b);
            Capital -= b.CoutAcquisition;
        }
        public virtual void AddPart(Part p)
        {
            Boolean found = false;
            foreach (Part i in Parts)
                if (i.ID == p.ID)
                {
                    Capital -= p.Montant;
                    i.Montant = p.Montant;
                    found = true;
                }
            if (!found)
            {
                Parts.Add(p);
                p.PartOff = this;
            }
            Capital += p.Montant;

        }
        public virtual ArrayList ListSouscripteur()
        {
            ArrayList liste = new ArrayList();
            foreach (Part p in Parts)
                liste.Add(p.Owner);
            return liste;
        }
        public virtual Double LoyetNetTrimestrielTotal()
        {
            Double total = 0;
            foreach (BienImmobilier b in Biens)
                total = total + b.LoyerTrimestr - b.ChargesTrimestr - FraisGestion;
            return total;
        }
        public virtual Double ChiffreAffaire()
        {
            Double ca =Capital;
            foreach (BienImmobilier b in Biens)
                ca += b.CoutAcquisition;
            return ca;
        }
        public virtual Double LoyerNetParPart(Part p)
        {
            Double loyer = 0;
            float percent =(float) (p.Montant / ChiffreAffaire());
            loyer = percent * LoyetNetTrimestrielTotal();
            return Math.Round(loyer, 4);

        }
        public virtual int nbrePart()
        {
            return Parts.Count;
        }
       


    }
}
