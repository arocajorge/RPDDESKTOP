using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion
{
    public class fa_factura_det_x_fa_descuento_Data
    {
        public List<fa_factura_det_x_fa_descuento_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, int Secuencia)
        {
            try
            {
                List<fa_factura_det_x_fa_descuento_Info> Lista = new List<fa_factura_det_x_fa_descuento_Info>();

                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    var lst = from q in Context.fa_factura_det_x_fa_descuento
                              where q.IdEmpresa_fa == IdEmpresa
                              && q.IdSucursal == IdSucursal
                              && q.IdBodega == IdBodega
                              && q.IdCbteVta == IdCbteVta
                              && q.Secuencia == Secuencia
                              select q;

                    foreach (var item in lst)
                    {
                        fa_factura_det_x_fa_descuento_Info info = new fa_factura_det_x_fa_descuento_Info();

                        info.IdEmpresa_fa = item.IdEmpresa_fa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdBodega = item.IdBodega;
                        info.IdCbteVta = item.IdCbteVta;
                        info.Secuencia = item.Secuencia;
                        info.IdEmpresa_de = item.IdEmpresa_de;
                        info.IdDescuento = item.IdDescuento;
                        info.Secuencia_reg = item.Secuencia_reg;
                        info.de_valor = item.de_valor;

                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(fa_factura_det_x_fa_descuento_Info info)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    fa_factura_det_x_fa_descuento Entity = new fa_factura_det_x_fa_descuento();
                    Entity.IdEmpresa_fa = info.IdEmpresa_fa;
                    Entity.IdSucursal = info.IdSucursal;
                    Entity.IdBodega = info.IdBodega;
                    Entity.IdCbteVta = info.IdCbteVta;
                    Entity.Secuencia = info.Secuencia;
                    Entity.IdEmpresa_de = info.IdEmpresa_de;
                    Entity.IdDescuento = info.IdDescuento;
                    Entity.Secuencia_reg = info.Secuencia_reg;
                    Entity.de_valor = info.de_valor;
                    Context.fa_factura_det_x_fa_descuento.Add(Entity);
                    Context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool GuardarDB(List<fa_factura_det_x_fa_descuento_Info> lst)
        {
            try
            {
                int Secuencia_reg = 1;
                foreach (var item in lst)
                {
                    item.Secuencia_reg = Secuencia_reg;
                    if (!GuardarDB(item))
                        return false;
                    Secuencia_reg++;
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool EliminarDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta)
        {
            try
            {
                using (EntitiesFacturacion Context = new EntitiesFacturacion())
                {
                    string comando = "delete fa_factura_det_x_fa_descuento where IdEmpresa_fa = " + IdEmpresa + " and IdSucursal = " + IdSucursal + " and IdBodega = " + IdBodega + " and IdCbteVta = " + IdCbteVta;
                    Context.Database.ExecuteSqlCommand(comando);
                }

                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
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
