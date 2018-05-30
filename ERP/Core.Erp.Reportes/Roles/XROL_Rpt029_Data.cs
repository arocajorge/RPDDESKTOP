
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt029_Data
    {
        string mensaje = "";
        tb_Empresa_Info info_empresa = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

  
        public List<XROL_Rpt029_Info> GetListConsultaGeneral(int idEmpresa,int idnomina, int IdDivision, DateTime fi, DateTime ff, string estado, bool considerar_fecha_ingreso)
        {
            try
            {
                List<XROL_Rpt029_Info> listado = new List<XROL_Rpt029_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    IQueryable<vwROL_Rpt029> datos;
                    if(!considerar_fecha_ingreso)
                     datos = (from a in db.vwROL_Rpt029
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdTipoNomina == idnomina
                                 && a.IdDivision ==IdDivision
                                 && estado.Contains(a.EstadoEmpleado)

                                 
                               &&
                                (
                                 (a.em_fechaSalida>=fi
                                  && a.em_fechaSalida <=ff)
                                  || a.em_fechaSalida==null
                                )
                                 select a);
                    else
                        datos = (from a in db.vwROL_Rpt029
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdTipoNomina == idnomina
                                 && a.IdDivision == IdDivision
                                 && estado.Contains(a.EstadoEmpleado)


                               &&
                                (
                                 (a.em_fechaSalida >= fi
                                  && a.em_fechaSalida <= ff)
                                  || a.em_fechaSalida == null
                                )
                                && fi <= a.em_fecha_ingreso && a.em_fecha_ingreso <= ff
                                 select a);


                    info_empresa = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt029_Info info = new XROL_Rpt029_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.Empleado = item.Empleado;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.em_fecha_ingreso = item.em_fechaIngaRol;
                        info.ca_descripcion = item.ca_descripcion;
                        info.EstadoEmpleado = item.EstadoEmpleado;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.Antiguedad = item.antiguedad_string;
                      
                      
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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XROL_Rpt029_Info>();
            }

        }

        public List<XROL_Rpt029_Info> GetListConsultaGeneral(int idEmpresa, int idnomina, DateTime fi, DateTime ff, string estado, bool considerar_fecha_ingreso)
        {
            try
            {
                List<XROL_Rpt029_Info> listado = new List<XROL_Rpt029_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    IQueryable<vwROL_Rpt029> datos;
                    if (!considerar_fecha_ingreso)
                        datos = (from a in db.vwROL_Rpt029
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdTipoNomina == idnomina
                                 && estado.Contains(a.EstadoEmpleado)


                               &&
                                (
                                 (a.em_fechaSalida >= fi
                                  && a.em_fechaSalida <= ff)
                                  || a.em_fechaSalida == null
                                )
                                 select a);
                    else
                        datos = (from a in db.vwROL_Rpt029
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdTipoNomina == idnomina
                                 && estado.Contains(a.EstadoEmpleado)


                               &&
                                (
                                 (a.em_fechaSalida >= fi
                                  && a.em_fechaSalida <= ff)
                                  || a.em_fechaSalida == null
                                )
                                && fi <= a.em_fecha_ingreso && a.em_fecha_ingreso <= ff
                                 select a);


                    info_empresa = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt029_Info info = new XROL_Rpt029_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.Empleado = item.Empleado;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.em_fecha_ingreso = item.em_fechaIngaRol;
                        info.ca_descripcion = item.ca_descripcion;
                        info.EstadoEmpleado = item.EstadoEmpleado;
                        info.em_fechaSalida = item.em_fechaSalida;
                        info.Antiguedad = item.antiguedad_string;


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
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XROL_Rpt029_Info>();
            }

        }


    
    }
}
