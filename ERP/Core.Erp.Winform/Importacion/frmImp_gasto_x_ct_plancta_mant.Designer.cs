namespace Core.Erp.Winform.Importacion
{
    partial class frmImp_gasto_x_ct_plancta_mant
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
            this.menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_IdGastoTipo = new DevExpress.XtraEditors.TextEdit();
            this.txt_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_plancta = new Core.Erp.Winform.Controles.UCCon_Plan_de_Cuenta_x_Movimiento();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdGastoTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Enabled_bnRetImprimir = true;
            this.menu.Enabled_bntAnular = true;
            this.menu.Enabled_bntAprobar = true;
            this.menu.Enabled_bntGuardar_y_Salir = true;
            this.menu.Enabled_bntImprimir = true;
            this.menu.Enabled_bntImprimir_Guia = true;
            this.menu.Enabled_bntLimpiar = true;
            this.menu.Enabled_bntSalir = true;
            this.menu.Enabled_btn_conciliacion_Auto = true;
            this.menu.Enabled_btn_DiseñoReporte = true;
            this.menu.Enabled_btn_Generar_XML = true;
            this.menu.Enabled_btn_Imprimir_Cbte = true;
            this.menu.Enabled_btn_Imprimir_Cheq = true;
            this.menu.Enabled_btn_Imprimir_Reten = true;
            this.menu.Enabled_btnAceptar = true;
            this.menu.Enabled_btnAprobarGuardarSalir = true;
            this.menu.Enabled_btnEstadosOC = true;
            this.menu.Enabled_btnGuardar = true;
            this.menu.Enabled_btnImpFrm = true;
            this.menu.Enabled_btnImpLote = true;
            this.menu.Enabled_btnImpRep = true;
            this.menu.Enabled_btnImprimirSoporte = true;
            this.menu.Enabled_btnproductos = true;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(523, 29);
            this.menu.TabIndex = 0;
            this.menu.Visible_bntAnular = false;
            this.menu.Visible_bntAprobar = false;
            this.menu.Visible_bntDiseñoReporte = false;
            this.menu.Visible_bntGuardar_y_Salir = true;
            this.menu.Visible_bntImprimir = false;
            this.menu.Visible_bntImprimir_Guia = false;
            this.menu.Visible_bntLimpiar = true;
            this.menu.Visible_bntReImprimir = false;
            this.menu.Visible_bntSalir = true;
            this.menu.Visible_btn_Actualizar = false;
            this.menu.Visible_btn_conciliacion_Auto = false;
            this.menu.Visible_btn_Generar_XML = false;
            this.menu.Visible_btn_Imprimir_Cbte = false;
            this.menu.Visible_btn_Imprimir_Cheq = false;
            this.menu.Visible_btn_Imprimir_Reten = false;
            this.menu.Visible_btnAceptar = false;
            this.menu.Visible_btnAprobarGuardarSalir = false;
            this.menu.Visible_btnContabilizar = false;
            this.menu.Visible_btnEstadosOC = false;
            this.menu.Visible_btnGuardar = true;
            this.menu.Visible_btnImpFrm = false;
            this.menu.Visible_btnImpLote = false;
            this.menu.Visible_btnImpRep = false;
            this.menu.Visible_btnImprimirSoporte = false;
            this.menu.Visible_btnModificar = false;
            this.menu.Visible_btnproductos = false;
            this.menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.menu_event_btnGuardar_Click);
            this.menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.menu_event_btnGuardar_y_Salir_Click);
            this.menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.menu_event_btnlimpiar_Click);
            this.menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.menu_event_btnSalir_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID";
            // 
            // txt_IdGastoTipo
            // 
            this.txt_IdGastoTipo.Location = new System.Drawing.Point(130, 43);
            this.txt_IdGastoTipo.Name = "txt_IdGastoTipo";
            this.txt_IdGastoTipo.Properties.ReadOnly = true;
            this.txt_IdGastoTipo.Size = new System.Drawing.Size(100, 22);
            this.txt_IdGastoTipo.TabIndex = 2;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(130, 71);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(300, 22);
            this.txt_descripcion.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 74);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Descripción";
            // 
            // cmb_plancta
            // 
            this.cmb_plancta.Location = new System.Drawing.Point(126, 96);
            this.cmb_plancta.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_plancta.Name = "cmb_plancta";
            this.cmb_plancta.Size = new System.Drawing.Size(420, 28);
            this.cmb_plancta.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Cta cble";
            // 
            // frmImp_gasto_x_ct_plancta_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 154);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmb_plancta);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_IdGastoTipo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.menu);
            this.Name = "frmImp_gasto_x_ct_plancta_mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos de importación";
            this.Load += new System.EventHandler(this.frmImp_gasto_x_ct_plancta_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdGastoTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant menu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_IdGastoTipo;
        private DevExpress.XtraEditors.TextEdit txt_descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Controles.UCCon_Plan_de_Cuenta_x_Movimiento cmb_plancta;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}