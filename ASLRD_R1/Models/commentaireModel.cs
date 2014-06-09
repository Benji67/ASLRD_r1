using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASLRD_R1.Models
{    
    public partial class commentaireModel
    {
        public commentaireModel()
        {
            //this.menu = new HashSet<menuModel>();
            this.produit = new HashSet<produitModel>();
        }

        public int commentaireID { get; set; }
        public string commentaire1 { get; set; }
        public int? note { get; set; }
        public System.DateTime datecommentaire { get; set; }
        public int? restaurantID { get; set; }
        public int? clientID { get; set; }

        public virtual clientModel client { get; set; }
        public virtual restaurantModel restaurant { get; set; }
        //public virtual ICollection<menuModel> menu { get; set; }
        public virtual ICollection<produitModel> produit { get; set; }
    }
}