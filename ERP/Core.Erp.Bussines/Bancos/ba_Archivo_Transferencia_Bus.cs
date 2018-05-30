using Core.Erp.Data.Bancos;
using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

namespace Core.Erp.Business.Bancos
{
    public class ba_Archivo_Transferencia_Bus
    {
        #region Variables
        ba_Archivo_Transferencia_Data oData = new ba_Archivo_Transferencia_Data();
        ba_Archivo_Transferencia_Det_Data oData_det = new ba_Archivo_Transferencia_Det_Data();

        tb_banco_procesos_bancarios_x_empresa_Bus bus_procesos_x_empresa = new tb_banco_procesos_bancarios_x_empresa_Bus();
        tb_banco_procesos_bancarios_x_empresa_Info info_procesos_x_empresa = new tb_banco_procesos_bancarios_x_empresa_Info();

        ba_Cbte_Ban_Info info_Cbtecble_ban = new ba_Cbte_Ban_Info();
        ba_Cbte_Ban_Bus bus_Cbtecble_ban = new ba_Cbte_Ban_Bus();

        ct_Cbtecble_Bus bus_Cbtecble_conta = new ct_Cbtecble_Bus();
        cp_orden_pago_cancelaciones_Bus bus_op_cancelaciones = new cp_orden_pago_cancelaciones_Bus();

        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info info_cbte_ban_tipo_x_cbtecble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus bus_cbte_ban_tipo_x_cbtecble = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();

        ba_Banco_Cuenta_Bus bus_banco_cta = new ba_Banco_Cuenta_Bus();
        ba_Banco_Cuenta_Info info_banco_cta = new ba_Banco_Cuenta_Info();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Archivo_Transferencia_Det_Bus bus_archivo_det = new ba_Archivo_Transferencia_Det_Bus();
        string mensaje_error = "";
        #endregion

        public List<ba_Archivo_Transferencia_Info> Get_List_Archivo_transferencia()
        {
            try
            {
                return oData.Get_List_Archivo_transferencia();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public ba_Archivo_Transferencia_Info Get_Info_Archivo_Transferencia(int idEmpresa, decimal idArchivo)
        {
            try
            {
                return oData.Get_Info_Archivo_Transferencia(idEmpresa,idArchivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public ba_Archivo_Transferencia_Info Get_Info_Vista_Archivo_transferencia(int idEmpresa, decimal idArchivo, int idBanco, string idProceso)
        {
            try
            {
                return oData.Get_Info_Vista_Archivo_transferencia(idEmpresa, idArchivo, idBanco, idProceso);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Vista_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_Vista_Archivo_transferencia(int IdEmpresa, DateTime fechaIni, DateTime fechaFin, int idBancoIni, int idBancoFin, string idProceso)
        {
            try
            {
                return oData.Get_Vista_Archivo_transferencia(IdEmpresa, fechaIni,fechaFin,idBancoIni,idBancoFin,idProceso);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Vista_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_Vista_Archivo_transferencia_x_Estado(string idEstadoArchivo, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.Get_Vista_Archivo_transferencia_x_Estado(idEstadoArchivo, fechaIni,fechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Vista_Archivo_transferencia_x_Estado", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_List_Archivo_transferencia(int IdEmpresa, String Origen_Archivo,DateTime fi,DateTime ff)
        {
            try
            {
                return oData.Get_List_Archivo_transferencia(IdEmpresa, Origen_Archivo,fi,ff);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Vista_Archivo_transferencia_x_Estado", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public List<ba_Archivo_Transferencia_Info> Get_List_Archivo_transferencia(int IdEmpresa, int IdBanco, string IdProceso_bancario, String Origen_Archivo)
        {
            try
            {
                return oData.Get_List_Archivo_transferencia(IdEmpresa, IdBanco, IdProceso_bancario, Origen_Archivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Vista_Archivo_transferencia_x_Estado", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool GrabarDB(ba_Archivo_Transferencia_Info info,ref int Idarchivo)
        {
            try
            {
                bool res = false;

                if (info.Lst_Archivo_Transferencia_Det.Count() == 0)
                {
                    return false;
                }

                if (oData.GrabarDB(info, ref Idarchivo))
                {
                    foreach (var item in info.Lst_Archivo_Transferencia_Det)
                    {
                        item.IdArchivo = info.IdArchivo;
                        item.IdEstadoRegistro_cat = "REG_EMITI";
                        item.IdProceso_bancario = info.IdProceso_bancario;
                    }
                    res = oData_det.GrabarDB(info.Lst_Archivo_Transferencia_Det);

                    if (res == true)
                    {
                        ba_Cbte_Ban_Bus BusCbteBan = new ba_Cbte_Ban_Bus();
                        List<ba_Cbte_Ban_Info> listCbteBan= new List<ba_Cbte_Ban_Info>();

                        foreach (var item in info.Lst_Archivo_Transferencia_Det)
                        {
                            ba_Cbte_Ban_Info InfoCbteBan = new ba_Cbte_Ban_Info();
                            InfoCbteBan.IdEmpresa = Convert.ToInt32(item.IdEmpresa_mvba);
                            InfoCbteBan.IdTipocbte = Convert.ToInt32(item.IdTipocbte_mvba);
                            InfoCbteBan.IdCbteCble = Convert.ToDecimal(item.IdCbteCble_mvba);

                            listCbteBan.Add(InfoCbteBan);    
                        }

                        BusCbteBan.Modificar_Estado_Preaviso_ch(listCbteBan, eEstado_Preaviso_Cheque.ES_CH_PREAVISO_CH, ref mensaje_error);
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool Contabilizar_proceso(ba_Archivo_Transferencia_Info info_archivo, tb_banco_procesos_bancarios_x_empresa_Info info_procesos_x_empresa, string Origen)
        {
            try
            {
                bool res = false;
                if (info_archivo.Contabilizado != true)
                {
                    decimal IdCbteCble = 0;
                    decimal Valor_total = 0;
                    string Observacion = "";
                    int cont = 0;

                    info_Cbtecble_ban = new ba_Cbte_Ban_Info();
                    info_cbte_ban_tipo_x_cbtecble = bus_cbte_ban_tipo_x_cbtecble.Get_info_Cbte_Ban_tipo_x_ct_CbteCble_tipo(info_archivo.IdEmpresa, "NDBA");
                    info_banco_cta = bus_banco_cta.Get_Info_Banco_Cuenta(info_archivo.IdEmpresa, info_archivo.IdBanco);

                    List<cp_orden_pago_cancelaciones_Info> list_op_cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                    List<ba_Archivo_Transferencia_Det> list_archivo_detalle_act = new List<ba_Archivo_Transferencia_Det>();

                    switch (info_archivo.IdProceso_bancario)
                    {
                        case "PAGO_PROVEEDORES_BOL":
                            #region Pago a proveedores del bolivariano
                            var list_secuenciales = (from q in info_archivo.Lst_Archivo_Transferencia_Det
                                                     group q by new { q.Secuencial_reg_x_proceso }
                                                         into secuenciales
                                                         select new
                                                         {
                                                             secuencial = secuenciales.Key.Secuencial_reg_x_proceso == null ? 0 : Convert.ToDecimal(secuenciales.Key.Secuencial_reg_x_proceso)
                                                         });

                            foreach (var item in list_secuenciales.OrderBy(q => q.secuencial))
                            {
                                //OBTENGO LA LISTA DE OP PARA HACER DIARIOS POR PROVEEDOR
                                list_op_cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                                List<decimal> list_op = new List<decimal>();


                                foreach (var det_archivo in info_archivo.Lst_Archivo_Transferencia_Det.Where(q => q.Secuencial_reg_x_proceso == item.secuencial).ToList())
                                {
                                    list_op.Add(det_archivo.IdOrdenPago == null ? 0 : (decimal)det_archivo.IdOrdenPago);
                                }
                                List<cp_orden_pago_det_Info> list_op_det = new List<cp_orden_pago_det_Info>();
                                cp_orden_pago_det_Bus bus_op_det = new cp_orden_pago_det_Bus();

                                //OBTENGO LA LISTA DE LAS OP PARA MATAR CON LA NDBA
                                list_op_det = bus_op_det.Get_list_orden_pago_con_cta_acreedora(info_archivo.IdEmpresa, list_op);

                                #region Armo cabecera diario
                                info_Cbtecble_ban.info_Cbtecble = new ct_Cbtecble_Info();
                                info_Cbtecble_ban.IdEmpresa = info_Cbtecble_ban.info_Cbtecble.IdEmpresa = info_archivo.IdEmpresa;
                                info_Cbtecble_ban.IdTipocbte = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte = info_cbte_ban_tipo_x_cbtecble.IdTipoCbteCble;
                                info_Cbtecble_ban.IdCbteCble = info_Cbtecble_ban.info_Cbtecble.IdCbteCble = 0;
                                info_Cbtecble_ban.IdPeriodo = info_Cbtecble_ban.info_Cbtecble.IdPeriodo = (info_archivo.Fecha.Year * 100) + info_archivo.Fecha.Month;
                                info_Cbtecble_ban.cb_Fecha = info_Cbtecble_ban.info_Cbtecble.cb_Fecha = info_archivo.Fecha;
                                info_Cbtecble_ban.info_Cbtecble.Anio = info_archivo.Fecha.Year;
                                info_Cbtecble_ban.info_Cbtecble.Mes = info_archivo.Fecha.Month;
                                info_Cbtecble_ban.IdUsuario = info_Cbtecble_ban.info_Cbtecble.IdUsuario = info_archivo.IdUsuario;
                                info_Cbtecble_ban.Fecha_Transac = info_Cbtecble_ban.info_Cbtecble.cb_FechaTransac = DateTime.Now;

                                info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                                info_Cbtecble_ban.Estado = info_Cbtecble_ban.info_Cbtecble.Estado = "A";
                                #endregion

                                #region Armo detalle diario
                                Valor_total = 0;
                                Observacion = "OB# " + item.secuencial + " NDBA x " + info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString();

                                cont = 0;
                                foreach (var det_op in list_op_det)
                                {

                                    if (cont == 0)
                                    {
                                        Observacion += " " + det_op.IdTipo_Persona + ": [" + det_op.IdEntidad.ToString() + "] " + det_op.pr_nombre.Trim();
                                        cont++;
                                    }
                                    Observacion += ", " + det_op.Referencia;
                                    Valor_total += Convert.ToDecimal(Math.Round(det_op.Valor_a_pagar, 2, MidpointRounding.AwayFromZero));

                                    ct_Cbtecble_det_Info Debe = new ct_Cbtecble_det_Info();
                                    Debe.IdEmpresa = info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                    Debe.IdTipoCbte = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                    Debe.IdCbteCble = 0;
                                    Debe.secuencia = 0;
                                    Debe.IdCtaCble = det_op.IdCtaCble_Acreedora;
                                    Debe.dc_Valor = Convert.ToDouble(Math.Round(Convert.ToDecimal(det_op.Valor_a_pagar), 2, MidpointRounding.AwayFromZero));
                                    Debe.dc_Observacion = "OB# " + item.secuencial + " NDBA x " + info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString() + " " + det_op.IdTipo_Persona + ": [" + det_op.IdEntidad.ToString() + "] " + det_op.pr_nombre.Trim() + " " + det_op.Referencia;
                                    info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Debe);

                                    //Cabecera de cbte bancario necesita id proveedor
                                    info_Cbtecble_ban.IdProveedor = det_op.IdEntidad;

                                    #region Cancelaciones x op
                                    cp_orden_pago_cancelaciones_Info info_op_cancelaciones = new cp_orden_pago_cancelaciones_Info();

                                    info_op_cancelaciones.IdEmpresa = info_archivo.IdEmpresa;
                                    info_op_cancelaciones.Idcancelacion = 0;
                                    info_op_cancelaciones.Secuencia = 0;
                                    info_op_cancelaciones.IdEmpresa_op = det_op.IdEmpresa;
                                    info_op_cancelaciones.IdOrdenPago_op = det_op.IdOrdenPago;
                                    info_op_cancelaciones.Secuencia_op = det_op.Secuencia;
                                    info_op_cancelaciones.IdEmpresa_cxp = det_op.IdEmpresa_cxp;
                                    info_op_cancelaciones.IdTipoCbte_cxp = det_op.IdTipoCbte_cxp;
                                    info_op_cancelaciones.IdCbteCble_cxp = det_op.IdCbteCble_cxp;
                                    info_op_cancelaciones.MontoAplicado = det_op.Valor_a_pagar;
                                    info_op_cancelaciones.SaldoActual = 0;
                                    info_op_cancelaciones.SaldoAnterior = 0;
                                    info_op_cancelaciones.Observacion = "Canc./ de OP con Archivo bancario x " + info_archivo.IdProceso_bancario + " #" + info_archivo.IdArchivo.ToString();
                                    info_op_cancelaciones.fechaTransaccion = info_archivo.Fecha;

                                    list_op_cancelaciones.Add(info_op_cancelaciones);
                                    #endregion
                                }

                                ct_Cbtecble_det_Info Haber = new ct_Cbtecble_det_Info();
                                Haber.IdEmpresa = info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                Haber.IdTipoCbte = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                Haber.IdCbteCble = 0;
                                Haber.secuencia = 0;
                                Haber.IdCtaCble = info_banco_cta.IdCtaCble;
                                Haber.dc_Valor = Convert.ToDouble(Math.Round(Valor_total, 2, MidpointRounding.AwayFromZero)) * -1;
                                Haber.dc_Observacion = Observacion;
                                Haber.dc_para_conciliar = true;
                                info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Haber);
                                #endregion

                                info_Cbtecble_ban.cb_Valor = info_Cbtecble_ban.info_Cbtecble.cb_Valor = Convert.ToDouble(Math.Round(Valor_total, 2, MidpointRounding.AwayFromZero));
                                info_Cbtecble_ban.cb_Observacion = info_Cbtecble_ban.info_Cbtecble.cb_Observacion = Observacion;
                                IdCbteCble = 0;

                                #region Grabar
                                if (bus_Cbtecble_conta.GrabarDB(info_Cbtecble_ban.info_Cbtecble, ref IdCbteCble, ref mensaje_error))
                                {
                                    info_Cbtecble_ban.IdBanco = info_archivo.IdBanco;
                                    info_Cbtecble_ban.IdCbteCble = IdCbteCble;
                                    info_Cbtecble_ban.IdTipoNota = info_procesos_x_empresa.IdTipoNota;

                                    bus_Cbtecble_ban.GrabarDB(info_Cbtecble_ban, ref mensaje_error);

                                    var list_agrup = (from q in list_op_cancelaciones
                                                      group q by new
                                                      {
                                                          q.IdEmpresa,
                                                          q.Idcancelacion,
                                                          q.Secuencia,
                                                          q.IdEmpresa_op,
                                                          q.IdOrdenPago_op,
                                                          q.Secuencia_op,
                                                          q.IdEmpresa_cxp,
                                                          q.IdTipoCbte_cxp,
                                                          q.IdCbteCble_cxp,
                                                          q.MontoAplicado,
                                                          q.SaldoActual,
                                                          q.SaldoAnterior,
                                                          q.Observacion,
                                                          q.fechaTransaccion
                                                      }
                                                          into Lista_agrupada
                                                          select new
                                                          {
                                                              Lista_agrupada.Key.IdEmpresa,
                                                              Lista_agrupada.Key.Idcancelacion,
                                                              Lista_agrupada.Key.Secuencia,
                                                              Lista_agrupada.Key.IdEmpresa_op,
                                                              Lista_agrupada.Key.IdOrdenPago_op,
                                                              Lista_agrupada.Key.Secuencia_op,
                                                              Lista_agrupada.Key.IdEmpresa_cxp,
                                                              Lista_agrupada.Key.IdTipoCbte_cxp,
                                                              Lista_agrupada.Key.IdCbteCble_cxp,
                                                              Lista_agrupada.Key.MontoAplicado,
                                                              Lista_agrupada.Key.SaldoActual,
                                                              Lista_agrupada.Key.SaldoAnterior,
                                                              Lista_agrupada.Key.Observacion,
                                                              Lista_agrupada.Key.fechaTransaccion
                                                          });
                                    list_op_cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                                    foreach (var cancelacion in list_agrup)
                                    {
                                        cp_orden_pago_cancelaciones_Info info_can = new cp_orden_pago_cancelaciones_Info();
                                        info_can.IdEmpresa = cancelacion.IdEmpresa;
                                        info_can.Idcancelacion = cancelacion.Idcancelacion;
                                        info_can.Secuencia = cancelacion.Secuencia;
                                        info_can.IdEmpresa_op = cancelacion.IdEmpresa_op;
                                        info_can.IdOrdenPago_op = cancelacion.IdOrdenPago_op;
                                        info_can.Secuencia_op = cancelacion.Secuencia_op;
                                        info_can.IdEmpresa_cxp = cancelacion.IdEmpresa_cxp;
                                        info_can.IdTipoCbte_cxp = cancelacion.IdTipoCbte_cxp;
                                        info_can.IdCbteCble_cxp = cancelacion.IdCbteCble_cxp;
                                        info_can.MontoAplicado = cancelacion.MontoAplicado;
                                        info_can.SaldoActual = cancelacion.SaldoActual;
                                        info_can.SaldoAnterior = cancelacion.SaldoAnterior;
                                        info_can.Observacion = cancelacion.Observacion;
                                        info_can.fechaTransaccion = cancelacion.fechaTransaccion;
                                        info_can.IdEmpresa_pago = info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                        info_can.IdTipoCbte_pago = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                        info_can.IdCbteCble_pago = IdCbteCble;
                                        list_op_cancelaciones.Add(info_can);
                                    }
                                    bus_op_cancelaciones.GuardarDB(list_op_cancelaciones, info_archivo.IdEmpresa, ref mensaje_error);
                                }

                                #endregion
                            }
                            res = true;
                            info_archivo.Contabilizado = true;
                            #endregion
                            break;
                        default:
                            if (info_archivo.Origen_Archivo != "RRHH")
                            {
                                #region Pago a proveedores que tengan op

                                //OBTENGO LA LISTA DE OP PARA HACER DIARIOS POR PROVEEDOR

                                List<decimal> list_op_x_canc = new List<decimal>();
                                foreach (var det_archivo in info_archivo.Lst_Archivo_Transferencia_Det)
                                {
                                    list_op_x_canc.Add(det_archivo.IdOrdenPago == null ? 0 : (decimal)det_archivo.IdOrdenPago);
                                }
                                List<cp_orden_pago_det_Info> list_op_det_x_cancelar = new List<cp_orden_pago_det_Info>();
                                cp_orden_pago_det_Bus bus_op_det_x_cancelar = new cp_orden_pago_det_Bus();
                                //OBTENGO LA LISTA DE LAS OP PARA MATAR CON LA NDBA
                                list_op_det_x_cancelar = bus_op_det_x_cancelar.Get_list_orden_pago_con_cta_acreedora(info_archivo.IdEmpresa, list_op_x_canc);
                                //OBTENGO LISTA AGRUPADA POR PROVEEDOR
                                var lst_proveedores = from q in list_op_det_x_cancelar
                                                      group q by new { q.IdEmpresa, q.IdPersona, q.IdEntidad, q.IdTipo_Persona }
                                                          into grouping
                                                          select new
                                                          {
                                                              IdEmpresa = grouping.Key.IdEmpresa,
                                                              IdPersona = grouping.Key.IdPersona,
                                                              IdEntidad = grouping.Key.IdEntidad,
                                                              IdTipo_Persona = grouping.Key.IdTipo_Persona
                                                          };
                                

                                foreach (var item in lst_proveedores)
                                {
                                    List<cp_orden_pago_cancelaciones_Info> lst_op_a_cancelar = new List<cp_orden_pago_cancelaciones_Info>();

                                    #region Armo cabecera diario
                                    info_Cbtecble_ban.info_Cbtecble = new ct_Cbtecble_Info();
                                    info_Cbtecble_ban.IdEmpresa = info_Cbtecble_ban.info_Cbtecble.IdEmpresa = info_archivo.IdEmpresa;
                                    info_Cbtecble_ban.IdTipocbte = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte = info_cbte_ban_tipo_x_cbtecble.IdTipoCbteCble;
                                    info_Cbtecble_ban.IdCbteCble = info_Cbtecble_ban.info_Cbtecble.IdCbteCble = 0;
                                    info_Cbtecble_ban.IdPeriodo = info_Cbtecble_ban.info_Cbtecble.IdPeriodo = (info_archivo.Fecha.Year * 100) + info_archivo.Fecha.Month;
                                    info_Cbtecble_ban.cb_Fecha = info_Cbtecble_ban.info_Cbtecble.cb_Fecha = info_archivo.Fecha;
                                    info_Cbtecble_ban.info_Cbtecble.Anio = info_archivo.Fecha.Year;
                                    info_Cbtecble_ban.info_Cbtecble.Mes = info_archivo.Fecha.Month;
                                    info_Cbtecble_ban.IdUsuario = info_Cbtecble_ban.info_Cbtecble.IdUsuario = info_archivo.IdUsuario;
                                    info_Cbtecble_ban.Fecha_Transac = info_Cbtecble_ban.info_Cbtecble.cb_FechaTransac = DateTime.Now;

                                    info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                                    info_Cbtecble_ban.Estado = info_Cbtecble_ban.info_Cbtecble.Estado = "A";
                                    #endregion

                                    #region detalle del diario cuenta banco
                                    ct_Cbtecble_det_Info Haber_op = new ct_Cbtecble_det_Info();
                                    Haber_op.IdEmpresa = info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                    Haber_op.IdTipoCbte = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                    Haber_op.IdCbteCble = 0;
                                    Haber_op.secuencia = 0;
                                    Haber_op.IdCtaCble = info_banco_cta.IdCtaCble;
                                    Haber_op.dc_Valor = Convert.ToDouble(Math.Round(list_op_det_x_cancelar.Where(q=>q.IdEmpresa == item.IdEmpresa && q.IdEntidad == item.IdEntidad && q.IdPersona == item.IdPersona && q.IdTipo_Persona == item.IdTipo_Persona).Sum(q=>q.Valor_a_pagar), 2, MidpointRounding.AwayFromZero)) * -1;
                                    Haber_op.dc_Observacion = Observacion;
                                    Haber_op.dc_para_conciliar = true;
                                    info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Haber_op);
                                    #endregion
                                    list_op_cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                                    foreach (var det_op in list_op_det_x_cancelar.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdEntidad == item.IdEntidad && q.IdPersona == item.IdPersona && q.IdTipo_Persona == item.IdTipo_Persona).ToList())
                                    {
                                        

                                        #region Armo detalle diario
                                        Valor_total = 0;
                                        Observacion = info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString();

                                        cont = 0;

                                        if (cont == 0)
                                        {
                                            Observacion += " " + det_op.IdTipo_Persona + ": [" + det_op.IdEntidad.ToString() + "] " + det_op.pr_nombre.Trim();
                                            cont++;
                                        }
                                        Observacion += ", " + det_op.Referencia;
                                        Valor_total += Convert.ToDecimal(Math.Round(det_op.Valor_a_pagar, 2, MidpointRounding.AwayFromZero));

                                        ct_Cbtecble_det_Info Debe = new ct_Cbtecble_det_Info();
                                        Debe.IdEmpresa = info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                        Debe.IdTipoCbte = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                        Debe.IdCbteCble = 0;
                                        Debe.secuencia = 0;
                                        Debe.IdCtaCble = det_op.IdCtaCble_Acreedora;
                                        Debe.dc_Valor = Convert.ToDouble(Math.Round(Convert.ToDecimal(det_op.Valor_a_pagar), 2, MidpointRounding.AwayFromZero));
                                        Debe.dc_Observacion = info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString() + " " + det_op.IdTipo_Persona + ": [" + det_op.IdEntidad.ToString() + "] " + det_op.pr_nombre.Trim() + " " + det_op.Referencia;
                                        info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Debe);
                                        #endregion

                                        //Cabecera de cbte bancario necesita id proveedor
                                        info_Cbtecble_ban.IdProveedor = det_op.IdEntidad;

                                        #region Cancelaciones x op
                                        cp_orden_pago_cancelaciones_Info info_op_cancelaciones = new cp_orden_pago_cancelaciones_Info();

                                        info_op_cancelaciones.IdEmpresa = info_archivo.IdEmpresa;
                                        info_op_cancelaciones.Idcancelacion = 0;
                                        info_op_cancelaciones.Secuencia = 0;
                                        info_op_cancelaciones.IdEmpresa_op = det_op.IdEmpresa;
                                        info_op_cancelaciones.IdOrdenPago_op = det_op.IdOrdenPago;
                                        info_op_cancelaciones.Secuencia_op = det_op.Secuencia;
                                        info_op_cancelaciones.IdEmpresa_cxp = det_op.IdEmpresa_cxp;
                                        info_op_cancelaciones.IdTipoCbte_cxp = det_op.IdTipoCbte_cxp;
                                        info_op_cancelaciones.IdCbteCble_cxp = det_op.IdCbteCble_cxp;
                                        info_op_cancelaciones.MontoAplicado = det_op.Valor_a_pagar;
                                        info_op_cancelaciones.SaldoActual = 0;
                                        info_op_cancelaciones.SaldoAnterior = 0;
                                        info_op_cancelaciones.Observacion = "Canc./ de OP con Archivo bancario x " + info_archivo.IdProceso_bancario + " #" + info_archivo.IdArchivo.ToString();
                                        info_op_cancelaciones.fechaTransaccion = info_archivo.Fecha;

                                        list_op_cancelaciones.Add(info_op_cancelaciones);
                                        lst_op_a_cancelar.Add(info_op_cancelaciones);
                                        #endregion


                                    }
                                    info_Cbtecble_ban.cb_Valor = info_Cbtecble_ban.info_Cbtecble.cb_Valor = Convert.ToDouble(Math.Round(Valor_total, 2, MidpointRounding.AwayFromZero));
                                    info_Cbtecble_ban.cb_Observacion = info_Cbtecble_ban.info_Cbtecble.cb_Observacion = Observacion;
                                    IdCbteCble = 0;

                                    #region Grabar
                                    if (bus_Cbtecble_conta.GrabarDB(info_Cbtecble_ban.info_Cbtecble, ref IdCbteCble, ref mensaje_error))
                                    {
                                        info_Cbtecble_ban.IdBanco = info_archivo.IdBanco;
                                        info_Cbtecble_ban.IdCbteCble = IdCbteCble;
                                        info_Cbtecble_ban.IdTipoNota = info_procesos_x_empresa.IdTipoNota;

                                        bus_Cbtecble_ban.GrabarDB(info_Cbtecble_ban, ref mensaje_error);

                                        foreach (var info_archivo_det in info_archivo.Lst_Archivo_Transferencia_Det)
                                        {
                                            if (lst_op_a_cancelar.Where(q=>q.IdEmpresa_op == info_archivo_det.IdEmpresa_OP && q.IdOrdenPago_op == info_archivo_det.IdOrdenPago && q.Secuencia_op == info_archivo_det.Secuencia_OP).Count()>0)
                                            {
                                                info_archivo_det.IdEmpresa_pago = info_Cbtecble_ban.IdEmpresa;
                                                info_archivo_det.IdTipoCbte_pago = info_Cbtecble_ban.IdTipocbte;
                                                info_archivo_det.IdCbteCble_pago = info_Cbtecble_ban.IdCbteCble;
                                                bus_archivo_det.ModificarDB(info_archivo_det);    
                                            }
                                        }                                        

                                        var list_agrup = (from q in list_op_cancelaciones
                                                          group q by new
                                                          {
                                                              q.IdEmpresa,
                                                              q.Idcancelacion,
                                                              q.Secuencia,
                                                              q.IdEmpresa_op,
                                                              q.IdOrdenPago_op,
                                                              q.Secuencia_op,
                                                              q.IdEmpresa_cxp,
                                                              q.IdTipoCbte_cxp,
                                                              q.IdCbteCble_cxp,
                                                              q.MontoAplicado,
                                                              q.SaldoActual,
                                                              q.SaldoAnterior,
                                                              q.Observacion,
                                                              q.fechaTransaccion
                                                          }
                                                              into Lista_agrupada
                                                              select new
                                                              {
                                                                  Lista_agrupada.Key.IdEmpresa,
                                                                  Lista_agrupada.Key.Idcancelacion,
                                                                  Lista_agrupada.Key.Secuencia,
                                                                  Lista_agrupada.Key.IdEmpresa_op,
                                                                  Lista_agrupada.Key.IdOrdenPago_op,
                                                                  Lista_agrupada.Key.Secuencia_op,
                                                                  Lista_agrupada.Key.IdEmpresa_cxp,
                                                                  Lista_agrupada.Key.IdTipoCbte_cxp,
                                                                  Lista_agrupada.Key.IdCbteCble_cxp,
                                                                  Lista_agrupada.Key.MontoAplicado,
                                                                  Lista_agrupada.Key.SaldoActual,
                                                                  Lista_agrupada.Key.SaldoAnterior,
                                                                  Lista_agrupada.Key.Observacion,
                                                                  Lista_agrupada.Key.fechaTransaccion
                                                              });
                                        list_op_cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                                        foreach (var cancelacion in list_agrup)
                                        {
                                            cp_orden_pago_cancelaciones_Info info_can = new cp_orden_pago_cancelaciones_Info();
                                            info_can.IdEmpresa = cancelacion.IdEmpresa;
                                            info_can.Idcancelacion = cancelacion.Idcancelacion;
                                            info_can.Secuencia = cancelacion.Secuencia;
                                            info_can.IdEmpresa_op = cancelacion.IdEmpresa_op;
                                            info_can.IdOrdenPago_op = cancelacion.IdOrdenPago_op;
                                            info_can.Secuencia_op = cancelacion.Secuencia_op;
                                            info_can.IdEmpresa_cxp = cancelacion.IdEmpresa_cxp;
                                            info_can.IdTipoCbte_cxp = cancelacion.IdTipoCbte_cxp;
                                            info_can.IdCbteCble_cxp = cancelacion.IdCbteCble_cxp;
                                            info_can.MontoAplicado = cancelacion.MontoAplicado;
                                            info_can.SaldoActual = cancelacion.SaldoActual;
                                            info_can.SaldoAnterior = cancelacion.SaldoAnterior;
                                            info_can.Observacion = cancelacion.Observacion;
                                            info_can.fechaTransaccion = cancelacion.fechaTransaccion;
                                            info_can.IdEmpresa_pago = info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                            info_can.IdTipoCbte_pago = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                            info_can.IdCbteCble_pago = IdCbteCble;
                                            list_op_cancelaciones.Add(info_can);
                                        }
                                        bus_op_cancelaciones.GuardarDB(list_op_cancelaciones, info_archivo.IdEmpresa, ref mensaje_error);
                                    }
                                    #endregion
                                }

                                res = true;
                                info_archivo.Contabilizado = true;
                                #endregion
                            }
                            else
                            {
                                #region Contabilizacion de archivos de roles
                                ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info info_param_ro = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info();
                                ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Bus bus_param_ro = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Bus();

                                if (info_archivo.Lst_Archivo_Transferencia_Det.Count != 0)
                                {
                                    ba_Archivo_Transferencia_Det_Info info_det_archivo = new ba_Archivo_Transferencia_Det_Info();
                                    info_det_archivo = info_archivo.Lst_Archivo_Transferencia_Det.First();
                                    info_param_ro = bus_param_ro.Get_Info(Convert.ToInt32(info_det_archivo.IdEmpresa), Convert.ToInt32(info_det_archivo.IdNominaTipo), Convert.ToInt32(info_det_archivo.IdNominaTipoLiqui));
                                }

                                cont = 0;
                                foreach (var det_op in info_archivo.Lst_Archivo_Transferencia_Det)
                                {
                                    if (det_op.IdEmpresa_pago == null)
                                    {
                                        #region Armo cabecera diario
                                        info_Cbtecble_ban.info_Cbtecble = new ct_Cbtecble_Info();
                                        info_Cbtecble_ban.IdEmpresa = info_Cbtecble_ban.info_Cbtecble.IdEmpresa = info_archivo.IdEmpresa;
                                        info_Cbtecble_ban.IdTipocbte = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte = info_cbte_ban_tipo_x_cbtecble.IdTipoCbteCble;
                                        info_Cbtecble_ban.IdCbteCble = info_Cbtecble_ban.info_Cbtecble.IdCbteCble = 0;
                                        info_Cbtecble_ban.IdPeriodo = info_Cbtecble_ban.info_Cbtecble.IdPeriodo = (info_archivo.Fecha.Year * 100) + info_archivo.Fecha.Month;
                                        info_Cbtecble_ban.cb_Fecha = info_Cbtecble_ban.info_Cbtecble.cb_Fecha = info_archivo.Fecha;
                                        info_Cbtecble_ban.info_Cbtecble.Anio = info_archivo.Fecha.Year;
                                        info_Cbtecble_ban.info_Cbtecble.Mes = info_archivo.Fecha.Month;
                                        info_Cbtecble_ban.IdUsuario = info_Cbtecble_ban.info_Cbtecble.IdUsuario = info_archivo.IdUsuario;
                                        info_Cbtecble_ban.Fecha_Transac = info_Cbtecble_ban.info_Cbtecble.cb_FechaTransac = DateTime.Now;
                                        
                                        info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info = new List<ct_Cbtecble_det_Info>();
                                        info_Cbtecble_ban.Estado = info_Cbtecble_ban.info_Cbtecble.Estado = "A";
                                        #endregion

                                        #region Armo detalle diario
                                        Valor_total = 0;
                                        Observacion = info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString();


                                        Observacion += " " + "EMPLEA" + ": [" + det_op.pe_cedulaRuc.ToString() + "] " + det_op.pe_nombreCompleto.Trim() + " " + info_archivo.Observacion;


                                        Valor_total += Convert.ToDecimal(Math.Round(det_op.Valor, 2, MidpointRounding.AwayFromZero));

                                        ct_Cbtecble_det_Info Debe = new ct_Cbtecble_det_Info();
                                        Debe.IdEmpresa = info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                        Debe.IdTipoCbte = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                        Debe.IdCbteCble = 0;
                                        Debe.secuencia = 1;
                                        Debe.IdCtaCble = info_param_ro.IdCtaCble;
                                        Debe.dc_Valor = Convert.ToDouble(Math.Round(Convert.ToDecimal(det_op.Valor), 2, MidpointRounding.AwayFromZero));
                                        Debe.dc_Observacion = info_archivo.IdProceso_bancario + " # " + info_archivo.IdArchivo.ToString() + " " + "EMPLEA" + ": [" + det_op.pe_cedulaRuc.ToString() + "] " + det_op.pe_nombreCompleto.Trim() + " " + info_archivo.Observacion;
                                        info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Debe);

                                        //Cabecera de cbte bancario necesita id proveedor
                                        //info_Cbtecble_ban.IdPersona_Girado_a = det_op.IdEmpleado;

                                        ct_Cbtecble_det_Info Haber_op = new ct_Cbtecble_det_Info();
                                        Haber_op.IdEmpresa = info_Cbtecble_ban.info_Cbtecble.IdEmpresa;
                                        Haber_op.IdTipoCbte = info_Cbtecble_ban.info_Cbtecble.IdTipoCbte;
                                        Haber_op.IdCbteCble = 0;
                                        Haber_op.secuencia = 2;
                                        Haber_op.IdCtaCble = info_banco_cta.IdCtaCble;
                                        Haber_op.dc_Valor = Convert.ToDouble(Math.Round(Valor_total, 2, MidpointRounding.AwayFromZero)) * -1;
                                        Haber_op.dc_Observacion = Observacion;
                                        Haber_op.dc_para_conciliar = true;
                                        info_Cbtecble_ban.info_Cbtecble._cbteCble_det_lista_info.Add(Haber_op);
                                        #endregion

                                        info_Cbtecble_ban.cb_Valor = info_Cbtecble_ban.info_Cbtecble.cb_Valor = Convert.ToDouble(Math.Round(Valor_total, 2, MidpointRounding.AwayFromZero));
                                        info_Cbtecble_ban.cb_Observacion = info_Cbtecble_ban.info_Cbtecble.cb_Observacion = Observacion;
                                        IdCbteCble = 0;

                                        #region Grabar
                                        if (bus_Cbtecble_conta.GrabarDB(info_Cbtecble_ban.info_Cbtecble, ref IdCbteCble, ref mensaje_error))
                                        {

                                            info_Cbtecble_ban.IdBanco = info_archivo.IdBanco;
                                            info_Cbtecble_ban.IdCbteCble = IdCbteCble;
                                            info_Cbtecble_ban.IdTipoNota = info_procesos_x_empresa.IdTipoNota;
                                            info_Cbtecble_ban.IdUsuario = param.IdUsuario;
                                            info_Cbtecble_ban.IdTipoFlujo = info_param_ro.IdTipoFlujo;
                                            if (bus_Cbtecble_ban.GrabarDB(info_Cbtecble_ban, ref mensaje_error))
                                            {
                                                det_op.IdEmpresa_pago = info_Cbtecble_ban.IdEmpresa;
                                                det_op.IdTipoCbte_pago = info_Cbtecble_ban.IdTipocbte;
                                                det_op.IdCbteCble_pago = info_Cbtecble_ban.IdCbteCble;
                                                bus_archivo_det.ModificarDB(det_op);
                                            }
                                        }

                                        #endregion
                                    }                                  
                                }

                                info_archivo.Contabilizado = true;
                                #endregion
                            }

                            break;
                    }
                    Actualizar_estado_contabilizacion(info_archivo);
                }
                
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool Actualizar_Archivo(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                return oData.Actualizar_Archivo(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_Archivo", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdArchivo)
        {
            try
            {
                if (bus_archivo_det.EliminarDB(IdEmpresa, IdArchivo))
                {
                    if (oData.EliminarDB(IdEmpresa, IdArchivo))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_Archivo", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool Actualizar_estado_contabilizacion(ba_Archivo_Transferencia_Info info_archivo)
        {
            try
            {
                return oData.Actualizar_estado_contabilizacion(info_archivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar_estado_contabilizacion", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool ModificarDB(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                bool res = false;

                if (oData.ModificarDB(info))
                {
                    if (oData_det.EliminarDB(info.IdEmpresa,info.IdArchivo))
                    {
                        foreach (var item in info.Lst_Archivo_Transferencia_Det)
                        {
                            item.IdArchivo = info.IdArchivo;
                            item.IdEstadoRegistro_cat = "REG_EMITI";
                            item.IdProceso_bancario = info.IdProceso_bancario;
                        }
                        res = oData_det.GrabarDB(info.Lst_Archivo_Transferencia_Det);
                    }
                    info_procesos_x_empresa = bus_procesos_x_empresa.Get_info_proceso_bancario_x_empresa(info.IdEmpresa, info.IdProceso_bancario);                   
                } 

                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public bool AnularDB(ba_Archivo_Transferencia_Info info)
        {
            try
            {
                return oData.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public byte[] Get_Archivo(int idEmpresa, decimal idArchivo, string idProceso, int idBanco)
        {
            try
            {
                return oData.Get_Archivo(idEmpresa, idArchivo, idProceso, idBanco);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Archivo", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };

            }
        }

        public string GetId_codigoArchivo_bolivariano(int IdEmpresa, int IdBanco, DateTime fecha)
        {
            try
            {
                return oData.GetId_codigoArchivo_bolivariano(IdEmpresa, IdBanco, fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }        

        public string GetId_codigoArchivo(int IdEmpresa, DateTime fecha)
        {
            try
            {
                return oData.GetId_codigoArchivo(IdEmpresa,fecha);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

        public int GetId(int IdEmpresa)
        {
            try
            {
                return oData.GetId(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Archivo_transferencia", ex.Message), ex) { EntityType = typeof(ba_Archivo_Transferencia_Bus) };
            }
        }

    }
}
