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
    
    public partial class ba_prestamo_detalle_cancelacion
    {
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public int NumCuota { get; set; }
        public int Secuencia { get; set; }
        public double Monto_Canc { get; set; }
        public double Saldo { get; set; }
        public System.DateTime FechaPago { get; set; }
        public string Observacion_canc { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ba_prestamo_detalle ba_prestamo_detalle { get; set; }
    }
}
