﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt012_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdProforma { get; set; }
        public int Secuencia { get; set; }
        public string nom_TerminoPago { get; set; }
        public int pf_plazo { get; set; }
        public string pf_codigo { get; set; }
        public System.DateTime pf_fecha { get; set; }
        public bool estado { get; set; }
        public string pf_atencion_a { get; set; }
        public string Codigo { get; set; }
        public string Ve_Vendedor { get; set; }
        public string pr_descripcion { get; set; }
        public double pd_cantidad { get; set; }
        public double pd_precio { get; set; }
        public double pd_por_descuento_uni { get; set; }
        public double pd_descuento_uni { get; set; }
        public double pd_precio_final { get; set; }
        public double pd_subtotal { get; set; }
        public double pd_por_iva { get; set; }
        public double pd_iva { get; set; }
        public double pd_total { get; set; }
        public string nom_modelo { get; set; }
        public string nom_marca { get; set; }
        public Image Imagen_image { get; set; }
        public byte[] Imagen { get; set; }
        public decimal IdProducto { get; set; }
        public string observacion { get; set; }
        public int pf_dias_entrega { get; set; }
    }
}
