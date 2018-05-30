using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data.Entity.Validation;
namespace Core.Erp.Data.Facturacion_Fj
{
    public class fa_tarifario_facturacion_x_cliente_det_Data
    {
        string MensajeError = "";

        public bool Guardar(List<fa_tarifario_facturacion_x_cliente_det_Info> lista)
        {
            try
            {
                try
                {

                    int Secuencia = 1;
                    using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                    {
                        foreach (var item in lista)
                        {
                            fa_tarifario_facturacion_x_cliente_det add = new fa_tarifario_facturacion_x_cliente_det();
                            add.IdEmpresa = item.IdEmpresa;
                            add.IdTarifario = item.IdTarifario;
                            add.Secuencia = item.Secuencia = Secuencia;
                            add.cantidad = item.cantidad;
                            add.IdCategoriaAF = item.IdCategoriaAF;
                            model.fa_tarifario_facturacion_x_cliente_det.Add(add);
                            model.SaveChanges();
                            Secuencia++;

                        }

                        return true;

                    }
                }
                catch (DbEntityValidationException ex)
                {
                    string mensaje = "";
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }

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

        public bool Eliminar(fa_tarifario_facturacion_x_cliente_Info info)
        {
            try
            {
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    model.Database.ExecuteSqlCommand(" delete Fj_servindustrias.fa_tarifario_facturacion_x_cliente_det where IdEmpresa = '" + info.IdEmpresa + "' and IdTarifario = '" + info.IdTarifario + "'");

                    return true;

                }

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

        public List<fa_tarifario_facturacion_x_cliente_det_Info> Get_List_Tarifarios(int idempresa, decimal idtarifario)
        {
            try
            {
                List<fa_tarifario_facturacion_x_cliente_det_Info> lista = new List<fa_tarifario_facturacion_x_cliente_det_Info>();
                using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
                {
                    var query = from q in model.fa_tarifario_facturacion_x_cliente_det
                                where q.IdEmpresa == idempresa
                                && q.IdTarifario == idtarifario
                                select q;

                    foreach (var item in query)
                    {
                        fa_tarifario_facturacion_x_cliente_det_Info info = new fa_tarifario_facturacion_x_cliente_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTarifario = item.IdTarifario;
                        info.Secuencia = item.Secuencia;
                        info.cantidad = item.cantidad;
                        info.IdCategoriaAF = item.IdCategoriaAF;
                        lista.Add(info);
                    }
                    return lista;

                }

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
