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
    
    public partial class cp_pagos_sri
    {
        public cp_pagos_sri()
        {
            this.cp_orden_giro_pagos_sri = new HashSet<cp_orden_giro_pagos_sri>();
        }
    
        public string formas_pago_sri { get; set; }
        public string codigo_pago_sri { get; set; }
    
        public virtual ICollection<cp_orden_giro_pagos_sri> cp_orden_giro_pagos_sri { get; set; }
    }
}
