
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Reportes.Roles
{
   public  class XROL_Rpt028_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();


        public List<XROL_Rpt028_Info> GetLista(int IdEmpresa, int idnomina,DateTime fechai, DateTime fechaf)
        {
            try
            {
                int secuencia = 0;

                List<XROL_Rpt028_Info> listado = new List<XROL_Rpt028_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {

                    var querry = (from q in db.vwROL_Rpt028
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdTipoNomina == idnomina
                                  && q.em_fechaSalida>= fechai
                                  && q.em_fechaSalida<=fechaf
                                  select q);
                    foreach (var item in querry.ToList())
                    {
                        secuencia++;
                        XROL_Rpt028_Info info = new XROL_Rpt028_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdTipoNomina = item.IdTipoNomina;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Empleado = item.Empleado;
                        info.Estado = item.Estado;
                        info.ca_descripcion = item.ca_descripcion;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.Ingresos = item.Ingresos;
                        info.Egresos = item.Egresos;
                        info.MotivoTerminacion = item.MotivoTerminacion;


                        listado.Add(info);
                    }

                }
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }

        }

        public List<XROL_Rpt028_Info> GetLista(int IdEmpresa, int idnomina,int iddiviosn, DateTime fechai, DateTime fechaf)
        {
            try
            {
                int secuencia = 0;

                List<XROL_Rpt028_Info> listado = new List<XROL_Rpt028_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {

                    var querry = (from q in db.vwROL_Rpt028
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdTipoNomina == idnomina
                                  && q.em_fechaSalida >= fechai
                                  && q.em_fechaSalida <= fechaf
                                  select q);
                    foreach (var item in querry.ToList())
                    {
                        secuencia++;
                        XROL_Rpt028_Info info = new XROL_Rpt028_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdTipoNomina = item.IdTipoNomina;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Empleado = item.Empleado;
                        info.Estado = item.Estado;
                        info.ca_descripcion = item.ca_descripcion;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.Ingresos = item.Ingresos;
                        info.Egresos = item.Egresos;
                        info.MotivoTerminacion = item.MotivoTerminacion;


                        listado.Add(info);
                    }

                }
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }

        }




    }
}
