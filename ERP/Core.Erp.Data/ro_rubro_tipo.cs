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
    
    public partial class ro_rubro_tipo
    {
        public ro_rubro_tipo()
        {
            this.ro_empleado_novedad_det = new HashSet<ro_empleado_novedad_det>();
            this.ro_rol_detalle = new HashSet<ro_rol_detalle>();
            this.ro_empleado_x_rubro_acumulado = new HashSet<ro_empleado_x_rubro_acumulado>();
            this.ro_empleado_x_ro_rubro = new HashSet<ro_empleado_x_ro_rubro>();
            this.ro_Config_Param_contable = new HashSet<ro_Config_Param_contable>();
        }
    
        public int IdEmpresa { get; set; }
        public string IdRubro { get; set; }
        public string rub_codigo { get; set; }
        public string ru_codRolGen { get; set; }
        public string ru_descripcion { get; set; }
        public string NombreCorto { get; set; }
        public string ru_tipo { get; set; }
        public string ru_estado { get; set; }
        public int ru_orden { get; set; }
        public bool rub_concep { get; set; }
        public int rub_tipcal { get; set; }
        public string rub_ctacon { get; set; }
        public Nullable<int> rub_grupo { get; set; }
        public bool rub_provision { get; set; }
        public bool rub_noafecta { get; set; }
        public bool rub_nocontab { get; set; }
        public bool rub_guarda_rol { get; set; }
        public bool rub_aplica_IESS { get; set; }
        public bool rub_Contabiliza_x_empleado { get; set; }
        public string rub_Acuerdo_Descuento { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public bool rub_acumula { get; set; }
    
        public virtual ICollection<ro_empleado_novedad_det> ro_empleado_novedad_det { get; set; }
        public virtual ICollection<ro_rol_detalle> ro_rol_detalle { get; set; }
        public virtual ICollection<ro_empleado_x_rubro_acumulado> ro_empleado_x_rubro_acumulado { get; set; }
        public virtual ICollection<ro_empleado_x_ro_rubro> ro_empleado_x_ro_rubro { get; set; }
        public virtual ICollection<ro_Config_Param_contable> ro_Config_Param_contable { get; set; }
    }
}
