namespace Core.Erp.Winform.Mantenimiento
{
    partial class FrmMan_tecnico_mant
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
            this.lbl_anulado = new DevExpress.XtraEditors.LabelControl();
            this.txt_IdTecnico = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_codigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_observacion = new DevExpress.XtraEditors.MemoEdit();
            this.cmb_empleado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdTecnico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_anulado
            // 
            this.lbl_anulado.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_anulado.Location = new System.Drawing.Point(322, 46);
            this.lbl_anulado.Name = "lbl_anulado";
            this.lbl_anulado.Size = new System.Drawing.Size(115, 28);
            this.lbl_anulado.TabIndex = 11;
            this.lbl_anulado.Text = "ANULADO";
            this.lbl_anulado.Visible = false;
            // 
            // txt_IdTecnico
            // 
            this.txt_IdTecnico.Location = new System.Drawing.Point(137, 53);
            this.txt_IdTecnico.Name = "txt_IdTecnico";
            this.txt_IdTecnico.Properties.ReadOnly = true;
            this.txt_IdTecnico.Size = new System.Drawing.Size(100, 22);
            this.txt_IdTecnico.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 16);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "ID";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(137, 81);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_codigo.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 16);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Código *";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 16);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Observación";
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(137, 137);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(560, 75);
            this.txt_observacion.TabIndex = 17;
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.Location = new System.Drawing.Point(137, 109);
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_empleado.Properties.DisplayMember = "InfoPersona.pe_nombreCompleto";
            this.cmb_empleado.Properties.ValueMember = "IdEmpleado";
            this.cmb_empleado.Properties.View = this.searchLookUpEdit1View;
            this.cmb_empleado.Size = new System.Drawing.Size(560, 22);
            this.cmb_empleado.TabIndex = 18;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(45, 112);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 16);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Empleado";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Empleado";
            this.gridColumn1.FieldName = "InfoPersona.pe_nombreCompleto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 1446;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cedula";
            this.gridColumn2.FieldName = "InfoPersona.pe_cedulaRuc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 288;
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
            this.menu.Size = new System.Drawing.Size(835, 36);
            this.menu.TabIndex = 10;
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
            this.menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.menu_event_btnSalir_Click);
            // 
            // FrmMan_tecnico_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 371);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmb_empleado);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_observacion);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_IdTecnico);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lbl_anulado);
            this.Controls.Add(this.menu);
            this.Name = "FrmMan_tecnico_mant";
            this.Text = "Mantenimiento de tecnico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMan_tecnico_mant_FormClosed);
            this.Load += new System.EventHandler(this.FrmMan_tecnico_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdTecnico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant menu;
        private DevExpress.XtraEditors.LabelControl lbl_anulado;
        private DevExpress.XtraEditors.TextEdit txt_IdTecnico;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_codigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txt_observacion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_empleado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}