using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASLRD_R1.Models
{
    public partial class produitModel
    {
        public produitModel()
        {
            //this.commande = new HashSet<commande>();
            this.commentaire = new HashSet<commentaireModel>();
            //this.ingredient = new HashSet<ingredient>();
            //this.menu = new HashSet<menuModel>();
        }
    
        public int produitID { get; set; }
        public string nom { get; set; }
        public decimal prixproduit { get; set; }
        public string description { get; set; }
        public System.TimeSpan? delais { get; set; }
        public double? reduction { get; set; }
        public int restaurantID { get; set; }
    
        public virtual restaurantModel restaurant { get; set; }
        //public virtual ICollection<commande> commande { get; set; }
        public virtual ICollection<commentaireModel> commentaire { get; set; }
        //public virtual ICollection<ingredient> ingredient { get; set; }
        //public virtual ICollection<menuModel> menu { get; set; }
    }
}
