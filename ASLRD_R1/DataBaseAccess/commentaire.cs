//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASLRD_R1.DataBaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class commentaire
    {
        public commentaire()
        {
            this.menu = new HashSet<menu>();
            this.produit = new HashSet<produit>();
        }
    
        public int commentaireID { get; set; }
        public string commentaire1 { get; set; }
        public Nullable<int> note { get; set; }
        public System.DateTime datecommentaire { get; set; }
        public Nullable<int> restaurantID { get; set; }
        public Nullable<int> clientID { get; set; }
    
        public virtual client client { get; set; }
        public virtual restaurant restaurant { get; set; }
        public virtual ICollection<menu> menu { get; set; }
        public virtual ICollection<produit> produit { get; set; }
    }
}
