﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;


namespace Core.Erp.Info.Inventario
{
    public class in_Parametro_Info
    {
        public int IdEmpresa { get; set; }
        
        public int ? IdMovi_inven_tipo_egresoBodegaOrigen { get; set; }
        public int ? IdMovi_inven_tipo_ingresoBodegaDestino { get; set; }

        public string Maneja_Stock_Negativo { get; set; }

        public string Usuario_Escoge_Motivo { get; set; }

        public int ?IdMovi_inven_tipo_egresoAjuste { get; set; }
        public int ?IdMovi_inven_tipo_ingresoAjuste { get; set; }

        public Nullable<int> IdMovi_inven_tipo_x_distribucion_ing { get; set; }
        public Nullable<int> IdMovi_inven_tipo_x_distribucion_egr { get; set; }


        public Nullable<int> P_IdProductoTipo_para_lote_0 { get; set; }
        public Nullable<bool> P_se_crea_lote_0_al_crear_producto_matriz { get; set; }

        public string ApruebaAjusteFisicoAuto { get; set; }
        public string pa_EstadoInicial_Pedido { get; set; }

        public string IdCentro_Costo_Inventario { get; set; }
        public string IdCentro_Costo_Costo { get; set; }
        public int? IdTipoCbte_CostoInven_Reverso { get; set; }

        public int? IdMovi_Inven_tipo_x_anu_Ing { get; set; }
        public int? IdMovi_Inven_tipo_x_anu_Egr { get; set; }

        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_CostoInven { get; set; }
        public int? IdTipoCbte_CostoInven { get; set; }
        
        public int ? IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa { get; set; }
        public int ? IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa { get; set; }

        public string IdEstadoAproba_x_Ing { get; set; }
        public string IdEstadoAproba_x_Egr { get; set; }

        public int ? IdMovi_Inven_tipo_x_Dev_Inv_x_Ing { get; set; }
        public int ? IdMovi_Inven_tipo_x_Dev_Inv_x_Erg { get; set; }

        public string P_Fecha_para_contabilizacion_ingr_egr { get; set; }
        public Nullable<bool> P_se_valida_parametrizacion_x_producto { get; set; }

        public string P_IdCtaCble_transitoria_transf_inven { get; set; }
        public Nullable<int> P_IdMovi_inven_tipo_default_ing { get; set; }
        public Nullable<int> P_IdMovi_inven_tipo_default_egr { get; set; }
        public Nullable<int> P_IdMovi_inven_tipo_ingreso_x_compra { get; set; }

        public Nullable<int> P_Dias_menores_alerta_desde_fecha_actual_rojo { get; set; }
        public Nullable<int> P_Dias_menores_alerta_desde_fecha_actual_amarillo { get; set; }

    }
}
