using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Activo_fijo_Info
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string CodActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public Nullable<int> IdActivoFijoTipo { get; set; }
        public string IdCatalogo_Marca { get; set; }
        public string IdCatalogo_Modelo { get; set; }
        public string Af_NumSerie { get; set; }
        public string IdCatalogo_Color { get; set; }
        public string IdTipoCatalogo_Ubicacion { get; set; }
        public System.DateTime Af_fecha_compra { get; set; }
        public System.DateTime Af_fecha_ini_depre { get; set; }
        public System.DateTime Af_fecha_fin_depre { get; set; }
        public double Af_Costo_historico { get; set; }
        public double Af_costo_compra { get; set; }
        public Nullable<double> Af_Depreciacion_acum { get; set; }
        public int Af_Vida_Util { get; set; }
        public int Af_Meses_depreciar { get; set; }
        public double Af_porcentaje_deprec { get; set; }
        public string Af_observacion { get; set; }
        public string Af_NumPlaca { get; set; }
        public Nullable<int> Af_Anio_fabrica { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }
        public byte[] Af_foto { get; set; }
        public string Af_DescripcionCorta { get; set; }
        public string Af_Codigo_Barra { get; set; }
        public string Af_DescripcionTecnica { get; set; }
        public string Estado_Proceso { get; set; }
        public Nullable<double> Af_ValorSalvamento { get; set; }
        public Nullable<double> Af_ValorResidual { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string Af_NumSerie_Motor { get; set; }
        public string Af_NumSerie_Chasis { get; set; }
        public Nullable<int> IdCategoriaAF { get; set; }
        public Nullable<int> IdGrupoActivoFijo { get; set; }
        public Nullable<double> Af_valor_asegurado { get; set; }
        public Nullable<double> Af_valor_asegurado_extra { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public List<Af_Activo_fijo_x_Af_Activo_fijo_Info> lista_Activo_relacionados { get; set; }
        public Boolean Seleccionado { get; set; }
        //campos vista
        public string nom_Categoria { get; set; }
        public string nom_encargado { get; set; }
        public string nom_Color { get; set; }
        public string nom_UnidadFact { get; set; }
        public string nom_Cliente { get; set; }
        public string nom_punto_cargo { get; set; }
        public string nom_Centro_costo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double costo_compra_carroceria { get; set; }
        public double valor_salvamento_carroceria { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }

        public List< Af_Activo_fijo_CtasCbles_Info> ListAf_Activo_fijo_CtasCbles { get; set; }
        
        public Af_Activo_fijo_Info() 
        {
            ListAf_Activo_fijo_CtasCbles = new List<Af_Activo_fijo_CtasCbles_Info>();
        }


    }
}
