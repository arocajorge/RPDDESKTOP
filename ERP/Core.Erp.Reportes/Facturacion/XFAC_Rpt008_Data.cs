using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt008_Data
    {

        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XFAC_Rpt008_Info> get_ImpresionFactura(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdCbteVta, bool mostrar_cuotas)
        {
            try
            {
                List<XFAC_Rpt008_Info> lstRpt = new List<XFAC_Rpt008_Info>();

                using (EntitiesFacturacion_Reportes ListadoDocu = new EntitiesFacturacion_Reportes())
                {
                    if (!mostrar_cuotas)                    
                    lstRpt = (from q in ListadoDocu.vwFAC_Rpt008
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                              && q.IdBodega == IdBodega && q.IdCbteVta == IdCbteVta
                              select new XFAC_Rpt008_Info
                     {

                         IdEmpresa = q.IdEmpresa,
                         IdSucursal = q.IdSucursal,
                         IdBodega = q.IdBodega,
                         IdCbteVta = q.IdCbteVta,
                         Secuencia = q.Secuencia,
                         vt_tipoDoc = q.vt_tipoDoc,
                         vt_serie1 = q.vt_serie1,
                         vt_serie2 = q.vt_serie2,
                         vt_PorDescUnitario = q.vt_PorDescUnitario,
                         vt_NumFactura = q.vt_NumFactura,
                         vt_fecha = q.vt_fecha,
                         Estado = q.Estado,
                         IdProducto = q.IdProducto,
                         pr_descripcion = q.pr_descripcion,
                         pr_descripcion_2 = q.pr_descripcion_2,
                         vt_fech_venc = q.vt_fech_venc,
                         vt_cantidad = q.vt_cantidad,
                         vt_PrecioFinal = q.vt_PrecioFinal,
                         vt_Subtotal = q.vt_Subtotal,
                         Observacion_x_item = q.Observacion_x_item,
                         IdCliente = q.IdCliente,
                         pe_nombreCompleto = q.pe_nombreCompleto,
                         pe_cedulaRuc = q.pe_cedulaRuc,
                         pe_direccion = q.pe_direccion,
                         Observacion_central = q.Observacion_central,
                         dia = q.dia,
                         mes = q.mes,
                         anio = q.anio,
                         vt_iva = q.vt_iva,
                         subtotal_0 = q.subtotal_0,
                         subtotal_iva = q.subtotal_iva,
                         vt_total = q.vt_total,
                         forma_pago_CHEQUE_TRANSFERENCIA = q.forma_pago_CHEQUE_TRANSFERENCIA,
                         forma_pago_DINERO_ELECTRONICO = q.forma_pago_DINERO_ELECTRONICO,
                         forma_pago_EFECTIVO = q.forma_pago_EFECTIVO,
                         forma_pago_TARJETA_CRE_DEB = q.forma_pago_TARJETA_CRE_DEB,
                         descto = q.descto,
                         vt_por_iva = q.vt_por_iva,
                         Descripcion_Ciudad = q.Descripcion_Ciudad,
                         ve_Vendedor = q.Ve_Vendedor,
                         lote_fecha_fab = q.lote_fecha_fab,
                         lote_fecha_vcto = q.lote_fecha_vcto,
                         lote_num_lote = q.lote_num_lote,
                         pe_razonSocial=q.pe_razonSocial,
                         vt_Precio = q.vt_Precio,
                        vt_DescUnitario = q.vt_DescUnitario
                     }).ToList();
                    else
                        lstRpt = (from q in ListadoDocu.vwFAC_Rpt008_cuotas
                                  where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
                                  && q.IdBodega == IdBodega && q.IdCbteVta == IdCbteVta
                                  select new XFAC_Rpt008_Info
                                  {

                                      IdEmpresa = q.IdEmpresa,
                                      IdSucursal = q.IdSucursal,
                                      IdBodega = q.IdBodega,
                                      IdCbteVta = q.IdCbteVta,
                                      Secuencia = q.Secuencia,
                                      vt_tipoDoc = q.vt_tipoDoc,
                                      vt_serie1 = q.vt_serie1,
                                      vt_serie2 = q.vt_serie2,
                                      vt_PorDescUnitario = q.vt_PorDescUnitario,
                                      vt_NumFactura = q.vt_NumFactura,
                                      vt_fecha = q.vt_fecha,
                                      Estado = q.Estado,
                                      IdProducto = q.IdProducto,
                                      pr_descripcion = q.pr_descripcion,
                                      pr_descripcion_2 = q.pr_descripcion_2,
                                      vt_fech_venc = q.vt_fech_venc,
                                      vt_cantidad = q.vt_cantidad,
                                      vt_PrecioFinal = q.vt_PrecioFinal,
                                      vt_Subtotal = q.vt_Subtotal,
                                      Observacion_x_item = q.Observacion_x_item,
                                      IdCliente = q.IdCliente,
                                      pe_nombreCompleto = q.pe_nombreCompleto,
                                      pe_cedulaRuc = q.pe_cedulaRuc,
                                      pe_direccion = q.pe_direccion,
                                      Observacion_central = q.Observacion_central,
                                      dia = q.dia,
                                      mes = q.mes,
                                      anio = q.anio,
                                      vt_iva = q.vt_iva,
                                      subtotal_0 = q.subtotal_0,
                                      subtotal_iva = q.subtotal_iva,
                                      vt_total = q.vt_total,
                                      forma_pago_CHEQUE_TRANSFERENCIA = q.forma_pago_CHEQUE_TRANSFERENCIA,
                                      forma_pago_DINERO_ELECTRONICO = q.forma_pago_DINERO_ELECTRONICO,
                                      forma_pago_EFECTIVO = q.forma_pago_EFECTIVO,
                                      forma_pago_TARJETA_CRE_DEB = q.forma_pago_TARJETA_CRE_DEB,
                                      descto = q.descto,
                                      vt_por_iva = q.vt_por_iva,
                                      Descripcion_Ciudad = q.Descripcion_Ciudad,
                                      ve_Vendedor = q.Ve_Vendedor,
                                      lote_fecha_fab = q.lote_fecha_fab,
                                      lote_fecha_vcto = q.lote_fecha_vcto,
                                      lote_num_lote = q.lote_num_lote,
                                      pe_razonSocial = q.pe_razonSocial,
                                      vt_Precio = q.vt_Precio,
                                      vt_DescUnitario = q.vt_DescUnitario,
                                      orden = q.orden
                                  }).ToList();

                }

                lstRpt.ForEach(q => 
                { 
                    q.vt_DescUnitario = q.vt_DescUnitario * q.vt_cantidad; 
                    q.subtotal_iva = q.subtotal_iva > 0 ? (q.subtotal_iva + q.vt_DescUnitario) : 0;
                    q.subtotal_0 = q.subtotal_0 > 0 ? (q.subtotal_0 + q.vt_DescUnitario) : 0;
                });
                return lstRpt.OrderBy(q=>q.Secuencia).ThenBy(q=>q.orden).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                return new List<XFAC_Rpt008_Info>();
            }
        }


    }
}
