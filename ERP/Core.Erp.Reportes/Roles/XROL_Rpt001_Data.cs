
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt001_Data
    {
        string mensaje = "";
        tb_Empresa_Info info_empresa = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

  
        public List<XROL_Rpt001_Info> GetListConsultaGeneral(int idEmpresa,int idnomina, int IdDivision)
        {
            try
            {
                List<XROL_Rpt001_Info> listado = new List<XROL_Rpt001_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt001
                                 where a.IdEmpresa == idEmpresa
                                 && a.EstadoEmpleado == "A"
                                 && a.StatusEmpleado != "EST_LIQ"
                                 && a.IdDivision==IdDivision
                                 && a.IdTipoNomina==idnomina
                                 select a);
                    info_empresa = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt001_Info info = new XROL_Rpt001_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.NombreCompleto = item.Apellido + " " + item.Nombre;
                        info.CedulaRuc = item.CedulaRuc;
                        info.cargo = item.cargo;
                        info.departamento = item.departamento;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.StatusEmpleado = item.StatusEmpleado;
                        info.IdDivision = item.IdDivision;
                        info.IdSucursal = item.IdSucursal;
                        info.Sucursal = item.Sucursal;
                        info.Division = item.Division;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_foto = item.em_foto;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;
                        info.em_empEspecial = item.em_empEspecial;
                        info.pe_direccion = item.pe_direccion;
                        info.pe_celular = item.pe_celular;
                        info.IdEstadoCivil = item.IdEstadoCivil;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.Sueldo_Actual = (decimal)item.Sueldo_Actual;
                        if (item.pe_sexo == "SEXO_MAS")
                        {
                            info.pe_sexo = "MASCULINO";
                        }
                        else if (item.pe_sexo == "SEXO_FEM")
                        {
                            info.pe_sexo = "FEMENINO";
                        }


                        info.Logo = info_empresa.em_logo_Image;
                        info.RazonSocial = info_empresa.RazonSocial;
                        info.NombreComercial = info_empresa.NombreComercial;
                        info.ca_descripcion = item.ca_descripcion;
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
                return new List<XROL_Rpt001_Info>();
            }

        }



        public List<XROL_Rpt001_Info> GetListConsultaGeneral(int idEmpresa, int idnomina)
        {
            try
            {
                List<XROL_Rpt001_Info> listado = new List<XROL_Rpt001_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt001
                                 where a.IdEmpresa == idEmpresa
                                 && a.EstadoEmpleado == "A"
                                 && a.StatusEmpleado != "EST_LIQ"
                                 && a.IdTipoNomina == idnomina
                                 select a);
                    info_empresa = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt001_Info info = new XROL_Rpt001_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.NombreCompleto = item.Apellido + " " + item.Nombre;
                        info.CedulaRuc = item.CedulaRuc;
                        info.cargo = item.cargo;
                        info.departamento = item.departamento;
                        info.CodigoSectorialIESS = item.CodigoSectorialIESS;
                        info.StatusEmpleado = item.StatusEmpleado;
                        info.IdDivision = item.IdDivision;
                        info.IdSucursal = item.IdSucursal;
                        info.Sucursal = item.Sucursal;
                        info.Division = item.Division;
                        info.em_fecha_ingreso = item.em_fecha_ingreso;
                        info.em_fechaIngaRol = item.em_fechaIngaRol;
                        info.em_foto = item.em_foto;
                        info.es_AcreditaHorasExtras = item.es_AcreditaHorasExtras;
                        info.por_discapacidad = item.por_discapacidad;
                        info.carnet_conadis = item.carnet_conadis;
                        info.em_empEspecial = item.em_empEspecial;
                        info.pe_direccion = item.pe_direccion;
                        info.pe_celular = item.pe_celular;
                        info.IdEstadoCivil = item.IdEstadoCivil;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.Sueldo_Actual = (decimal)item.Sueldo_Actual;
                        if (item.pe_sexo == "SEXO_MAS")
                        {
                            info.pe_sexo = "MASCULINO";
                        }
                        else if (item.pe_sexo == "SEXO_FEM")
                        {
                            info.pe_sexo = "FEMENINO";
                        }


                        info.Logo = info_empresa.em_logo_Image;
                        info.RazonSocial = info_empresa.RazonSocial;
                        info.NombreComercial = info_empresa.NombreComercial;
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
                return new List<XROL_Rpt001_Info>();
            }

        }


    }
}
