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
    
    public partial class vwtb_tb_banco_procesos_bancarios
    {
        public int IdEmpresa { get; set; }
        public string IdProceso_bancario_tipo { get; set; }
        public int IdBanco { get; set; }
        public string cod_banco { get; set; }
        public string Codigo_Empresa { get; set; }
        public string Iniciales_Archivo { get; set; }
        public string nom_proceso_bancario { get; set; }
        public Nullable<decimal> Secuencial_detalle_inicial { get; set; }
        public Nullable<int> IdTipoNota { get; set; }
        public Nullable<bool> Se_contabiliza { get; set; }
        public string Tipo_Proc { get; set; }
    }
}
