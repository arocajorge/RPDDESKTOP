//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class cp_codigo_SRI
    {
        public cp_codigo_SRI()
        {
            this.cp_codigo_SRI_x_CtaCble = new HashSet<cp_codigo_SRI_x_CtaCble>();
            this.cp_nota_DebCre = new HashSet<cp_nota_DebCre>();
            this.cp_nota_DebCre1 = new HashSet<cp_nota_DebCre>();
            this.cp_proveedor_codigo_SRI = new HashSet<cp_proveedor_codigo_SRI>();
            this.cp_retencion_det = new HashSet<cp_retencion_det>();
            this.cp_orden_giro = new HashSet<cp_orden_giro>();
            this.cp_orden_giro1 = new HashSet<cp_orden_giro>();
            this.cp_orden_giro2 = new HashSet<cp_orden_giro>();
            this.cp_proveedor = new HashSet<cp_proveedor>();
            this.cp_proveedor1 = new HashSet<cp_proveedor>();
            this.cp_proveedor2 = new HashSet<cp_proveedor>();
        }
    
        public int IdCodigo_SRI { get; set; }
        public string codigoSRI { get; set; }
        public string co_codigoBase { get; set; }
        public string co_descripcion { get; set; }
        public double co_porRetencion { get; set; }
        public System.DateTime co_f_valides_desde { get; set; }
        public System.DateTime co_f_valides_hasta { get; set; }
        public string co_estado { get; set; }
        public string IdTipoSRI { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotivoAnulacion { get; set; }
    
        public virtual cp_codigo_SRI_tipo cp_codigo_SRI_tipo { get; set; }
        public virtual ICollection<cp_codigo_SRI_x_CtaCble> cp_codigo_SRI_x_CtaCble { get; set; }
        public virtual ICollection<cp_nota_DebCre> cp_nota_DebCre { get; set; }
        public virtual ICollection<cp_nota_DebCre> cp_nota_DebCre1 { get; set; }
        public virtual ICollection<cp_proveedor_codigo_SRI> cp_proveedor_codigo_SRI { get; set; }
        public virtual ICollection<cp_retencion_det> cp_retencion_det { get; set; }
        public virtual ICollection<cp_orden_giro> cp_orden_giro { get; set; }
        public virtual ICollection<cp_orden_giro> cp_orden_giro1 { get; set; }
        public virtual ICollection<cp_orden_giro> cp_orden_giro2 { get; set; }
        public virtual ICollection<cp_proveedor> cp_proveedor { get; set; }
        public virtual ICollection<cp_proveedor> cp_proveedor1 { get; set; }
        public virtual ICollection<cp_proveedor> cp_proveedor2 { get; set; }
    }
}
