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
    
    public partial class vwseg_Menu_x_Usuario_x_Empresa
    {
        public int IdMenu { get; set; }
        public Nullable<int> IdMenuPadre { get; set; }
        public string DescripcionMenu { get; set; }
        public int PosicionMenu { get; set; }
        public bool Habilitado { get; set; }
        public bool Tiene_FormularioAsociado { get; set; }
        public string nom_Formulario { get; set; }
        public string nom_Asembly { get; set; }
        public Nullable<int> nivel { get; set; }
        public int IdEmpresa { get; set; }
        public string IdUsuario { get; set; }
        public bool Eliminacion { get; set; }
        public bool Escritura { get; set; }
        public bool Lectura { get; set; }
    }
}
