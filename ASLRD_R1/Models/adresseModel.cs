using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASLRD_R1.Models
{
    public partial class adresseModel
    {
        public int adresseID { get; set; }
        public string ville { get; set; }
        public string rue { get; set; }
        public int codepostal { get; set; }
        public Nullable<int> clientID { get; set; }
        public Nullable<int> restaurantID { get; set; }

        public virtual clientModel client { get; set; }
        public virtual restaurantModel restaurant { get; set; }
    }
}
