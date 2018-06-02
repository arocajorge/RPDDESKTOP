namespace Core.Erp.Winform.Caja
{
    partial class FrmCa_Caja_AdministradorReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucGe_Administrador_Reporte1 = new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.frmGe_Esperar), true, true);
            this.SuspendLayout();
            // 
            // ucGe_Administrador_Reporte1
            // 
            this.ucGe_Administrador_Reporte1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGe_Administrador_Reporte1.FormMain = null;
            this.ucGe_Administrador_Reporte1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Administrador_Reporte1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Administrador_Reporte1.Name = "ucGe_Administrador_Reporte1";
            this.ucGe_Administrador_Reporte1.Size = new System.Drawing.Size(1104, 687);
            this.ucGe_Administrador_Reporte1.TabIndex = 0;
            this.ucGe_Administrador_Reporte1.event_ucGe_Menu_event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte.delegate_ucGe_Menu_event_btnSalir_ItemClick(this.ucGe_Administrador_Reporte1_event_ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Administrador_Reporte1.event_delegate_mostrar_espera += new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte.delegate_mostrar_espera(this.ucGe_Admin_event_delegate_mostrar_espera);
            this.ucGe_Administrador_Reporte1.event_delegate_cerrar_espera += new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte.delegate_cerrar_espera(this.ucGe_Admin_event_delegate_cerrar_espera);
            // 
            // FrmCa_Caja_AdministradorReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 687);
            this.Controls.Add(this.ucGe_Administrador_Reporte1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCa_Caja_AdministradorReporte";
            this.Text = "FrmCa_Caja_AdministradorReporte";
            this.Load += new System.EventHandler(this.FrmCa_Caja_AdministradorReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Administrador_Reporte ucGe_Administrador_Reporte1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}