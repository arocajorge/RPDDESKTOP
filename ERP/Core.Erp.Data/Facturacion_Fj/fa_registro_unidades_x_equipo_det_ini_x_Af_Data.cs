using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_registro_unidades_x_equipo_det_ini_x_Af_Data
    {
        public List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Get_List_Inicial_x_Af(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Lista = new List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_registro_unidades_x_equipo_det_ini_x_Af
                              where q.IdEmpresa == info.IdEmpresa
                              && q.IdRegistro == info.IdRegistro
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_det_ini_x_Af_Info info_det = new fa_registro_unidades_x_equipo_det_ini_x_Af_Info();

                        info_det.IdEmpresa = item.IdEmpresa;
                        info_det.IdActivoFijo = item.IdActivoFijo;
                        info_det.IdRegistro = item.IdRegistro;
                        info_det.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        info_det.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        info_det.IdEmpresa_hn = item.IdEmpresa_hn;
                        info_det.IdSucursal_hn = item.IdSucursal_hn;
                        info_det.IdBodega_hn = item.IdBodega_hn;
                        info_det.IdCbteVta_hn = item.IdCbteVta_hn;

                        info_det.IdEmpresa_he = item.IdEmpresa_he;
                        info_det.IdSucursal_he = item.IdSucursal_he;
                        info_det.IdBodega_he = item.IdBodega_he;
                        info_det.IdCbteVta_he = item.IdCbteVta_he;
                        Lista.Add(info_det);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GuardarDB(List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Lista)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (var item in Lista)
                    {
                        fa_registro_unidades_x_equipo_det_ini_x_Af Entity = new fa_registro_unidades_x_equipo_det_ini_x_Af();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdRegistro = item.IdRegistro;
                        Entity.IdUnidadFact_cat = item.IdUnidadFact_cat;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;
                        Entity.IdEmpresa_hn = item.IdEmpresa_hn;
                        Entity.IdSucursal_hn = item.IdSucursal_hn;
                        Entity.IdBodega_hn = item.IdBodega_hn;
                        Entity.IdCbteVta_hn = item.IdCbteVta_hn;

                        Entity.IdEmpresa_he = item.IdEmpresa_he;
                        Entity.IdSucursal_he = item.IdSucursal_he;
                        Entity.IdBodega_he = item.IdBodega_he;
                        Entity.IdCbteVta_he = item.IdCbteVta_he;
                        Context.fa_registro_unidades_x_equipo_det_ini_x_Af.Add(Entity);
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(fa_registro_unidades_x_equipo_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete [Fj_servindustrias].[fa_registro_unidades_x_equipo_det_ini_x_Af] where IdEmpresa = " + info.IdEmpresa + " and IdRegistro = " + info.IdRegistro);
                }
                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Get_List_Inicial_x_Af_para_facturar(int IdEmpresa, string IdCentroCosto, int IdPeriodo)
        {
            try
            {
                List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Lista = new List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_registro_unidades_x_equipo_para_facturacion
                              where q.IdEmpresa == IdEmpresa
                              && q.IdPeriodo == IdPeriodo
                              && q.IdCentroCosto == IdCentroCosto
                              select q;

                    foreach (var item in lst)
                    {
                        fa_registro_unidades_x_equipo_det_ini_x_Af_Info info_det = new fa_registro_unidades_x_equipo_det_ini_x_Af_Info();

                        info_det.IdEmpresa = item.IdEmpresa;
                        info_det.IdActivoFijo = item.IdActivoFijo;
                        info_det.IdRegistro = item.IdRegistro;
                        info_det.Af_ValorUnidad_Actu = item.Af_ValorUnidad_Actu;

                        info_det.IdEmpresa_hn = item.IdEmpresa_hn;
                        info_det.IdSucursal_hn = item.IdSucursal_hn;
                        info_det.IdBodega_hn = item.IdBodega_hn;
                        info_det.IdCbteVta_hn = item.IdCbteVta_hn;

                        info_det.IdEmpresa_he = item.IdEmpresa_he;
                        info_det.IdSucursal_he = item.IdSucursal_he;
                        info_det.IdBodega_he = item.IdBodega_he;
                        info_det.IdCbteVta_he = item.IdCbteVta_he;

                        info_det.IdCentroCosto = item.IdCentroCosto;
                        info_det.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info_det.unidades_maximas = item.unidades_maximas;
                        info_det.diferencia_a_facturar = item.diferencia_a_facturar;
                        info_det.IdPunto_cargo = item.IdPunto_cargo;
                        info_det.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        info_det.nom_punto_cargo = item.nom_punto_cargo;
                        Lista.Add(info_det);
                    }

                    int anio = Convert.ToInt32(IdPeriodo.ToString().Substring(0, 4));

                    var lst_tarifario = (from c in Context.fa_tarifario_horometro
                               join d in Context.fa_tarifario_horometro_det
                               on new { c.IdEmpresa, c.IdTarifario } equals new { d.IdEmpresa, d.IdTarifario }
                               where c.IdEmpresa == IdEmpresa && c.IdCentroCosto == IdCentroCosto
                               && c.IdPeriodo_ini <= IdPeriodo && IdPeriodo <= c.IdPeriodo_fin
                               && c.estado == true
                               select new fa_tarifario_horometro_det_Info
                               {
                                   IdEmpresa = d.IdEmpresa,
                                   IdTarifario = d.IdTarifario,
                                   Secuencia = d.Secuencia,
                                   IdActivoFijo = d.IdActivoFijo,
                                   valor_unidad = d.valor_unidad,
                                   unidades_minimas = d.unidades_minimas,
                                   total_valor_x_unidades_minimas = d.total_valor_x_unidades_minimas,
                                   IdProducto_normal = c.IdProducto_hora_regular,
                                   IdProducto_extra = c.IdProducto_hora_extra,
                                   IdCod_Impuesto = c.IdCod_Impuesto,
                                   porcentaje = c.porcentaje
                               }).ToList();

                    foreach (var item in Lista)
                    {
                        fa_tarifario_horometro_det_Info info_tarifario_x_activo = lst_tarifario.FirstOrDefault(q => q.IdActivoFijo == item.IdActivoFijo);
                        if (info_tarifario_x_activo != null)
                        {
                            item.cantidad_unidades_normales = item.diferencia_a_facturar < info_tarifario_x_activo.unidades_minimas ? info_tarifario_x_activo.unidades_minimas : info_tarifario_x_activo.unidades_minimas;
                            item.cantidad_unidades_extra = item.diferencia_a_facturar > info_tarifario_x_activo.unidades_minimas ? item.diferencia_a_facturar - info_tarifario_x_activo.unidades_minimas : 0;
                            item.valor_x_unidad = info_tarifario_x_activo.valor_unidad;
                            item.total_facturar_unidades_normales = item.cantidad_unidades_normales * item.valor_x_unidad;
                            item.total_facturar_unidades_extra = item.cantidad_unidades_extra * item.valor_x_unidad;
                            item.IdProducto_normal = info_tarifario_x_activo.IdProducto_normal;
                            item.IdProducto_extra = info_tarifario_x_activo.IdProducto_extra;
                            item.IdCod_Impuesto = info_tarifario_x_activo.IdCod_Impuesto;
                            item.porcentaje = info_tarifario_x_activo.porcentaje;
                        }
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> Lista)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (var item in Lista)
                    {
                        fa_registro_unidades_x_equipo_det_ini_x_Af Entity = Context.fa_registro_unidades_x_equipo_det_ini_x_Af.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdRegistro == item.IdRegistro && q.IdActivoFijo == item.IdActivoFijo);
                        if (Entity!= null)
                        {
                            Entity.IdEmpresa_hn = item.IdEmpresa_hn;
                            Entity.IdSucursal_hn = item.IdSucursal_hn;
                            Entity.IdBodega_hn = item.IdBodega_hn;
                            Entity.IdCbteVta_hn = item.IdCbteVta_hn;

                            Entity.IdEmpresa_he = item.IdEmpresa_he;
                            Entity.IdSucursal_he = item.IdSucursal_he;
                            Entity.IdBodega_he = item.IdBodega_he;
                            Entity.IdCbteVta_he = item.IdCbteVta_he;
                            Context.SaveChanges();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
