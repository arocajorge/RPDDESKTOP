//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcp_cp_archivos_para_banco_x_cxp_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdArchivo { get; set; }
        public int IdBanco { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Cod_Empresa { get; set; }
        public string Tipo { get; set; }
        public string Nom_Archivo { get; set; }
        public string estado { get; set; }
        public string observacion { get; set; }
        public Nullable<decimal> IdOrdenPago_op { get; set; }
        public string Observacion_OP { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_razonSocial { get; set; }
        public string num_cta { get; set; }
        public string IdTipoCta { get; set; }
        public string pe_cedulaRuc { get; set; }
        public Nullable<double> Saldo_x_pagar { get; set; }
        public Nullable<double> Valor_pagado { get; set; }
        public int IdTipoPersona { get; set; }
        public Nullable<int> IdEmpresa_op { get; set; }
        public int Secuencia { get; set; }
        public int Secuencia_op { get; set; }
        public string pe_Naturaleza { get; set; }
        public string CodPersona { get; set; }
        public decimal IdPersona { get; set; }
        public string IdTipoDocumento { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string Motivo_aproba { get; set; }
        public System.DateTime Fecha_Pago { get; set; }
    }
}
