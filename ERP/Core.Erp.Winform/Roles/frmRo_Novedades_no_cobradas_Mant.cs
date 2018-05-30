using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Novedades_no_cobradas_Mant : Form
    {

        #region Declaracion Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_Empleado_Novedad_Bus OEmpDCabecera = new ro_Empleado_Novedad_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_contrato_Info> listCon = new List<ro_contrato_Info>();
        BindingList<ro_Empleado_Novedad_Info> detalle = new BindingList<ro_Empleado_Novedad_Info>();
        List<ro_Empleado_Novedad_Det_Info> detalle_actaualizar = new List<ro_Empleado_Novedad_Det_Info>();
        ro_Empleado_Novedad_Det_Bus bus_novedad_det = new ro_Empleado_Novedad_Det_Bus();
        #endregion


        public frmRo_Novedades_no_cobradas_Mant()
        {
            try
            {
                InitializeComponent();
                    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_Novedades_no_cobradas_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                 load_datos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void load_datos()
        {
            try
            {
                detalle = new BindingList<ro_Empleado_Novedad_Info>(OEmpDCabecera.Get_List_novedades_no_cobradas(param.IdEmpresa, Convert.ToDateTime(dtp_fecha_corte.EditValue)));
                grdLista.DataSource = detalle;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView.GetRow(e.RowHandle) as ro_Empleado_Novedad_Info;
                if (data == null)
                    return;
                if (data.InfoNovedadDet.Estado == "I" )
                    e.Appearance.ForeColor = Color.Red;

                if (data.InfoNovedadDet.EstadoCobro == "CAN")
                    e.Appearance.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            ucGe_Menu.Focus();
            detalle_actaualizar = new List<ro_Empleado_Novedad_Det_Info>();
            foreach (var item in detalle)
            {
                ro_Empleado_Novedad_Det_Info info = new ro_Empleado_Novedad_Det_Info();
                info.IdEmpresa = item.IdEmpresa;
                info.IdEmpleado = item.IdEmpleado;
                info.IdNovedad = item.IdNovedad;
                info.Secuencia =Convert.ToInt32( item.Secuencia);
                info.FechaPago = item.InfoNovedadDet.FechaPago;
                info.EstadoCobro = "PEN";

                bus_novedad_det.ModificarDB(info);
            }

            MessageBox.Show("Registros actualizados correctamente",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            gridView.ShowPrintPreview();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            load_datos();
        }

        public void set( DateTime fecha)
        {
            try
            {
                dtp_fecha_corte.EditValue = fecha;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
