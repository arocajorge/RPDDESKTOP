using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_pre_facturacion_mano_obra_servindustria_Data
    {
        string MensajeError = "";

        public List<fa_pre_facturacion_mano_obra_servindustria_Info> GetList_procesar(int idEmpresa, int IdPeriodo)
        {
            try
            {
                List<fa_pre_facturacion_mano_obra_servindustria_Info> Lista = new List<fa_pre_facturacion_mano_obra_servindustria_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.spro_mano_obra_servindustria(idEmpresa, IdPeriodo)
                              select q;



                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_mano_obra_servindustria_Info info = new fa_pre_facturacion_mano_obra_servindustria_Info();

                        info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdPeriodo = item.IdPeriodo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdCargo = item.IdCargo;
                        info.IdActivoFijo = item.IdActivo_fijo;
                        info.pe_apellido = item.Empleado;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                        info.Salario = Convert.ToDouble(item.salario);
                        info.ca_descripcion = item.ca_descripcion;
                        info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                        info.HorasExtras = Convert.ToDouble(item.horasExtras);
                        info.Alimentacion = Convert.ToDouble(item.alimentacion);
                        if (item.IdCargo != null)
                        {
                            info.TotalIngresos = Convert.ToDouble(item.totalIngresos);
                            info.Total_mas_Beneficios = (info.TotalIngresos * 1.1) * 1.4214;
                            info.TotalManoObra = info.Total_mas_Beneficios + info.Alimentacion;
                        }
                        else
                        {
                            info.Total_mas_Beneficios = 0;
                            info.TotalIngresos = 0;
                            info.TotalManoObra = Convert.ToDouble(item.totalIngresos);
                        }

                        info.Centro_costo = item.Centro_costo;
                        info.SubcentroCosto = item.SubCentroCosto;
                        Lista.Add(info);
                    }
                }



                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_pre_facturacion_mano_obra_servindustria_Info> GetList_historico(int idEmpresa, int IdPeriodo)
        {
            try
            {
                List<fa_pre_facturacion_mano_obra_servindustria_Info> Lista = new List<fa_pre_facturacion_mano_obra_servindustria_Info>();

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    var lst = from q in Context.vwfa_pre_facturacion_mano_obra_servindustria
                              where idEmpresa == q.IdEmpresa
                              && q.IdPeriodo==IdPeriodo
                              select q;



                    foreach (var item in lst)
                    {
                        fa_pre_facturacion_mano_obra_servindustria_Info info = new fa_pre_facturacion_mano_obra_servindustria_Info();

                        info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdPeriodo = item.IdPeriodo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdCargo = item.IdCargo;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.pe_apellido = item.pe_nombre + " " + item.pe_apellido;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Salario = Convert.ToDouble(item.Salario);
                        info.ca_descripcion = item.ca_descripcion;
                        info.Af_DescripcionCorta = item.Af_DescripcionCorta;
                        info.HorasExtras = Convert.ToDouble(item.HorasExtras);
                        info.TotalIngresos = Convert.ToDouble(item.TotalIngresos);
                        info.Total_mas_Beneficios = (info.TotalIngresos * 1.1) * 1.4214;
                        info.TotalManoObra = info.Total_mas_Beneficios + info.Alimentacion;
                        info.Centro_costo = item.SubcentroCosto;
                        info.SubcentroCosto = item.Centro_costo;
                        Lista.Add(info);
                    }
                }

                if (Lista.Count() == 0)
                {
                    Lista = GetList_procesar(idEmpresa, IdPeriodo);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public bool GuardarDB(List<fa_pre_facturacion_mano_obra_servindustria_Info> Lst_Info)
        {
            try
            {



                int Secuencia = 0;
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    foreach (fa_pre_facturacion_mano_obra_servindustria_Info item in Lst_Info)
                    {
                        fa_pre_facturacion_mano_obra_servindustria Entity = new fa_pre_facturacion_mano_obra_servindustria();
                        Secuencia++;
                        Entity.IdEmpresa = item.IdEmpresa;
                        Entity.IdPrefacturacion = item.IdPrefacturacion;
                        Entity.IdPeriodo = item.IdPeriodo;
                        Entity.IdEmpleado = item.IdEmpleado;
                        Entity.IdActivoFijo = item.IdActivoFijo;
                        Entity.IdCargo = item.IdCargo;
                        Entity.IdCentroCosto = item.IdCentroCosto;
                        Entity.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Entity.Salario = Convert.ToDouble(item.Salario);
                        Entity.HorasExtras = item.HorasExtras;
                        Entity.Alimentacion = item.Alimentacion;
                        Entity.TotalIngresos = item.TotalIngresos;
                        Entity.TotalManoObra = item.TotalManoObra;
                        Entity.Secuencia = Secuencia;
                        Entity.Total_mas_Beneficios = item.Total_mas_Beneficios;
                        Context.fa_pre_facturacion_mano_obra_servindustria.Add(Entity);
                        Context.SaveChanges();

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public bool EliminarDB(int IdEmpresa, int IdPeriodo, decimal IdPrefacturacion)
        {
            try
            {

                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_mano_obra_servindustria where IdPeriodo = " + IdPeriodo + " and IdEmpresa = " + IdEmpresa + " and IdPrefacturacion=  " + IdPrefacturacion + " ");
                }

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
