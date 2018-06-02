
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Participacion_Utilidad_Bus
    {
        ro_Participacion_Utilidad_Data oData = new ro_Participacion_Utilidad_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ro_CargaFamiliar_Bus oRo_CargaFamiliar_Bus = new ro_CargaFamiliar_Bus();
        ro_Participacion_Utilidad_Empleado_Bus oRo_Participacion_Utilidad_Empleado_Bus = new ro_Participacion_Utilidad_Empleado_Bus();

        string mensaje = "";

        public List<ro_Participacion_Utilidad_Info> GetListGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                return oData.GetListGeneral(idEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListGeneral", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Bus) };
            }
        }

        public ro_Participacion_Utilidad_Info GetInfoPorIdPeriodo(int idEmpresa, int idPeriodo, ref string msg)
        {
            try
            {
                return oData.GetInfoPorIdPeriodo(idEmpresa, idPeriodo,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoPorIdPeriodo", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Bus) };
            }
        }


        public Boolean GuardarBD(ro_Participacion_Utilidad_Info info, ref string msg) {
            try {
                Boolean valorRetornar = false;
                int IdUtilidad = 0;
                //MODIFICA
                if(oData.GetExiste(info,ref msg))
                {
                    info.UsuarioIngresa = param.IdUsuario;
                    info.FechaIngresa = param.Fecha_Transac;
                    valorRetornar = oData.ModificarBD(info,ref msg);
                }
                else
                {//GRABA
                    info.UsuarioIngresa = param.IdUsuario;
                    info.FechaIngresa = param.Fecha_Transac;
                    valorRetornar = oData.GuardarBD(info,ref IdUtilidad, ref msg);
                    info.IdUtilidad = IdUtilidad;

                }
                
                //ELIMINA EL DETALLE
                oRo_Participacion_Utilidad_Empleado_Bus.EliminarBD(info.IdEmpresa, info.IdPeriodo, ref msg);

                //GUARDA EL DETALLE
                if (valorRetornar)
                {
                    foreach (ro_Participacion_Utilidad_Empleado_Info item in info.oListRo_Participacion_Utilidad_Empleado_Info)
                    {
                        item.IdUtilidad = info.IdUtilidad;
                        if (!oRo_Participacion_Utilidad_Empleado_Bus.GuardarBD(item, ref msg)) {
                            valorRetornar = false;
                            break;
                        }                    
                    }                               
                }
                
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Participacion_Utilidad_Bus) };
            }       
        }


        public List<ro_Participacion_Utilidad_Empleado_Info> Get_nomina_x_utilidades(int idEmpresa, int IdNomina, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                
                List<ro_Participacion_Utilidad_Empleado_Info> listado = new List<ro_Participacion_Utilidad_Empleado_Info>();
                ro_Rol_Bus oRo_Rol_Bus = new ro_Rol_Bus();
                ro_CargaFamiliar_Bus oRo_CargaFamiliar_Bus = new Roles.ro_CargaFamiliar_Bus();

                int cnt = 0;

                DateTime fechaInicial = Convert.ToDateTime("01/01/" + fechaFin.Year.ToString());
                DateTime fechaFinal = Convert.ToDateTime("31/12/" + fechaFin.Year.ToString());


                listado = oData.Get_nomina_x_utilidades(idEmpresa, IdNomina, fechaInicio, fechaFin);


                foreach (ro_Participacion_Utilidad_Empleado_Info item in listado)
                {

                    item.cargas =Convert.ToInt32( oRo_CargaFamiliar_Bus.pu_TotalCargasParaCalculoUtilidad(idEmpresa, item.IdEmpleado, fechaFin));

                    item.diasTrabajo = Dias_trabajados(item, fechaInicial, fechaFinal);
                }

                return listado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaUtilidad", ex.Message), ex) { EntityType = typeof(ro_Empleado_Bus) };
            }

        }

        private int Dias_trabajados(ro_Participacion_Utilidad_Empleado_Info info, DateTime Fi, DateTime Ff)
        {
            int meses = 0;
            int diaIngresos = 0;
            int DiasSalida = 0;
            int totaldias = 0;
            info.em_fechaIngaRol = Convert.ToDateTime(info.em_fechaIngaRol).Date;
            try
            {
                if (info.IdEmpleado == 263)
                {
                }
                if (info.em_status != "EST_LIQ" & info.em_status != "EST_PLQ")
                {
                    if (info.em_fecha_ingreso <= Fi)
                    {
                        totaldias = 360;
                    }
                    else
                    {
                        //info.InfoPersona.pe_nombreCompleto
                        if (info.em_fechaIngaRol > Fi)
                        {
                            diaIngresos = 31 - Convert.ToDateTime(info.em_fechaIngaRol).Day;
                            meses = (Ff.Month - Convert.ToDateTime(info.em_fechaIngaRol).Month);
                            totaldias = diaIngresos + (meses * 30);
                        }
                        else
                        {

                        }

                    }
                }
                else
                {
                    info.em_fechaSalida = Convert.ToDateTime(info.em_fechaSalida).Date;
                    if (info.em_fechaSalida >= Ff)
                    {
                        if (info.em_fechaIngaRol < Fi)
                            totaldias = 360;
                        else
                        {
                            diaIngresos = 31 - Convert.ToDateTime(info.em_fechaIngaRol).Day;
                            meses = (Convert.ToDateTime(Ff).Month - Convert.ToDateTime(info.em_fechaIngaRol).Month);
                            totaldias = (diaIngresos + DiasSalida) + (meses * 30);
                        }
                    }
                    else
                    {
                        //info.InfoPersona.pe_nombreCompleto
                        if (info.em_fechaIngaRol < Fi)
                        {
                            DiasSalida = Convert.ToDateTime(info.em_fechaSalida).Day;
                            meses = (Convert.ToDateTime(info.em_fechaSalida).Month - Fi.Month);
                            totaldias = (diaIngresos + DiasSalida) + (meses * 30);
                        }
                        else
                        {
                            if ((Convert.ToDateTime(info.em_fechaSalida).Month != Convert.ToDateTime(info.em_fechaIngaRol).Month))
                            {
                                diaIngresos = 31 - Convert.ToDateTime(info.em_fechaIngaRol).Day;
                                DiasSalida = Convert.ToDateTime(info.em_fechaSalida).Day;
                                meses = (Convert.ToDateTime(info.em_fechaSalida).Month - Convert.ToDateTime(info.em_fechaIngaRol).Month) - 1;
                                totaldias = (diaIngresos + DiasSalida) + (meses * 30);
                            }
                            else
                            {
                                totaldias = Convert.ToDateTime(info.em_fechaSalida).Day - Convert.ToDateTime(info.em_fechaIngaRol).Day + 1;

                            }
                        }
                    }
                }

                return totaldias;
            }
            catch (Exception)
            {

                throw;
            }
        }
  



    }
}
