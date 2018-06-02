using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Importacion
{
    public class imp_orden_compra_ext_ct_cbteble_det_gastos_Data
    {
        public List<imp_orden_compra_ext_ct_cbteble_det_gastos_Info> get_list(int IdEmpresa, decimal IdOrdenCompra_ext)
        {
            try
            {
                List<imp_orden_compra_ext_ct_cbteble_det_gastos_Info> Lista;

                using (Entities_importacion Context = new Entities_importacion())
                {
                    Lista = (from q in Context.vwimp_orden_compra_ext_ct_cbteble_det_gastos
                             where q.IdEmpresa == IdEmpresa && q.IdOrdenCompra_ext == IdOrdenCompra_ext
                             select new imp_orden_compra_ext_ct_cbteble_det_gastos_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                 IdEmpresa_ct = q.IdEmpresa_ct,
                                 IdTipoCbte = q.IdTipoCbte,
                                 IdCbteCble = q.IdCbteCble,
                                 secuencia_ct = q.secuencia_ct,
                                 IdGasto_tipo = q.IdGasto_tipo,
                                 IdCtaCble = q.IdCtaCble,
                                 cb_Fecha = q.cb_Fecha,
                                 dc_Valor = q.dc_Valor,
                                 cb_Observacion = q.cb_Observacion,
                                 seleccionado = q.seleccionado
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public List<imp_orden_compra_ext_ct_cbteble_det_gastos_Info> get_list(int IdEmpresa, List<decimal> IdOrdenCompra_ext)
        {
            try
            {
                List<imp_orden_compra_ext_ct_cbteble_det_gastos_Info> Lista = new List<imp_orden_compra_ext_ct_cbteble_det_gastos_Info>();

                using (Entities_importacion Context = new Entities_importacion())
                {
                    foreach (var item in IdOrdenCompra_ext)
                    {
                        Lista.AddRange((from q in Context.vwimp_orden_compra_ext_ct_cbteble_det_gastos
                                        where q.IdEmpresa == IdEmpresa && q.IdOrdenCompra_ext == item
                                        select new imp_orden_compra_ext_ct_cbteble_det_gastos_Info
                                        {
                                            IdEmpresa = q.IdEmpresa,
                                            IdOrdenCompra_ext = q.IdOrdenCompra_ext,
                                            IdEmpresa_ct = q.IdEmpresa_ct,
                                            IdTipoCbte = q.IdTipoCbte,
                                            IdCbteCble = q.IdCbteCble,
                                            secuencia_ct = q.secuencia_ct,
                                            IdGasto_tipo = q.IdGasto_tipo,
                                            IdCtaCble = q.IdCtaCble,
                                            cb_Fecha = q.cb_Fecha,
                                            dc_Valor = q.dc_Valor,
                                            cb_Observacion = q.cb_Observacion,
                                            seleccionado = q.seleccionado
                                        }).ToList());
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(List<imp_orden_compra_ext_ct_cbteble_det_gastos_Info> Lista)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    foreach (var item in Lista)
                    {
                        imp_orden_compra_ext_ct_cbteble_det_gastos Entity = new imp_orden_compra_ext_ct_cbteble_det_gastos
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdOrdenCompra_ext = item.IdOrdenCompra_ext,
                            IdEmpresa_ct = item.IdEmpresa_ct,
                            IdTipoCbte = item.IdTipoCbte,
                            IdCbteCble = item.IdCbteCble,
                            secuencia_ct = item.secuencia_ct,
                            IdGasto_tipo = item.IdGasto_tipo
                        };
                        Context.imp_orden_compra_ext_ct_cbteble_det_gastos.Add(Entity);
                        Context.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool eliminarDB(int IdEmpresa, decimal IdOrdenCompra_ext)
        {
            try
            {
                using (Entities_importacion Context = new Entities_importacion())
                {
                    Context.Database.ExecuteSqlCommand("DELETE imp_orden_compra_ext_ct_cbteble_det_gastos WHERE IdEmpresa = "+IdEmpresa+" and IdOrdenCompra_ext = "+IdOrdenCompra_ext);
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
