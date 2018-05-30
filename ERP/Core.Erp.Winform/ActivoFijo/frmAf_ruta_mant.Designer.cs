namespace Core.Erp.Winform.ActivoFijo
{
    partial class frmAf_ruta_mant
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
            this.txt_IdRuta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_observacion = new DevExpress.XtraEditors.MemoEdit();
            this.txt_kms = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdRuta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kms.Properties)).BeginInit();
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
            this.menu.Size = new System.Drawing.Size(889, 36);
            this.menu.TabIndex = 0;
            this.menu.Visible_bntAnular = true;
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
            this.menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.menu_event_btnAnular_Click);
            this.menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // txt_IdRuta
            // 
            this.txt_IdRuta.Location = new System.Drawing.Point(160, 73);
            this.txt_IdRuta.Name = "txt_IdRuta";
            this.txt_IdRuta.Properties.ReadOnly = true;
            this.txt_IdRuta.Size = new System.Drawing.Size(100, 22);
            this.txt_IdRuta.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "IdRuta";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Descripcion: *";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(160, 101);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(561, 22);
            this.txt_descripcion.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Kms: *";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(51, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Observacion:";
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(160, 157);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(561, 83);
            this.txt_observacion.TabIndex = 7;
            // 
            // txt_kms
            // 
            this.txt_kms.Location = new System.Drawing.Point(160, 129);
            this.txt_kms.Name = "txt_kms";
            this.txt_kms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txt_kms.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_kms.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_kms.Size = new System.Drawing.Size(100, 22);
            this.txt_kms.TabIndex = 5;
            // 
            // frmAf_ruta_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 471);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_IdRuta);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.txt_observacion);
            this.Controls.Add(this.txt_kms);
            this.Name = "frmAf_ruta_mant";
            this.Text = "frmAf_ruta_mant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAf_ruta_mant_FormClosed);
            this.Load += new System.EventHandler(this.frmAf_ruta_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdRuta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kms.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant menu;
        private DevExpress.XtraEditors.TextEdit txt_IdRuta;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txt_observacion;
        private DevExpress.XtraEditors.SpinEdit txt_kms;
    }
}