//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwFAC_Rpt002
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_NunDocumento { get; set; }
        public string Referencia { get; set; }
        public decimal IdComprobante { get; set; }
        public string CodComprobante { get; set; }
        public string Su_Descripcion { get; set; }
        public decimal IdCliente { get; set; }
        public string nombreCliente { get; set; }
        public string pe_cedulaRuc { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public Nullable<double> vt_total { get; set; }
        public Nullable<double> Saldo { get; set; }
        public double TotalCobrado { get; set; }
        public double vt_Subtotal { get; set; }
        public Nullable<double> vt_iva { get; set; }
        public System.DateTime vt_fech_venc { get; set; }
        public Nullable<double> dc_ValorRetFu { get; set; }
        public Nullable<double> dc_ValorRetIva { get; set; }
        public decimal vt_plazo { get; set; }
        public string IdUsuario { get; set; }
        public double SubTotal_0 { get; set; }
        public double SubTotal_Iva { get; set; }
        public string IdFormaPago { get; set; }
        public string nom_FormaPago { get; set; }
        public Nullable<double> vt_por_iva { get; set; }
    }
}
