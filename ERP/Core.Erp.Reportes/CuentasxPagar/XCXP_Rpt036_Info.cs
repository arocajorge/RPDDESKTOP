using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt036_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public Nullable<System.DateTime> co_FechaContabilizacion { get; set; }
        public string co_factura { get; set; }
        public decimal IdProveedor { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string co_observacion { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double co_valoriva { get; set; }
        public double co_total { get; set; }
        public double Total_Retencion { get; set; }
        public double monto_pagado { get; set; }
        public double Saldo { get; set; }
        public Nullable<bool> origen_bodega { get; set; }
        public Nullable<bool> origen_caja { get; set; }

        public Image image_origen_bodega { get; set; }
        public Image image_origen_caja { get; set; }
    }
}
