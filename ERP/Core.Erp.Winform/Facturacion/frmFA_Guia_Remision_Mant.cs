using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Facturacion;
using Core.Erp.Winform.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System.Windows;
using DevExpress.Xpf;
using Core.Erp.Reportes.Facturacion;
namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Guia_Remision_Mant : Form
    {
        #region Declaración de variables
        string msg = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<tb_transportista_Info> LisTransportista = new List<tb_transportista_Info>();
        in_producto_Bus BusProduCto = new in_producto_Bus();
        fa_guia_remision_Bus Bus = new fa_guia_remision_Bus();
        UCGe_NumeroDocTrans ctrl_numerdoc = new UCGe_NumeroDocTrans();
        private Cl_Enumeradores.eTipo_action _Accion;
        decimal Aux;
        BindingList<fa_guia_remision_det_Info> lista_guia_detalle = new BindingList<fa_guia_remision_det_Info>();
        fa_guia_remision_Info _Info = new fa_guia_remision_Info();
        fa_guia_remision_det_bus BusDetalle = new fa_guia_remision_det_bus();
        public fa_guia_remision_Info SetInfo { get; set; }
        tb_transportista_Info info_transportista = new tb_transportista_Info();
        tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();

        fa_guia_remision_det_x_factura_Bus bus_factura_x_guia = new fa_guia_remision_det_x_factura_Bus();
        List<fa_guia_remision_det_x_factura_Info> lista_factura_x_guia = new List<fa_guia_remision_det_x_factura_Info>();

        fa_factura_det_Bus bus_factura_der = new fa_factura_det_Bus();
        List<fa_factura_det_info> lista_factura_det = new List<fa_factura_det_info>();


        public delegate void Delegate_frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmFA_Guia_Remision_Mant_FormClosing Event_frmFA_Guia_Remision_Mant_FormClosing;

        #endregion

        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public frmFa_Guia_Remision_Mant()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }



      



        public void cargarTransportistas()
        {
            try
            {

                tb_transportista_Bus Bustransportista = new tb_transportista_Bus();
                LisTransportista = Bustransportista.Get_List_transportista(param.IdEmpresa);
                ultraComboEditorTransportista.Properties.DataSource = LisTransportista;
                ultraComboEditorTransportista.Properties.DisplayMember = "Nombre";
                ultraComboEditorTransportista.Properties.ValueMember = "IdTransportista";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void frmFA_Guia_Remision_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = "";
                cargarTransportistas();
                Event_frmFA_Guia_Remision_Mant_FormClosing += new Delegate_frmFA_Guia_Remision_Mant_FormClosing(frmFA_Guia_Remision_Mant_Event_frmFA_Guia_Remision_Mant_FormClosing);

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                       
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        //btnGuardar.Text = "Actualizar";
                        this.Text = this.Text + "***Actualizar***";


                      

                        gridViewGuia.OptionsBehavior.Editable = false;

                        this.txtNumPlaca.Enabled = false;
                        this.txtNumPlaca.BackColor = System.Drawing.Color.White;
                        this.txtNumPlaca.ForeColor = System.Drawing.Color.Black;

                        

                       
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.Text = this.Text + "***Anular***";
                        
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.Text = this.Text + "***Consulta***";

                        
                        if (SetInfo.Impreso == "S")
                        {


                        }
                        if (SetInfo.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }

                        Set();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frmFA_Guia_Remision_Mant_Event_frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e) { }


        public void Get()
        {
            try
            {

                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdSucursal = UCSucursal.get_IdSucursal();
                _Info.IdBodega = UCSucursal.get_IdBodega();
                _Info.IdCliente = ucFa_ClienteCmb.get_ClienteInfo().IdCliente;
                _Info.gi_fecha = Convert.ToDateTime(dateFecha.Value.ToShortDateString());
                _Info.gi_fech_venc = _Info.gi_fecha;
                _Info.gi_FecIniTraslado = Convert.ToDateTime(dtpFecIniTrasl.Value.ToShortDateString());
                _Info.gi_FecFinTraslado = Convert.ToDateTime(dtpFecFinTrasl.Value.ToShortDateString());
                _Info.CodGuiaRemision = txtCodigo.Text;
                _Info.IdVendedor = Convert.ToInt32(ultraComboEditorTransportista.EditValue);
                _Info.IdTransportista = (decimal)ultraComboEditorTransportista.EditValue;
                _Info.gi_Observacion = txtObservacion.Text;
                _Info.placa = txtNumPlaca.Text;
                _Info.Direccion_Origen = txtorigen.Text;
                _Info.ListaDetalle =  lista_guia_detalle.ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        public void Set()
        {
            try
            {
                txtCodigo.Text = SetInfo.CodGuiaRemision;
                dateFecha.Value = SetInfo.gi_fecha;
                dtpFecIniTrasl.Value = SetInfo.gi_FecIniTraslado;
                dtpFecFinTrasl.Value = SetInfo.gi_FecFinTraslado;
                ultraComboEditorTransportista.EditValue = SetInfo.IdTransportista;
                ucFa_ClienteCmb.set_ClienteInfo(SetInfo.IdCliente);
                UCSucursal.set_Idsucursal(SetInfo.IdSucursal);
                UCSucursal.set_Idbodega(SetInfo.IdSucursal, SetInfo.IdBodega);
                txtObservacion.Text = SetInfo.gi_Observacion;
                txtNumPlaca.Text = SetInfo.placa;
                SetInfo.ListaDetalle = BusDetalle.Get_List_guia_remision_det(SetInfo.IdEmpresa, SetInfo.IdSucursal, SetInfo.IdBodega, SetInfo.IdGuiaRemision);
                gridControlGuia.DataSource = SetInfo.ListaDetalle;
                lista_factura_x_guia = bus_factura_x_guia.Get_List_factura_con_guia(SetInfo.IdEmpresa, SetInfo.IdSucursal, SetInfo.IdBodega,Convert.ToInt32( SetInfo.IdGuiaRemision));
                gridControlFactura.DataSource = lista_factura_x_guia;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void Grabar()
        {
            try
            {
                txtCodigo.Focus();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Guardar()
        {
            try
            {
                string numDocFactu = "";
                decimal id = 0;
                string ms = "";
               

               
                    _Info.IdUsuario = param.IdUsuario;
                    _Info.ip = param.ip;
                    _Info.nom_pc = param.nom_pc;
                    _Info.Fecha_Transac = DateTime.Now;

                    if (Bus.GrabarDB(_Info, ref id, ref numDocFactu, ref ms))
                    {
                       

                        if (txtCodigo.Text == "")
                        {
                        }
                        if (MessageBox.Show("Guía de Remisión # " + id + " Ingresada con éxito." + "\n" + "¿Desea Imprimir la Guía Remisión N° " + id + "?", "Imprimir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Imprimir();
                        }
                        _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                    }

                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        public void Actualizar()
        {
            try
            {
                if (!Validar())
                { return; }

                string msn = "";
                _Info.IdUsuarioUltMod = param.IdUsuario;
                if (Bus.ModificarDB(_Info, ref msn))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Guía de Remisión", _Info.IdGuiaRemision);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public Boolean Validar()
        {
            try
            {
                //if (ucgt == 0 || _Info.IdTransportista == null)
                //{
                //    MessageBox.Show("Por Favor seleccione Transportista", "Sistema ERP");
                //    return false;
                //}
                if (ucFa_ClienteCmb.get_ClienteInfo().IdCliente == 0 || ucFa_ClienteCmb.get_ClienteInfo().IdCliente==null)
                {
                    MessageBox.Show("Por Favor seleccione Cliente", "Sistema ERP");
                    return false;
                }
               
                
               
                if (_Info.gi_FecFinTraslado < _Info.gi_FecIniTraslado)
                {
                    MessageBox.Show("La fecha de Finalización del Traslado no pude ser menor a la fecha Inicial del Traslado", "Sistema ERP");
                    return false;
                }

                if (_Info.gi_FecIniTraslado < _Info.gi_fecha)
                {
                    MessageBox.Show("La fecha de Inicio del Traslado no pude ser menor a la fecha de Emisión", "Sistema ERP");
                    return false;
                }

                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }

        private void frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmFA_Guia_Remision_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewGuia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewGuia_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                //Aux = Convert.ToDecimal(gridViewGuia.GetFocusedRowCellValue(colgi_cantidad));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void limiar()
        {
            try
            {
                txtCodigo.Text = "";

                dateFecha.Value = DateTime.Now;

                this.Text = "Guía De Remisión ***Guardar***";
                _Accion = Cl_Enumeradores.eTipo_action.grabar;

              
                lblAnulado.Visible = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



      
        private void Imprimir()
        {

            try
            {

                Get();

                XFAC_Rpt014_rpt reporte = new XFAC_Rpt014_rpt();
                reporte.Parameters["PIdEmpresa"].Value = _Info.IdEmpresa;
                reporte.Parameters["PIdCliente"].Value = _Info.IdCliente;
                reporte.Parameters["PIdguia"].Value = _Info.IdGuiaRemision;
                reporte.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

    




        private void GetFact_a_Guia(fa_guia_remision_det_x_factura_Info info_fac, bool check)
        {
            try
            {
                lista_factura_det = bus_factura_der.Get_List_factura_para_guia(info_fac.IdEmpresa, info_fac.IdSucursal, info_fac.IdBodega, info_fac.IdCbteVta, ref msg);
                if (check)
                {
                    foreach (var item in lista_factura_det)
                    {

                        fa_guia_remision_det_Info info_guia_det = new fa_guia_remision_det_Info();
                        info_guia_det.IdEmpresa = param.IdEmpresa;
                        info_guia_det.IdSucursal = item.IdSucursal;
                        info_guia_det.IdBodega = item.IdBodega;
                        info_guia_det.IdProducto = item.IdProducto;
                        info_guia_det.secuancia_fac  = item.Secuencia;
                        info_guia_det.IdComprobante = Convert.ToInt32(item.IdCbteVta);
                        info_guia_det.pr_codigo = item.pr_codigo;
                        info_guia_det.pr_descripcion = item.pr_descripcion;
                        info_guia_det.gi_cantidad = item.vt_cantidad;
                        info_guia_det.gi_detallexItems = item.vt_detallexItems;
                        lista_guia_detalle.Add(info_guia_det);
                    }
                }
                else
                {
                    int itemeliminar = lista_guia_detalle.Where(v => v.IdSucursal == info_fac.IdSucursal
                            && v.IdBodega == info_fac.IdBodega
                            && v.IdComprobante == info_fac.IdCbteVta).Count();

                    while (itemeliminar>0)
                    {
                        foreach (var item in lista_guia_detalle)
                        {
                            if (item.IdSucursal == info_fac.IdSucursal
                                && item.IdBodega == info_fac.IdBodega
                                && item.IdComprobante == info_fac.IdCbteVta)
                            {
                                lista_guia_detalle.Remove(item);
                                itemeliminar--;
                                break;

                            }
                        }
                    }

                   
                }


                gridControlGuia.DataSource = lista_guia_detalle;
            }
            catch (Exception ex)
            {


            }

        }

        private void gridViewFactura_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                fa_guia_remision_det_x_factura_Info info = null;
                info = (fa_guia_remision_det_x_factura_Info)gridViewFactura.GetFocusedRow();
                if (info != null)
                {

                    GetFact_a_Guia(info, info.check);
                }
            }
            catch (Exception)
            {


            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                lista_factura_x_guia = bus_factura_x_guia.Get_List_factura_sin_guia(param.IdEmpresa, UCSucursal.get_IdBodega(), UCSucursal.get_IdBodega(), Convert.ToInt32(ucFa_ClienteCmb.get_ClienteInfo().IdCliente), dtpdesde.Value, dtphasta.Value);
                gridControlFactura.DataSource = lista_factura_x_guia;
            }
            catch (Exception)
            {

            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                if (Validar())
                {
                   Grabar();
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {

            try
            {
                Get();

           
                FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
               
                if (MessageBox.Show("¿Está seguro que desea anular la Cotización ?", "Anulación de Cotización", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ofrm.ShowDialog();
                    _Info.MotivoAnu = ofrm.motivoAnulacion;
                    _Info.ip = param.ip;
                    _Info.nom_pc = param.nom_pc;
                    _Info.IdUsuarioUltAnu = param.IdUsuario;
                    _Info.Fecha_UltAnu = DateTime.Now;
                    if (ofrm.cerrado == "N")
                    {
                        if (Bus.ActualizarEstado(param.IdEmpresa, _Info))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Guía de Remisión", _Info.IdGuiaRemision);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            lblAnulado.Visible = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (Validar())
                {
                    Get();
                    Grabar();
                    limiar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();
            }
            catch (Exception)
            {
                
            }
        }

        private void ultraComboEditorTransportista_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_transportista = (tb_transportista_Info)ultraComboEditorTransportista.Properties.View.GetFocusedRow();
                if (info_transportista!=null)
                txtNumPlaca.Text = info_transportista.Placa;
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error comuniquese con sistema", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void UCSucursal_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                info_sucursal = (tb_Sucursal_Info)UCSucursal.get_sucursal();
                if(info_sucursal!=null)
                txtorigen.Text = info_sucursal.Su_Direccion;
            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error comuniquese con sistema", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



    }

}