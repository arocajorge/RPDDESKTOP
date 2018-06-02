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
    public class fa_pre_facturacion_det_Data
    {

        #region Variables
        tb_sis_impuesto_Data data_impuesto = new tb_sis_impuesto_Data();
        tb_sis_impuesto_Info info_impuesto = new tb_sis_impuesto_Info();
        fa_parametro_FJ_Info info_param_fj = new fa_parametro_FJ_Info();
        fa_parametro_FJ_Data data_param_fj = new fa_parametro_FJ_Data();
        #endregion

        public List<fa_pre_facturacion_det_Info> get_list(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Lista = (from q in Context.fa_pre_facturacion_det
                             where q.IdEmpresa == IdEmpresa
                             && q.IdPreFacturacion == IdPrefacturacion
                             select new fa_pre_facturacion_det_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdPreFacturacion = q.IdPreFacturacion,
                                 Secuencia = q.Secuencia,
                                 IdGrupo = q.IdGrupo,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 IdProducto = q.IdProducto,
                                 subtotal = q.subtotal,
                                 valor_ganancia = q.valor_ganancia,
                                 IdCod_Impuesto = q.IdCod_Impuesto,
                                 por_iva = q.por_iva,
                                 valor_iva = q.valor_iva,
                                 total = q.total,
                                 IdEmpresa_vta = q.IdEmpresa_vta,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 IdCbteVta = q.IdCbteVta,
                                 IdProceso_prefacturacion = q.IdProceso_prefacturacion,
                             }).ToList();
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

        public bool guardarDB(List<fa_pre_facturacion_det_Info> lst)
        {
            try
            {
                int Secuencia = 1;

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lst)
                    {
                        while (lst.Where(q=>q.Secuencia == Secuencia).Count() != 0)
                        {
                            Secuencia++;
                        }

                        fa_pre_facturacion_det Entity = new fa_pre_facturacion_det();
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPreFacturacion = item.IdPreFacturacion;
                        Entity.Secuencia = item.Secuencia = Secuencia;
                        Entity.IdGrupo = item.IdGrupo;
                        Entity.IdCentroCosto = item.IdCentroCosto;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.IdProducto = item.IdProducto;
                        Entity.subtotal = item.subtotal;
                        Entity.valor_ganancia = item.valor_ganancia;
                        Entity.IdCod_Impuesto = item.IdCod_Impuesto;
                        Entity.por_iva = item.por_iva;
                        Entity.valor_iva = item.valor_iva;
                        Entity.total = item.total;
                        Entity.IdEmpresa_vta = item.IdEmpresa_vta;
                        Entity.IdSucursal = item.IdSucursal;
                        Entity.IdBodega = item.IdBodega;
                        Entity.IdCbteVta = item.IdCbteVta;
                        Entity.IdProceso_prefacturacion = item.IdProceso_prefacturacion;
                        Context.fa_pre_facturacion_det.Add(Entity);
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

        public bool eliminarDB(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("DELETE Fj_servindustrias.fa_pre_facturacion_det WHERE IdEmpresa = " + IdEmpresa + " and IdPreFacturacion = " + IdPrefacturacion);
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

        public List<fa_pre_facturacion_det_Info> get_list_gastos(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_pre_facturacion_det_Fact_x_Gastos
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdPreFacturacion == info_prefacturacion.IdPreFacturacion
                              && q.IdCentro_Costo == info_prefacturacion.IdCentroCosto
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat && q.IdAnio == anio
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdGrupo = item.IdGrupo;
                        if (item.IdProducto != null)
                            info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                        else
                            info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                        info.subtotal = lst.Where(q => q.IdCentro_Costo == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).Sum(q => q.Valor_a_cobrar);
                        if (aplica_porc_ganancia)
                            info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).porcentaje / 100);
                        else
                            info.valor_ganancia = 0;

                        info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                        info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                        info.por_iva = info_impuesto.porcentaje;
                        info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                        info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                        Lista.Add(info);
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

        public List<fa_pre_facturacion_det_Info> get_list_depreciacion(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_depreciacion_x_activo
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                              && q.IdPeriodo == info_prefacturacion.IdPeriodo
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat && q.IdAnio == anio
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        if (lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).Count() != 0)
                        {
                            fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdGrupo = item.IdGrupo;
                            if (item.IdProducto!= null)
                                info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);  
                            else
                                info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                            info.subtotal = lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).Sum(q => q.Valor_Depreciacion);
                            if (aplica_porc_ganancia)
                                info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).porcentaje / 100);
                            else
                                info.valor_ganancia = 0;

                            info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                            info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                            info.por_iva = info_impuesto.porcentaje;
                            info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                            info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                            Lista.Add(info);
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

        public List<fa_pre_facturacion_det_Info> get_list_poliza_x_cuota(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_Poliza_x_AF_det_cuota
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                              && q.IdPeriodo == info_prefacturacion.IdPeriodo
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat && q.IdAnio == anio
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        if (lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).Count() != 0)
                        {
                            fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdGrupo = item.IdGrupo;
                            if (item.IdProducto != null)
                                info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                            else
                                info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                            info.subtotal = lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).Sum(q => q.valor_prima);
                            if (aplica_porc_ganancia)
                                info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).porcentaje / 100);
                            else
                                info.valor_ganancia = 0;

                            info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                            info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                            info.por_iva = info_impuesto.porcentaje;
                            info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                            info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                            Lista.Add(info);
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

        public List<fa_pre_facturacion_det_Info> get_list_diferencia_mano_obra(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_proyeccion_mano_obra
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                              && q.IdPeriodo == info_prefacturacion.IdPeriodo
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat && q.IdAnio == anio
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        if (lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdSubcentroCosto == item.IdCentroCosto_sub_centro_costo).Count() != 0)
                        {
                            fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdGrupo = item.IdGrupo;
                            if (item.IdProducto != null)
                                info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                            else
                                info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                            info.subtotal = (double)lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdSubcentroCosto == item.IdCentroCosto_sub_centro_costo).Sum(q => q.DiferenciaManoObra);
                            if (aplica_porc_ganancia)
                                info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).porcentaje / 100);
                            else
                                info.valor_ganancia = 0;

                            info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                            info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                            info.por_iva = info_impuesto.porcentaje;
                            info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                            info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                            Lista.Add(info);
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

        public List<fa_pre_facturacion_det_Info> get_list_compensacion(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_compensacion
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat && q.IdAnio == anio
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        if (lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).Count() != 0)
                        {
                            fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdGrupo = item.IdGrupo;
                            if (item.IdProducto != null)
                                info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                            else
                                info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                            info.subtotal = (double)lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).Sum(q => q.valor_interes_diferencia);
                            if (aplica_porc_ganancia)
                                info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo).porcentaje / 100);
                            else
                                info.valor_ganancia = 0;

                            info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                            info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                            info.por_iva = info_impuesto.porcentaje;
                            info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                            info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                            Lista.Add(info);
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

        public List<fa_pre_facturacion_det_Info> get_list_mano_obra(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                List<fa_pre_facturacion_det_Info> Lista_detallada = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_pre_facturacion_mano_obra_servindustria
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                              && q.IdPrefacturacion == info_prefacturacion.IdPreFacturacion
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo                                 
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 join a in Context.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
                                 on new {q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo} equals new {a.IdCentroCosto, a.IdCentroCosto_sub_centro_costo}
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto                                 
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto,
                                     IdActivoFijo = a.IdActivoFijo
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        if (lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Count() != 0)
                        {
                            fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdGrupo = item.IdGrupo;
                            if (item.IdProducto != null)
                                info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                            else
                                info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                            info.subtotal = (double)lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Sum(q => q.TotalManoObra);
                            if (aplica_porc_ganancia)
                                info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).porcentaje / 100);
                            else
                                info.valor_ganancia = 0;

                            info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                            info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                            info.por_iva = info_impuesto.porcentaje;
                            info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                            info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                            Lista_detallada.Add(info);
                        }
                    }

                    Lista = (from q in Lista_detallada
                             group q by new { q.IdEmpresa, q.IdCentroCosto, q.IdGrupo, q.IdCentroCosto_sub_centro_costo, q.IdProceso_prefacturacion, q.IdProducto, q.por_iva, q.IdCod_Impuesto }
                                 into grouping
                                 select new fa_pre_facturacion_det_Info
                                 {
                                     IdEmpresa = grouping.Key.IdEmpresa,
                                     IdProceso_prefacturacion = grouping.Key.IdProceso_prefacturacion,
                                     IdCentroCosto = grouping.Key.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = grouping.Key.IdCentroCosto_sub_centro_costo,
                                     IdGrupo = grouping.Key.IdGrupo,
                                     IdProducto = grouping.Key.IdProducto,
                                     subtotal = grouping.Sum(q => q.subtotal),
                                     valor_ganancia = grouping.Sum(q => q.valor_ganancia),
                                     IdCod_Impuesto = grouping.Key.IdCod_Impuesto,
                                     por_iva = grouping.Key.por_iva,
                                     valor_iva = grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100),
                                     total = grouping.Sum(q => q.subtotal) + grouping.Sum(q => q.valor_ganancia) + (grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100)),
                                 }).ToList();
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

        public List<fa_pre_facturacion_det_Info> get_list_inventario(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                List<fa_pre_facturacion_det_Info> Lista_detallada = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_pre_facturacion_det_ing_egr_inven
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                              && q.IdPreFacturacion == info_prefacturacion.IdPreFacturacion
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 join a in Context.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
                                 on new { q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { a.IdCentroCosto, a.IdCentroCosto_sub_centro_costo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto,
                                     IdActivoFijo = a.IdActivoFijo
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat 
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        if (lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Count() != 0)
                        {
                            fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdGrupo = item.IdGrupo;
                            if (item.IdProducto != null)
                                info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                            else
                                info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                            info.subtotal = (double)lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Sum(q => q.subtotal);
                            if (aplica_porc_ganancia)
                                info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).porcentaje / 100);
                            else
                                info.valor_ganancia = 0;

                            info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                            info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                            info.por_iva = info_impuesto.porcentaje;
                            info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                            info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                            Lista_detallada.Add(info);
                        }
                    }

                    Lista = (from q in Lista_detallada
                             group q by new { q.IdEmpresa, q.IdCentroCosto, q.IdGrupo, q.IdCentroCosto_sub_centro_costo, q.IdProceso_prefacturacion, q.IdProducto, q.por_iva, q.IdCod_Impuesto }
                                 into grouping
                                 select new fa_pre_facturacion_det_Info
                                 {
                                     IdEmpresa = grouping.Key.IdEmpresa,
                                     IdProceso_prefacturacion = grouping.Key.IdProceso_prefacturacion,
                                     IdCentroCosto = grouping.Key.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = grouping.Key.IdCentroCosto_sub_centro_costo,
                                     IdGrupo = grouping.Key.IdGrupo,
                                     IdProducto = grouping.Key.IdProducto,
                                     subtotal = grouping.Sum(q => q.subtotal),
                                     valor_ganancia = grouping.Sum(q => q.valor_ganancia),
                                     IdCod_Impuesto = grouping.Key.IdCod_Impuesto,
                                     por_iva = grouping.Key.por_iva,
                                     valor_iva = grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100),
                                     total = grouping.Sum(q => q.subtotal) + grouping.Sum(q => q.valor_ganancia) + (grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100)),
                                 }).ToList();
                
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

        public List<fa_pre_facturacion_det_Info> get_list_otros(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                List<fa_pre_facturacion_det_Info> Lista_detallada = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_pre_facturacion_det_otros
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                              && q.IdPreFacturacion == info_prefacturacion.IdPreFacturacion
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 join a in Context.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
                                 on new { q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { a.IdCentroCosto, a.IdCentroCosto_sub_centro_costo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto,
                                     IdActivoFijo = a.IdActivoFijo
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        if (lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Count() != 0)
                        {
                            fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdGrupo = item.IdGrupo;
                            if (item.IdProducto != null)
                                info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                            else
                                info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                            info.subtotal = (double)lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Sum(q => q.valor);
                            if (aplica_porc_ganancia)
                                info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).porcentaje / 100);
                            else
                                info.valor_ganancia = 0;

                            info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                            info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                            info.por_iva = info_impuesto.porcentaje;
                            info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                            info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                            Lista_detallada.Add(info);
                        }
                    }

                    Lista = (from q in Lista_detallada
                             group q by new { q.IdEmpresa, q.IdCentroCosto, q.IdGrupo, q.IdCentroCosto_sub_centro_costo, q.IdProceso_prefacturacion, q.IdProducto, q.por_iva, q.IdCod_Impuesto }
                                 into grouping
                                 select new fa_pre_facturacion_det_Info
                                 {
                                     IdEmpresa = grouping.Key.IdEmpresa,
                                     IdProceso_prefacturacion = grouping.Key.IdProceso_prefacturacion,
                                     IdCentroCosto = grouping.Key.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = grouping.Key.IdCentroCosto_sub_centro_costo,
                                     IdGrupo = grouping.Key.IdGrupo,
                                     IdProducto = grouping.Key.IdProducto,
                                     subtotal = grouping.Sum(q => q.subtotal),
                                     valor_ganancia = grouping.Sum(q => q.valor_ganancia),
                                     IdCod_Impuesto = grouping.Key.IdCod_Impuesto,
                                     por_iva = grouping.Key.por_iva,
                                     valor_iva = grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100),
                                     total = grouping.Sum(q => q.subtotal) + grouping.Sum(q => q.valor_ganancia) + (grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100)),
                                 }).ToList();

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

        public List<fa_pre_facturacion_det_Info> get_list_depreciacion_x_subcentro(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                List<fa_pre_facturacion_det_Info> Lista_detallada = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_det_depreciacion_x_subcentro
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto                              
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 join a in Context.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
                                 on new { q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { a.IdCentroCosto, a.IdCentroCosto_sub_centro_costo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto,
                                     IdActivoFijo = a.IdActivoFijo
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        if (lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Count() != 0)
                        {
                            fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdGrupo = item.IdGrupo;
                            if (item.IdProducto != null)
                                info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                            else
                                info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                            info.subtotal = (double)lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Sum(q => q.Valor_depreciacion);
                            if (aplica_porc_ganancia)
                                info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).porcentaje / 100);
                            else
                                info.valor_ganancia = 0;

                            info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                            info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                            info.por_iva = info_impuesto.porcentaje;
                            info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                            info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                            Lista_detallada.Add(info);
                        }
                    }

                    Lista = (from q in Lista_detallada
                             group q by new { q.IdEmpresa, q.IdCentroCosto, q.IdGrupo, q.IdCentroCosto_sub_centro_costo, q.IdProceso_prefacturacion, q.IdProducto, q.por_iva, q.IdCod_Impuesto }
                                 into grouping
                                 select new fa_pre_facturacion_det_Info
                                 {
                                     IdEmpresa = grouping.Key.IdEmpresa,
                                     IdProceso_prefacturacion = grouping.Key.IdProceso_prefacturacion,
                                     IdCentroCosto = grouping.Key.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = grouping.Key.IdCentroCosto_sub_centro_costo,
                                     IdGrupo = grouping.Key.IdGrupo,
                                     IdProducto = grouping.Key.IdProducto,
                                     subtotal = grouping.Sum(q => q.subtotal),
                                     valor_ganancia = grouping.Sum(q => q.valor_ganancia),
                                     IdCod_Impuesto = grouping.Key.IdCod_Impuesto,
                                     por_iva = grouping.Key.por_iva,
                                     valor_iva = grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100),
                                     total = grouping.Sum(q => q.subtotal) + grouping.Sum(q => q.valor_ganancia) + (grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100)),
                                 }).ToList();

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

        public List<fa_pre_facturacion_det_Info> get_list_movilizacion(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                List<fa_pre_facturacion_det_Info> Lista_detallada = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.fa_pre_facturacion_activos
                              where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdPreFacturacion == info_prefacturacion.IdPreFacturacion
                              select q;

                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 join a in Context.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
                                 on new { q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { a.IdCentroCosto, a.IdCentroCosto_sub_centro_costo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto,
                                     IdActivoFijo = a.IdActivoFijo
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    foreach (var item in lst_grupo)
                    {
                        if (lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Count() != 0)
                        {
                            fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                            info.IdCentroCosto = item.IdCentroCosto;
                            info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            info.IdGrupo = item.IdGrupo;
                            if (item.IdProducto != null)
                                info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                            else
                                info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);
                            info.subtotal = (double)lst.Where(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).Sum(q => q.valor_movilizacion);
                            if (aplica_porc_ganancia)
                                info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).porcentaje / 100);
                            else
                                info.valor_ganancia = 0;

                            info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                            info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                            info.por_iva = info_impuesto.porcentaje;
                            info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                            info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                            Lista_detallada.Add(info);
                        }
                    }

                    Lista = (from q in Lista_detallada
                             group q by new { q.IdEmpresa, q.IdCentroCosto, q.IdGrupo, q.IdCentroCosto_sub_centro_costo, q.IdProceso_prefacturacion, q.IdProducto, q.por_iva, q.IdCod_Impuesto }
                                 into grouping
                                 select new fa_pre_facturacion_det_Info
                                 {
                                     IdEmpresa = grouping.Key.IdEmpresa,
                                     IdProceso_prefacturacion = grouping.Key.IdProceso_prefacturacion,
                                     IdCentroCosto = grouping.Key.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = grouping.Key.IdCentroCosto_sub_centro_costo,
                                     IdGrupo = grouping.Key.IdGrupo,
                                     IdProducto = grouping.Key.IdProducto,
                                     subtotal = grouping.Sum(q => q.subtotal),
                                     valor_ganancia = grouping.Sum(q => q.valor_ganancia),
                                     IdCod_Impuesto = grouping.Key.IdCod_Impuesto,
                                     por_iva = grouping.Key.por_iva,
                                     valor_iva = grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100),
                                     total = grouping.Sum(q => q.subtotal) + grouping.Sum(q => q.valor_ganancia) + (grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100)),
                                 }).ToList();

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

        public List<fa_pre_facturacion_det_Info> get_list_disponibilidad(fa_pre_facturacion_Info info_prefacturacion, int IdProceso_prefacturacion, bool aplica_porc_ganancia, double valor_x_disponibilidad, int cantidad_activos)
        {
            try
            {
                List<fa_pre_facturacion_det_Info> Lista = new List<fa_pre_facturacion_det_Info>();
                //Verifico parametros de facturacion fj
                info_param_fj = data_param_fj.get_info(info_prefacturacion.IdEmpresa);

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    List<fa_grupo_x_sub_centro_costo_det_Info> lst_grupo;

                    lst_grupo = (from q in Context.fa_grupo_x_sub_centro_costo_det
                                 join c in Context.fa_grupo_x_sub_centro_costo
                                 on new { q.IdEmpresa, q.IdGrupo } equals new { c.IdEmpresa, c.IdGrupo }
                                 join a in Context.fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
                                 on new { q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { a.IdCentroCosto, a.IdCentroCosto_sub_centro_costo }
                                 where q.IdEmpresa == info_prefacturacion.IdEmpresa && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                && c.Estado == true
                                 select new fa_grupo_x_sub_centro_costo_det_Info
                                 {
                                     IdEmpresa = q.IdEmpresa,
                                     IdGrupo = q.IdGrupo,
                                     Secuencia = q.Secuencia,
                                     IdCentroCosto = q.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                     IdProducto = c.IdProducto,
                                     IdActivoFijo = a.IdActivoFijo
                                 }).ToList();

                    int anio = Convert.ToInt32(info_prefacturacion.IdPeriodo.ToString().Substring(0, 4));

                    var lst_grupo_x_porc_ganancia = from q in Context.vwfa_grupo_porc_ganancia_x_anio
                                                    where q.IdEmpresa == info_prefacturacion.IdEmpresa
                                                    && q.IdCentroCosto == info_prefacturacion.IdCentroCosto
                                                    && q.TIPO == info_param_fj.p_tipo_porc_ganancia_tarifario_cat 
                                                    && q.IdPeriodo_ini <= info_prefacturacion.IdPeriodo && info_prefacturacion.IdPeriodo <= q.IdPeriodo_fin
                                                    select q;

                    List<fa_pre_facturacion_det_Info> Lista_detallada = new List<fa_pre_facturacion_det_Info>();

                    foreach (var item in lst_grupo)
                    {

                        fa_pre_facturacion_det_Info info = new fa_pre_facturacion_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdProceso_prefacturacion = IdProceso_prefacturacion;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdGrupo = item.IdGrupo;
                        if (item.IdProducto != null)
                            info.IdProducto = item.IdProducto == null ? 0 : Convert.ToDecimal(item.IdProducto);
                        else
                            info.IdProducto = info_param_fj.p_IdProducto_prefacturacion == null ? 0 : Convert.ToDecimal(info_param_fj.p_IdProducto_prefacturacion);

                        info.subtotal = Math.Round(valor_x_disponibilidad / cantidad_activos, 2, MidpointRounding.AwayFromZero);
                        if (aplica_porc_ganancia)
                            info.valor_ganancia = info.subtotal * (lst_grupo_x_porc_ganancia.FirstOrDefault(q => q.IdCentroCosto == item.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == item.IdCentroCosto_sub_centro_costo && q.IdActivoFijo == item.IdActivoFijo).porcentaje / 100);
                        else
                            info.valor_ganancia = 0;

                        info.IdCod_Impuesto = info_param_fj.p_IdCod_Impuesto_IVA;
                        info_impuesto = data_impuesto.Get_Info_impuesto(info_param_fj.p_IdCod_Impuesto_IVA);
                        info.por_iva = info_impuesto.porcentaje;
                        info.valor_iva = (info.subtotal + info.valor_ganancia) * (info.por_iva / 100);
                        info.total = info.subtotal + info.valor_ganancia + info.valor_iva;
                        Lista_detallada.Add(info);

                    }

                    Lista = (from q in Lista_detallada
                             group q by new { q.IdEmpresa, q.IdCentroCosto, q.IdGrupo, q.IdCentroCosto_sub_centro_costo, q.IdProceso_prefacturacion, q.IdProducto, q.por_iva, q.IdCod_Impuesto }
                                 into grouping
                                 select new fa_pre_facturacion_det_Info
                                 {
                                     IdEmpresa = grouping.Key.IdEmpresa,
                                     IdProceso_prefacturacion = grouping.Key.IdProceso_prefacturacion,
                                     IdCentroCosto = grouping.Key.IdCentroCosto,
                                     IdCentroCosto_sub_centro_costo = grouping.Key.IdCentroCosto_sub_centro_costo,
                                     IdGrupo = grouping.Key.IdGrupo,
                                     IdProducto = grouping.Key.IdProducto,
                                     subtotal = grouping.Sum(q => q.subtotal),
                                     valor_ganancia = grouping.Sum(q => q.valor_ganancia),
                                     IdCod_Impuesto = grouping.Key.IdCod_Impuesto,
                                     por_iva = grouping.Key.por_iva,
                                     valor_iva = grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100),
                                     total = grouping.Sum(q => q.subtotal) + grouping.Sum(q => q.valor_ganancia) + (grouping.Sum(q => q.subtotal) * (grouping.Key.por_iva / 100)),
                                 }).ToList();
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

        public bool modificarDB(List<fa_pre_facturacion_det_Info> lst)
        {
            try
            {
               using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_det Entity = Context.fa_pre_facturacion_det.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdPreFacturacion == item.IdPreFacturacion && q.Secuencia == item.Secuencia);
                        if (Entity!=null)
                        {                           
                            Entity.IdGrupo = item.IdGrupo;
                            Entity.IdCentroCosto = item.IdCentroCosto;
                            Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            Entity.IdProducto = item.IdProducto;
                            Entity.subtotal = item.subtotal;
                            Entity.valor_ganancia = item.valor_ganancia;
                            Entity.IdCod_Impuesto = item.IdCod_Impuesto;
                            Entity.por_iva = item.por_iva;
                            Entity.valor_iva = item.valor_iva;
                            Entity.total = item.total;
                            Entity.IdEmpresa_vta = item.IdEmpresa_vta;
                            Entity.IdSucursal = item.IdSucursal;
                            Entity.IdBodega = item.IdBodega;
                            Entity.IdCbteVta = item.IdCbteVta;
                            Entity.IdProceso_prefacturacion = item.IdProceso_prefacturacion;
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
