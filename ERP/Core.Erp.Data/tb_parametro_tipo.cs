//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_parametro_tipo
    {
        public tb_parametro_tipo()
        {
            this.tb_parametro = new HashSet<tb_parametro>();
        }
    
        public string IdTipoParam { get; set; }
        public string nom_TipoParam { get; set; }
    
        public virtual ICollection<tb_parametro> tb_parametro { get; set; }
    }
}
