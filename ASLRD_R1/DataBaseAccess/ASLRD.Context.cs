﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataBaseASLRD : DbContext
    {
        public DataBaseASLRD()
            : base("name=DataBaseASLRD")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<adresse> adresse { get; set; }
        public DbSet<client> client { get; set; }
        public DbSet<commande> commande { get; set; }
        public DbSet<commentaire> commentaire { get; set; }
        public DbSet<ingredient> ingredient { get; set; }
        public DbSet<menu> menu { get; set; }
        public DbSet<ouverture> ouverture { get; set; }
        public DbSet<produit> produit { get; set; }
        public DbSet<restaurant> restaurant { get; set; }
    }
}
