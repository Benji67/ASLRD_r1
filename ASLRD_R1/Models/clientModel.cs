using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASLRD_R1.Models
{   
    public partial class clientModel
    {
        public clientModel()
        {
            this.adresse = new HashSet<adresseModel>();
            //this.commande = new HashSet<commande>();
            this.commentaire = new HashSet<commentaireModel>();
        }

        public int clientID { get; set; }
        public string email { get; set; }
        public string motdepasse { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public Nullable<int> telephone { get; set; }
        public string status { get; set; }
        public string genre { get; set; }

        public virtual ICollection<adresseModel> adresse { get; set; }
        //public virtual ICollection<commande> commande { get; set; }
        public virtual ICollection<commentaireModel> commentaire { get; set; }
    }
}