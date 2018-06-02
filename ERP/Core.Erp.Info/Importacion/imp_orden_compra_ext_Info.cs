﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Importacion
{
    public class imp_orden_compra_ext_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenCompra_ext { get; set; }
        public int IdMoneda_origen { get; set; }
        public int IdMoneda_destino { get; set; }
        public decimal IdProveedor { get; set; }
        public string IdPais_origen { get; set; }
        public string IdPais_embarque { get; set; }
        public string IdCiudad_destino { get; set; }
        public int IdCatalogo_via { get; set; }
        public int IdCatalogo_forma_pago { get; set; }
        public System.DateTime oe_fecha { get; set; }
        public Nullable<System.DateTime> oe_fecha_llegada_est { get; set; }
        public Nullable<System.DateTime> oe_fecha_embarque_est { get; set; }
        public Nullable<System.DateTime> oe_fecha_desaduanizacion_est { get; set; }
        public string IdCtaCble_importacion { get; set; }
        public string oe_observacion { get; set; }
        public string oe_codigo { get; set; }
        public double oe_valor_flete { get; set; }
        public double oe_valor_seguro { get; set; }
        public bool estado { get; set; }
        public Nullable<System.DateTime> oe_fecha_llegada { get; set; }
        public Nullable<System.DateTime> oe_fecha_embarque { get; set; }
        public Nullable<System.DateTime> oe_fecha_desaduanizacion { get; set; }
        public Nullable<decimal> IdLiquidacion { get; set; }


        public string IdUsuario_creacion { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string IdUsuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public string IdUsuario_anulacion { get; set; }
        public Nullable<System.DateTime> fecha_anulacion { get; set; }

        public List<imp_orden_compra_ext_det_Info> lst_det { get; set; }

        public imp_orden_compra_ext_Info()
        {
            lst_det = new List<imp_orden_compra_ext_det_Info>();
        }
    }
}
