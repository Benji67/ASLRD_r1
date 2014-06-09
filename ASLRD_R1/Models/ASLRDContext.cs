using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;    
using System.Data.Entity.Infrastructure;

namespace ASLRD_R1.Models
{
    public class ASLRDContext : DbContext
    {
        public ASLRDContext()
            : base("name=DataBaseASLRD")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<adresseModel> adresse { get; set; }
        public DbSet<restaurantModel> restaurant { get; set; }
        public DbSet<clientModel> client { get; set; }
        //public DbSet<commande> commande { get; set; }
        //public DbSet<commande_menu> commande_menu { get; set; }
        //public DbSet<commande_produit> commande_produit { get; set; }
        public DbSet<commentaireModel> commentaire { get; set; }
        //public DbSet<ingredient> ingredient { get; set; }
        //public DbSet<menuModel> menu { get; set; }
        //public DbSet<ouverture> ouverture { get; set; }
        public DbSet<produitModel> produit { get; set; }
    }
}