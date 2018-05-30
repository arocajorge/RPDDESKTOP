using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt019_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdCbteVta { get; set; }
        public string dc_tipo_documento { get; set; }
        public string observacion { get; set; }
        public string num_documento { get; set; }
        public System.DateTime fecha { get; set; }
        public System.DateTime fecha_vcto { get; set; }
        public decimal IdCliente { get; set; }
        public string nom_cliente { get; set; }
        public double subtotal { get; set; }
        public double valor_iva { get; set; }
        public double valor_total { get; set; }
        public double valor_retencion { get; set; }
        public double valor_pagos { get; set; }
        public double valor_nc { get; set; }
        public double saldo { get; set; }
    }
}
