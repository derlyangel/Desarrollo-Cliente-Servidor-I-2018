//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Curso
    {
        public Curso()
        {
            this.Plan_Estudio = new HashSet<Plan_Estudio>();
            this.recuperaciones = new HashSet<recuperaciones>();
        }
    
        public int IdCurso { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdEscuela { get; set; }
        public string IdCiclo { get; set; }
    
        public virtual Ciclo Ciclo { get; set; }
        public virtual Escuela Escuela { get; set; }
        public virtual ICollection<Plan_Estudio> Plan_Estudio { get; set; }
        public virtual ICollection<recuperaciones> recuperaciones { get; set; }
    }
}
