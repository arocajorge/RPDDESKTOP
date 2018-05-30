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
    public class fa_compensacion_x_ct_centro_costo_det_Data
    {
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        public bool Guardar_DB(List<fa_compensacion_x_ct_centro_costo_det_Info> lista)
        {
            try
            {
                using (Entity_Facturacion_FJ db = new Entity_Facturacion_FJ())
                {
                    foreach (var info in lista)
                    {
                        fa_compensacion_x_ct_centro_costo_det add = new fa_compensacion_x_ct_centro_costo_det();


                        add.IdEmpresa = info.IdEmpresa;
                        add.IdCompensacion = info.IdCompensacion;
                        add.Secuencia = info.Secuencia;
                        add.num_mes = info.num_mes;
                        add.capital_reducido = info.IdEmpresa;
                        add.valor_amortizacion = info.valor_amortizacion;
                        add.valor_interes_banco = info.valor_interes_banco;
                        add.valor_interes_centro_costo = info.valor_interes_centro_costo;
                        add.valor_interes_diferencia = info.valor_interes_diferencia;
                        add.dividendo = info.dividendo;
                        add.IdPeriodo = info.IdPeriodo;
                        add.estado_cobro = info.estado_cobro;
                        add.IdPeriodo = info.IdPeriodo;
                        db.fa_compensacion_x_ct_centro_costo_det.Add(add);
                        db.SaveChanges();
                    }
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

       
         public List<fa_compensacion_x_ct_centro_costo_det_Info> GetList(int IdEmpresa, int IdCompensacion)
        {
            try
            {
                List<fa_compensacion_x_ct_centro_costo_det_Info> lista = new List<fa_compensacion_x_ct_centro_costo_det_Info>();


                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {

                    var contact = from q in Context.fa_compensacion_x_ct_centro_costo_det
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdCompensacion == IdCompensacion
                                  select q;

                    foreach (var item in contact)
                    {
                        fa_compensacion_x_ct_centro_costo_det_Info Info = new fa_compensacion_x_ct_centro_costo_det_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdCompensacion = item.IdCompensacion;
                        Info.Secuencia = item.Secuencia;
                        Info.num_mes = item.num_mes;
                        Info.capital_reducido = item.IdEmpresa;
                        Info.valor_amortizacion = item.valor_amortizacion;
                        Info.valor_interes_centro_costo = item.valor_interes_centro_costo;
                        Info.valor_interes_diferencia = item.valor_interes_diferencia;
                        Info.dividendo = item.dividendo;
                        Info.IdPeriodo = item.IdPeriodo;
                        Info.estado_cobro = item.estado_cobro;
                        Info.IdPeriodo = item.IdPeriodo;
                        lista.Add(Info);
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                MensajeError = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public bool EliminarDB(fa_compensacion_x_ct_centro_costo_Info info)
        {

            try
            {
                using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                {
                    Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_compensacion_x_ct_centro_costo_det where IdEmpresa='" + info.IdEmpresa + "' and IdCompensacion='" + info.IdCompensacion + "'  ");
                 
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
