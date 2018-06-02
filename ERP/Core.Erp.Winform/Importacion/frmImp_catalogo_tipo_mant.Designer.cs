namespace Core.Erp.Winform.Importacion
{
    partial class frmImp_catalogo_tipo_mant
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_IdCatalogo_tipo = new DevExpress.XtraEditors.TextEdit();
            this.txt_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.uc_menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.lbl_anulado = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdCatalogo_tipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // txt_IdCatalogo_tipo
            // 
            this.txt_IdCatalogo_tipo.Location = new System.Drawing.Point(125, 63);
            this.txt_IdCatalogo_tipo.Name = "txt_IdCatalogo_tipo";
            this.txt_IdCatalogo_tipo.Properties.ReadOnly = true;
            this.txt_IdCatalogo_tipo.Size = new System.Drawing.Size(100, 22);
            this.txt_IdCatalogo_tipo.TabIndex = 1;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(125, 91);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(371, 22);
            this.txt_descripcion.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descripción";
            // 
            // uc_menu
            // 
            this.uc_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_menu.Enabled_bnRetImprimir = true;
            this.uc_menu.Enabled_bntAnular = true;
            this.uc_menu.Enabled_bntAprobar = true;
            this.uc_menu.Enabled_bntGuardar_y_Salir = true;
            this.uc_menu.Enabled_bntImprimir = true;
            this.uc_menu.Enabled_bntImprimir_Guia = true;
            this.uc_menu.Enabled_bntLimpiar = true;
            this.uc_menu.Enabled_bntSalir = true;
            this.uc_menu.Enabled_btn_conciliacion_Auto = true;
            this.uc_menu.Enabled_btn_DiseñoReporte = true;
            this.uc_menu.Enabled_btn_Generar_XML = true;
            this.uc_menu.Enabled_btn_Imprimir_Cbte = true;
            this.uc_menu.Enabled_btn_Imprimir_Cheq = true;
            this.uc_menu.Enabled_btn_Imprimir_Reten = true;
            this.uc_menu.Enabled_btnAceptar = true;
            this.uc_menu.Enabled_btnAprobarGuardarSalir = true;
            this.uc_menu.Enabled_btnEstadosOC = true;
            this.uc_menu.Enabled_btnGuardar = true;
            this.uc_menu.Enabled_btnImpFrm = true;
            this.uc_menu.Enabled_btnImpLote = true;
            this.uc_menu.Enabled_btnImpRep = true;
            this.uc_menu.Enabled_btnImprimirSoporte = true;
            this.uc_menu.Enabled_btnproductos = true;
            this.uc_menu.Location = new System.Drawing.Point(0, 0);
            this.uc_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uc_menu.Name = "uc_menu";
            this.uc_menu.Size = new System.Drawing.Size(571, 28);
            this.uc_menu.TabIndex = 4;
            this.uc_menu.Visible_bntAnular = true;
            this.uc_menu.Visible_bntAprobar = false;
            this.uc_menu.Visible_bntDiseñoReporte = false;
            this.uc_menu.Visible_bntGuardar_y_Salir = true;
            this.uc_menu.Visible_bntImprimir = false;
            this.uc_menu.Visible_bntImprimir_Guia = false;
            this.uc_menu.Visible_bntLimpiar = true;
            this.uc_menu.Visible_bntReImprimir = false;
            this.uc_menu.Visible_bntSalir = true;
            this.uc_menu.Visible_btn_Actualizar = false;
            this.uc_menu.Visible_btn_conciliacion_Auto = false;
            this.uc_menu.Visible_btn_Generar_XML = false;
            this.uc_menu.Visible_btn_Imprimir_Cbte = false;
            this.uc_menu.Visible_btn_Imprimir_Cheq = false;
            this.uc_menu.Visible_btn_Imprimir_Reten = false;
            this.uc_menu.Visible_btnAceptar = false;
            this.uc_menu.Visible_btnAprobarGuardarSalir = false;
            this.uc_menu.Visible_btnContabilizar = false;
            this.uc_menu.Visible_btnEstadosOC = false;
            this.uc_menu.Visible_btnGuardar = true;
            this.uc_menu.Visible_btnImpFrm = false;
            this.uc_menu.Visible_btnImpLote = false;
            this.uc_menu.Visible_btnImpRep = false;
            this.uc_menu.Visible_btnImprimirSoporte = false;
            this.uc_menu.Visible_btnModificar = false;
            this.uc_menu.Visible_btnproductos = false;
            this.uc_menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.uc_menu_event_btnGuardar_Click);
            this.uc_menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.uc_menu_event_btnGuardar_y_Salir_Click);
            this.uc_menu.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.uc_menu_event_btnlimpiar_Click);
            this.uc_menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.uc_menu_event_btnAnular_Click);
            this.uc_menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.uc_menu_event_btnSalir_Click);
            // 
            // lbl_anulado
            // 
            this.lbl_anulado.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_anulado.Location = new System.Drawing.Point(254, 54);
            this.lbl_anulado.Name = "lbl_anulado";
            this.lbl_anulado.Size = new System.Drawing.Size(115, 28);
            this.lbl_anulado.TabIndex = 5;
            this.lbl_anulado.Text = "ANULADO";
            this.lbl_anulado.Visible = false;
            // 
            // frmImp_catalogo_tipo_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 133);
            this.Controls.Add(this.lbl_anulado);
            this.Controls.Add(this.uc_menu);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_IdCatalogo_tipo);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmImp_catalogo_tipo_mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo tipo";
            this.Load += new System.EventHandler(this.frmImp_catalogo_tipo_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdCatalogo_tipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_descripcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_IdCatalogo_tipo;
        private DevExpress.XtraEditors.TextEdit txt_descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Controles.UCGe_Menu_Superior_Mant uc_menu;
        private DevExpress.XtraEditors.LabelControl lbl_anulado;
    }
}