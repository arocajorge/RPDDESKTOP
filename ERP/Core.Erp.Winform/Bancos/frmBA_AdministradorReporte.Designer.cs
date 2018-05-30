namespace Core.Erp.Winform.Bancos
{
    partial class frmBA_AdministradorReporte
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
            this.ucGe_Admin = new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.frmGe_Esperar), true, true);
            this.SuspendLayout();
            // 
            // ucGe_Admin
            // 
            this.ucGe_Admin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGe_Admin.FormMain = null;
            this.ucGe_Admin.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Admin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Admin.Name = "ucGe_Admin";
            this.ucGe_Admin.Size = new System.Drawing.Size(1104, 687);
            this.ucGe_Admin.TabIndex = 0;
            this.ucGe_Admin.event_ucGe_Menu_event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte.delegate_ucGe_Menu_event_btnSalir_ItemClick(this.ucGe_Admin_event_ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Admin.event_delegate_mostrar_espera += new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte.delegate_mostrar_espera(this.ucGe_Admin_event_delegate_mostrar_espera);
            this.ucGe_Admin.event_delegate_cerrar_espera += new Core.Erp.Winform.Controles.UCGe_Administrador_Reporte.delegate_cerrar_espera(this.ucGe_Admin_event_delegate_cerrar_espera);
            // 
            // frmBA_AdministradorReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 687);
            this.Controls.Add(this.ucGe_Admin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBA_AdministradorReporte";
            this.Text = "frmBA_AdministradorReporte";
            this.Load += new System.EventHandler(this.frmBA_AdministradorReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Administrador_Reporte ucGe_Admin;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}