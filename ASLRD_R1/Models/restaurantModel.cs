using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASLRD_R1.Models
{
    public class restaurantModel
    {
        public int restaurantID { get; set; }
        public string email { get; set; }
        public string motdepasse { get; set; }
        public string nom { get; set; }
        public Nullable<int> telephone { get; set; }
        public string status { get; set; }
        public string genre { get; set; }
        public string nsiret { get; set; }

        public virtual ICollection<adresseModel> adresse { get; set; }
        //public virtual ICollection<commande> commande { get; set; }
        //public virtual ICollection<commentaire> commentaire { get; set; }
        //public virtual ICollection<menu> menu { get; set; }
        //public virtual ICollection<ouverture> ouverture { get; set; }
        //public virtual ICollection<produit> produit { get; set; }
    }
}