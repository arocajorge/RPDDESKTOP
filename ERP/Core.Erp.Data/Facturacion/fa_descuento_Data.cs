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
    public class fa_descuento_Data
    {
        public List<fa_descuento_Info> Get_Lista_Descuento(int IdEmpresa, ref string mensaje)
        {
            try
            {
                List<fa_descuento_Info> Lista = new List<fa_descuento_Info>();
                EntitiesFacturacion Base = new EntitiesFacturacion();
                var Select = from q in Base.fa_descuento
                             where q.IdEmpresa == IdEmpresa
                             select q;
                             if(Select != null)
                             {
                                 foreach (var item in Select)
                                 {
                                     fa_descuento_Info Info = new fa_descuento_Info();
                                     Info.IdEmpresa = item.IdEmpresa;
                                     Info.IdDescuento = item.IdDescuento;
                                     Info.de_IdCtaCble = item.de_IdCtaCble;
                                     Info.de_nombre = item.de_nombre;
                                     Info.de_observacion = item.de_observacion;
                                     Info.de_porcentaje = item.de_porcentaje;
                                     if (item.Estado == true)
                                         Info.estado = 'A';
                                     else
                                         Info.estado = 'I';
                                     Info.Estado = item.Estado;
                                     Lista.Add(Info);
                                 }
                             }
                             return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
        }


        public int getId(int IdEmpresa)
        {
            int Id = 0;
            try
            {
                EntitiesFacturacion Base = new EntitiesFacturacion();
                int select = (from q in Base.fa_descuento
                              where q.IdEmpresa == IdEmpresa
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = ((from q in Base.fa_descuento
                              where q.IdEmpresa == IdEmpresa
                                     select q.IdDescuento).Max());
                    Id = Convert.ToInt32(select_as.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public Boolean GrabarBD(fa_descuento_Info Info, ref string mensaje)
        {
            try
            {
                bool resultado = false;
                int IdEmpresa = 0;
                EntitiesFacturacion Base = new EntitiesFacturacion();
                {
                    fa_descuento Entity = new fa_descuento();
                    Entity.IdEmpresa = IdEmpresa = Info.IdEmpresa;
                    Entity.IdDescuento = getId(IdEmpresa);
                    Entity.de_IdCtaCble = Info.de_IdCtaCble;
                    Entity.de_nombre = Info.de_nombre;
                    Entity.de_observacion = Info.de_observacion;
                    Entity.de_porcentaje = Info.de_porcentaje;
                    Entity.Estado = true;
                    Entity.FechaCreacion = Info.FechaCreacion;
                    Entity.IdUsuarioCreacion = Info.IdUsuarioCreacion;
                    Entity.ip = Info.ip;
                    Entity.nom_pc = Info.nom_pc;
                    Base.fa_descuento.Add(Entity);
                    Base.SaveChanges();
                    resultado = true;
                }
                return resultado;
            }

            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
                   
        }

        public Boolean ModificarBD(fa_descuento_Info Info, ref string mensaje)
        {
            try
            {
                bool resultado = false;
                EntitiesFacturacion Base = new EntitiesFacturacion();
                var Descuento = Base.fa_descuento.FirstOrDefault(a => a.IdEmpresa == Info.IdEmpresa && a.IdDescuento == Info.IdDescuento);
                    if(Descuento != null)
                    {
                        Descuento.de_IdCtaCble = Info.de_IdCtaCble;
                        Descuento.de_nombre = Info.de_nombre;
                        Descuento.de_observacion = Info.de_observacion;
                        Descuento.de_porcentaje = Info.de_porcentaje;
                        Descuento.FechaUltMod = Info.FechaUltMod;
                        Descuento.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        Descuento.ip = Info.ip;
                        Descuento.nom_pc = Info.nom_pc;
                        Base.SaveChanges();
                        resultado = true;
                    }
              return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean AnularBD(fa_descuento_Info Info, ref string mensaje)
        {
            try
            {
                bool resultado = false;
                EntitiesFacturacion Base = new EntitiesFacturacion();
                var Descuento = Base.fa_descuento.FirstOrDefault(a => a.IdEmpresa == Info.IdEmpresa && a.IdDescuento == Info.IdDescuento);
                if (Descuento != null)
                {
                    Descuento.Estado = false;
                    Descuento.Fecha_UltAnu = Info.Fecha_UltAnu;
                    Descuento.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                    Descuento.MotiAnula = Info.MotiAnula;
                    Descuento.ip = Info.ip;
                    Descuento.nom_pc = Info.nom_pc;
                    Base.SaveChanges();
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
