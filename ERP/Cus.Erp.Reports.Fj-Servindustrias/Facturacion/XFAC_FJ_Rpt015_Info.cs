using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt015_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int IdPunto_cargo { get; set; }
        public System.DateTime li_fecha { get; set; }
        public string IdTerminoPago { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string li_num_orden { get; set; }
        public string li_num_horas { get; set; }
        public string li_atencion_a { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public string li_tipo_pedido { get; set; }
        public bool estado { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string nom_TerminoPago { get; set; }
        public string nom_punto_cargo { get; set; }
        public string Centro_costo { get; set; }
        public string codigo { get; set; }
        public string Su_Descripcion { get; set; }
        public string cod_liquidacion { get; set; }
        public string li_reporte_mantenimiento { get; set; }
        public double li_subtotal { get; set; }
        public double li_por_iva { get; set; }
        public double li_valor_iva { get; set; }
        public double li_total { get; set; }
        public string li_observacion { get; set; }
        public string su_Direccion { get; set; }
    }
}
