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
    
    public partial class imp_gasto
    {
        public imp_gasto()
        {
            this.imp_gasto_x_ct_plancta = new HashSet<imp_gasto_x_ct_plancta>();
            this.imp_orden_compra_ext_ct_cbteble_det_gastos = new HashSet<imp_orden_compra_ext_ct_cbteble_det_gastos>();
        }
    
        public int IdGasto_tipo { get; set; }
        public string gt_descripcion { get; set; }
        public bool estado { get; set; }
        public string observacion { get; set; }
    
        public virtual ICollection<imp_gasto_x_ct_plancta> imp_gasto_x_ct_plancta { get; set; }
        public virtual ICollection<imp_orden_compra_ext_ct_cbteble_det_gastos> imp_orden_compra_ext_ct_cbteble_det_gastos { get; set; }
    }
}
