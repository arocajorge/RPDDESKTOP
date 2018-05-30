using Core.Erp.Business.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Aprobacion_Ing_varios_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param;
        BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info> blst_det;
        cp_Aprobacion_Ing_Bod_x_OC_Info info_aprobacion;
        List<cp_TipoDocumento_Info> LstTipDoc;
        List<in_Producto_Info> lst_producto;
        in_producto_Bus bus_producto;
        Cl_Enumeradores.eTipo_action Accion;
        List<tb_sis_impuesto_Info> lst_impuesto;
        tb_sis_impuesto_Bus bus_impuesto;
        in_Parametro_Info info_in_param;
        in_Parametro_Bus bus_in_param;
        cp_Aprobacion_Ing_Bod_x_OC_det_Bus bus_aprobacion_det;
        cp_Aprobacion_Ing_Bod_x_OC_Bus bus_aprobacion;
        cp_parametros_Info info_cp_param;
        cp_parametros_Bus bus_cp_param;
        List<in_UnidadMedida_Info> lst_unidad_medida;
        in_UnidadMedida_Bus bus_unidad_medida;
        #endregion

        public frmCP_Aprobacion_Ing_varios_Mant()
        {
            InitializeComponent();
            event_delegate_frmCP_Aprobacion_Ing_varios_Mant_FormClosed += frmCP_Aprobacion_Ing_varios_Mant_event_delegate_frmCP_Aprobacion_Ing_varios_Mant_FormClosed;
            Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            blst_det = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>();
            info_aprobacion = new cp_Aprobacion_Ing_Bod_x_OC_Info();
            LstTipDoc = new List<cp_TipoDocumento_Info>();
            lst_producto = new List<in_Producto_Info>();
            bus_producto = new in_producto_Bus();
            lst_impuesto = new List<tb_sis_impuesto_Info>();
            bus_impuesto = new tb_sis_impuesto_Bus();
            info_in_param = new in_Parametro_Info();
            bus_in_param = new in_Parametro_Bus();
            bus_aprobacion_det = new cp_Aprobacion_Ing_Bod_x_OC_det_Bus();
            bus_aprobacion = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
            info_cp_param = new cp_parametros_Info();
            bus_cp_param = new cp_parametros_Bus();
            lst_unidad_medida = new List<in_UnidadMedida_Info>();
            bus_unidad_medida = new in_UnidadMedida_Bus();
        }

        #region Delegados
        public delegate void delegate_frmCP_Aprobacion_Ing_varios_Mant_FormClosed(object sender, FormClosedEventArgs e);
        public event delegate_frmCP_Aprobacion_Ing_varios_Mant_FormClosed event_delegate_frmCP_Aprobacion_Ing_varios_Mant_FormClosed;
        void frmCP_Aprobacion_Ing_varios_Mant_event_delegate_frmCP_Aprobacion_Ing_varios_Mant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void frmCP_Aprobacion_Ing_varios_Mant_FormClosed(object sender, FormClosedEventArgs e)
        {
            event_delegate_frmCP_Aprobacion_Ing_varios_Mant_FormClosed(sender, e);
        }
        #endregion

        public void set_info(cp_Aprobacion_Ing_Bod_x_OC_Info _info)
        {
            try
            {
                info_aprobacion = _info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action _accion)
        {
            try
            {
                Accion = _accion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {
            try
            {
                txtIdAprobacion.Text = info_aprobacion.IdAprobacion.ToString();
                ucCp_Proveedor1.set_ProveedorInfo(info_aprobacion.IdProveedor);
                txtSerie.Text = info_aprobacion.Serie;
                txtSerie2.Text = info_aprobacion.Serie2;
                txtNumDocu.Text = info_aprobacion.num_documento;
                txtNumAutProve.Text = info_aprobacion.num_auto_Proveedor;
                cmbSustTrib.EditValue = info_aprobacion.IdIden_credito;
                cmbTipoDocu.EditValue = info_aprobacion.IdOrden_giro_Tipo;
                txtObservacion.Text = info_aprobacion.Observacion;
                de_fecha.EditValue = info_aprobacion.Fecha_aprobacion;
                dtpFecFactura.EditValue = info_aprobacion.Fecha_Factura;
                txt_plazo.Text = info_aprobacion.co_plazo.ToString();
                dtpFecVtc.EditValue = info_aprobacion.Fecha_vcto;


                blst_det = new BindingList<cp_Aprobacion_Ing_Bod_x_OC_det_Info>(bus_aprobacion_det.Get_List_Aprobacion_Ing_Bod_x_OC_det(info_aprobacion.IdEmpresa,info_aprobacion.IdAprobacion));
                gridControl_aprobacion.DataSource = blst_det;

                if (blst_det.Count != 0)
                {
                    ucIn_Sucursal_Bodega1.set_Idsucursal(blst_det[0].IdSucursal_Ing_Egr_Inv);
		            ucIn_Sucursal_Bodega1.set_Idbodega(blst_det[0].IdSucursal_Ing_Egr_Inv,blst_det[0].IdBodega);
                    ucIn_TipoMoviInv_Cmb1.set_TipoMoviInvInfo(blst_det[0].IdMovi_inven_tipo_Ing_Egr_Inv);
                }

                calcular_totales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        set_info_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        set_info_in_controls();
                        break;
                }
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
                info_in_param = bus_in_param.Get_Info_Parametro(param.IdEmpresa);

                cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
                List<cp_codigo_SRI_Info> ListCodigoSRI = new List<cp_codigo_SRI_Info>();
                ListCodigoSRI = dat_ti.Get_List_codigo_SRI_(param.IdEmpresa).FindAll(c => c.co_estado == "A" && c.IdTipoSRI == "COD_IDCREDITO");

                cmbSustTrib.Properties.DataSource = ListCodigoSRI;
                cmbSustTrib.Properties.DisplayMember = "descriConcate";
                cmbSustTrib.Properties.ValueMember = "IdCodigo_SRI";

                cp_TipoDocumento_Bus TipDoc_B = new cp_TipoDocumento_Bus();
                LstTipDoc = TipDoc_B.Get_List_TipoDocumento().FindAll(c => c.CodSRI != "04" && c.CodSRI != "05");
                LstTipDoc.ForEach(c => c.Descripcion = "[" + c.CodSRI + "] - " + c.Descripcion);
                cmbTipoDocu.Properties.DataSource = LstTipDoc;
                cmbTipoDocu.Properties.DisplayMember = "Descripcion";
                cmbTipoDocu.Properties.ValueMember = "CodTipoDocumento";

                ucCp_Proveedor1.cargar_proveedores();
                ucIn_Sucursal_Bodega1.set_Idsucursal(param.IdSucursal);
                
                lst_impuesto = bus_impuesto.Get_List_impuesto("IVA");
                cmb_impuesto_iva.DataSource = lst_impuesto;

                ucIn_TipoMoviInv_Cmb1.cargar_TipoMotivo(0, 0, "+", "");
                ucIn_TipoMoviInv_Cmb1.set_TipoMoviInvInfo(info_in_param.P_IdMovi_inven_tipo_ingreso_x_compra == null ? 0 : Convert.ToInt32(info_in_param.P_IdMovi_inven_tipo_ingreso_x_compra));
                gridControl_aprobacion.DataSource = blst_det;

                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida.DataSource = lst_unidad_medida;

                de_fecha.DateTime = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Aprobacion_Ing_varios_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {                
                lst_producto = bus_producto.Get_list_Producto(param.IdEmpresa, ucIn_Sucursal_Bodega1.get_IdSucursal(), ucIn_Sucursal_Bodega1.get_IdBodega());
                cmb_producto.DataSource = lst_producto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_aprobacion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                cp_Aprobacion_Ing_Bod_x_OC_det_Info row = (cp_Aprobacion_Ing_Bod_x_OC_det_Info)gridView_aprobacion.GetRow(e.RowHandle);
                if (row == null)
                    return;

                if (e.Column == col_IdProducto)
                {
                    if (row.IdProducto != null)
                    {
                        in_Producto_Info row_producto = lst_producto.FirstOrDefault(q => q.IdProducto == Convert.ToDecimal(row.IdProducto));
                        if (row_producto != null)
                        {
                            row.IdUnidadMedida = row_producto.IdUnidadMedida;
                            row.IdCod_Impuesto_Iva = row_producto.IdCod_Impuesto_Iva;
                            tb_sis_impuesto_Info row_impuesto = lst_impuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto_Iva);
                            if (row_impuesto != null)
                            {
                                row.PorIva = row_impuesto.porcentaje;
                            }
                            row.IdCtaCble_Gasto = row_producto.IdCtaCble_Gasto_x_cxp == null ? row_producto.IdCtaCble_Costo_categoria : row_producto.IdCtaCble_Gasto_x_cxp;
                            if (row.IdCtaCble_Gasto == null)
                            {
                                MessageBox.Show("El producto seleccionado no está parametrizado contablemente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                gridView_aprobacion.DeleteSelectedRows();
                                return;
                            }
                        }
                    }
                }

                if (e.Column == col_cantidad || e.Column == col_costo || e.Column == col_por_descuento)
                {
                    row.Descuento = Math.Round((row.Costo_uni * row.por_descuento) / 100, 2, MidpointRounding.AwayFromZero);
                    row.Cost_uni_final = Math.Round(row.Costo_uni - row.Descuento,2,MidpointRounding.AwayFromZero);
                    row.SubTotal = Math.Round(row.Cost_uni_final * row.Cantidad,2,MidpointRounding.AwayFromZero);
                    row.valor_Iva = Math.Round((row.SubTotal * row.PorIva) / 100, 2, MidpointRounding.AwayFromZero);
                    row.Total = Math.Round(row.SubTotal + row.valor_Iva,2,MidpointRounding.AwayFromZero);
                }

                if (e.Column == col_impuesto)
                {
                    tb_sis_impuesto_Info row_impuesto = lst_impuesto.FirstOrDefault(q => q.IdCod_Impuesto == row.IdCod_Impuesto_Iva);
                    if (row_impuesto != null)
                    {
                        row.PorIva = row_impuesto.porcentaje;
                    }
                    row.SubTotal = Math.Round(row.Cost_uni_final * row.Cantidad,2,MidpointRounding.AwayFromZero);
                    row.valor_Iva = Math.Round((row.SubTotal * row.PorIva) / 100, 2, MidpointRounding.AwayFromZero);
                    row.Total = Math.Round(row.SubTotal + row.valor_Iva,2,MidpointRounding.AwayFromZero);
                }
                calcular_totales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void calcular_totales()
        {
            try
            {
                double subtotal_0 = 0;
                double subtotal_iva = 0;
                double subtotal = 0;
                double total_iva = 0;
                double total_descuento = 0;
                double total = 0;
                foreach (var item in blst_det)
                {
                    if (item.PorIva == 0)
                        subtotal_0 += item.SubTotal;
                    else
                    {
                        subtotal_iva += item.SubTotal;
                        total_iva += item.valor_Iva;
                    }
                    subtotal += item.SubTotal;
                    total_descuento += (item.Cantidad * item.Descuento);
                    total += item.Total;
                }

                txtSubtotal0.Text = Math.Round(subtotal_0,2,MidpointRounding.AwayFromZero).ToString();
                txtSubtotalIva.Text = Math.Round(subtotal_iva, 2, MidpointRounding.AwayFromZero).ToString();
                txtSubtotal.Text = Math.Round(subtotal, 2, MidpointRounding.AwayFromZero).ToString();
                txtTotalIva.Text = Math.Round(total_iva, 2, MidpointRounding.AwayFromZero).ToString();
                txtTotDescuento.Text = Math.Round(total_descuento, 2, MidpointRounding.AwayFromZero).ToString();
                txtTotal.Text = Math.Round(total, 2, MidpointRounding.AwayFromZero).ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSustTrib_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    return;
                }

                if (cmbSustTrib.EditValue == null)
                {
                    return;
                }

                cp_proveedor_Info _p = ucCp_Proveedor1.get_ProveedorInfo();

                this.cmbTipoDocu.EditValue = null;
                if (_p != null)
                {
                    if (_p.Persona_Info.IdTipoDocumento != null)
                    {
                        cp_codigo_SRI_Info info_codSri = new cp_codigo_SRI_Info();
                        var a = (List<cp_codigo_SRI_Info>)cmbSustTrib.Properties.DataSource;
                        info_codSri = a.First(q => q.IdCodigo_SRI == Convert.ToDecimal(cmbSustTrib.EditValue));

                        List<cp_TipoDocumento_Info> lst = new List<cp_TipoDocumento_Info>();

                        if (info_codSri != null)
                            if (info_codSri.codigoSRI != null)
                                foreach (var item in LstTipDoc)
                                {
                                    if (item.Sustento_Tributario != null)
                                    {
                                        if (item.CodSRI == "06")
                                        {
                                        }
                                        //Separa sustento por documento
                                        string[] arreglo = item.Sustento_Tributario.Split(',');
                                        //Recorre los sustentos del documento
                                        for (int i = 0; i < arreglo.Length; i++)
                                        {
                                            arreglo[i] = arreglo[i].Trim();

                                            if (arreglo[i] == info_codSri.codigoSRI)
                                            { //Datos SRI cod_secuencia (01 compra ruc)(02 compra cedula)(03 compra pasaporte)

                                                string secuencial = "";
                                                if (_p.Persona_Info.IdTipoDocumento.Trim() == "RUC")
                                                    secuencial = "01";
                                                else if (_p.Persona_Info.IdTipoDocumento.Trim() == "CED")
                                                    secuencial = "02";
                                                else
                                                    secuencial = "03";

                                                string[] arregloSecuenci = item.Codigo_Secuenciales_Transaccion.Split(',');
                                                for (int ise = 0; ise < arregloSecuenci.Length; ise++)
                                                {
                                                    arregloSecuenci[ise] = arregloSecuenci[ise].Trim();
                                                    if (arregloSecuenci[ise] == secuencial)
                                                    {
                                                        lst.Add(item);
                                                        ise = arregloSecuenci.Length;
                                                        i = arreglo.Length;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                        cmbTipoDocu.Properties.DataSource = lst;
                    }
                    else
                    {
                        MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Antes de continuar debe seleccionar Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSustTrib.EditValue = null;
                    return;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void de_fecha_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtp_fecha_contabilizacion.EditValue = de_fecha.EditValue;
                dtpFecFactura.EditValue = de_fecha.EditValue;

                int dias_plazo = string.IsNullOrEmpty(txt_plazo.Text) ? 0 : Convert.ToInt32(txt_plazo.Text);
                dtpFecVtc.EditValue = Convert.ToDateTime(de_fecha.EditValue).AddDays(dias_plazo);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_plazo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_plazo.Text != "")
                {
                    int plazo = 0;
                    DateTime fechaFact = Convert.ToDateTime(dtpFecFactura.EditValue);

                    plazo = Convert.ToInt32(txt_plazo.Text);
                    fechaFact = fechaFact.AddDays(plazo);

                    dtpFecVtc.EditValue = fechaFact;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtNumDocu_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string secuencia_aux = "";
                string secuencia = "";

                string valor_secu = "";
                valor_secu = Convert.ToString(txtNumDocu.EditValue);

                if (!String.IsNullOrEmpty(valor_secu))
                {
                    if (valor_secu.Length < 9)
                    {
                        int conta = valor_secu.Length;
                        int diferencia = 9 - conta;

                        secuencia_aux = secuencia_aux.PadLeft(diferencia, '0');
                        secuencia = secuencia_aux + valor_secu;

                        txtNumDocu.EditValue = secuencia;
                    }
                }
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDB())
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

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {

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
                txtIdAprobacion.Focus();
                string mensaje = "";

                if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show("Seleccione un proveedor", param.Nombre_sistema);
                    return false;
                }

                if (!string.IsNullOrEmpty(Convert.ToString(txtSerie.EditValue)) && !String.IsNullOrEmpty(Convert.ToString(txtSerie2.EditValue)) && !String.IsNullOrEmpty(Convert.ToString(txtNumDocu.EditValue)))
                {
                    bus_aprobacion = new cp_Aprobacion_Ing_Bod_x_OC_Bus();
                    if (bus_aprobacion.VerificarNumDocumento(param.IdEmpresa, Convert.ToString(txtSerie.EditValue), Convert.ToString(txtSerie2.EditValue), Convert.ToString(txtNumDocu.EditValue), ucCp_Proveedor1.get_ProveedorInfo().IdProveedor, ref mensaje))
                    {
                        MessageBox.Show("El número de Documento : " + mensaje + " ya se encuentra registrado" + " Para este proveedor verifique..", param.Nombre_sistema);
                        return false;
                    }
                }

                bool Item_mes_anterior = false;
                foreach (var item in blst_det)
                {
                    if (item.Checked == true)
                    {
                        if (item.IdCtaCble_Gasto == null || item.IdCtaCble_Gasto == "")
                        {
                            MessageBox.Show("Ingrese la Cta Cble del Gasto para el Producto" + item.nom_producto, param.Nombre_sistema);
                            return false;
                        }
                        if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(item.Fecha_Ing_Bod)))
                        {
                            Item_mes_anterior = true;
                        }
                    }
                }
                if (Item_mes_anterior)
                {
                    if (MessageBox.Show("Ha escogido movimientos de un periodo cerrado, ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(de_fecha.EditValue)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dtp_fecha_contabilizacion.EditValue)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void get_info()
        {
            try
            {
                info_cp_param = bus_cp_param.Get_Info_parametros(param.IdEmpresa);
                info_aprobacion = new cp_Aprobacion_Ing_Bod_x_OC_Info();
                info_aprobacion.IdEmpresa = param.IdEmpresa;
                info_aprobacion.IdAprobacion = Convert.ToDecimal((txtIdAprobacion.EditValue == "") ? 0 : Convert.ToDecimal(txtIdAprobacion.EditValue));
                info_aprobacion.Fecha_Factura = Convert.ToDateTime(dtpFecFactura.EditValue);
                info_aprobacion.Fecha_aprobacion = Convert.ToDateTime(de_fecha.EditValue);
                info_aprobacion.co_FechaContabilizacion = Convert.ToDateTime(Convert.ToDateTime(dtp_fecha_contabilizacion.EditValue).ToShortDateString());
                info_aprobacion.Fecha_vcto = Convert.ToDateTime(dtpFecVtc.EditValue);
                info_aprobacion.co_plazo = Convert.ToInt32(txt_plazo.Text);



                info_aprobacion.IdOrden_giro_Tipo = Convert.ToString(cmbTipoDocu.EditValue).Trim();
                info_aprobacion.IdIden_credito = Convert.ToInt32(cmbSustTrib.EditValue);
                info_aprobacion.IdProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;
                info_aprobacion.Observacion = Convert.ToString(txtObservacion.EditValue).Trim() + "FP:#" + txtSerie.Text + "-" + txtSerie2.Text + "-" + txtNumDocu.Text + " Prv:" + ucCp_Proveedor1.get_ProveedorInfo().pr_nombre;
                info_aprobacion.Serie = Convert.ToString(txtSerie.EditValue).Trim();
                info_aprobacion.Serie2 = Convert.ToString(txtSerie2.EditValue).Trim();
                info_aprobacion.num_documento = Convert.ToString(txtNumDocu.EditValue).Trim();
                info_aprobacion.num_auto_Proveedor = Convert.ToString(txtNumAutProve.EditValue).Trim();
                info_aprobacion.num_auto_Imprenta = "";
                info_aprobacion.co_subtotal_iva = Math.Round((txtSubtotalIva.EditValue == "" ? 0 : Convert.ToDouble(txtSubtotalIva.EditValue)), 2);
                info_aprobacion.co_subtotal_siniva = Math.Round((txtSubtotal0.EditValue == "" ? 0 : Convert.ToDouble(txtSubtotal0.EditValue)), 2);
                info_aprobacion.Descuento = Math.Round((txtTotDescuento.EditValue == "" ? 0 : Convert.ToDouble(txtTotDescuento.EditValue)), 2);
                info_aprobacion.co_baseImponible = Math.Round((txtSubtotal.EditValue == "" ? 0 : Convert.ToDouble(txtSubtotal.EditValue)), 2);
                double por_iva = param.iva.porcentaje;
                //if (blst_det.Where(q => q.Checked == true).Count() != 0)
                    por_iva = blst_det.Max(q => q.PorIva);
                info_aprobacion.co_Por_iva = por_iva;
                

                info_aprobacion.co_valoriva = Math.Round((txtTotalIva.EditValue == "" ? 0 : Convert.ToDouble(txtTotalIva.EditValue)), 2);
                info_aprobacion.co_total = Math.Round((txtTotal.EditValue == "" ? 0 : Convert.ToDouble(txtTotal.EditValue)), 2);
                info_aprobacion.IdCtaCble_CXP = ucCp_Proveedor1.get_ProveedorInfo().IdCtaCble_CXP;
                info_aprobacion.pa_ctacble_iva = info_cp_param.pa_ctacble_iva;
                info_aprobacion.IdCentroCosoto_CXP = null;

                info_aprobacion.listDetalle = new List<cp_Aprobacion_Ing_Bod_x_OC_det_Info>(blst_det);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool guardarDB()
        {
            try
            {
                if (!validar())
                {
                    return false;
                }
                get_info();
                armar_movimiento_inventario();
                string mensaje = "";
                decimal IdIdAprobacion = 0;

                if (bus_aprobacion.GuardarDB(info_aprobacion, ref   IdIdAprobacion, ref mensaje))
                {
                    txtIdAprobacion.Text = Convert.ToString(IdIdAprobacion);

                    if (info_aprobacion.IdCbteCble_Ogiro != 0)
                    {
                        if (info_aprobacion.IdCbteCble_Ogiro != null)
                        {
                            MessageBox.Show("Se ha procedido a grabar el registro de Aprobación #: " + IdIdAprobacion.ToString() + ", con Factura Proveedor #: " + info_aprobacion.IdCbteCble_Ogiro + " exitosamente.",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show(mensaje);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al grabar el registro de Aprobación, " + mensaje, param.Nombre_sistema);
                    return false;
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

        private void armar_movimiento_inventario()
        {
            try
            {
                in_Ing_Egr_Inven_Info info_movimiento = new in_Ing_Egr_Inven_Info();

                #region Cabecera
                info_movimiento = new in_Ing_Egr_Inven_Info
                    {
                        IdEmpresa = param.IdEmpresa,
                        IdSucursal = ucIn_Sucursal_Bodega1.get_IdSucursal(),
                        IdMovi_inven_tipo = ucIn_TipoMoviInv_Cmb1.get_TipoMoviInvInfo().IdMovi_inven_tipo,
                        IdNumMovi = 0,
                        IdBodega = ucIn_Sucursal_Bodega1.get_IdBodega(),
                        signo = "+",
                        CodMoviInven = "FACT" + info_aprobacion.Serie+"-"+info_aprobacion.Serie2+"-"+info_aprobacion.num_documento,
                        cm_observacion = txtObservacion.Text,
                        cm_fecha = de_fecha.DateTime.Date,
                        IdUsuario = param.IdUsuario,
                        Estado = "A",
                        Fecha_Transac = DateTime.Now,
                        nom_pc = param.nom_pc,
                        ip = param.ip,
                        IdMotivo_Inv = ucIn_MotivoInvCmb1.get_MotivoInvInfo().IdMotivo_Inv
                    };
              
                #endregion

                #region Detalle
                foreach (var item in blst_det)
                {
                    in_Ing_Egr_Inven_det_Info info_det = new in_Ing_Egr_Inven_det_Info
                    {
                        IdEmpresa = info_movimiento.IdEmpresa,
                        IdSucursal = info_movimiento.IdSucursal,
                        IdMovi_inven_tipo = info_movimiento.IdMovi_inven_tipo,
                        IdNumMovi = info_movimiento.IdNumMovi,
                        IdBodega = info_movimiento.IdBodega,
                        IdProducto = Convert.ToDecimal(item.IdProducto),
                        dm_observacion = "",
                        dm_cantidad = item.Cantidad,
                        dm_cantidad_sinConversion = item.Cantidad,
                        mv_costo = item.Cost_uni_final,
                        mv_costo_sinConversion = item.Cost_uni_final,
                        IdUnidadMedida = item.IdUnidadMedida,
                        IdUnidadMedida_sinConversion = item.IdUnidadMedida,
                    };
                    info_movimiento.listIng_Egr.Add(info_det);
                }
                #endregion
                info_aprobacion.info_ing_x_compra = info_movimiento;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
