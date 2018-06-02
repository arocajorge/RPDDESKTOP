using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class in_Parametro_Data
    {
        string mensaje = "";
        public Boolean ModificarDB(in_Parametro_Info info, int IdEmpresa)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    EntitiesInventario param_Info = new EntitiesInventario();
                    var selectBaParam = (from C in param_Info.in_parametro
                                         where C.IdEmpresa == IdEmpresa
                                         select C).Count();
                    if (selectBaParam == 0)
                    {
                        var addressG = new in_parametro();
                        addressG.IdEmpresa = IdEmpresa;
                        addressG.IdMovi_inven_tipo_egresoBodegaOrigen = info.IdMovi_inven_tipo_egresoBodegaOrigen;
                        addressG.IdMovi_inven_tipo_ingresoBodegaDestino = info.IdMovi_inven_tipo_ingresoBodegaDestino;
                        addressG.Maneja_Stock_Negativo = info.Maneja_Stock_Negativo;
                        addressG.Usuario_Escoge_Motivo = info.Usuario_Escoge_Motivo;
                        addressG.IdMovi_inven_tipo_egresoAjuste = info.IdMovi_inven_tipo_egresoAjuste;
                        addressG.IdMovi_inven_tipo_ingresoAjuste = info.IdMovi_inven_tipo_ingresoAjuste;
                        addressG.ApruebaAjusteFisicoAuto = info.ApruebaAjusteFisicoAuto;


                        addressG.IdCtaCble_Inven = (info.IdCtaCble_Inven == "") ? null : info.IdCtaCble_Inven;
                        addressG.IdCtaCble_CostoInven = (info.IdCtaCble_CostoInven == "") ? null : info.IdCtaCble_CostoInven;
                         
                        if(info.IdTipoCbte_CostoInven != 0) 
                        addressG.IdTipoCbte_CostoInven = info.IdTipoCbte_CostoInven;
                        if (info.IdTipoCbte_CostoInven_Reverso != 0) 
                        addressG.IdTipoCbte_CostoInven_Reverso = info.IdTipoCbte_CostoInven_Reverso;
                        if (info.IdMovi_Inven_tipo_x_anu_Ing != 0) 
                        addressG.IdMovi_Inven_tipo_x_anu_Ing = (info.IdMovi_Inven_tipo_x_anu_Ing);
                        if (info.IdMovi_Inven_tipo_x_anu_Egr != 0) 
                        addressG.IdMovi_Inven_tipo_x_anu_Egr = (info.IdMovi_Inven_tipo_x_anu_Egr);

                        if (info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa != 0)
                            addressG.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa = (info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa);
                        if (info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa != 0)
                            addressG.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa = (info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa);

                        addressG.IdEstadoAproba_x_Ing = info.IdEstadoAproba_x_Ing;
                        addressG.IdEstadoAproba_x_Egr = info.IdEstadoAproba_x_Egr;

                        addressG.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg = info.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg;
                        addressG.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing = info.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing;
                        addressG.P_Fecha_para_contabilizacion_ingr_egr = info.P_Fecha_para_contabilizacion_ingr_egr;
                        addressG.P_se_valida_parametrizacion_x_producto = (info.P_se_valida_parametrizacion_x_producto == null) ? false : Convert.ToBoolean(info.P_se_valida_parametrizacion_x_producto);
                        addressG.P_IdProductoTipo_para_lote_0 = info.P_IdProductoTipo_para_lote_0;
                        addressG.P_se_crea_lote_0_al_crear_producto_matriz = info.P_se_crea_lote_0_al_crear_producto_matriz;
                        addressG.P_IdCtaCble_transitoria_transf_inven = (info.P_IdCtaCble_transitoria_transf_inven == null) ? null : Convert.ToString(info.P_IdCtaCble_transitoria_transf_inven);
                        addressG.IdMovi_inven_tipo_x_distribucion_egr = info.IdMovi_inven_tipo_x_distribucion_egr;
                        addressG.IdMovi_inven_tipo_x_distribucion_ing = info.IdMovi_inven_tipo_x_distribucion_ing;
                        addressG.P_IdMovi_inven_tipo_default_egr = info.P_IdMovi_inven_tipo_default_egr;
                        addressG.P_IdMovi_inven_tipo_default_ing = info.P_IdMovi_inven_tipo_default_ing;
                        addressG.P_IdMovi_inven_tipo_ingreso_x_compra = info.P_IdMovi_inven_tipo_ingreso_x_compra;
                        addressG.P_Dias_menores_alerta_desde_fecha_actual_amarillo = info.P_Dias_menores_alerta_desde_fecha_actual_amarillo;
                        addressG.P_Dias_menores_alerta_desde_fecha_actual_rojo = info.P_Dias_menores_alerta_desde_fecha_actual_rojo;
                        context.in_parametro.Add(addressG);
                        context.SaveChanges();
                    }
                    else
                    {
                        var contact = context.in_parametro.First(para => para.IdEmpresa == IdEmpresa);
                        contact.IdEmpresa = IdEmpresa;
                        contact.IdMovi_inven_tipo_egresoBodegaOrigen = info.IdMovi_inven_tipo_egresoBodegaOrigen;
                        contact.IdMovi_inven_tipo_ingresoBodegaDestino = info.IdMovi_inven_tipo_ingresoBodegaDestino;
                        contact.Maneja_Stock_Negativo = info.Maneja_Stock_Negativo;
                        contact.Usuario_Escoge_Motivo = info.Usuario_Escoge_Motivo;
                        contact.IdMovi_inven_tipo_egresoAjuste = info.IdMovi_inven_tipo_egresoAjuste;
                        contact.IdMovi_inven_tipo_ingresoAjuste = info.IdMovi_inven_tipo_ingresoAjuste;
                        contact.ApruebaAjusteFisicoAuto = info.ApruebaAjusteFisicoAuto;

                        contact.IdCtaCble_Inven = info.IdCtaCble_Inven;
                        contact.IdCtaCble_CostoInven = info.IdCtaCble_CostoInven;
                        contact.IdEstadoAproba_x_Ing = info.IdEstadoAproba_x_Ing;
                        contact.IdEstadoAproba_x_Egr = info.IdEstadoAproba_x_Egr;

                        if (info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa != 0)
                            contact.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa = (info.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa);
                        if (info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa != 0)
                            contact.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa = (info.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa);

                        if (info.IdTipoCbte_CostoInven != 0)
                            contact.IdTipoCbte_CostoInven = info.IdTipoCbte_CostoInven;
                        if (info.IdTipoCbte_CostoInven_Reverso != 0)
                            contact.IdTipoCbte_CostoInven_Reverso = info.IdTipoCbte_CostoInven_Reverso;
                        if (info.IdMovi_Inven_tipo_x_anu_Ing != 0)
                            contact.IdMovi_Inven_tipo_x_anu_Ing = (info.IdMovi_Inven_tipo_x_anu_Ing);
                        if (info.IdMovi_Inven_tipo_x_anu_Egr != 0)
                            contact.IdMovi_Inven_tipo_x_anu_Egr = (info.IdMovi_Inven_tipo_x_anu_Egr);
                        contact.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg = info.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg;
                        contact.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing = info.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing;
                        contact.P_Fecha_para_contabilizacion_ingr_egr = info.P_Fecha_para_contabilizacion_ingr_egr;
                        contact.P_se_valida_parametrizacion_x_producto = (info.P_se_valida_parametrizacion_x_producto == null) ? false : Convert.ToBoolean(info.P_se_valida_parametrizacion_x_producto);
                        contact.P_IdProductoTipo_para_lote_0 = info.P_IdProductoTipo_para_lote_0;
                        contact.P_se_crea_lote_0_al_crear_producto_matriz = info.P_se_crea_lote_0_al_crear_producto_matriz;
                        contact.IdMovi_inven_tipo_x_distribucion_ing = info.IdMovi_inven_tipo_x_distribucion_ing;
                        contact.IdMovi_inven_tipo_x_distribucion_egr = info.IdMovi_inven_tipo_x_distribucion_egr;
                        contact.P_IdCtaCble_transitoria_transf_inven = (info.P_IdCtaCble_transitoria_transf_inven == null) ? null : Convert.ToString(info.P_IdCtaCble_transitoria_transf_inven);
                        contact.P_IdMovi_inven_tipo_default_egr = info.P_IdMovi_inven_tipo_default_egr;
                        contact.P_IdMovi_inven_tipo_default_ing = info.P_IdMovi_inven_tipo_default_ing;
                        contact.P_IdMovi_inven_tipo_ingreso_x_compra = info.P_IdMovi_inven_tipo_ingreso_x_compra;
                        contact.P_Dias_menores_alerta_desde_fecha_actual_amarillo = info.P_Dias_menores_alerta_desde_fecha_actual_amarillo;
                        contact.P_Dias_menores_alerta_desde_fecha_actual_rojo = info.P_Dias_menores_alerta_desde_fecha_actual_rojo;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public in_Parametro_Info Get_Info_Parametro(int IdEmpresa)
        {
            try
            {
                in_Parametro_Info Cbt=null;
                EntitiesInventario param_Info = new EntitiesInventario();
                var selectBaParam = from C in param_Info.in_parametro
                                    where C.IdEmpresa == IdEmpresa
                                    select C;
                foreach (var item in selectBaParam)
                {
                    Cbt = new in_Parametro_Info();            
                    
                    Cbt.IdMovi_inven_tipo_egresoBodegaOrigen =Convert.ToInt32( item.IdMovi_inven_tipo_egresoBodegaOrigen);
                    Cbt.IdMovi_inven_tipo_ingresoBodegaDestino = Convert.ToInt32(item.IdMovi_inven_tipo_ingresoBodegaDestino);
                    Cbt.Maneja_Stock_Negativo = item.Maneja_Stock_Negativo;
                    Cbt.Usuario_Escoge_Motivo = item.Usuario_Escoge_Motivo;
                    Cbt.IdMovi_inven_tipo_egresoAjuste = Convert.ToInt32(item.IdMovi_inven_tipo_egresoAjuste);
                    Cbt.IdMovi_inven_tipo_ingresoAjuste = Convert.ToInt32(item.IdMovi_inven_tipo_ingresoAjuste);
                    Cbt.ApruebaAjusteFisicoAuto = item.ApruebaAjusteFisicoAuto;
                    Cbt.IdEmpresa = IdEmpresa;
                    Cbt.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    Cbt.IdCtaCble_CostoInven = item.IdCtaCble_CostoInven;
                    Cbt.IdTipoCbte_CostoInven = item.IdTipoCbte_CostoInven;
                    Cbt.IdTipoCbte_CostoInven_Reverso = item.IdTipoCbte_CostoInven_Reverso;
                    Cbt.IdMovi_Inven_tipo_x_anu_Egr = item.IdMovi_Inven_tipo_x_anu_Egr;
                    Cbt.IdMovi_Inven_tipo_x_anu_Ing = item.IdMovi_Inven_tipo_x_anu_Ing;
                    Cbt.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa = item.IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa;
                    Cbt.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa = item.IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa;
                    Cbt.IdTipoCbte_CostoInven = item.IdTipoCbte_CostoInven;
                    Cbt.IdTipoCbte_CostoInven_Reverso = item.IdTipoCbte_CostoInven_Reverso;
                    Cbt.IdMovi_Inven_tipo_x_anu_Ing = (item.IdMovi_Inven_tipo_x_anu_Ing);
                    Cbt.IdMovi_Inven_tipo_x_anu_Egr = (item.IdMovi_Inven_tipo_x_anu_Egr);
                    Cbt.IdEstadoAproba_x_Ing = item.IdEstadoAproba_x_Ing;
                    Cbt.IdEstadoAproba_x_Egr = item.IdEstadoAproba_x_Egr;
                    Cbt.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg = item.IdMovi_Inven_tipo_x_Dev_Inv_x_Erg;
                    Cbt.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing = item.IdMovi_Inven_tipo_x_Dev_Inv_x_Ing;
                    Cbt.P_Fecha_para_contabilizacion_ingr_egr = item.P_Fecha_para_contabilizacion_ingr_egr;
                    Cbt.P_se_valida_parametrizacion_x_producto = item.P_se_valida_parametrizacion_x_producto;
                    Cbt.P_IdCtaCble_transitoria_transf_inven = item.P_IdCtaCble_transitoria_transf_inven;
                    Cbt.P_IdProductoTipo_para_lote_0 = item.P_IdProductoTipo_para_lote_0;
                    Cbt.P_se_crea_lote_0_al_crear_producto_matriz = item.P_se_crea_lote_0_al_crear_producto_matriz;
                    Cbt.IdMovi_inven_tipo_x_distribucion_ing = item.IdMovi_inven_tipo_x_distribucion_ing;
                    Cbt.IdMovi_inven_tipo_x_distribucion_egr = item.IdMovi_inven_tipo_x_distribucion_egr;
                    Cbt.P_IdMovi_inven_tipo_default_egr = item.P_IdMovi_inven_tipo_default_egr;
                    Cbt.P_IdMovi_inven_tipo_default_ing = item.P_IdMovi_inven_tipo_default_ing;
                    Cbt.P_IdMovi_inven_tipo_ingreso_x_compra = item.P_IdMovi_inven_tipo_ingreso_x_compra;
                    Cbt.P_Dias_menores_alerta_desde_fecha_actual_rojo = item.P_Dias_menores_alerta_desde_fecha_actual_rojo;
                    Cbt.P_Dias_menores_alerta_desde_fecha_actual_amarillo = item.P_Dias_menores_alerta_desde_fecha_actual_amarillo;
                }
                return (Cbt);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
