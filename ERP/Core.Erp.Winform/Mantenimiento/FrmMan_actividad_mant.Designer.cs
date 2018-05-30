namespace Core.Erp.Winform.Mantenimiento
{
    partial class FrmMan_actividad_mant
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.lbl_anulado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ac_descripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ac_codigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_IdActividad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ac_observacion = new DevExpress.XtraEditors.MemoEdit();
            this.gridControl_actividades = new DevExpress.XtraGrid.GridControl();
            this.gridView_actividades = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_actividades = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_cant_horas_min = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ac_descripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ac_codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdActividad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ac_observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_actividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_actividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_actividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cant_horas_min.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_cant_horas_min);
            this.panelControl1.Controls.Add(this.menu);
            this.panelControl1.Controls.Add(this.lbl_anulado);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txt_ac_descripcion);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txt_ac_codigo);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txt_IdActividad);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_ac_observacion);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(723, 224);
            this.panelControl1.TabIndex = 0;
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
            this.menu.Location = new System.Drawing.Point(2, 2);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(719, 36);
            this.menu.TabIndex = 9;
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
            // lbl_anulado
            // 
            this.lbl_anulado.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_anulado.Location = new System.Drawing.Point(302, 50);
            this.lbl_anulado.Name = "lbl_anulado";
            this.lbl_anulado.Size = new System.Drawing.Size(115, 28);
            this.lbl_anulado.TabIndex = 8;
            this.lbl_anulado.Text = "ANULADO";
            this.lbl_anulado.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 16);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Observación";
            // 
            // txt_ac_descripcion
            // 
            this.txt_ac_descripcion.Location = new System.Drawing.Point(125, 103);
            this.txt_ac_descripcion.Name = "txt_ac_descripcion";
            this.txt_ac_descripcion.Size = new System.Drawing.Size(560, 22);
            this.txt_ac_descripcion.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Descripción *";
            // 
            // txt_ac_codigo
            // 
            this.txt_ac_codigo.Location = new System.Drawing.Point(125, 75);
            this.txt_ac_codigo.Name = "txt_ac_codigo";
            this.txt_ac_codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_ac_codigo.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Código *";
            // 
            // txt_IdActividad
            // 
            this.txt_IdActividad.Location = new System.Drawing.Point(125, 47);
            this.txt_IdActividad.Name = "txt_IdActividad";
            this.txt_IdActividad.Properties.ReadOnly = true;
            this.txt_IdActividad.Size = new System.Drawing.Size(100, 22);
            this.txt_IdActividad.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID";
            // 
            // txt_ac_observacion
            // 
            this.txt_ac_observacion.Location = new System.Drawing.Point(125, 131);
            this.txt_ac_observacion.Name = "txt_ac_observacion";
            this.txt_ac_observacion.Size = new System.Drawing.Size(560, 75);
            this.txt_ac_observacion.TabIndex = 7;
            // 
            // gridControl_actividades
            // 
            this.gridControl_actividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_actividades.Location = new System.Drawing.Point(0, 224);
            this.gridControl_actividades.MainView = this.gridView_actividades;
            this.gridControl_actividades.Name = "gridControl_actividades";
            this.gridControl_actividades.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_actividades});
            this.gridControl_actividades.Size = new System.Drawing.Size(723, 278);
            this.gridControl_actividades.TabIndex = 1;
            this.gridControl_actividades.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_actividades});
            // 
            // gridView_actividades
            // 
            this.gridView_actividades.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4});
            this.gridView_actividades.GridControl = this.gridControl_actividades;
            this.gridView_actividades.Name = "gridView_actividades";
            this.gridView_actividades.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_actividades.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_actividades.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_actividades.OptionsView.ShowGroupPanel = false;
            this.gridView_actividades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_actividades_KeyDown);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Actividad";
            this.gridColumn4.ColumnEdit = this.cmb_actividades;
            this.gridColumn4.FieldName = "IdActividad_hijo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // cmb_actividades
            // 
            this.cmb_actividades.AutoHeight = false;
            this.cmb_actividades.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_actividades.DisplayMember = "ac_descripcion";
            this.cmb_actividades.Name = "cmb_actividades";
            this.cmb_actividades.ValueMember = "IdActividad";
            this.cmb_actividades.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdActividad";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 225;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Actividad";
            this.gridColumn2.FieldName = "ac_descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 1270;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Código";
            this.gridColumn3.FieldName = "ac_codigo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 239;
            // 
            // txt_cant_horas_min
            // 
            this.txt_cant_horas_min.Location = new System.Drawing.Point(585, 72);
            this.txt_cant_horas_min.Name = "txt_cant_horas_min";
            this.txt_cant_horas_min.Properties.Mask.EditMask = "n2";
            this.txt_cant_horas_min.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_cant_horas_min.Size = new System.Drawing.Size(100, 22);
            this.txt_cant_horas_min.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(443, 75);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(124, 16);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Cant. horas mínimo *";
            // 
            // FrmMan_actividad_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 502);
            this.Controls.Add(this.gridControl_actividades);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmMan_actividad_mant";
            this.Text = "Mantenimiento de actividades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMan_actividad_mant_FormClosed);
            this.Load += new System.EventHandler(this.FrmMan_actividad_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ac_descripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ac_codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdActividad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ac_observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_actividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_actividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_actividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cant_horas_min.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl_actividades;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_actividades;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_actividades;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_ac_descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_ac_codigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_IdActividad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txt_ac_observacion;
        private DevExpress.XtraEditors.LabelControl lbl_anulado;
        private Controles.UCGe_Menu_Superior_Mant menu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_cant_horas_min;
    }
}