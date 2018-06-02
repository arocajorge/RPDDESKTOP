using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Business.General_CG;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Inventario_CG;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Info.General_CG;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Inventario_CG;
using Core.Erp.Reportes.Inventario;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Inventario;
using Cus.Erp.Reports.FJ.Inventario;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario_CG
{
    public partial class FrmIn_Egresos_varios_CG_Mant : Form
    {

        #region Declaración de Variables
        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus Bus_Producto;
        in_movi_inven_tipo_Bus Bus_InMovTipo;
        in_UnidadMedida_Bus Bus_Uni_Med;
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        in_Ing_Egr_Inven_det_Bus bus_IngEgrDet;
        in_Ing_Egr_Inven_Bus bus_IngEgr;
        ct_Centro_costo_Bus bus_centro_costo;
        in_movi_inve_x_ct_cbteCble_Bus bus_InMovxCble;
        in_movi_inve_Bus bus_MovInv;


        string MensajeError = "";
        //Listas
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        List<in_movi_inven_tipo_Info> listInMovTip = new List<in_movi_inven_tipo_Info>();

        List<ct_Centro_costo_Info> list_centro_costo = new List<ct_Centro_costo_Info>();
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro_combo = new List<ct_centro_costo_sub_centro_costo_Info>();


        //Infos
        in_movi_inve_x_ct_cbteCble_Info info_InMovxCble;
        in_movi_inve_Info infoMovInv;

        ct_centro_costo_sub_centro_costo_Info info_subcentro = new ct_centro_costo_sub_centro_costo_Info();
        in_Producto_Info Info_validar_cantidades = new in_Producto_Info();

        //Variables PRINCIPALES DE LA PANTALLA
        in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info();
        BindingList<in_Ing_Egr_Inven_det_Info> List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>();
        in_Ing_Egr_Inven_det_Info InfoDet = new in_Ing_Egr_Inven_det_Info();


        public delegate void delegate_FrmIn_Egreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Egreso_varios_Mant_FormClosing event_FrmIn_Egreso_varios_Mant_FormClosing;

        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();

        Cl_Enumeradores.eTipo_action Accion;
        int IdEmpresa_inv = 0;
        int IdSucursal_inv = 0;
        int IdBodega_inv = 0;
        int IdMovi_inven_tipo_inv = 0;
        decimal IdNumMovi_inv = 0;
        int RowHandle = 0;
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        List<ct_punto_cargo_Info> list_punto_cargo = new List<ct_punto_cargo_Info>();

        ct_punto_cargo_grupo_Info info_grupo_punto_cargo = new ct_punto_cargo_grupo_Info();
        List<ct_punto_cargo_grupo_Info> list_grupo_punto_cargo = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo_punto_cargo = new ct_punto_cargo_grupo_Bus();

        List<in_Motivo_Inven_Info> list_MotivoInv = new List<in_Motivo_Inven_Info>();
        in_Motivo_Inven_Info info_MotivoInv = new in_Motivo_Inven_Info();
        in_Motivo_Inven_Bus bus_MotivoInv = new in_Motivo_Inven_Bus();

        in_Parametro_Info info_parametros = new in_Parametro_Info();
        in_Parametro_Bus bus_parametros = new in_Parametro_Bus();

        in_Producto_Info Item = new in_Producto_Info();

        List<in_UnidadMedida_Info> lst_unidad_medida = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Bus bus_unidad_medida = new in_UnidadMedida_Bus();
        List<in_UnidadMedida_Info> lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Info info_unidad_medida = new in_UnidadMedida_Info();

        List<in_UnidadMedida_Equiv_conversion_Info> lst_unidad_equiv = new List<in_UnidadMedida_Equiv_conversion_Info>();
        in_UnidadMedida_Equiv_conversion_Bus bus_unidad_equiv = new in_UnidadMedida_Equiv_conversion_Bus();
        in_UnidadMedida_Equiv_conversion_Info info_unidad_equiv = new in_UnidadMedida_Equiv_conversion_Info();
        List<vwtb_pacientes_para_egreso_Info> Lista_Paciente;
        vwtb_pacientes_para_egreso_Bus Bus_paciente = new vwtb_pacientes_para_egreso_Bus();
        in_Ing_Egr_Inven_CG_Bus bus_CG = new in_Ing_Egr_Inven_CG_Bus();


        #endregion

        public FrmIn_Egresos_varios_CG_Mant()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;


            event_FrmIn_Egreso_varios_Mant_FormClosing += FrmIn_Ingreso_varios_CG_Mant_event_FrmIn_Egreso_varios_Mant_FormClosing;


            ucIn_Sucursal_Bodega1.Event_cmb_bodega1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged;
            ucIn_Sucursal_Bodega1.Event_cmb_sucursal1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged;
        }

        void ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        void ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue != null)
                {
                    //ucIn_MotivoInvCmb1.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.EGR;
                    cmbTipoMovi.cargar_TipoMotivo(param.IdSucursal, Convert.ToInt32( ucIn_Sucursal_Bodega1.cmb_bodega.EditValue), "-", "N");
                    ucIn_MotivoInvCmb1.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.EGR;
                    ucIn_MotivoInvCmb1.cargar_MotivoInv();
                    CargarProducto();
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

        void FrmIn_Ingreso_varios_CG_Mant_event_FrmIn_Egreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                
                        Get();

                        string mensaje = "";
                        if (MessageBox.Show("Esta seguro que desea eliminar la transaccion ", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                        { return; }
                        Core.Erp.Winform.General.FrmGe_MotivoAnulacion ofrm = new General.FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();
                        info_IngEgr.MotivoAnulacion = ofrm.motivoAnulacion;
                        info_IngEgr.IdusuarioUltAnu = param.IdUsuario;
                        info_IngEgr.Fecha_UltAnu = param.Fecha_Transac;
                        bus_IngEgr = new in_Ing_Egr_Inven_Bus();

                        if (bus_IngEgr.AnularDB(info_IngEgr, ref mensaje))
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema);
                            lblAnulado.Visible = true;

                            //  anular movimiento inventario                  
                            infoMovInv = new in_movi_inve_Info();
                            string msgAnula = "";
                            bus_MovInv = new in_movi_inve_Bus();
                            infoMovInv = bus_MovInv.Get_Info_Movi_inven(IdEmpresa_inv, IdSucursal_inv, IdBodega_inv, IdMovi_inven_tipo_inv, IdNumMovi_inv);

                            if (bus_MovInv.AnularDB(infoMovInv, param.Fecha_Transac, ref msgAnula))
                            {
                                MessageBox.Show("Movimiento de Inventario Anulado: " + msgAnula, param.Nombre_sistema);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al anular el registro: " + mensaje, param.Nombre_sistema);
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

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
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

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {

                    case Cl_Enumeradores.eCliente_Vzen.FJ:

                        XINV_FJ_Rpt007_Rpt Reporte = new XINV_FJ_Rpt007_Rpt();
                        Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        Reporte.Parameters["IdSucursal"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                        Reporte.Parameters["IdBodega"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                        Reporte.Parameters["IdMovi_inven_tipo"].Value = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                        Reporte.Parameters["IdNumMovi"].Value = Convert.ToDecimal(txtNumIngreso.Text);
                        Reporte.RequestParameters = false;
                        DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                        pt.AutoShowParametersPanel = false;
                        Reporte.ShowPreviewDialog();


                        break;

                    default:
                        XINV_Rpt002_Rpt Reporte_ = new XINV_Rpt002_Rpt();
                        Reporte_.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                        Reporte_.Parameters["IdSucursal"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                        Reporte_.Parameters["IdBodega"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                        Reporte_.Parameters["IdMovi_inven_tipo"].Value = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                        Reporte_.Parameters["IdNumMovi"].Value = Convert.ToDecimal(txtNumIngreso.Text);
                        Reporte_.RequestParameters = false;
                        DevExpress.XtraReports.UI.ReportPrintTool pt_ = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte_);
                        pt_.AutoShowParametersPanel = false;
                        Reporte_.ShowPreviewDialog();

                        break;
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

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                    Close();
                
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

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                    LimpiarDatos();
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

        private void FrmIn_Ingreso_varios_CG_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                info_parametros = bus_parametros.Get_Info_Parametro(param.IdEmpresa);

                List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = List_Bind_IngEgrDet;

                ucIn_Sucursal_Bodega1.set_Idsucursal(param.IdSucursal);

                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }

                carga_Combos();

                set_Accion_in_controls();

                txtCodigo.Focus();

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

        private void FrmIn_Ingreso_varios_CG_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Egreso_varios_Mant_FormClosing(sender, e);
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

        private void gridViewProductos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                 InfoDet = (in_Ing_Egr_Inven_det_Info)this.gridViewProductos.GetFocusedRow();

                if (e.Column.Name == "colIdProducto")
                {
                    foreach (var item in List_Bind_IngEgrDet)
                    {
                        var itemProd = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);

                        if (item.IdProducto == InfoDet.IdProducto)
                        {
                            item.cod_producto = itemProd.pr_codigo;
                            InfoDet.mv_costo = 0;
                            InfoDet.mv_costo_sinConversion = 0;
                            InfoDet.pr_descripcion = itemProd.pr_descripcion;
                            InfoDet.IdUnidadMedida = itemProd.IdUnidadMedida_Consumo;
                            InfoDet.IdUnidadMedida_sinConversion = itemProd.IdUnidadMedida_Consumo;
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

        private void gridViewProductos_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewProductos.GetRow(e.RowHandle) as in_Ing_Egr_Inven_det_Info;
                if (data == null)
                    return;

                if (data.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    e.Appearance.ForeColor = Color.Blue;
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

        private void gridViewProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewProductos.DeleteSelectedRows();
                        txtCodigo.Focus();
                    }
                }

                // para pegar en las columnas en el mismo orden 
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();
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

      

        void carga_Combos()
        {
            try
            {
               
                Lista_Paciente = new List<vwtb_pacientes_para_egreso_Info>();
                Lista_Paciente = Bus_paciente.Get_List_Paciente(param.IdEmpresa, ref MensajeError);
                if (Lista_Paciente.Count() == 0 && MensajeError != "")
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        cmbPaciente.Properties.DataSource = Lista_Paciente.Where(a => a.IdEstado == 1 || a.IdEstado == 2).ToList();
                        cmbPaciente.Properties.DisplayMember = "pe_nombreCompleto";
                        cmbPaciente.Properties.ValueMember = "IdCuenta";
                    }
                    else
                    {
                        cmbPaciente.Properties.DataSource = Lista_Paciente;
                        cmbPaciente.Properties.DisplayMember = "pe_nombreCompleto";
                        cmbPaciente.Properties.ValueMember = "IdCuenta";
                    }
                }

                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmbUnidad_medida.DataSource = lst_unidad_medida;
                cmbUnidad_medida.DisplayMember = "Descripcion";
                cmbUnidad_medida.ValueMember = "IdUnidadMedida";

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

        void CargarProducto()
         {
            try
            {
                Bus_Producto = new in_producto_Bus();
                listProducto = new List<in_Producto_Info>();
                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue != null && ucIn_Sucursal_Bodega1.cmb_bodega.EditValue != null)
                {
                    listProducto = Bus_Producto.Get_list_Producto_modulo_x_inventario(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue));
                }
                cmbProducto_grid.DataSource = listProducto;
                cmbProducto_grid.DisplayMember = "pr_descripcion";
                cmbProducto_grid.ValueMember = "IdProducto";
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

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
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

        private void set_Accion_in_controls()
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.CG:
                        break;                    
                    default:
                        break;
                }
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        this.txtNumIngreso.ReadOnly = true;
                        
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        setInfo_in_controls();

                        foreach (var item in List_Bind_IngEgrDet)
                        {
                            Info_validar_cantidades = listProducto.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdProducto == item.IdProducto);

                            if (Info_validar_cantidades != null)
                            {
                                listProducto.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdProducto == item.IdProducto).pr_Pedidos_inv = Info_validar_cantidades.pr_Pedidos_inv - (Math.Abs(item.dm_cantidad) * -1);
                            }
                        }

                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        Inhabilita_Controles();
                        dtpFecha.Enabled = true;
                        txtObservacion.Enabled = true;
                        

                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        setInfo_in_controls();
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        Inhabilita_Controles();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        setInfo_in_controls();
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        Inhabilita_Controles();
                        break;

                    default:
                        break;
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

        void Inhabilita_Controles()
        {
            try
            {
                txtNumIngreso.ReadOnly = true;

                dtpFecha.Enabled = false;

                cmbTipoMovi.Enabled = false;

                txtObservacion.ReadOnly = true;

                ucIn_Sucursal_Bodega1.cmb_sucursal.Enabled = false;
                ucIn_Sucursal_Bodega1.cmb_bodega.Enabled = false;
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

        private void LimpiarDatos()
        {
            try
            {
                carga_Combos();
                set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                txtNumIngreso.Text = "";
                txtCodigo.Text = "";
                txtObservacion.Text = "";
                dtpFecha.Value = DateTime.Now;
                info_IngEgr = new in_Ing_Egr_Inven_Info();
                info_IngEgr.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = List_Bind_IngEgrDet;
                cmbPaciente.EditValue = null;
                ucIn_Sucursal_Bodega1.InicializarBodega();
                ucIn_MotivoInvCmb1.Inicializar_cmbMotivoInv();
                cmbTipoMovi.Inicializar_Catalogos();

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

        void Get()
        {
            try
            {
                info_IngEgr = new in_Ing_Egr_Inven_Info();
                info_IngEgr.IdEmpresa = param.IdEmpresa;
                info_IngEgr.IdNumMovi = Convert.ToDecimal((txtNumIngreso.Text == "") ? "0" : txtNumIngreso.Text);
                info_IngEgr.IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                info_IngEgr.IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                info_IngEgr.CodMoviInven = txtCodigo.Text;
                //info_IngEgr.cm_observacion = Lista_Paciente
                info_IngEgr.IdMovi_inven_tipo = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info_IngEgr.cm_fecha = dtpFecha.Value;
                info_IngEgr.IdUsuario = param.IdUsuario;
                info_IngEgr.nom_pc = param.nom_pc;
                info_IngEgr.ip = param.ip;
                info_IngEgr.Fecha_Transac = param.Fecha_Transac;
                info_IngEgr.signo = "-";
                info_IngEgr.IdMotivo_Inv = ucIn_MotivoInvCmb1.get_MotivoInvInfo().IdMotivo_Inv;
              

                info_IngEgr.listIng_Egr = GetDetalle();
                foreach (var item in info_IngEgr.listIng_Egr)
                {
                    item.IdEmpresa = info_IngEgr.IdEmpresa;
                    item.IdNumMovi = info_IngEgr.IdNumMovi;
                    item.IdSucursal = info_IngEgr.IdSucursal;
                    item.IdBodega = info_IngEgr.IdBodega;
                }

                info_IngEgr.Info_Inven_CG.IdEmpresa = param.IdEmpresa;
                info_IngEgr.Info_Inven_CG.IdSucursal = info_IngEgr.IdSucursal;
                info_IngEgr.Info_Inven_CG.IdNumMovi = info_IngEgr.IdNumMovi;
                info_IngEgr.Info_Inven_CG.IdMovi_inven_tipo = info_IngEgr.IdMovi_inven_tipo;
                vwtb_pacientes_para_egreso_Info pacientes_info = new vwtb_pacientes_para_egreso_Info();
                
                pacientes_info = Lista_Paciente.FirstOrDefault(a => a.IdCuenta == Convert.ToDecimal(cmbPaciente.EditValue));
                if (pacientes_info != null)
                {
                    info_IngEgr.Info_Inven_CG.IdIngreso = pacientes_info.IdIngreso;
                    info_IngEgr.Info_Inven_CG.IdCuenta = pacientes_info.IdCuenta;
                    info_IngEgr.Info_Inven_CG.IdUsuarioCreacion = param.IdUsuario;
                    info_IngEgr.cm_observacion = "[" + pacientes_info.IdCuenta + "] " + pacientes_info.pe_nombreCompleto + " - " + pacientes_info.nom_plan + " - " + pacientes_info.Fecha_ingreso;
                    info_IngEgr.Info_Inven_CG.ip = param.ip;
                    info_IngEgr.Info_Inven_CG.nom_pc = param.nom_pc;
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

        List<in_Ing_Egr_Inven_det_Info> GetDetalle()
        {
            try
            {
                return new List<in_Ing_Egr_Inven_det_Info>(List_Bind_IngEgrDet);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<in_Ing_Egr_Inven_det_Info>();
            }
        }

        public void setInfo_(in_Ing_Egr_Inven_Info info_IngEgr_)
        {
            info_IngEgr = info_IngEgr_;
        }

        private void setInfo_in_controls()
        {
            try
            {
                if (info_IngEgr == null)
                { return; }

                txtNumIngreso.Text = Convert.ToString(info_IngEgr.IdNumMovi);
                ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = info_IngEgr.IdSucursal;
                ucIn_Sucursal_Bodega1.cmb_bodega.EditValue = info_IngEgr.IdBodega;
                dtpFecha.Value = info_IngEgr.cm_fecha;
                cmbTipoMovi.set_TipoMoviInvInfo(info_IngEgr.IdMovi_inven_tipo);
                txtObservacion.Text = info_IngEgr.cm_observacion;
              
                
                lblAnulado.Visible = info_IngEgr.Estado == "I" ? true : false;

               
                in_Ing_Egr_Inven_CG_Info Inv_CG_Info = new in_Ing_Egr_Inven_CG_Info();
                Inv_CG_Info.IdCuenta = bus_CG.Get_Info(param.IdEmpresa, info_IngEgr.IdNumMovi).IdCuenta;
                if (Inv_CG_Info.IdCuenta != 0)
                    cmbPaciente.EditValue = Inv_CG_Info.IdCuenta;
                bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();
                List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>(bus_IngEgrDet.Get_List_Ing_Egr_Inven_det(param.IdEmpresa, info_IngEgr.IdSucursal, info_IngEgr.IdMovi_inven_tipo, info_IngEgr.IdNumMovi));
                foreach (var item in List_Bind_IngEgrDet)
                {
                    item.dm_cantidad = item.dm_cantidad < 0 ? item.dm_cantidad * -1 : item.dm_cantidad;
                    item.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion < 0 ? item.dm_cantidad_sinConversion * -1 : item.dm_cantidad_sinConversion;
                }
                ucIn_MotivoInvCmb1.set_MotivoInvInfo((int)info_IngEgr.IdMotivo_Inv);

                gridControlProductos.DataSource = List_Bind_IngEgrDet;
              
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

        public Boolean grabar()
        {
            try
            {
                txtNumIngreso.Focus();
                if (!ValidarDatos())
                    return false;

                Get();
                string mensaje = "";

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        decimal IdNumMovi = 0;
                        bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                        if (bus_IngEgr.GuardarDB(info_IngEgr, ref   IdNumMovi, ref mensaje))
                        {
                            txtNumIngreso.Text = Convert.ToString(IdNumMovi);
                            if (info_IngEgr.Info_Inven_CG.IdNumMovi == 0)
                                info_IngEgr.Info_Inven_CG.IdNumMovi = IdNumMovi;

                           bool  res = bus_CG.GrabarDB(info_IngEgr.Info_Inven_CG, ref  mensaje);
                           if (res)
                           {
                               string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro del egreso a Bodega ", IdNumMovi.ToString());
                               MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                               //MessageBox.Show("Se ha procedido a grabar el registro del Ingreso a Bodega #: " + IdNumMovi.ToString() + " exitosamente.", "Operación Exitosa");

                               // consulta grid contable                      
                               var item = info_IngEgr.listIng_Egr.FirstOrDefault();
                               ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));

                               if (MessageBox.Show("Desea Imprimir el Egreso", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                               {
                                   ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(null, null);
                               }

                               LimpiarDatos();
                           }
                        }
                        else
                        {
                            MessageBox.Show("Error al grabar el Ingreso a Bodega, " + mensaje, param.Nombre_sistema);
                            return false;
                        }

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        info_IngEgr.IdUsuarioUltModi = param.IdUsuario;
                        info_IngEgr.Fecha_UltMod = param.Fecha_Transac;
                        bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                        if (bus_IngEgr.ModificarDB(info_IngEgr, ref mensaje))
                        {
                            bool res = bus_CG.ActualizarDB(info_IngEgr.Info_Inven_CG);
                            if (res)
                            {
                                MessageBox.Show(mensaje, param.Nombre_sistema);
                                LimpiarDatos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el registro: " + mensaje, param.Nombre_sistema);
                            return false;
                        }

                        break;
                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void anular()
        {
            try
            {
                if (info_IngEgr != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (info_IngEgr.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el egreso N#: " + info_IngEgr.IdNumMovi + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();

                            info_IngEgr.cm_observacion = "***ANULADO****" + info_IngEgr.cm_observacion;
                            info_IngEgr.MotivoAnulacion = oFrm.motivoAnulacion;

                            info_IngEgr.Fecha_Transac = param.Fecha_Transac;
                            info_IngEgr.IdusuarioUltAnu = param.IdUsuario;

                            info_IngEgr.cm_observacion = "***ANULADO****" + info_IngEgr.cm_observacion;
                            bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                            if (bus_IngEgr.AnularDB(info_IngEgr, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro ", info_IngEgr.IdNumMovi.ToString());
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //MessageBox.Show("Anulación con éxito # " + info_IngEgr.IdNumMovi);
                                info_IngEgr.Estado = "I";

                                lblAnulado.Visible = true;

                                //  anular movimiento inventario                  
                                infoMovInv = new in_movi_inve_Info();
                                string msgAnula = "";

                                ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                                //consulta detalle
                                var item = List_Bind_IngEgrDet.FirstOrDefault();

                                bus_MovInv = new in_movi_inve_Bus();
                                infoMovInv = bus_MovInv.Get_Info_Movi_inven(Convert.ToInt32(item.IdEmpresa_inv), Convert.ToInt32(item.IdSucursal_inv), Convert.ToInt32(item.IdBodega_inv), Convert.ToInt32(item.IdMovi_inven_tipo_inv), Convert.ToDecimal(item.IdNumMovi_inv));

                                if (bus_MovInv.AnularDB(infoMovInv, param.Fecha_Transac, ref msgAnula))
                                {
                                    MessageBox.Show("Movimiento de Inventario Anulado: " + msgAnula, param.Nombre_sistema);
                                }

                                Accion = Cl_Enumeradores.eTipo_action.consultar;
                            }
                        }
                    }
                    else if (info_IngEgr.Estado == "I")
                    {
                        MessageBox.Show("No se puede anular la devolución de Compra N#: " + info_IngEgr.IdNumMovi +
                             ", ya se encuentra anulada", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Pegar_Data()
        {
            try
            {
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    if (!Agregar_fila_copiada(row))
                        break;

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

        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }

        private Boolean Agregar_fila_copiada(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });


                //posicion de la ata pegada
                //codigo produc | unidad medida |cant |costo|observacion|

                in_Ing_Egr_Inven_det_Info newRow = new in_Ing_Egr_Inven_det_Info();
                if (rowData.Count() >= 3) //return false;          
                {

                    string cod_producto = rowData[0];
                    in_Producto_Info Info_Producto;
                    var QProducto = listProducto.FirstOrDefault(v => v.pr_codigo == cod_producto);
                    if (QProducto != null)
                    { Info_Producto = listProducto.FirstOrDefault(v => v.pr_codigo == cod_producto); }
                    else { MessageBox.Show("el codigo de este producto:" + cod_producto + " no esta en la base"); return false; }



                    string IdUnidadMedida = Convert.ToString(rowData[2]) == "" ? Info_Producto.IdUnidadMedida_Consumo : Convert.ToString(rowData[2]);
                    double cantidad = Convert.ToDouble(rowData[3]);
                    double costo_unitario = Convert.ToDouble(rowData[4]);
                    string observacion = Convert.ToString(rowData[1]);


                    in_Ing_Egr_Inven_det_Info emp = new in_Ing_Egr_Inven_det_Info();
                    if (!string.IsNullOrWhiteSpace(cod_producto))
                    {

                        newRow.IdProducto = Info_Producto.IdProducto;
                        newRow.cod_producto = cod_producto;
                        newRow.dm_cantidad = cantidad;
                        newRow.dm_cantidad_sinConversion = cantidad;
                        newRow.IdUnidadMedida = IdUnidadMedida;
                        newRow.IdUnidadMedida_sinConversion = IdUnidadMedida;
                        newRow.mv_costo = costo_unitario;
                        newRow.mv_costo_sinConversion = costo_unitario;
                        newRow.dm_observacion = observacion;
                        newRow.nom_UnidadMedida = Info_Producto.nom_UnidadMedida;


                    }
                    else
                    {
                        MessageBox.Show("Ya se encuentra registrado el codigo del producto # :" + cod_producto);
                        return false;
                    }

                    List_Bind_IngEgrDet.Add(newRow);
                    return true;
                }
                else
                {
                    MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + "El formato debe ser el siguiente\n" + "|codigo Producto|nombre producto|unidad med.|cantidad|costo|observacion det|centros cos|", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
              
        Boolean ValidarDatos()
        {
            try
            {

                txtObservacion.Focus();
                if (ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue == null || ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue == "")
                {
                    MessageBox.Show("Seleccione la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue == null || ucIn_Sucursal_Bodega1.cmb_bodega.EditValue == "")
                {
                    MessageBox.Show("Seleccione la Bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbTipoMovi.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_MotivoInvCmb1.get_MotivoInvInfo() == null)
                {
                    MessageBox.Show("Seleccione el motivo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }               

                if (dtpFecha.Value == null)
                {
                    MessageBox.Show("Ingrese la Fecha de la Transacción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (List_Bind_IngEgrDet.Count() <= 0)
                {
                    MessageBox.Show("Ingrese al menos un Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                if (cmbPaciente.EditValue == "")
                {
                    MessageBox.Show("Por favor, seleccione el paciente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbPaciente.Focus();
                    return false;
                }
                //foreach (var item in List_Bind_IngEgrDet)
                //{
                  
                    
                                    
                //}


                if (info_parametros != null)
                {
                    if (info_parametros.Maneja_Stock_Negativo.Trim() == "N")
                    {
                        string Producto_no_contabilizado = "";
                        List<decimal> revisados = new List<decimal>();
                        int res = 0;
                        foreach (var item in List_Bind_IngEgrDet)
                        {

                           
                            res = revisados.Where(q => q == item.IdProducto).Count();
                            if (res == 0)
                            {
                                double cantidad_pedida = Math.Round(List_Bind_IngEgrDet.Where(q => q.IdProducto == item.IdProducto).Sum(q => q.dm_cantidad), 2, MidpointRounding.AwayFromZero);
                                in_Producto_Info producto = listProducto.FirstOrDefault(q => q.IdProducto == item.IdProducto && q.IdEmpresa == param.IdEmpresa && q.IdSucursal == ucIn_Sucursal_Bodega1.get_sucursal().IdSucursal && q.IdBodega == ucIn_Sucursal_Bodega1.get_bodega().IdBodega);
                                double cantidad_disponible = Convert.ToDouble(producto.pr_stock) - Math.Abs(Convert.ToDouble(producto.pr_Pedidos_inv));

                                if (cantidad_disponible < cantidad_pedida)
                                {
                                    MessageBox.Show("Producto: " + producto.pr_descripcion_2 + "\nStock actual en bodega: " + producto.pr_stock.ToString() + " " + producto.nom_UnidadMedida_Consumo + "\nCantidad pedida no aprobada :" + Math.Abs(Convert.ToDouble(producto.pr_Pedidos_inv)) + " " + producto.nom_UnidadMedida_Consumo + " \nCantidad pedida en este egreso: " + cantidad_pedida.ToString() + " " + producto.nom_UnidadMedida_Consumo + " \nCorrija las cantidades.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                                bool se_valida_paramatrizacion_contable_x_producto = info_parametros.P_se_valida_parametrizacion_x_producto == null ? false : (bool)info_parametros.P_se_valida_parametrizacion_x_producto;
                                if (se_valida_paramatrizacion_contable_x_producto)
                                {
                                    if (producto.IdCtaCble_Inventario == null || producto.IdCtaCble_Costo == null)
                                    {
                                        if (Producto_no_contabilizado == "") Producto_no_contabilizado = producto.pr_descripcion_2;
                                        else Producto_no_contabilizado += "\n" + producto.pr_descripcion_2;
                                    }
                                }
                                revisados.Add(item.IdProducto);
                            }
                        }
                        if (Producto_no_contabilizado != "")
                        {
                            MessageBox.Show("Los siguientes productos no estan parametrizados contablemente, por favor corrija:\n" + Producto_no_contabilizado, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtpFecha.Value)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }  

        private void btn_buscar_diarios_Click(object sender, EventArgs e)
        {
            try
            {
                // consulta grid contable             
                var item = List_Bind_IngEgrDet.FirstOrDefault();
                if (item != null)
                    ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));
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

        private void lblPlantilla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string filePath = null;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_inventario);
                    MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    InfoDet = new in_Ing_Egr_Inven_det_Info();
                    if (!string.IsNullOrEmpty(txtCodigo.Text.Trim()))
                    {
                        in_Producto_Info i_producto = new in_Producto_Info();
                        i_producto = listProducto.FirstOrDefault(a => a.pr_codigo_barra == txtCodigo.Text.Trim());
                        if (i_producto == null)
                        {
                            switch (MessageBox.Show("El código no se encuentra registrado \n¿Desea crear el producto[SI] o asignar el código de barras a un producto exitente[NO]?", param.Nombre_sistema, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                            {/*
                                case DialogResult.Cancel:
                                    txtCodigo.Text = string.Empty;
                                    return;
                                    break;
                                case DialogResult.No:
                                    Inventario_CG.FrmIn_Producto_Cons frmc = new FrmIn_Producto_Cons();
                                    if (txtCodigo.Text != null)
                                        frmc.codigo_barra = txtCodigo.Text;
                                    frmc.MdiParent = this.MdiParent;
                                    frmc.llamado_externamente = true;
                                    frmc.event_FrmIn_Producto_Cons_FormClosing += frmc_event_FrmIn_Producto_Cons_FormClosing;
                                    frmc.Show();
                                    txtCodigo.Text = string.Empty;
                                    //LLAMAR PANTALLA DE CONSULTA PARA ASIGNAR CODIGO DE BARRA A PRODUCTO
                                    break;
                                case DialogResult.Yes:
                                    Inventario_CG.FrmIn_Producto_Mant frm = new FrmIn_Producto_Mant();
                                    frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                                    frm.event_FrmIn_Producto_Mant_FormClosing += frm_event_FrmIn_Producto_Mant_FormClosing;
                                    frm.MdiParent = this.MdiParent;
                                    if(txtCodigo.Text != null)
                                    frm.codigo_barra = txtCodigo.Text;
                                    frm.Show();
                                    txtCodigo.Text = string.Empty;
                                    break;
                                default:
                                    txtCodigo.Text = string.Empty;
                                    return;
                                    break;
                              * */
                            }
                        }
                        else
                        {
                            InfoDet.IdProducto = i_producto.IdProducto;
                            InfoDet.dm_cantidad_sinConversion = 1;

                            if (InfoDet.IdProducto != 0)
                            {
                                if (List_Bind_IngEgrDet.Count() != 0)
                                {
                                    foreach (var item in List_Bind_IngEgrDet)
                                    {
                                        if (item.IdProducto == InfoDet.IdProducto)
                                        {
                                            item.dm_cantidad_sinConversion++;
                                            txtCodigo.Text = string.Empty;
                                            gridControlProductos.RefreshDataSource();
                                            return;
                                        }
                                    }

                                    List_Bind_IngEgrDet.Add(InfoDet);
                                }
                                else
                                {
                                    List_Bind_IngEgrDet.Add(InfoDet);
                                    gridControlProductos.DataSource = List_Bind_IngEgrDet;
                                    txtCodigo.Text = string.Empty;
                                    gridControlProductos.RefreshDataSource();
                                }
                            }

                            gridControlProductos.DataSource = List_Bind_IngEgrDet;
                            txtCodigo.Text = string.Empty;
                            gridControlProductos.RefreshDataSource();
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

        void frmc_event_FrmIn_Producto_Cons_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            CargarProducto();
        }

        void frm_event_FrmIn_Producto_Mant_FormClosing(object sender, FormClosingEventArgs e, in_Producto_Info info)
        {
            CargarProducto();
        }

        private void cmbPaciente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Focus();
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

        private void searchLookUpEdit1View_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = searchLookUpEdit1View.GetRow(e.RowHandle) as vwtb_pacientes_para_egreso_Info;
                if (data == null)
                    return;
                if (data.nom_estado == "INACTIVA")
                    e.Appearance.ForeColor = Color.Red;
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
