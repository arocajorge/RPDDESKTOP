using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Reportes.Roles
{
   public  class XROL_Rpt030_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();


        public List<XROL_Rpt030_Info> GetLista(int IdEmpresa, DateTime fechai, DateTime fechaf)
        {
            try
            {
                int secuencia = 0;

                List<XROL_Rpt030_Info> listado = new List<XROL_Rpt030_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {

                    var querry = (from q in db.vwROL_Rpt030
                                  where q.IdEmpresa == IdEmpresa
                                  && q.Fecha_Desde>= fechai
                                  && q.Fecha_Desde <= fechaf
                                  select q);
                    foreach (var item in querry.ToList())
                    {
                        secuencia++;
                        XROL_Rpt030_Info info = new XROL_Rpt030_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNomina_Tipo = item.IdNomina_Tipo;
                        info.IdSolicitudVaca = item.IdSolicitudVaca;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Nombre = item.Nombre;
                        info.ca_descripcion = item.ca_descripcion;
                        info.Anio_Desde = item.Anio_Desde;
                        info.Anio_Hasta = item.Anio_Hasta;
                        info.AnioServicio = item.AnioServicio;
                        info.Dias_q_Corresponde = item.Dias_q_Corresponde;
                        info.Dias_a_disfrutar = item.Dias_a_disfrutar;
                        info.Fecha_Desde = item.Fecha_Desde;
                        info.Dias_pendiente = item.Dias_pendiente;


                        info.Fecha_Hasta = item.Fecha_Hasta;
                        info.Fecha_Retorno = item.Fecha_Retorno;
                        info.Observacion = item.Observacion;
                        info.ValorCancelado = item.ValorCancelado;
                        info.FechaPago = item.FechaPago;
                        info.Iess=item.Iess;
                        if (item.Gozadas_Pgadas == true)
                            info.Gozadas_Pgadas = "Gozadas";
                        else
                            info.Gozadas_Pgadas = "Pagadas";

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
