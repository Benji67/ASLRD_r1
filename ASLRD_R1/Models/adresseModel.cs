using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASLRD_R1.Models
{
    public class adresseModel
    {
        public int adresseID { get; set; }
        public string ville { get; set; }
        public string rue { get; set; }
        public int codepostal { get; set; }
        //public int? clientID { get; set; }
        public int restaurantID { get; set; }
                
        public virtual restaurantModel restaurant { get; set; }
        //public virtual client client { get; set; }
    }
}