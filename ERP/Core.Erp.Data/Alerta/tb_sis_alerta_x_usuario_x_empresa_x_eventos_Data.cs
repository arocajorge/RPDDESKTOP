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
    public class tb_sis_alerta_x_usuario_x_empresa_x_eventos_Data
    {
        public List<tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info> get_list(int IdEmpresa, string IdUsuario, string CodAlerta)
        {
            try
            {
                List<tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info> Lista;

                using (Entities_alerta Context = new Entities_alerta())
                {
                    Lista = (from q in Context.vwtb_sis_alerta_x_usuario_x_empresa_x_eventos
                             where q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario
                             && q.CodAlerta == CodAlerta
                             select new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdUsuario = q.IdUsuario,
                                 CodAlerta = q.CodAlerta,
                                 enum_evento = q.enum_evento,
                                 IdSucursal = q.IdSucursal
                             }).ToList();
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
                    Context.Database.ExecuteSqlCommand("DELETE tb_sis_alerta_x_usuario_x_empresa_x_eventos WHERE IdEmpresa = " + IdEmpresa + " and IdUsuario = '" + IdUsuario+"'");
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

        public bool guardarDB(tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info info)
        {
            try
            {
                using (Entities_alerta Context = new Entities_alerta())
                {
                    tb_sis_alerta_x_usuario_x_empresa_x_eventos Entity = new tb_sis_alerta_x_usuario_x_empresa_x_eventos();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdUsuario = info.IdUsuario;
                    Entity.CodAlerta = info.CodAlerta;
                    Entity.enum_evento = info.enum_evento;
                    Entity.observacion = info.observacion;
                    Context.tb_sis_alerta_x_usuario_x_empresa_x_eventos.Add(Entity);
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

        public bool guardarDB(List<tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info> Lista)
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

        public tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info get_info(int IdEmpresa, string IdUsuario, string CodAlerta, string evento)
        {
            try
            {
                tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info info = new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info();

                using (Entities_alerta Context = new Entities_alerta())
                {
                    info = (from q in Context.vwtb_sis_alerta_x_usuario_x_empresa_x_eventos
                             where q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario
                             && q.CodAlerta == CodAlerta && q.enum_evento == evento
                             select new tb_sis_alerta_x_usuario_x_empresa_x_eventos_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdUsuario = q.IdUsuario,
                                 CodAlerta = q.CodAlerta,
                                 enum_evento = q.enum_evento,
                                 IdSucursal = q.IdSucursal,
                                 Nombre = q.Nombre,
                                 nom_Asembly = q.nom_Asembly,
                                 Formulario = q.Formulario
                             }).FirstOrDefault();
                }

                return info;
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
