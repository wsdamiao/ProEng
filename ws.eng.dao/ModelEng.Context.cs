﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ws.eng.dao
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProEngEntities : DbContext
    {
        public ProEngEntities()
            : base("name=ProEngEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Logradouro> Logradouroes { get; set; }
        public virtual DbSet<Elemento> Elementoes { get; set; }
        public virtual DbSet<ElementoValor> ElementoValors { get; set; }
        public virtual DbSet<Pai> Pais { get; set; }
        public virtual DbSet<Distancia> Distancias { get; set; }
        public virtual DbSet<DadosGerai> DadosGerais { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Projeto> Projetoes { get; set; }
        public virtual DbSet<ProjetoServico> ProjetoServicoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<ServicoHistorico> ServicoHistoricoes { get; set; }
        public virtual DbSet<MensagemCliente> MensagemClientes { get; set; }
        public virtual DbSet<UsuarioCategoria> UsuarioCategorias { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Servico> Servicoes { get; set; }
        public virtual DbSet<ServicoTipo> ServicoTipoes { get; set; }
        public virtual DbSet<ProjetoCliUsu> ProjetoCliUsus { get; set; }
        public virtual DbSet<ProjetoServicoSerTipo> ProjetoServicoSerTipoes { get; set; }
    }
}
