using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public class XACTF_FJ_Rpt003_Data
    {
        string mensaje = "";
        tb_Empresa_Data empresa_data = new tb_Empresa_Data();
        tb_Empresa_Info info_empresa = new tb_Empresa_Info();
        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa, bool UbicacionActual, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            try
            {
                info_empresa = empresa_data.Get_Info_Empresa(idempresa);
                Fecha_Inicio = Fecha_Inicio.Date;
                Fecha_Fin = Fecha_Fin.Date;
                List<XACTF_FJ_Rpt003_Info> lista = new List<XACTF_FJ_Rpt003_Info>();
                using (EntitiesActivoFijo_Reporte_FJ database = new EntitiesActivoFijo_Reporte_FJ())
                {

                    var query =( from q in database.spACTF_FJ_Rpt003(idempresa, Fecha_Inicio, Fecha_Fin, UbicacionActual)
                                where q.UbicacionActual == UbicacionActual
                                select q);
                    foreach (var item in query)
                    {
                        XACTF_FJ_Rpt003_Info info = new XACTF_FJ_Rpt003_Info();
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdCentroCosto_Scc = item.IdCentroCosto_Ant;
                        info.IdCentroCosto_sub_centro_costo_Scc = item.IdCentroCosto_sub_centro_costo;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.Categoria = item.Categoria;
                        info.Tipo = item.Tipo;
                        info.Subcentro_Costo = item.Subcentro_Costo;
                        info.Centro_costo = item.Centro_costo;
                        info.Af_Nombre = item.Af_Nombre;
                        info.CodActivoFijo = item.CodActivoFijo;
                        info.em_logo = info_empresa.em_logo;
                        info.NombreComercial = info_empresa.em_nombre;
                        info.Estado = "Activo";
                        info.Af_DescripcionCorta = item.Af_DescripcionCorta;

                        lista.Add(info);
                    }


                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XACTF_FJ_Rpt003_Info>();

            }
        }
        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa, string IdCentroCosto, bool UbicacionActual, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            try
            {
                info_empresa = empresa_data.Get_Info_Empresa(idempresa);
                Fecha_Inicio = Fecha_Inicio.Date;
                Fecha_Fin = Fecha_Fin.Date;
                List<XACTF_FJ_Rpt003_Info> lista = new List<XACTF_FJ_Rpt003_Info>();
                using (EntitiesActivoFijo_Reporte_FJ database = new EntitiesActivoFijo_Reporte_FJ())
                {
                                var query =( from q in database.spACTF_FJ_Rpt003(idempresa, Fecha_Inicio, Fecha_Fin, UbicacionActual)
                                where q.UbicacionActual == UbicacionActual
                                && q.IdCentroCosto_Ant==IdCentroCosto
                                && q.UbicacionActual == UbicacionActual
                                select q);

                    foreach (var item in query)
                    {
                        XACTF_FJ_Rpt003_Info info = new XACTF_FJ_Rpt003_Info();
                        info.IdEmpresa_AF = item.IdEmpresa;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdCentroCosto_Scc = item.IdCentroCosto_Ant;
                        info.IdCentroCosto_sub_centro_costo_Scc = item.IdCentroCosto_sub_centro_costo;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.Categoria = item.Categoria;
                        info.Tipo = item.Tipo;
                        info.Subcentro_Costo = item.Subcentro_Costo;
                        info.Centro_costo = item.Centro_costo;
                        info.Af_Nombre = item.Af_Nombre;
                        info.CodActivoFijo = item.CodActivoFijo;
                        info.em_logo = info_empresa.em_logo;
                        info.NombreComercial = info_empresa.em_nombre;
                        info.Estado = "Activo";
                        info.Af_DescripcionCorta = item.Af_DescripcionCorta;


                        lista.Add(info);
                    }


                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XACTF_FJ_Rpt003_Info>();

            }
        }
        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa, string IdCentroCosto, string IdSubCentroCosto, bool UbicacionActual, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {

            try
            {
                info_empresa = empresa_data.Get_Info_Empresa(idempresa);
                Fecha_Inicio = Fecha_Inicio.Date;
                Fecha_Fin = Fecha_Fin.Date;
                List<XACTF_FJ_Rpt003_Info> lista = new List<XACTF_FJ_Rpt003_Info>();
                using (EntitiesActivoFijo_Reporte_FJ database = new EntitiesActivoFijo_Reporte_FJ())
                {

                    var query = (from q in database.spACTF_FJ_Rpt003(idempresa, Fecha_Inicio, Fecha_Fin, UbicacionActual)
                                 where q.UbicacionActual == UbicacionActual
                                 && q.IdCentroCosto_Ant == IdCentroCosto
                                 && q.UbicacionActual == UbicacionActual
                                 select q);
                    foreach (var item in query)
                    {
                        XACTF_FJ_Rpt003_Info info = new XACTF_FJ_Rpt003_Info();
                        info.IdEmpresa_AF = item.IdEmpresa;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info.IdCentroCosto_Scc = item.IdCentroCosto_Ant;
                        info.IdCentroCosto_sub_centro_costo_Scc = item.IdCentroCosto_sub_centro_costo;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        info.IdActijoFijoTipo = item.IdActijoFijoTipo;
                        info.IdActivoFijo = item.IdActivoFijo;
                        info.Categoria = item.Categoria;
                        info.Tipo = item.Tipo;
                        info.Subcentro_Costo = item.Subcentro_Costo;
                        info.Centro_costo = item.Centro_costo;
                        info.Af_Nombre = item.Af_Nombre;
                        info.CodActivoFijo = item.CodActivoFijo;
                        info.em_logo = info_empresa.em_logo;
                        info.NombreComercial = info_empresa.em_nombre;
                        info.Estado = "Activo";
                        info.Af_DescripcionCorta = item.Af_DescripcionCorta;


                        lista.Add(info);
                    }


                }

                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XACTF_FJ_Rpt003_Info>();

            }
        }

    }
}
