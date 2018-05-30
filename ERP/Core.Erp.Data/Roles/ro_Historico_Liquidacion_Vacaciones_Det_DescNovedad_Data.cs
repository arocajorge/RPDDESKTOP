using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
namespace Core.Erp.Data.Roles
{
  public  class ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Data
    {


      public bool Guardar_DB(ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info info)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad add = new ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad();
                     add.IdEmpresa=info.IdEmpresa;
                     add.IdNomina_tipo=info.IdNomina_tipo;
                     add.IdEmpleado=info.IdEmpleado;
                     add.IdSolicitud_Vacaciones=info.IdSolicitud_Vacaciones;
                     add.IdNovedad=info.IdNovedad;
                     add.IdNomina_Tipo_Liq=info.IdNomina_Tipo_Liq;
                     add.IdRubro=info.IdRubro;
                     add.Secuencia=info.Secuencia;
                     add.Valor=info.Valor;
                     add.Secuencia = info.Secuencia;
                     db.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad.Add(add);
                    db.SaveChanges();
                   return true;
                }
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);

                throw new Exception(ex.ToString());
            }
        }

      public bool Eliminar(ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info info)
        {
            string mensaje = "";
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand(" delete Grafinpren.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad where IdEmpresa='" + info.IdEmpresa + "'  and IdNominatipo='" + info.IdNomina_tipo + "'  and IdEmpleado='" + info.IdEmpleado + "'  and IdSolicitud_Vacaciones ='" + info.IdSolicitud_Vacaciones + "'");
                    return true;
                }
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

        public List<ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info> Get_Lis(int IdEmpresa, int idempleado, int idsolicitud)
        {
            List<ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info> Lst = new List<ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info>();
            EntitiesRoles oEnti = new EntitiesRoles();
            try
            {
                var Query = from q in oEnti.ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad
                            where q.IdEmpresa == IdEmpresa
                            && q.IdEmpleado == idempleado
                            && q.IdSolicitud_Vacaciones == idsolicitud
                            select q;
                foreach (var item in Query)
                {

                    ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info add = new ro_Historico_Liquidacion_Vacaciones_Det_DescNovedad_Info();
                    add.IdEmpresa = item.IdEmpresa;
                    add.IdNomina_tipo = item.IdNomina_tipo;
                    add.IdEmpleado = item.IdEmpleado;
                    add.IdSolicitud_Vacaciones = item.IdSolicitud_Vacaciones;
                    add.IdNovedad = item.IdNovedad;
                    add.IdNomina_Tipo_Liq = item.IdNomina_Tipo_Liq;
                    add.IdRubro = item.IdRubro;
                    add.Secuencia = item.Secuencia;
                    add.Valor = item.Valor;

                    Lst.Add(add);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                throw new Exception(ex.ToString());
            }

        }

    }
}
