﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_AdministradorReporte : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_modulo_Bus busModulo = new tb_modulo_Bus();
        List<tb_modulo_Info> lstModulo = new List<tb_modulo_Info>();

        public frmFa_AdministradorReporte()
        {
            InitializeComponent();
        }

        private void frmFa_AdministradorReporte_Load(object sender, EventArgs e)
        {
            try
            {
                lstModulo = busModulo.Get_list_Modulo("FAC");
                ucGe_Admin.FormMain =this.MdiParent;
                ucGe_Admin.set_UCGe_Administrador_Reporte(lstModulo);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Admin_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Admin_event_ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Admin_event_delegate_mostrar_espera()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Admin_event_delegate_cerrar_espera()
        {
            try
            {
                if (splashScreenManager1.IsSplashFormVisible)
                {
                    splashScreenManager1.CloseWaitForm();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
