﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_de_Negocio
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class HorariosIEntities : DbContext
    {
        public HorariosIEntities()
            : base("name=HorariosIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Aula> Aula { get; set; }
        public DbSet<capacidad> capacidad { get; set; }
        public DbSet<Ciclo> Ciclo { get; set; }
        public DbSet<clasificacion> clasificacion { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Descrip_Pabellon> Descrip_Pabellon { get; set; }
        public DbSet<dia> dia { get; set; }
        public DbSet<Docente> Docente { get; set; }
        public DbSet<Escuela> Escuela { get; set; }
        public DbSet<Facultad> Facultad { get; set; }
        public DbSet<fecha> fecha { get; set; }
        public DbSet<Grado_Docente> Grado_Docente { get; set; }
        public DbSet<hora> hora { get; set; }
        public DbSet<Pabellon> Pabellon { get; set; }
        public DbSet<Plan_Estudio> Plan_Estudio { get; set; }
        public DbSet<recuperaciones> recuperaciones { get; set; }
        public DbSet<seccion> seccion { get; set; }
        public DbSet<semestre> semestre { get; set; }
        public DbSet<tipo_aula> tipo_aula { get; set; }
        public DbSet<Tipo_Docente> Tipo_Docente { get; set; }
        public DbSet<usuario> usuario { get; set; }
    
        public virtual ObjectResult<usp_ValidarContraseña_Result> usp_ValidarContraseña(string prmContraseña)
        {
            var prmContraseñaParameter = prmContraseña != null ?
                new ObjectParameter("prmContraseña", prmContraseña) :
                new ObjectParameter("prmContraseña", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ValidarContraseña_Result>("usp_ValidarContraseña", prmContraseñaParameter);
        }
    
        public virtual ObjectResult<usp_ValidarUsuario_Result> usp_ValidarUsuario(string prmUsuario)
        {
            var prmUsuarioParameter = prmUsuario != null ?
                new ObjectParameter("prmUsuario", prmUsuario) :
                new ObjectParameter("prmUsuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ValidarUsuario_Result>("usp_ValidarUsuario", prmUsuarioParameter);
        }
    }
}
