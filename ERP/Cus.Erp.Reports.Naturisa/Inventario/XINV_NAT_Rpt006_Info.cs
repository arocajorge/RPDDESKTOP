﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Inventario
{
    class XINV_NAT_Rpt006_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_unidad_medida { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string cod_bodega { get; set; }
        public string nom_bodega { get; set; }
        public string cod_sucursal { get; set; }
        public string nom_sucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public string nom_centro_costo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string nom_subcentro_costo { get; set; }
        public Nullable<double> dm_cantidad { get; set; }
        public double mv_costo { get; set; }
        public Nullable<double> Total { get; set; }
        public string mv_tipo_movi { get; set; }
    }
}
