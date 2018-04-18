using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
 public    class BienImmobilier
    {  public  enum TypeImmobilier {Habitation,Bureau }
        public virtual int ID { get; set; }
        public virtual string NumCadastre { get; set; }
        public virtual string Adresse { get; set; }
        public virtual string Image { get; set; }
        public virtual Double CoutAcquisition { get; set; }
        public virtual Double ChargesTrimestr { get; set; }
        public virtual Double LoyerTrimestr { get; set; }
        public virtual TypeImmobilier Type { get; set; }
        public BienImmobilier() { }
        public BienImmobilier( string numCadastre, string adresse, string image, double coutAcquisition, double chargesTrimestr, double loyerTrimestr, int k)
        {
            
            NumCadastre = numCadastre;
            Adresse = adresse;
            Image = image;
            CoutAcquisition = coutAcquisition;
            ChargesTrimestr = chargesTrimestr;
            LoyerTrimestr = loyerTrimestr;
            if(k==0)
            Type = TypeImmobilier.Bureau;
            else
                Type = TypeImmobilier.Habitation;
        }
    }
}
