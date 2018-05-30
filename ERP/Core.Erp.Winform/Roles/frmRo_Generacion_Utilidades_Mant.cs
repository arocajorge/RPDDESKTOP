using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Generacion_Utilidades_Mant : Form
    {
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        string mensaje = "";

        //INFO
        BindingList<ro_Participacion_Utilidad_Empleado_Info> oListRo_Empleado_Info = new BindingList<ro_Participacion_Utilidad_Empleado_Info>();
        ro_Participacion_Utilidad_Info _Info = new ro_Participacion_Utilidad_Info();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();


        List<ro_Rol_Detalle_Info> ro_rol_detalle_info = new List<ro_Rol_Detalle_Info>();
        ro_Rol_Info rol_info = new ro_Rol_Info();


        //BUS
        ro_Participacion_Utilidad_Bus oRo_Empleado_Bus = new ro_Participacion_Utilidad_Bus();
        ro_Participacion_Utilidad_Bus oRo_Participacion_Utilidad_Bus = new ro_Participacion_Utilidad_Bus();
        ro_Participacion_Utilidad_Empleado_Bus oRo_Participacion_Utilidad_Empleado_Bus = new ro_Participacion_Utilidad_Empleado_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus Bus_Periodo = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();


        ro_Rol_Bus rol_bus = new ro_Rol_Bus();
        ro_Rol_Detalle_Bus rol_rol_detalle_bus = new ro_Rol_Detalle_Bus();


        public frmRo_Generacion_Utilidades_Mant()
        {
           
            try
            {
                InitializeComponent();

                ucGe_Menu_Superior_Mant.event_btnSalir_Click += ucGe_Menu_Superior_Mant_event_btnSalir_Click;
                ucGe_Menu_Superior_Mant.event_btnGuardar_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_Click;
                ucGe_Menu_Superior_Mant.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click;

                ucGe_Menu_Superior_Mant.event_btnImprimir_Click += ucGe_Menu_Superior_Mant_event_btnImprimir_Click;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_Superior_Mant_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Imprimir();

            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                pu_Guardar();
                this.Close();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void ucGe_Menu_Superior_Mant_event_btnGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                pu_Guardar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRo_Generacion_Utilidades_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                pu_CargarInicial();
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
          
        }


 
        private Boolean getInfo() {
            try
            {

                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdPeriodo = Convert.ToInt32(cmbPeriodos.EditValue);
                _Info.IdNomina=Convert.ToInt32( cmbnomina.EditValue);
                _Info.IdNominaTipo_liq = Convert.ToInt32(cmbnominaTipo.EditValue);
                _Info.UtilidadDerechoIndividual = Convert.ToDouble(txtUtilidadPorDerechoIndividual.Text);
                _Info.UtilidadCargaFamiliar = Convert.ToDouble(txtUtilidadPorCargaFamiliar.Text);


                _Info.oListRo_Participacion_Utilidad_Empleado_Info.Clear();

                foreach (ro_Participacion_Utilidad_Empleado_Info item in oListRo_Empleado_Info)
                {
                    ro_Participacion_Utilidad_Empleado_Info infoDetalle=new ro_Participacion_Utilidad_Empleado_Info();

                    infoDetalle.IdEmpresa = _Info.IdEmpresa;
                    infoDetalle.IdEmpleado = item.IdEmpleado;
                    infoDetalle.DiasTrabajados = item.diasTrabajo;
                    infoDetalle.CargasFamiliares = item.cargas;
                    infoDetalle.ValorIndividual = item.subTotalIndividual;
                    infoDetalle.ValorCargaFamiliar = item.subTotalCarga;
                    infoDetalle.ValorExedenteIESS = item.exedenteIESS;
                    infoDetalle.ValorTotal = item.valorEntregar;

                    _Info.oListRo_Participacion_Utilidad_Empleado_Info.Add(infoDetalle);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }   
       }

        private void pu_Guardar() {
            try {

                if (pu_Validar())
                {
                    if (getInfo())
                    {
                        if (oRo_Participacion_Utilidad_Bus.GuardarBD(_Info, ref mensaje))
                        {
                           
                            MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                           MessageBox.Show("El registro no se pudo guardar, revise por favor: " , "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);        
                        }
                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        private void pu_CargarInicial()
        {
            try
            {
               


                 listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                 cmbnomina.Properties.DataSource = listadoNomina;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void pu_CargarEmpleados()
        {
            try
            {
                ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo = (ro_periodo_x_ro_Nomina_TipoLiqui_Info)cmbPeriodos.Properties.View.GetFocusedRow();

                oListRo_Empleado_Info = new BindingList<ro_Participacion_Utilidad_Empleado_Info>(oRo_Empleado_Bus.Get_nomina_x_utilidades(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), info_periodo.pe_FechaIni, info_periodo.pe_FechaFin).Where(v => v.diasTrabajo > 0).ToList());
                gridEmpleados.DataSource = oListRo_Empleado_Info;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private void cmdCargarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                pu_CargarEmpleados();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private Boolean pu_Validar() {
            try {

                if (txtUtilidadPorDerechoIndividual.Text == "")
                {
                    MessageBox.Show("El Valor de la Utilidad por Derecho Individual es Obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUtilidadPorDerechoIndividual.Focus();
                    return false;
                }

                if (txtUtilidadPorCargaFamiliar.Text == "")
                {
                    MessageBox.Show("El Valor de la Utilidad por Carga Familiar es Obligatorio, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUtilidadPorCargaFamiliar.Focus();
                    return false;
                }

               
                if (Convert.ToDouble(txtUtilidadPorDerechoIndividual.Text) <= 0)
                {
                    MessageBox.Show("El Valor de la Utilidad por Derecho Individual debe ser mayor que cero, revise por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUtilidadPorDerechoIndividual.Focus();
                    return false;

                }

                if (Convert.ToDouble(txtUtilidadPorCargaFamiliar.Text) <= 0)
                {
                    MessageBox.Show("El Valor de la Utilidad por Carga Familiar  debe ser mayor que cero, revise por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUtilidadPorCargaFamiliar.Focus();
                    return false;

                }

                if (cmbPeriodos.EditValue==null)
                {
                    MessageBox.Show("Seleccione el periodo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUtilidadPorCargaFamiliar.Focus();
                    return false;

                }

                if (cmbnomina.EditValue == null)
                {
                    MessageBox.Show("Seleccione la nomina", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUtilidadPorCargaFamiliar.Focus();
                    return false;

                }

                if (cmbnominaTipo.EditValue == null)
                {
                    MessageBox.Show("Seleccione la el proceso", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUtilidadPorCargaFamiliar.Focus();
                    return false;

                }
                
                
                if (Convert.ToDouble(TxtUtilidadRepartir.Text) <= 0)
                {
                    MessageBox.Show("El Valor de la Utilidad a repartir debe ser mayor que cero, revise por favor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtUtilidadRepartir.Focus();
                    return false;

                }



                if (TxtUtilidadRepartir.Text=="")
                {
                    MessageBox.Show("Ingres valor de Utilidad a repartir", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtUtilidadRepartir.Focus();
                    return false;

                }

                if (cmbnomina.EditValue == null)
                {
                    MessageBox.Show("Seleccione la nomina", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    return false;
                }
                if (cmbnominaTipo.EditValue == null)
                {
                    MessageBox.Show("Seleccione el tipo de nomina", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cmbPeriodos.EditValue == null)
                {
                    MessageBox.Show("Seleccione el periodo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }





        private void pu_Calcular() {
            try {
                TxtUtilidadRepartir.Focus();

                if (pu_Validar())
                {

                    double valorUtilidadIndividual = 0;
                    double valorUtilidadCarga = 0;
                    double valorTotalDiasTrab = 0;
                    double valorAlicuotaIndividual = 0;
                    double valorAlicuotaCarga = 0;
                    double valorLimiteDistribucionIESS = 0;
                    double factorB = 0;

                    valorUtilidadIndividual = Convert.ToDouble(txtUtilidadPorDerechoIndividual.Text);
                    valorUtilidadCarga = Convert.ToDouble(txtUtilidadPorCargaFamiliar.Text);
                    valorTotalDiasTrab = Convert.ToDouble(colDiasTrab.SummaryText);

                    valorAlicuotaIndividual = valorUtilidadIndividual / valorTotalDiasTrab;

                    //CALCULAR UTILIDAD POR DERECHO INDIVIDUAL
                    foreach (ro_Participacion_Utilidad_Empleado_Info item in oListRo_Empleado_Info)
                    {
                        
                        item.alicuotaIndividual = valorAlicuotaIndividual;
                        item.subTotalIndividual = item.DiasTrabajados * valorAlicuotaIndividual;

                        item.valorEntregar = item.subTotalIndividual + item.subTotalCarga;

                        if (item.cargas > 0)
                        {
                            item.diasTrabAnual = item.diasTrabajo;
                            item.factorA = item.cargas * item.diasTrabajo;
                            factorB += item.factorA;
                        }
                    }

                    if (factorB > 0)
                    { valorAlicuotaCarga = valorUtilidadCarga / factorB; }
                    else
                    {
                        valorAlicuotaCarga = 0;
                    }
                    

                    //CALCULAR UTILIDAD POR CARGA FAMILIAR
                    foreach (ro_Participacion_Utilidad_Empleado_Info item in oListRo_Empleado_Info)
                    {
                        item.subTotalCarga = item.factorA * valorAlicuotaCarga;
                        item.alicuotaCarga = valorAlicuotaCarga;

                        item.valorEntregar = item.subTotalIndividual + item.subTotalCarga;


                        if (item.valorEntregar > valorLimiteDistribucionIESS)
                        {
                            item.exedenteIESS = item.valorEntregar - valorLimiteDistribucionIESS;
                            item.valorEntregar = valorLimiteDistribucionIESS;
                        }

                    }

                    gridEmpleados.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }


        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                 pu_Calcular();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void pu_Imprimir()
        {
            try
            {
                if (getInfo())
                {
                    XROL_Rpt008_frm oXROL_Rpt008_frm = new XROL_Rpt008_frm();
                    oXROL_Rpt008_frm.setInfo(_Info.IdEmpresa, _Info.IdPeriodo);
                    oXROL_Rpt008_frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void TxtUtilidadRepartir_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
          {
            try
            {
               

                double UtilidadPorCargas=0;
                double UtilidadIndividual=0;

                UtilidadPorCargas = Convert.ToDouble(TxtUtilidadRepartir.Text) * 0.05;
                UtilidadIndividual = Convert.ToDouble(TxtUtilidadRepartir.Text) * 0.10;


                txtUtilidadPorDerechoIndividual.Text = Convert.ToString(UtilidadIndividual);

                txtUtilidadPorCargaFamiliar.Text = Convert.ToString(UtilidadPorCargas);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void TxtUtilidadRepartir_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (e.KeyChar == 46)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        public void SetAccion(Cl_Enumeradores.eTipo_action Acion)
        {

            Accion = Acion;

            switch (Acion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:



                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    break;
                case Cl_Enumeradores.eTipo_action.duplicar:
                    break;
                default:
                    break;
            }
        }

        public void Set(ro_Participacion_Utilidad_Info info_ut)
        {
            string sm="";
            try
            {
                txtUtilidadPorCargaFamiliar.Text =Convert.ToString( info_ut.UtilidadCargaFamiliar);
                txtUtilidadPorDerechoIndividual.Text =Convert.ToString( info_ut.UtilidadDerechoIndividual);
                cmbnomina.EditValue = info_ut.IdNomina;
                cmbnominaTipo.EditValue = info_ut.IdNominaTipo_liq;
                cmbPeriodos.EditValue = info_ut.IdPeriodo;
                textBox1.Text = info_ut.Observacion;
                cmbPeriodos.EditValue =Convert.ToString( info_ut.IdPeriodo);
                info_ut.oListRo_Participacion_Utilidad_Empleado_Info=  oRo_Participacion_Utilidad_Empleado_Bus.GetListPorIdPeriodo(param.IdEmpresa, info_ut.IdUtilidad, ref sm);
                gridEmpleados.DataSource = info_ut.oListRo_Participacion_Utilidad_Empleado_Info;


                double valorUtilidadIndividual = 0;
                double valorUtilidadCarga = 0;
                double valorTotalDiasTrab = 0;
                double valorAlicuotaIndividual = 0;
                double valorAlicuotaCarga = 0;
                double valorLimiteDistribucionIESS = 0;
                double factorB = 0;

                valorUtilidadIndividual = Convert.ToDouble(txtUtilidadPorDerechoIndividual.Text);
                valorUtilidadCarga = Convert.ToDouble(txtUtilidadPorCargaFamiliar.Text);
                valorTotalDiasTrab = Convert.ToDouble(colDiasTrab.SummaryText);

                valorAlicuotaIndividual = valorUtilidadIndividual / valorTotalDiasTrab;

                //CALCULAR UTILIDAD POR DERECHO INDIVIDUAL
                foreach (ro_Participacion_Utilidad_Empleado_Info item in info_ut.oListRo_Participacion_Utilidad_Empleado_Info)
                {

                    item.alicuotaIndividual = valorAlicuotaIndividual;
                    item.subTotalIndividual = item.DiasTrabajados * valorAlicuotaIndividual;

                    item.valorEntregar = item.subTotalIndividual + item.subTotalCarga;

                    if (item.cargas > 0)
                    {
                        item.diasTrabAnual = item.diasTrabajo;
                        item.factorA = item.cargas * item.diasTrabajo;
                        factorB += item.factorA;
                    }
                }

                if (factorB > 0) { valorAlicuotaCarga = valorUtilidadCarga / factorB; }
                else
                {
                    valorAlicuotaCarga = 0;
                }


                //CALCULAR UTILIDAD POR CARGA FAMILIAR
                foreach (ro_Participacion_Utilidad_Empleado_Info item in info_ut.oListRo_Participacion_Utilidad_Empleado_Info)
                {
                    item.subTotalCarga = item.factorA * valorAlicuotaCarga;
                    item.alicuotaCarga = valorAlicuotaCarga;

                    item.valorEntregar = item.subTotalIndividual + item.subTotalCarga;


                    if (item.valorEntregar > valorLimiteDistribucionIESS)
                    {
                        item.exedenteIESS = item.valorEntregar - valorLimiteDistribucionIESS;
                        item.valorEntregar = valorLimiteDistribucionIESS;
                    }

                }

                gridEmpleados.RefreshDataSource();





            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbRuta_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                //Te Declaras un Objeto de Tipo OpenFileDialog
                OpenFileDialog dialogo = new OpenFileDialog();
                dialogo.Filter = "All files (*.csv*)|*.csv*";
                dialogo.InitialDirectory = @"C:\";
                //para mostrar el cuadro de seleccion de archivo hacemos asi:
                if (dialogo.ShowDialog() == DialogResult.OK)
                {
                    cmbRuta.Text = System.IO.Path.GetFileName(dialogo.FileName);
                    cmbRuta.Text = dialogo.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void CmbGenerar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        public void Set_Valor_Archivo_transferencia(ro_Participacion_Utilidad_Info info)
        {
            try
            {

                
                decimal idArchivo=0;string msg="";
                rol_info.IdEmpresa = param.IdEmpresa;
                rol_info.IdNominaTipo = 3;
                rol_info.IdNominaTipoLiqui = 1;
                rol_info.IdPeriodo =(int) cmbPeriodos.EditValue;
                rol_info.Descripcion = "";
                rol_info.FechaIngresa = DateTime.Now;
                rol_info.UsuarioIngresa = param.IdUsuario;
             

                if (rol_bus.GuardarBD(rol_info, ref msg))
                {// elimina el detalle
                    rol_rol_detalle_bus.EliminarBD(param.IdEmpresa, 3, 1,Convert.ToInt32( cmbPeriodos.EditValue));
                    foreach (var item in info.oListRo_Participacion_Utilidad_Empleado_Info)
                    {
                        ro_Rol_Detalle_Info info_detalle_rol = new ro_Rol_Detalle_Info();
                        info_detalle_rol.IdEmpresa = param.IdEmpresa;
                        info_detalle_rol.IdNominaTipo = 3;
                        info_detalle_rol.IdNominaTipoLiqui = 1;
                        info_detalle_rol.IdPeriodo =(int) cmbPeriodos.EditValue;
                        info_detalle_rol.IdEmpleado = item.IdEmpleado;

                        info_detalle_rol.IdRubro="550";
                        info_detalle_rol.Orden = 1;
                        info_detalle_rol.rub_visible_reporte = true;
                        info_detalle_rol.Observacion = "pago utilidad";
                        info_detalle_rol.Valor = item.ValorTotal;
                        rol_rol_detalle_bus.GrabarBD(info_detalle_rol, ref msg);
                    }

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
                cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;

            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbnominaTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                listadoPeriodo = periodo_nomina_bus.ConsultaPerNomTipLiq(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue), Convert.ToInt32(cmbnominaTipo.EditValue));
                cmbPeriodos.Properties.DataSource = listadoPeriodo.Where(v => v.Cerrado == "N" && v.Contabilizado == "N").ToList();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant_event_btnImprimir_guia_Click(object sender, EventArgs e)
        {
            try
            {
                viewEmpleados.ShowPrintPreview();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
