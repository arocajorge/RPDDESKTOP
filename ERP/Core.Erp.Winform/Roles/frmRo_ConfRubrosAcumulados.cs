using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Recursos;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_ConfRubrosAcumulados : Form
    {

        #region Declaracion Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ro_rubro_tipo_Bus OCBUS2 = new ro_rubro_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        #endregion

        public frmRo_ConfRubrosAcumulados()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
              ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }      

        private void frmRo_ConfRubrosAcumulados_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView.DeleteSelectedRows();

                  }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }

        }

        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e){}

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                        //for (int i = 0; i < gridView.RowCount ; i++)
                    //{

                    //    ro_ConfRubrosAcumulado_Info info1 = (ro_ConfRubrosAcumulado_Info)gridView.GetRow(i);

                    //    ro_ConfRubrosAcumulado_Info info2 = (ro_ConfRubrosAcumulado_Info)gridView.GetRow(i + 1);

                    //    if (info2.IdRubro == info1.IdRubro)
                    //    {
                    //        //MessageBox.Show("La fecha : " + info2.FechaPago + "  de la cuota # " + info2.NumCuota + " , no puede ser menor a la fecha de pago de la cuota  #  " + info1.NumCuota + " . Por favor ingrese una fecha válida..... ", " Sistemas");
                    //        MessageBox.Show("iguales");
                    //       // return false;
                    //    }

                    //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

       


    }
}
