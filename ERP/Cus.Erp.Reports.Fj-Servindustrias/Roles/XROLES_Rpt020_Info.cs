using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROLES_Rpt020_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public Nullable<double> dm_cantidad { get; set; }
        public Nullable<decimal> IdEmpleado { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_Centro_costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string cm_observacion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string CodMoviInven { get; set; }
        public string ca_descripcion { get; set; }
        public string de_descripcion { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }

    }
}
