﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Importacion
{
    public class imp_orden_compra_ext_ct_cbteble_det_gastos_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenCompra_ext { get; set; }
        public int IdEmpresa_ct { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public int secuencia_ct { get; set; }
        public Nullable<int> IdGasto_tipo { get; set; }

        //Campos vista
        public string IdCtaCble { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public double dc_Valor { get; set; }
        public string cb_Observacion { get; set; }
        public bool seleccionado { get; set; }
    }
}
