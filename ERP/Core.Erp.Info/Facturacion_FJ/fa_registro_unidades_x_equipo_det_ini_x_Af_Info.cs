using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Facturacion_FJ
{
    public class fa_registro_unidades_x_equipo_det_ini_x_Af_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdRegistro { get; set; }
        public int IdActivoFijo { get; set; }
        public string IdUnidadFact_cat { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
        public Nullable<int> IdEmpresa_hn { get; set; }
        public Nullable<int> IdSucursal_hn { get; set; }
        public Nullable<int> IdBodega_hn { get; set; }
        public Nullable<decimal> IdCbteVta_hn { get; set; }
        public Nullable<int> IdEmpresa_he { get; set; }
        public Nullable<int> IdSucursal_he { get; set; }
        public Nullable<int> IdBodega_he { get; set; }
        public Nullable<decimal> IdCbteVta_he { get; set; }
        
        
        //Campos vista
        public string IdCentroCosto { get; set; }
        public double unidades_maximas { get; set; }
        public double diferencia_a_facturar { get; set; }
        public int IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        //Campos para calcular tarifario
        public double cantidad_unidades_normales { get; set; }
        public double cantidad_unidades_extra { get; set; }
        public double valor_x_unidad { get; set; }
        public double total_facturar_unidades_normales { get; set; }
        public double total_facturar_unidades_extra { get; set; }
        public decimal IdProducto_normal { get; set; }
        public decimal IdProducto_extra { get; set; }
        public string IdCod_Impuesto { get; set; }
        public double porcentaje { get; set; }
        //Campos grilla
        public bool seleccionado { get; set; }
        
    }
}
