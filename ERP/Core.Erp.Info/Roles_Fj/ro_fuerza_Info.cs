﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles_Fj
{
    public class ro_fuerza_Info
    {
        public int IdEmpresa { get; set; }
        public int IdFuerza { get; set; }
        public string fu_descripcion { get; set; }
        public bool Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transaccion { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdSuccentroCosto { get; set; }
        public string cedula_gasto { get; set; }
        public string descripcion_gasto { get; set; }
        public Nullable<double> valor_gasto { get; set; }
    }
}
