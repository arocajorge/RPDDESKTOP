using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Roles
{//////
    public class ro_rubro_tipo_Info
    {
        public int IdEmpresa { get; set; }
        public string IdRubro { get; set; }
        public string rub_codigo { get; set; }
        public string ru_codRolGen { get; set; }
        public string ru_descripcion { get; set; }
        public string NombreCorto { get; set; }
        public string ru_tipo { get; set; }
        public string ru_estado { get; set; }
        public int ru_orden { get; set; }
        public string ru_EditablexUser { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public bool rub_concep { get; set; }
        public int rub_tipcal { get; set; }
        public string rub_formul { get; set; }
        public Nullable<decimal> rub_valfij { get; set; }
        public string rub_legal { get; set; }
        public string rub_foract { get; set; }
        public string rub_fornom { get; set; }
        public string rub_gencon { get; set; }
        public Nullable<bool> rub_antici { get; set; }
        public string rub_ctacon { get; set; }
        public Nullable<int> rub_grupo { get; set; }
        public Nullable<bool> rub_liquida { get; set; }
        public bool rub_provision { get; set; }
        public bool rub_noafecta { get; set; }
        public bool rub_acumula { get; set; }
        public Nullable<bool> rub_prorrateo { get; set; }
        public bool rub_nocontab { get; set; }
        public Nullable<bool> rub_utilid { get; set; }
        public bool rub_guarda_rol { get; set; }
        public bool rub_aplica_IESS { get; set; }
        public Nullable<bool> rub_AplicaEmpleado_Vac { get; set; }
        public Nullable<bool> ru_aplica_empleado_Subsidio { get; set; }
        public bool rub_Contabiliza_x_empleado { get; set; }
        public Nullable<bool> rub_mustra_liquidacion_cliente { get; set; }
        public string rub_Acuerdo_Descuento { get; set; }
        public bool Ckeck { get; set; }
        
   
        public ro_rubro_tipo_Info()
        {

        }
    }   

}
