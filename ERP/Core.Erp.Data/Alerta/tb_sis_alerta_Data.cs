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
    public class tb_sis_alerta_Data
    {
        public List<tb_sis_alerta_Info> get_list()
        {
            try
            {
                List<tb_sis_alerta_Info> Lista = new List<tb_sis_alerta_Info>();

                using (Entities_alerta Context = new Entities_alerta())
                {
                    Lista = (from q in Context.tb_sis_alerta
                            select new tb_sis_alerta_Info
                            {
                                CodAlerta = q.CodAlerta,
                                Nombre = q.Nombre,
                                CodModulo = q.CodModulo,
                                VistaRpt = q.VistaRpt,
                                Formulario = q.Formulario,
                                Class_NomReporte = q.Class_NomReporte,
                                nom_Asembly = q.nom_Asembly,
                                Class_Info = q.Class_Info,
                                Class_Bus = q.Class_Bus,
                                Class_Data = q.Class_Data,
                                Estado = q.Estado,
                                observacion = q.observacion
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

        public bool guardarDB(tb_sis_alerta_Info info)
        {
            try
            {
                using (Entities_alerta Context = new Entities_alerta())
                {
                    tb_sis_alerta Entity = new tb_sis_alerta();
                    Entity.CodAlerta = info.CodAlerta;
                    Entity.Nombre = info.Nombre;
                    Entity.CodModulo = info.CodModulo;
                    Entity.VistaRpt = info.VistaRpt;
                    Entity.Formulario = info.Formulario;
                    Entity.Class_NomReporte = info.Class_NomReporte;
                    Entity.nom_Asembly = info.nom_Asembly;
                    Entity.Class_Info = info.Class_Info;
                    Entity.Class_Bus = info.Class_Bus;
                    Entity.Class_Data = info.Class_Data;
                    Entity.Estado = info.Estado;
                    Entity.observacion = info.observacion;
                    Context.tb_sis_alerta.Add(Entity);
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

        public bool modificarDB(tb_sis_alerta_Info info)
        {
            try
            {
                using (Entities_alerta Context = new Entities_alerta())
                {
                    tb_sis_alerta Entity = Context.tb_sis_alerta.FirstOrDefault(q => q.CodAlerta == info.CodAlerta);
                    if (Entity != null)
                    {
                        Entity.Nombre = info.Nombre;
                        Entity.CodModulo = info.CodModulo;
                        Entity.VistaRpt = info.VistaRpt;
                        Entity.Formulario = info.Formulario;
                        Entity.Class_NomReporte = info.Class_NomReporte;
                        Entity.nom_Asembly = info.nom_Asembly;
                        Entity.Class_Info = info.Class_Info;
                        Entity.Class_Bus = info.Class_Bus;
                        Entity.Class_Data = info.Class_Data;
                        Entity.Estado = info.Estado;
                        Entity.observacion = info.observacion;
                        Context.SaveChanges();    
                    }
                    
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

        public string Get_Numero(string CodModulo)
        {
            try
            {
                string num = "";
                Entities_alerta oEnti = new Entities_alerta();

                var c = oEnti.Database.SqlQuery<int>("select max(substring(CodAlerta,LEN(CodReporte)-2,3) )+1 from tb_sis_alerta where CodModulo='" + CodModulo + "' ");
                try
                {
                    var c2 = c.First();
                    if (c2 == null)
                        num = "001";
                    else if (Convert.ToDecimal(c2) < 10)
                        num = "00" + Convert.ToString(c2);
                    else if (Convert.ToDecimal(c2) < 99)
                        num = "0" + Convert.ToString(c2);
                    else if (Convert.ToDecimal(c2) < 999)
                        num = Convert.ToString(c2);
                    else
                        num = null;
                }
                catch (Exception)
                {
                    return "001";
                }
                return num;
            }
            catch (Exception ex)
            {
                string mensaje = string.Empty;
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
