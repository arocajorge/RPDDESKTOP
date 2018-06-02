using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Facturacion
{
  public  class fa_cliente_contactos_Data
    {
      string mensaje = "";
        public Boolean GuardarDB(List<fa_cliente_contactos_Info> listDetalle_Guia_Info)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    foreach (var item in listDetalle_Guia_Info)
                    {
                        fa_cliente_contactos Entity = Context.fa_cliente_contactos.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdCliente == item.IdCliente && q.IdContacto == item.IdContacto).FirstOrDefault();
                        if (Entity == null)
                        {
                            var Address = new fa_cliente_contactos
                            {
                                IdEmpresa = item.IdEmpresa,
                                IdCliente = item.IdCliente,
                                IdContacto = item.IdContacto,
                                Telefono = item.Telefono,
                                Celular = item.Celular,
                                Correo = item.Correo,
                                Nombres = item.Nombres,
                                IdCiudad = item.IdCiudad,
                                IdParroquia = item.IdParroquia,
                                Direccion = item.Direccion
                            };
                            Context.fa_cliente_contactos.Add(Address);
                        }
                        else
                        {
                            Entity.Telefono = item.Telefono;
                            Entity.Celular = item.Celular;
                            Entity.Correo = item.Correo;
                            Entity.Nombres = item.Nombres;
                            Entity.IdCiudad = item.IdCiudad;
                            Entity.IdParroquia = item.IdParroquia;
                            Entity.Direccion = item.Direccion;
                        }
                    }
                    Context.SaveChanges();
                    Context.Dispose();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        public List<fa_cliente_contactos_Info> get_list(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                List<fa_cliente_contactos_Info> lista = new List<fa_cliente_contactos_Info>();
                EntitiesFacturacion OEFAC = new EntitiesFacturacion();
                lista = (from q in OEFAC.fa_cliente_contactos
                         where q.IdEmpresa == IdEmpresa
                         && q.IdCliente == IdCliente
                         select new fa_cliente_contactos_Info
                         {
                             IdEmpresa = q.IdEmpresa,
                             IdCliente = q.IdCliente,
                             IdContacto = q.IdContacto,
                             Telefono = q.Telefono,
                             Celular = q.Celular,
                             Correo = q.Correo,
                             Nombres = q.Nombres,
                             IdCiudad = q.IdCiudad,
                             IdParroquia = q.IdParroquia,
                             Direccion = q.Direccion
                         }).ToList();


                return lista;
            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }


        public Boolean Eliminar_DB(int IdEmpresa, decimal IdCliente)
        {
            try
            {
                    using (EntitiesFacturacion Context = new EntitiesFacturacion())
                    {
                        string sql = "delete fa_cliente_contactos where IdEmpresa='" + IdEmpresa + "' and IdCliente= '" + IdCliente + "'";
                        Context.Database.ExecuteSqlCommand(sql);
                    }
               
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
      
    }
}
