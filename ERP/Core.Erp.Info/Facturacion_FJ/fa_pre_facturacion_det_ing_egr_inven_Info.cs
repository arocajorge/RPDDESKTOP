using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_pre_facturacion_det_ing_egr_inven_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int Secuencia { get; set; }
        public Nullable<int> eg_IdEmpresa { get; set; }
        public Nullable<int> eg_IdSucursal { get; set; }
        public Nullable<int> eg_IdMovi_inven_tipo { get; set; }
        public Nullable<decimal> eg_IdNumMovi { get; set; }
        public Nullable<int> eg_Secuencia { get; set; }
        public Nullable<double> eg_cantidad { get; set; }
        public Nullable<int> in_IdEmpresa { get; set; }
        public Nullable<int> in_IdSucursal { get; set; }
        public Nullable<int> in_IdMovi_inven_tipo { get; set; }
        public Nullable<decimal> in_IdNumMovi { get; set; }
        public Nullable<int> in_Secuencia { get; set; }
        public double in_cantidad { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public Nullable<System.DateTime> cp_fecha { get; set; }
        public string cp_numero { get; set; }
        public int IdActivoFijo { get; set; }
        public double costo_uni { get; set; }
        public double subtotal { get; set; }
        public bool seleccionado { get; set; }
        //Campos vista data
        public string CodMoviInven { get; set; }
        public Nullable<System.DateTime> cm_fecha { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string nom_punto_cargo { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public string Tipo { get; set; }
        public decimal IdProducto { get; set; }
        public Nullable<double> saldo_aux { get; set; }
        public System.DateTime eg_fecha { get; set; }
        public string eg_codigo { get; set; }
    }
}
