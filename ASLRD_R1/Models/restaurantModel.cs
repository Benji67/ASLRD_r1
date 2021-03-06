﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASLRD_R1.Models
{
    public partial class restaurantModel
    {
        public restaurantModel()
        {
            this.adresse = new HashSet<adresseModel>();
            //this.commande = new HashSet<commande>();
            this.commentaire = new HashSet<commentaireModel>();
            //this.menu = new HashSet<menuModel>();
            //this.ouverture = new HashSet<ouverture>();
            this.produit = new HashSet<produitModel>();
        }

        public int restaurantID { get; set; }
        public string email { get; set; }
        public string motdepasse { get; set; }
        public string nom { get; set; }
        public int? telephone { get; set; }
        public string status { get; set; }
        public string genre { get; set; }
        public string nsiret { get; set; }

        public virtual ICollection<adresseModel> adresse { get; set; }
        //public virtual ICollection<commande> commande { get; set; }
        public virtual ICollection<commentaireModel> commentaire { get; set; }
        //public virtual ICollection<menuModel> menu { get; set; }
        //public virtual ICollection<ouverture> ouverture { get; set; }
        public virtual ICollection<produitModel> produit { get; set; }
    }
}
