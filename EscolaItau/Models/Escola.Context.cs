﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscolaItau.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class escolaEntities : DbContext
    {
        public escolaEntities()
            : base("name=escolaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Disciplina> Disciplinas { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Quadro> Quadroes { get; set; }
    }
}