using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_liquidacion_x_punto_cargo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int IdPunto_cargo { get; set; }
        public System.DateTime li_fecha { get; set; }
        public string IdTerminoPago { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string li_reporte_mantenimiento { get; set; }
        public string li_num_orden { get; set; }
        public string li_num_horas { get; set; }
        public string li_atencion_a { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public string li_tipo_pedido { get; set; }
        public bool estado { get; set; }        
        public Nullable<decimal> lo_IdProducto { get; set; }
        public Nullable<decimal> in_IdProducto { get; set; }
        public Nullable<decimal> eg_IdProducto { get; set; }
        public double li_por_iva { get; set; }
        public double li_subtotal { get; set; }
        public double li_valor_iva { get; set; }
        public double li_total { get; set; }
        public string IdCod_Impuesto { get; set; }
        public string li_observacion { get; set; }
        public Nullable<System.DateTime> li_fecha_orden_mantenimiento { get; set; }
        public Nullable<System.DateTime> li_fecha_reporte_mantenimiento { get; set; }
        public string li_referencia_facturas { get; set; }

        public List<fa_liquidacion_x_punto_cargo_det_mano_obra_Info> lst_det_mano_obra { get; set; }
        public List<fa_liquidacion_x_punto_cargo_det_logistica_Info> lst_det_logistica { get; set; }
        public List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info> lst_det_egresos { get; set; }
        public List<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info> lst_det_ingresos { get; set; }
        public List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info> lst_det_facturas { get; set; }


        public fa_liquidacion_x_punto_cargo_Info()
        {
            lst_det_egresos = new List<fa_liquidacion_x_punto_cargo_det_egresos_inventario_Info>();
            lst_det_facturas = new List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info>();
            lst_det_ingresos = new List<fa_liquidacion_x_punto_cargo_det_ingresos_consumo_directo_Info>();
            lst_det_logistica = new List<fa_liquidacion_x_punto_cargo_det_logistica_Info>();
            lst_det_mano_obra = new List<fa_liquidacion_x_punto_cargo_det_mano_obra_Info>();
        }

        public string nom_Centro_costo { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public string Su_Descripcion { get; set; }
        public string nom_punto_cargo { get; set; }
        public int numero_lineas { get; set; }
        public bool facturar { get; set; }
        public decimal IdCliente { get; set; }
        public string cod_liquidacion { get; set; }

    }
}
