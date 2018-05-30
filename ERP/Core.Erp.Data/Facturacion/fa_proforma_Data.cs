using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_proforma_Data
    {
        public List<fa_proforma_Info> get_list(int IdEmpresa, int IdSucursal, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                int IdSucursal_ini = IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                List<fa_proforma_Info> Lista;

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    Lista = (from q in Context.vwfa_proforma
                             where q.IdEmpresa == IdEmpresa
                             && IdSucursal_ini <= q.IdSucursal
                             && q.IdSucursal <= IdSucursal_fin
                             && Fecha_ini <= q.pf_fecha
                             && q.pf_fecha <= Fecha_fin
                             select new fa_proforma_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdProforma = q.IdProforma,
                                 IdCliente = q.IdCliente,
                                 IdTerminoPago = q.IdTerminoPago,
                                 pf_plazo = q.pf_plazo,
                                 pf_codigo = q.pf_codigo,
                                 pf_observacion = q.pf_observacion,
                                 pf_fecha = q.pf_fecha,
                                 pf_fecha_vcto = q.pf_fecha_vcto,
                                 estado = q.estado,
                                 Su_Descripcion = q.Su_Descripcion,
                                 pe_nombreCompleto = q.pe_nombreCompleto,
                                 pd_subtotal = q.pd_subtotal,
                                 pd_iva = q.pd_iva,
                                 pd_total = q.pd_total,
                                 IdUsuario_creacion = q.IdUsuario_creacion,
                                 fecha_creacion = q.fecha_creacion,
                                 IdUsuario_modificacion = q.IdUsuario_modificacion,
                                 fecha_modificacion = q.fecha_modificacion,
                                 IdUsuario_anulacion = q.IdUsuario_anulacion,
                                 fecha_anulacion = q.fecha_anulacion,
                                 IdBodega = q.IdBodega,
                                 IdVendedor = q.IdVendedor,
                                 pf_atencion_a = q.pf_atencion_a,
                                 pr_dias_entrega = q.pr_dias_entrega
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        private decimal get_id(int IdEmpresa, int IdSucursal)
        {
            try
            {
                decimal ID = 1;

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.fa_proforma
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              select q;

                    if (lst.Count() != 0)
                        ID = lst.Max(q => q.IdProforma) + 1;
                }

                return ID;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(fa_proforma_Info info)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_proforma Entity = new fa_proforma{
                     IdEmpresa = info.IdEmpresa,
                     IdSucursal = info.IdSucursal,
                     IdProforma = info.IdProforma = get_id(info.IdEmpresa,info.IdSucursal),
                     IdCliente = info.IdCliente,
                     IdTerminoPago = info.IdTerminoPago,
                     pf_plazo = info.pf_plazo,
                     pf_codigo = info.pf_codigo,
                     pf_observacion = info.pf_observacion,
                     pf_fecha = info.pf_fecha,
                     pf_fecha_vcto = info.pf_fecha_vcto,
                     IdUsuario_creacion = info.IdUsuario_creacion,
                     fecha_creacion = info.fecha_creacion,
                     IdBodega = info.IdBodega,
                     IdVendedor = info.IdVendedor,
                     pf_atencion_a = info.pf_atencion_a,
                     estado = info.estado = true,
                     pr_dias_entrega = info.pr_dias_entrega,
                     
                };
                    Context.fa_proforma.Add(Entity);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool modificarDB(fa_proforma_Info info)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_proforma Entity = Context.fa_proforma.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdProforma == info.IdProforma);
                    if (Entity == null)
                        return false;

                    Entity.IdTerminoPago = info.IdTerminoPago;
                    Entity.pf_plazo = info.pf_plazo;
                    Entity.pf_codigo = info.pf_codigo;
                    Entity.pf_observacion = info.pf_observacion;
                    Entity.pf_fecha = info.pf_fecha;
                    Entity.pf_fecha_vcto = info.pf_fecha_vcto;
                    Entity.IdUsuario_modificacion= info.IdUsuario_modificacion;
                    Entity.fecha_modificacion = info.fecha_modificacion;
                    Entity.IdVendedor = info.IdVendedor;
                    Entity.pf_atencion_a = info.pf_atencion_a;
                    Entity.pr_dias_entrega = info.pr_dias_entrega;
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool anularDB(fa_proforma_Info info)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_proforma Entity = Context.fa_proforma.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdProforma == info.IdProforma);
                    if (Entity == null)
                        return false;

                    Entity.estado = false;
                    Entity.IdUsuario_anulacion = info.IdUsuario_anulacion;
                    Entity.fecha_anulacion = info.fecha_anulacion;
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
