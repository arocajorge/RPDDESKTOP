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
    
    public partial class vwin_Ing_Egr_Inven_x_in_movi_inve
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string signo { get; set; }
        public Nullable<int> IdMotivo_Inv { get; set; }
        public string Desc_mov_inv { get; set; }
        public string tm_descripcion { get; set; }
        public string cm_descripcionCorta { get; set; }
        public string cm_observacion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string Genera_Movi_Inven { get; set; }
    }
}
