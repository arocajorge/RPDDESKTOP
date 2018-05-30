using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using System.Linq;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_Registro_de_horas_x_equipo_facturacion : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> blst_registro_unidades_x_af = new BindingList<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>();
        fa_registro_unidades_x_equipo_det_ini_x_Af_Bus bus_registro_x_unidades_x_af = new fa_registro_unidades_x_equipo_det_ini_x_Af_Bus();
        List<ct_Centro_costo_Info> lst_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();
        fa_parametro_info info_fa_param = new fa_parametro_info();
        fa_parametro_Bus bus_fa_param = new fa_parametro_Bus();
        Dictionary<int, string> lst_etipo_horas = new Dictionary<int, string>();
        Cl_Enumeradores.eTipo_horas_facturar eTipo_horas;
        List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info> lst_a_facturar;
        #endregion

        public frmFa_Registro_de_horas_x_equipo_facturacion()
        {
            InitializeComponent();
        }

        private void frmFa_Registro_de_horas_x_equipo_facturacion_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturar())
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAprobarGuardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (facturar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscar()
        {
            try
            {
                if (cmb_centro_costo.EditValue == null)
                {
                    MessageBox.Show("Ingrese el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ucCon_Periodo1.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Ingrese el periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                blst_registro_unidades_x_af = new BindingList<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>(bus_registro_x_unidades_x_af.Get_List_Inicial_x_Af_para_facturar(param.IdEmpresa, cmb_centro_costo.EditValue.ToString(), ucCon_Periodo1.Get_Periodo_Info().IdPeriodo));
                gridControl_unidades.DataSource = blst_registro_unidades_x_af;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                de_fecha.DateTime = DateTime.Now.Date;
                string mensaje="";

                ucIn_Sucursal_Bodega1.set_Idsucursal(param.IdSucursal);
                ucCon_Periodo1.Cargar_combos();

                lst_centro_costo = bus_centro_costo.Get_list_Centro_Costo_x_cliente(param.IdEmpresa, ref mensaje);
                cmb_centro_costo.Properties.DataSource = lst_centro_costo;

                blst_registro_unidades_x_af = new BindingList<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>();
                gridControl_unidades.DataSource = blst_registro_unidades_x_af;

                lst_etipo_horas = Enum.GetValues(typeof(Cl_Enumeradores.eTipo_horas_facturar)).
                    Cast<Cl_Enumeradores.eTipo_horas_facturar>().ToDictionary(x => (int)x, x => x.ToString());
                cmb_tipo_horas.Properties.DataSource = lst_etipo_horas.ToList();
                cmb_tipo_horas.EditValue = 1;//Horas normales
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar()
        {
            try
            {
                if (cmb_centro_costo.EditValue == null)
                {
                    MessageBox.Show("Ingrese el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucCon_Periodo1.Get_Periodo_Info() == null)
                {
                    MessageBox.Show("Ingrese el periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Sucursal_Bodega1.get_IdSucursal() == 0)
                {
                    MessageBox.Show("Seleccione la sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Sucursal_Bodega1.get_IdBodega() == 0)
                {
                    MessageBox.Show("Seleccione la bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blst_registro_unidades_x_af.Where(q=>q.seleccionado == true).Count() == 0)
                {
                    MessageBox.Show("Seleccione los registros a facturar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_tipo_horas.EditValue == null)
                {
                    MessageBox.Show("Seleccione el tipo de horas a facturar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                info_fa_param = bus_fa_param.Get_Info_parametro(param.IdEmpresa);

                int cont_hn = blst_registro_unidades_x_af.Where(q => q.cantidad_unidades_normales > 0 && q.seleccionado == true && q.IdCbteVta_hn == null).Count();
                int cont_he = blst_registro_unidades_x_af.Where(q => q.cantidad_unidades_extra > 0 && q.seleccionado == true && q.IdCbteVta_he == null).Count();

                eTipo_horas = (Cl_Enumeradores.eTipo_horas_facturar)Enum.Parse(typeof(Cl_Enumeradores.eTipo_horas_facturar), lst_etipo_horas.FirstOrDefault(q => q.Key == Convert.ToInt32(cmb_tipo_horas.EditValue)).Value);
                if (eTipo_horas == Cl_Enumeradores.eTipo_horas_facturar.HORAS_NORMALES)
                {
                    if (cont_hn == 0)
                    {
                        MessageBox.Show("Los registros seleccionados no contienen horas normales pendientes de facturar " + info_fa_param.NumeroDeItemFact, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if ((cont_hn) > info_fa_param.NumeroDeItemFact)
                    {
                        MessageBox.Show("Los registros seleccionados crearán " + (cont_hn) + " líneas en la factura y el máximo permitido es " + info_fa_param.NumeroDeItemFact, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                else
                {
                    if (cont_he == 0)
                    {
                        MessageBox.Show("Los registros seleccionados no contienen horas extras pendientes de facturar " + info_fa_param.NumeroDeItemFact, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (cont_he > info_fa_param.NumeroDeItemFact)
                    {
                        MessageBox.Show("Los registros seleccionados crearán " + (cont_he) + " líneas en la factura y el máximo permitido es " + info_fa_param.NumeroDeItemFact, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void limpiar()
        {
            try
            {
                cmb_centro_costo.EditValue = null;
                ucCon_Periodo1.Inicializar_Combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_unidades_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                fa_registro_unidades_x_equipo_det_ini_x_Af_Info row = (fa_registro_unidades_x_equipo_det_ini_x_Af_Info)gridView_unidades.GetRow(e.RowHandle);

                if (row == null) return;

                if (row.cantidad_unidades_extra > 0 && row.cantidad_unidades_normales > 0)
                {
                    if (row.IdCbteVta_he != null && row.IdCbteVta_hn != null)
                    {
                        e.Appearance.ForeColor = Color.Blue;
                    }
                    else
                        if ((row.IdCbteVta_he != null && row.IdCbteVta_hn == null) || (row.IdCbteVta_he == null && row.IdCbteVta_hn != null))
                        {
                            e.Appearance.ForeColor = Color.Orange;
                        }
                }
                else
                {
                    if (row.IdCbteVta_hn != null)
                    {
                        e.Appearance.ForeColor = Color.Blue;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_unidades_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                fa_registro_unidades_x_equipo_det_ini_x_Af_Info row = (fa_registro_unidades_x_equipo_det_ini_x_Af_Info)gridView_unidades.GetRow(e.FocusedRowHandle);
                if (row == null)
                {
                    gridView_unidades.OptionsBehavior.ReadOnly = false;
                    return;
                }
                if (cmb_tipo_horas.EditValue == null)
                {
                    gridView_unidades.OptionsBehavior.ReadOnly = false;
                    return;
                }
                eTipo_horas = (Cl_Enumeradores.eTipo_horas_facturar)Enum.Parse(typeof(Cl_Enumeradores.eTipo_horas_facturar), lst_etipo_horas.FirstOrDefault(q => q.Key == Convert.ToInt32(cmb_tipo_horas.EditValue)).Value);
                if (eTipo_horas == Cl_Enumeradores.eTipo_horas_facturar.HORAS_NORMALES)
                {
                    if (row.cantidad_unidades_normales > 0 && row.IdCbteVta_hn == null)
                    {
                        gridView_unidades.OptionsBehavior.ReadOnly = false;
                        return;
                    }
                    else
                    {
                        gridView_unidades.OptionsBehavior.ReadOnly = true;
                        return;
                    }
                }
                else
                {
                    if (row.cantidad_unidades_extra > 0 && row.IdCbteVta_he == null)
                    {
                        gridView_unidades.OptionsBehavior.ReadOnly = false;
                        return;
                    }
                    else
                    {
                        gridView_unidades.OptionsBehavior.ReadOnly = true;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool facturar()
        {
            try
            {
                if (!validar()) return false;
                
                fa_factura_Info info_factura = get_info_factura();
                frmFa_liquidacion_x_punto_cargo_factura_confirmacion frm_con = new frmFa_liquidacion_x_punto_cargo_factura_confirmacion();
                frm_con.set_info(info_factura);
                frm_con.set_info(lst_a_facturar,eTipo_horas);
                frm_con.ShowDialog();

                buscar();

                return false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private fa_factura_Info get_info_factura()
        {
            try
            {
                fa_factura_Info info_factura = new fa_factura_Info();
                info_factura.IdCbteVta = 0;
                info_factura.CodCbteVta = "";
                info_factura.Estado = "A";
                info_factura.Fecha_Transaccion = DateTime.Now;
                info_factura.Fecha_UltAnu = DateTime.Now;
                info_factura.Fecha_UltMod = DateTime.Now;
                info_factura.IdBodega = ucIn_Sucursal_Bodega1.get_IdSucursal();
                info_factura.IdSucursal = ucIn_Sucursal_Bodega1.get_IdBodega();
                info_factura.IdCliente = lst_centro_costo.FirstOrDefault(q => q.IdCentroCosto == cmb_centro_costo.EditValue.ToString()).IdCliente_cli;
                info_factura.IdEmpresa = param.IdEmpresa;
                info_factura.IdPeriodo = (de_fecha.DateTime.Date.Year * 100) + de_fecha.DateTime.Date.Month;
                info_factura.IdUsuario = param.IdUsuario;
                info_factura.IdUsuarioUltAnu = param.IdUsuario;
                info_factura.IdUsuarioUltModi = param.IdUsuario;
                info_factura.ip = param.ip;
                info_factura.nom_pc = param.nom_pc;
                info_factura.vt_fecha = de_fecha.DateTime.Date;
                info_factura.vt_flete = 0;
                info_factura.vt_interes = 0;
                info_factura.vt_OtroValor1 = 0;
                info_factura.vt_OtroValor2 = 0;
                info_factura.vt_tipo_venta = "CON";
                info_factura.vt_seguro = 0;
                info_factura.vt_anio = info_factura.vt_fecha.Year;
                info_factura.vt_mes = info_factura.vt_fecha.Month;

                info_factura.DetFactura_List = new List<fa_factura_det_info>();
                
                if(eTipo_horas == Cl_Enumeradores.eTipo_horas_facturar.HORAS_NORMALES)
                    lst_a_facturar = new List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>(blst_registro_unidades_x_af.Where(q => q.seleccionado == true && q.cantidad_unidades_normales > 0 && q.IdCbteVta_hn == null));
                else
                    lst_a_facturar = new List<fa_registro_unidades_x_equipo_det_ini_x_Af_Info>(blst_registro_unidades_x_af.Where(q => q.seleccionado == true && q.cantidad_unidades_extra > 0 && q.IdCbteVta_he == null));
                foreach (var item in lst_a_facturar)
                {
                    
                    fa_factura_det_info det_mo = new fa_factura_det_info();
                    det_mo.IdEmpresa = info_factura.IdEmpresa;
                    det_mo.IdSucursal = info_factura.IdSucursal;
                    det_mo.IdBodega = info_factura.IdBodega;
                    det_mo.IdCbteVta = 0;
                    det_mo.vt_cantidad = eTipo_horas == Cl_Enumeradores.eTipo_horas_facturar.HORAS_NORMALES ? Math.Round(item.cantidad_unidades_normales,2,MidpointRounding.AwayFromZero) : Math.Round(item.cantidad_unidades_extra,2,MidpointRounding.AwayFromZero);
                    det_mo.vt_Precio = item.valor_x_unidad;
                    det_mo.vt_PorDescUnitario = 0;
                    det_mo.vt_DescUnitario = 0;
                    det_mo.vt_PrecioFinal = item.valor_x_unidad;
                    det_mo.IdProducto = eTipo_horas == Cl_Enumeradores.eTipo_horas_facturar.HORAS_NORMALES ? item.IdProducto_normal : item.IdProducto_extra;
                    det_mo.vt_Subtotal = Math.Round(det_mo.vt_Precio * det_mo.vt_cantidad, 2, MidpointRounding.AwayFromZero);
                    det_mo.vt_iva = Math.Round(det_mo.vt_Subtotal * (item.porcentaje / 100), 2, MidpointRounding.AwayFromZero);
                    det_mo.vt_total = det_mo.vt_Subtotal + det_mo.vt_iva;
                    det_mo.vt_estado = "A";
                    det_mo.vt_por_iva = item.porcentaje;
                    det_mo.IdPunto_cargo = item.IdPunto_cargo;
                    det_mo.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    det_mo.IdCentroCosto = item.IdCentroCosto;
                    det_mo.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    det_mo.IdCod_Impuesto_Iva = item.IdCod_Impuesto;
                    det_mo.vt_detallexItems = " ";
                    info_factura.DetFactura_List.Add(det_mo);
                }

                return info_factura;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return null;
            }
        }

        private void chk_seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!chk_seleccionar_visibles.Checked)
                {
                    for (int i = 0; i < gridView_unidades.RowCount; i++)
                    {
                        gridView_unidades.SetRowCellValue(i, col_check, false);
                    }
                }
                else
                {
                    if (cmb_tipo_horas.EditValue == null)
                        return;

                    eTipo_horas = (Cl_Enumeradores.eTipo_horas_facturar)Enum.Parse(typeof(Cl_Enumeradores.eTipo_horas_facturar), lst_etipo_horas.FirstOrDefault(q => q.Key == Convert.ToInt32(cmb_tipo_horas.EditValue)).Value);

                    if (eTipo_horas == Cl_Enumeradores.eTipo_horas_facturar.HORAS_NORMALES)
                    {
                        for (int i = 0; i < gridView_unidades.RowCount; i++)
                        {
                            if (gridView_unidades.GetRowCellValue(i, col_IdCbteVta_hn) == null && Convert.ToDouble(gridView_unidades.GetRowCellValue(i, col_cantidad_unidades_normales)) > 0)
                            {
                                gridView_unidades.SetRowCellValue(i, col_check, true);
                            }
                            else
                                gridView_unidades.SetRowCellValue(i, col_check, false);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < gridView_unidades.RowCount; i++)
                        {
                            if (gridView_unidades.GetRowCellValue(i, col_IdCbteVta_he) == null && Convert.ToDouble(gridView_unidades.GetRowCellValue(i, col_cantidad_unidades_extra)) > 0)
                            {
                                gridView_unidades.SetRowCellValue(i, col_check, true);
                            }
                            else
                                gridView_unidades.SetRowCellValue(i, col_check, false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_tipo_horas_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in blst_registro_unidades_x_af)
                {
                    item.seleccionado = false;
                }
                gridControl_unidades.DataSource = null;
                gridControl_unidades.DataSource = blst_registro_unidades_x_af;
                chk_seleccionar_visibles.Checked = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}