using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cus.Erp.Reports.FJ.Facturacion;
using System.IO;

namespace Core.Erp.Winform.Facturacion_Fj
{
    public partial class frmFa_liquidacion_x_punto_cargo_cons : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<fa_liquidacion_x_punto_cargo_Info> blst_liquidacion = new BindingList<fa_liquidacion_x_punto_cargo_Info>();
        fa_liquidacion_x_punto_cargo_Info info_liquidacion = new fa_liquidacion_x_punto_cargo_Info();
        fa_liquidacion_x_punto_cargo_Bus bus_liquidacion = new fa_liquidacion_x_punto_cargo_Bus();
        fa_parametro_info info_param = new fa_parametro_info();
        fa_parametro_Bus bus_param = new fa_parametro_Bus();
        static string result = Path.GetTempPath();
        String RootReporte = result + @"Factura.repx";
        #endregion

        public frmFa_liquidacion_x_punto_cargo_cons()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_liquidacion = (fa_liquidacion_x_punto_cargo_Info)gridView_liquidacion.GetFocusedRow();

                if (info_liquidacion == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (!info_liquidacion.estado)
                {
                    MessageBox.Show("El registro seleccionado se encuentra anulado",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(Cl_Enumeradores.eTipo_action.Anular);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_liquidacion = (fa_liquidacion_x_punto_cargo_Info)gridView_liquidacion.GetFocusedRow();

                if (info_liquidacion == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                llamar_formulario(Cl_Enumeradores.eTipo_action.consultar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void load_data()
        {
            try
            {
                blst_liquidacion = new BindingList<fa_liquidacion_x_punto_cargo_Info>(bus_liquidacion.get_list(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario1.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta));
                gridControl_liquidacion.DataSource = blst_liquidacion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmFa_liquidacion_x_punto_cargo_cons_Load(object sender, EventArgs e)
        {
            try
            {
                ucGe_Menu_Mantenimiento_x_usuario1.btn_Habilitar_Reg.Caption = "Facturar";
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void llamar_formulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                frmFa_liquidacion_x_punto_cargo_mant frm = new frmFa_liquidacion_x_punto_cargo_mant();
                frm.set_accion(Accion);
                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    info_liquidacion = (fa_liquidacion_x_punto_cargo_Info)gridView_liquidacion.GetFocusedRow();
                    frm.set_info(info_liquidacion);
                }
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed += frm_event_delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_event_delegate_frmFa_liquidacion_x_punto_cargo_mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamar_formulario(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                info_liquidacion = (fa_liquidacion_x_punto_cargo_Info)gridView_liquidacion.GetFocusedRow();

                if (info_liquidacion == null)
                {
                    MessageBox.Show("Seleccione un registro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!info_liquidacion.estado)
                {
                    MessageBox.Show("El registro seleccionado se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                llamar_formulario(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_liquidacion_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_Info row = (fa_liquidacion_x_punto_cargo_Info)gridView_liquidacion.GetRow(e.RowHandle);
                if (row == null) return;
                if (!row.estado)
                {
                    e.Appearance.ForeColor = Color.Red;
                    return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btn_Habilitar_Reg_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ucGe_Menu_Mantenimiento_x_usuario1.Focus();
                info_param = bus_param.Get_Info_parametro(param.IdEmpresa);

                List<fa_liquidacion_x_punto_cargo_Info> lst_liquidaciones = blst_liquidacion.Where(q => q.facturar == true).ToList();

                if (lst_liquidaciones.Count == 0)
                {
                    MessageBox.Show("Seleccione las liquidaciones a facturar",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                if (lst_liquidaciones.Sum(q=>q.numero_lineas) > info_param.NumeroDeItemFact)
                {
                    MessageBox.Show("No se puede generar una factura superior a " + info_param.NumeroDeItemFact + " lineas, por favor corrija", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                int cont = lst_liquidaciones.GroupBy(q => q.IdSucursal).Count();
                if (cont > 1)
                {
                    MessageBox.Show("Todas las liquidaciones seleccionadas deben pertenecer a la misma sucursal, por favor corrija", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                cont = lst_liquidaciones.GroupBy(q => q.IdCentroCosto).Count();
                if (cont > 1)
                {
                    MessageBox.Show("Todas las liquidaciones seleccionadas deben tener el mismo centro de costo, por favor corrija",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                fa_factura_Info info_factura = bus_liquidacion.get_info_factura_x_liquidacion(lst_liquidaciones);
                frmFa_liquidacion_x_punto_cargo_factura_confirmacion frm_con = new frmFa_liquidacion_x_punto_cargo_factura_confirmacion();
                frm_con.event_delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed += frm_con_event_delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed;
                frm_con.set_info(info_factura);
                frm_con.set_info(lst_liquidaciones);
                
                frm_con.ShowDialog();                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frm_con_event_delegate_frmFa_liquidacion_x_punto_cargo_factura_confirmacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                load_data();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControl_liquidacion.ShowPrintPreview();
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

        private void imprimir_reporte()
        {
            try
            {
                XFAC_FJ_Rpt014_Rpt rptSoporte = new XFAC_FJ_Rpt014_Rpt();
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus busDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus();
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Info InfoDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Info();

                InfoDoc_x_Emp = busDoc_x_Emp.get_DisenioRpt(param.IdEmpresa, Cl_Enumeradores.eTipoDocumento_Talonario.FACT.ToString());
                if (InfoDoc_x_Emp.File_Disenio_Reporte != null)
                {
                    File.WriteAllBytes(RootReporte, InfoDoc_x_Emp.File_Disenio_Reporte);
                    rptSoporte.LoadLayout(RootReporte);
                }

                XFAC_FJ_Rpt014_Bus busRpt = new XFAC_FJ_Rpt014_Bus();
                List<XFAC_FJ_Rpt014_Info> lstRpt = new List<XFAC_FJ_Rpt014_Info>();
                rptSoporte.RequestParameters = false;
                /*
                rptSoporte.P_IdSucursal.Value = info_factura.IdSucursal;
                rptSoporte.P_IdSucursal.Visible = false;

                rptSoporte.P_IdBodega.Value = info_factura.IdBodega;
                rptSoporte.P_IdBodega.Visible = false;

                rptSoporte.P_IdCbteVta.Value = info_factura.IdCbteVta;
                rptSoporte.P_IdCbteVta.Visible = false;

                rptSoporte.P_Numero_lineas.Value = Info_Param_fact.NumeroDeItemFact;
                rptSoporte.P_Numero_lineas.Visible = false;
                */
                rptSoporte.CreateDocument();
                rptSoporte.ShowPreviewDialog();
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

        private void cmb_imagen_Click(object sender, EventArgs e)
        {
            try
            {
                fa_liquidacion_x_punto_cargo_Info row = (fa_liquidacion_x_punto_cargo_Info)gridView_liquidacion.GetFocusedRow();
                if (row != null)
                {
                    frmFa_liquidacion_x_punto_cargo_x_factura frm = new frmFa_liquidacion_x_punto_cargo_x_factura();
                    frm.set_info(row);
                    frm.ShowDialog();
                    load_data();
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
    }
}
