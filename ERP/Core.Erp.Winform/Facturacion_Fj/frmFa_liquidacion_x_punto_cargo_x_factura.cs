using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_liquidacion_x_punto_cargo_x_factura : Form
    {
        #region
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<fa_liquidacion_x_punto_cargo_x_fa_factura_Info> blst_liq_factura = new BindingList<fa_liquidacion_x_punto_cargo_x_fa_factura_Info>();
        List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info> lst_liq_factura = new List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info>();
        fa_liquidacion_x_punto_cargo_x_fa_factura_Bus bus_liq_factura = new fa_liquidacion_x_punto_cargo_x_fa_factura_Bus();
        fa_liquidacion_x_punto_cargo_Info info_liquidacion = new fa_liquidacion_x_punto_cargo_Info();
        fa_liquidacion_x_punto_cargo_Bus bus_liquidacion = new fa_liquidacion_x_punto_cargo_Bus();
        #endregion

        public frmFa_liquidacion_x_punto_cargo_x_factura()
        {
            InitializeComponent();
        }

        public void set_info(fa_liquidacion_x_punto_cargo_Info _info)
        {
            try
            {
                info_liquidacion = _info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }         

        private void frmFa_liquidacion_x_punto_cargo_x_factura_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl_facturas.DataSource = blst_liq_factura;
                set_info_in_controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                lst_liq_factura = bus_liq_factura.get_list(param.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto);
                cmb_facturas.DataSource = lst_liq_factura;

                lbl_cod_liquidacion.Text = info_liquidacion.cod_liquidacion;
                info_liquidacion.lst_det_facturas = new List<fa_liquidacion_x_punto_cargo_x_fa_factura_Info>(bus_liq_factura.get_list(param.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion));
                blst_liq_factura = new BindingList<fa_liquidacion_x_punto_cargo_x_fa_factura_Info>(info_liquidacion.lst_det_facturas);
                gridControl_facturas.DataSource = blst_liq_factura;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_facturas_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_factura)
                {
                    if (blst_liq_factura.Where(q => q.ID == e.Value.ToString()).Count() > 0)
                    {
                        gridView_facturas.DeleteSelectedRows();
                    }
                    else
                        gridView_facturas.SetRowCellValue(e.RowHandle, col_factura, e.Value);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_cod_liquidacion.Focus();

                if (Math.Round(blst_liq_factura.Sum(q=>q.vta_total),2,MidpointRounding.AwayFromZero) != Math.Round(info_liquidacion.li_total,2,MidpointRounding.AwayFromZero))
                {
                    if (MessageBox.Show("Existe un descuadre: \nValor total de las facturas es: " + Math.Round(blst_liq_factura.Sum(q => q.vta_total), 2, MidpointRounding.AwayFromZero) + "\nValor total de la liquidación: " + Math.Round(info_liquidacion.li_total, 2, MidpointRounding.AwayFromZero)+"\nDesea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        return;
                }

                foreach (var item in blst_liq_factura)
                {
                    fa_liquidacion_x_punto_cargo_x_fa_factura_Info row = lst_liq_factura.FirstOrDefault(q => q.ID == item.ID);
                    if (row != null)
                    {
                        item.IdEmpresa = info_liquidacion.IdEmpresa;
                        item.IdSucursal = info_liquidacion.IdSucursal;
                        item.IdCentroCosto = info_liquidacion.IdCentroCosto;
                        item.IdLiquidacion = info_liquidacion.IdLiquidacion;
                        item.vt_NumFactura = row.vt_NumFactura;
                        item.IdEmpresa_vta = row.IdEmpresa_vta;
                        item.IdSucursal_vta = row.IdSucursal_vta;
                        item.IdBodega_vta = row.IdBodega_vta;
                        item.IdCbteVta = row.IdCbteVta;
                    }
                }

                bus_liq_factura.eliminarDB(info_liquidacion.IdEmpresa, info_liquidacion.IdSucursal, info_liquidacion.IdCentroCosto, info_liquidacion.IdLiquidacion);

                if (bus_liq_factura.guardarDB(blst_liq_factura.ToList()))
                {
                    info_liquidacion.li_referencia_facturas = "";
                    foreach (var item in blst_liq_factura.ToList())
                    {
                        if (info_liquidacion.li_referencia_facturas == "")
                            info_liquidacion.li_referencia_facturas += item.vt_NumFactura;
                        else
                            info_liquidacion.li_referencia_facturas += " - " + item.vt_NumFactura;
                    }

                    bus_liquidacion.ModificarDB_referencia_facturas(info_liquidacion);

                    MessageBox.Show("Registros guardados exitosamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_facturas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Desea eliminar el registro seleccionado?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_facturas.DeleteSelectedRows();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_facturas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_x_fa_factura_Info fila = (fa_liquidacion_x_punto_cargo_x_fa_factura_Info)gridView_facturas.GetRow(e.RowHandle);

                if (col_factura == e.Column)
                {
                    if (e.Value == null)
                    {
                        return;
                    }
                    fa_liquidacion_x_punto_cargo_x_fa_factura_Info row = lst_liq_factura.FirstOrDefault(q => q.ID == e.Value.ToString());

                    if (MessageBox.Show("Aplicar valor de la liquidación [SI] \nAplicar valor de la factura[NO]", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_facturas.SetRowCellValue(e.RowHandle, col_subtotal, info_liquidacion.li_subtotal);
                        gridView_facturas.SetRowCellValue(e.RowHandle, col_iva, info_liquidacion.li_valor_iva);
                        gridView_facturas.SetRowCellValue(e.RowHandle, col_total, info_liquidacion.li_total);
                    }
                    else
                    {
                        if (row != null)
                        {
                            gridView_facturas.SetRowCellValue(e.RowHandle, col_subtotal, row.vta_subtotal);
                            gridView_facturas.SetRowCellValue(e.RowHandle, col_iva, row.vta_iva);
                            gridView_facturas.SetRowCellValue(e.RowHandle, col_total, row.vta_total);
                        }
                        else
                        {
                            gridView_facturas.SetRowCellValue(e.RowHandle, col_subtotal, info_liquidacion.li_subtotal);
                            gridView_facturas.SetRowCellValue(e.RowHandle, col_iva, info_liquidacion.li_valor_iva);
                            gridView_facturas.SetRowCellValue(e.RowHandle, col_total, info_liquidacion.li_total);
                        }
                    }
                }

                if (e.Column == col_subtotal)
                {
                    fila.vta_iva = Math.Round(fila.vta_subtotal * (info_liquidacion.li_por_iva/100), 2, MidpointRounding.AwayFromZero);
                    fila.vta_total = Math.Round(fila.vta_subtotal + fila.vta_iva, 2, MidpointRounding.AwayFromZero);
                }
                if (e.Column == col_iva)
                {
                    fila.vta_total = Math.Round(fila.vta_subtotal + fila.vta_iva, 2, MidpointRounding.AwayFromZero);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


    }
}
