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
    
    public partial class vwRo_Permiso_x_Empleado
    {
        public int IdEmpresa { get; set; }
        public decimal IdPermiso { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal IdEmpleado { get; set; }
        public string MotivoAusencia { get; set; }
        public string FormaRecuperacion { get; set; }
        public Nullable<decimal> IdEmpleado_Soli { get; set; }
        public string IdEstadoAprob { get; set; }
        public Nullable<decimal> IdEmpleado_Apro { get; set; }
        public string MotivoAproba { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public string NomEmpleado { get; set; }
        public string NomEmpleado_Aprobo { get; set; }
        public string IdTipoLicencia { get; set; }
        public Nullable<bool> EsLicencia { get; set; }
        public Nullable<bool> EsPermiso { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
        public Nullable<System.DateTime> FechaEntrada { get; set; }
        public System.TimeSpan TiempoAusencia { get; set; }
        public string HoraRegreso { get; set; }
        public string HoraSalida { get; set; }
        public string MotivoAnulacion { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string ca_descripcion { get; set; }
        public string de_descripcion { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string em_codigo { get; set; }
        public string Id_Forma_descuento_permiso_Cat { get; set; }
        public Nullable<int> Dias_tomados { get; set; }
        public int IdNomina_Tipo { get; set; }
        public Nullable<decimal> IdNovedad { get; set; }
    }
}
