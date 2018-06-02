using Core.Erp.Data.General;
using Core.Erp.Info.Alerta;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Alerta
{
    public class tb_sis_alerta_x_usuario_x_empresa_Data
    {
        public List<tb_sis_alerta_x_usuario_x_empresa_Info> get_list(int IdEmpresa, string IdUsuario)
        {
            try
            {
                List<tb_sis_alerta_x_usuario_x_empresa_Info> Lista;

                using (Entities_alerta Context = new Entities_alerta())
                {
                    Lista = (from q in Context.tb_sis_alerta_x_usuario_x_empresa
                             where q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario
                             select new tb_sis_alerta_x_usuario_x_empresa_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdUsuario = q.IdUsuario,
                                 CodAlerta = q.CodAlerta,
                                 IdSucursal = q.IdSucursal,                                 
                             }).ToList();

                    foreach (var item in Lista)
                    {
                        item.lst_eventos = (from q in Context.tb_sis_alerta_x_usuario_x_empresa_x_eventos
                                            where q.IdEmpresa == item.IdEmpresa
                                            && q.IdUsuario == item.IdUsuario
                                            && q.CodAlerta == item.CodAlerta
                                            select new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info
                                            {
                                                IdEmpresa = q.IdEmpresa,
                                                IdUsuario = q.IdUsuario,
                                                CodAlerta = q.CodAlerta,
                                                enum_evento = q.enum_evento,
                                                observacion = q.observacion,
                                                seleccionado = true
                                            }).ToList();    
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = string.Empty;
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool eliminarDB(int IdEmpresa, string IdUsuario)
        {
            try
            {
                using (Entities_alerta Context = new Entities_alerta())
                {
                    Context.Database.ExecuteSqlCommand("DELETE tb_sis_alerta_x_usuario_x_empresa WHERE IdEmpresa = "+IdEmpresa+" and IdUsuario = '"+IdUsuario+"'");
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = string.Empty;
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(tb_sis_alerta_x_usuario_x_empresa_Info info)
        {
            try
            {
                using (Entities_alerta Context = new Entities_alerta())
                {
                    tb_sis_alerta_x_usuario_x_empresa Entity = new tb_sis_alerta_x_usuario_x_empresa();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdUsuario = info.IdUsuario;
                    Entity.CodAlerta = info.CodAlerta;
                    Entity.IdSucursal = info.IdSucursal;
                    Context.tb_sis_alerta_x_usuario_x_empresa.Add(Entity);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = string.Empty;
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool guardarDB(List<tb_sis_alerta_x_usuario_x_empresa_Info> Lista)
        {
            try
            {

                foreach (var item in Lista)
                {
                    guardarDB(item);
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = string.Empty;
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
