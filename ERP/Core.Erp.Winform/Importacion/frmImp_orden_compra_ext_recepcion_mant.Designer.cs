namespace Core.Erp.Winform.Importacion
{
    partial class frmImp_orden_compra_ext_recepcion_mant
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_observacion = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.de_fecha = new DevExpress.XtraEditors.DateEdit();
            this.cmb_orden_compra_externa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_det = new DevExpress.XtraGrid.GridControl();
            this.gridView_det = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_producto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cantidad_recibida = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_orden_compra_externa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.menu.Size = new System.Drawing.Size(820, 27);
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
            this.menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.menu_event_btnSalir_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_observacion);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.de_fecha);
            this.panelControl1.Controls.Add(this.cmb_orden_compra_externa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 27);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(820, 118);
            this.panelControl1.TabIndex = 1;
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(124, 48);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(620, 58);
            this.txt_observacion.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Observación";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "OC externa";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(576, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Fecha *";
            // 
            // de_fecha
            // 
            this.de_fecha.EditValue = null;
            this.de_fecha.Location = new System.Drawing.Point(644, 20);
            this.de_fecha.Name = "de_fecha";
            this.de_fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_fecha.Size = new System.Drawing.Size(100, 22);
            this.de_fecha.TabIndex = 1;
            // 
            // cmb_orden_compra_externa
            // 
            this.cmb_orden_compra_externa.Location = new System.Drawing.Point(124, 20);
            this.cmb_orden_compra_externa.Name = "cmb_orden_compra_externa";
            this.cmb_orden_compra_externa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_orden_compra_externa.Properties.DisplayMember = "oe_observacion";
            this.cmb_orden_compra_externa.Properties.ValueMember = "IdOrdenCompra_ext";
            this.cmb_orden_compra_externa.Properties.View = this.searchLookUpEdit1View;
            this.cmb_orden_compra_externa.Size = new System.Drawing.Size(300, 22);
            this.cmb_orden_compra_externa.TabIndex = 0;
            this.cmb_orden_compra_externa.EditValueChanged += new System.EventHandler(this.cmb_orden_compra_externa_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "# Oc ext";
            this.gridColumn4.FieldName = "IdOrdenCompra_ext";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 167;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fecha";
            this.gridColumn5.FieldName = "oe_fecha";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 206;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Observación";
            this.gridColumn6.FieldName = "oe_observacion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 1361;
            // 
            // gridControl_det
            // 
            this.gridControl_det.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_det.Location = new System.Drawing.Point(0, 145);
            this.gridControl_det.MainView = this.gridView_det;
            this.gridControl_det.Name = "gridControl_det";
            this.gridControl_det.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_producto,
            this.cmb_unidad_medida});
            this.gridControl_det.Size = new System.Drawing.Size(820, 467);
            this.gridControl_det.TabIndex = 2;
            this.gridControl_det.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_det});
            // 
            // gridView_det
            // 
            this.gridView_det.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.col_cantidad_recibida});
            this.gridView_det.GridControl = this.gridControl_det;
            this.gridView_det.Name = "gridView_det";
            this.gridView_det.OptionsView.ShowFooter = true;
            this.gridView_det.OptionsView.ShowGroupPanel = false;
            this.gridView_det.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_det_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Producto";
            this.gridColumn1.ColumnEdit = this.cmb_producto;
            this.gridColumn1.FieldName = "IdProducto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 729;
            // 
            // cmb_producto
            // 
            this.cmb_producto.AutoHeight = false;
            this.cmb_producto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_producto.DisplayMember = "pr_descripcion";
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.ValueMember = "IdProducto";
            this.cmb_producto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "U. medida";
            this.gridColumn2.ColumnEdit = this.cmb_unidad_medida;
            this.gridColumn2.FieldName = "IdUnidadMedida";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 502;
            // 
            // cmb_unidad_medida
            // 
            this.cmb_unidad_medida.AutoHeight = false;
            this.cmb_unidad_medida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_unidad_medida.DisplayMember = "Descripcion";
            this.cmb_unidad_medida.Name = "cmb_unidad_medida";
            this.cmb_unidad_medida.ValueMember = "IdUnidadMedida";
            this.cmb_unidad_medida.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cantidad";
            this.gridColumn3.FieldName = "od_cantidad";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "od_cantidad", "{0:n2}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 250;
            // 
            // col_cantidad_recibida
            // 
            this.col_cantidad_recibida.Caption = "Cantidad recibida";
            this.col_cantidad_recibida.FieldName = "od_cantidad_recepcion";
            this.col_cantidad_recibida.Name = "col_cantidad_recibida";
            this.col_cantidad_recibida.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "od_cantidad_recepcion", "{0:n2}")});
            this.col_cantidad_recibida.Visible = true;
            this.col_cantidad_recibida.VisibleIndex = 3;
            this.col_cantidad_recibida.Width = 253;
            // 
            // frmImp_orden_compra_ext_recepcion_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 612);
            this.Controls.Add(this.gridControl_det);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.menu);
            this.Name = "frmImp_orden_compra_ext_recepcion_mant";
            this.Text = "Recepción de orden de compra exterior";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmImp_orden_compra_ext_recepcion_mant_FormClosed);
            this.Load += new System.EventHandler(this.frmImp_orden_compra_ext_recepcion_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_orden_compra_externa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant menu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl_det;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_det;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_producto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn col_cantidad_recibida;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_orden_compra_externa;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit de_fecha;
        private DevExpress.XtraEditors.MemoEdit txt_observacion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}