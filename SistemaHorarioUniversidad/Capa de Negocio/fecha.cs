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
    
    public partial class fecha
    {
        public fecha()
        {
            this.recuperaciones = new HashSet<recuperaciones>();
        }
    
        public string idfecha { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
    
        public virtual ICollection<recuperaciones> recuperaciones { get; set; }
    }
}
