namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_producto_asignacion_lote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_producto_asignacion_lote));
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmb_producto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_lote = new DevExpress.XtraGrid.GridControl();
            this.gridView_lote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_pr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_lote_codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_lote_fecha_fab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_lote_fecha_vcto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_producto_det = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_alerta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_alerta = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto_det)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_alerta)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Superior_Mant1
            // 
            this.ucGe_Menu_Superior_Mant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant1.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant1.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(993, 36);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnAprobar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAprobar_Click(this.ucGe_Menu_Superior_Mant1_event_btnAprobar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmb_producto);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 36);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(993, 41);
            this.panelControl1.TabIndex = 1;
            // 
            // cmb_producto
            // 
            this.cmb_producto.Location = new System.Drawing.Point(149, 7);
            this.cmb_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_producto.Properties.DisplayMember = "pr_descripcion";
            this.cmb_producto.Properties.ReadOnly = true;
            this.cmb_producto.Properties.ValueMember = "IdProducto";
            this.cmb_producto.Properties.View = this.searchLookUpEdit1View;
            this.cmb_producto.Size = new System.Drawing.Size(519, 22);
            this.cmb_producto.TabIndex = 1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Producto padre";
            // 
            // gridControl_lote
            // 
            this.gridControl_lote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_lote.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_lote.Location = new System.Drawing.Point(0, 77);
            this.gridControl_lote.MainView = this.gridView_lote;
            this.gridControl_lote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_lote.Name = "gridControl_lote";
            this.gridControl_lote.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_producto_det,
            this.cmb_alerta});
            this.gridControl_lote.Size = new System.Drawing.Size(993, 466);
            this.gridControl_lote.TabIndex = 2;
            this.gridControl_lote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_lote});
            // 
            // gridView_lote
            // 
            this.gridView_lote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_pr_descripcion,
            this.col_lote_codigo,
            this.col_lote_fecha_fab,
            this.col_lote_fecha_vcto,
            this.col_IdProducto,
            this.col_cantidad,
            this.col_alerta});
            this.gridView_lote.GridControl = this.gridControl_lote;
            this.gridView_lote.Name = "gridView_lote";
            this.gridView_lote.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_lote.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_lote.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_lote.OptionsView.ShowAutoFilterRow = true;
            this.gridView_lote.OptionsView.ShowGroupPanel = false;
            this.gridView_lote.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_lote_fecha_vcto, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_lote.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_lote_CellValueChanged);
            this.gridView_lote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_lote_KeyDown);
            this.gridView_lote.DoubleClick += new System.EventHandler(this.gridView_lote_DoubleClick);
            // 
            // col_pr_descripcion
            // 
            this.col_pr_descripcion.Caption = "Producto";
            this.col_pr_descripcion.FieldName = "pr_descripcion";
            this.col_pr_descripcion.Name = "col_pr_descripcion";
            this.col_pr_descripcion.Visible = true;
            this.col_pr_descripcion.VisibleIndex = 1;
            this.col_pr_descripcion.Width = 347;
            // 
            // col_lote_codigo
            // 
            this.col_lote_codigo.Caption = "Código lote";
            this.col_lote_codigo.FieldName = "lote_numero";
            this.col_lote_codigo.Name = "col_lote_codigo";
            this.col_lote_codigo.Visible = true;
            this.col_lote_codigo.VisibleIndex = 2;
            this.col_lote_codigo.Width = 124;
            // 
            // col_lote_fecha_fab
            // 
            this.col_lote_fecha_fab.Caption = "Fecha fab.";
            this.col_lote_fecha_fab.DisplayFormat.FormatString = "d";
            this.col_lote_fecha_fab.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_lote_fecha_fab.FieldName = "lote_fecha_fab";
            this.col_lote_fecha_fab.Name = "col_lote_fecha_fab";
            this.col_lote_fecha_fab.Visible = true;
            this.col_lote_fecha_fab.VisibleIndex = 3;
            this.col_lote_fecha_fab.Width = 124;
            // 
            // col_lote_fecha_vcto
            // 
            this.col_lote_fecha_vcto.Caption = "Fecha vcto.";
            this.col_lote_fecha_vcto.DisplayFormat.FormatString = "d";
            this.col_lote_fecha_vcto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_lote_fecha_vcto.FieldName = "lote_fecha_vcto";
            this.col_lote_fecha_vcto.Name = "col_lote_fecha_vcto";
            this.col_lote_fecha_vcto.Visible = true;
            this.col_lote_fecha_vcto.VisibleIndex = 4;
            this.col_lote_fecha_vcto.Width = 130;
            // 
            // col_IdProducto
            // 
            this.col_IdProducto.Caption = "Código";
            this.col_IdProducto.ColumnEdit = this.cmb_producto_det;
            this.col_IdProducto.FieldName = "IdProducto";
            this.col_IdProducto.Name = "col_IdProducto";
            this.col_IdProducto.Visible = true;
            this.col_IdProducto.VisibleIndex = 0;
            this.col_IdProducto.Width = 92;
            // 
            // cmb_producto_det
            // 
            this.cmb_producto_det.AutoHeight = false;
            this.cmb_producto_det.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_producto_det.DisplayMember = "pr_codigo";
            this.cmb_producto_det.Name = "cmb_producto_det";
            this.cmb_producto_det.ValueMember = "IdProducto";
            this.cmb_producto_det.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn2});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Producto";
            this.gridColumn6.FieldName = "pr_descripcion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 387;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ID";
            this.gridColumn7.FieldName = "IdProducto";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 67;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Lote";
            this.gridColumn1.FieldName = "lote_num_lote";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 161;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha exp";
            this.gridColumn2.FieldName = "lote_fecha_vcto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 157;
            // 
            // col_cantidad
            // 
            this.col_cantidad.Caption = "Cantidad";
            this.col_cantidad.DisplayFormat.FormatString = "n2";
            this.col_cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_cantidad.FieldName = "cantidad";
            this.col_cantidad.Name = "col_cantidad";
            this.col_cantidad.Visible = true;
            this.col_cantidad.VisibleIndex = 5;
            this.col_cantidad.Width = 88;
            // 
            // col_alerta
            // 
            this.col_alerta.Caption = "Alerta";
            this.col_alerta.ColumnEdit = this.cmb_alerta;
            this.col_alerta.FieldName = "color_alerta";
            this.col_alerta.Name = "col_alerta";
            this.col_alerta.OptionsColumn.AllowEdit = false;
            this.col_alerta.Visible = true;
            this.col_alerta.VisibleIndex = 6;
            // 
            // cmb_alerta
            // 
            this.cmb_alerta.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_alerta.AutoHeight = false;
            this.cmb_alerta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_alerta.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_alerta.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 0, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 1, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", 2, 2)});
            this.cmb_alerta.LargeImages = this.imageList1;
            this.cmb_alerta.Name = "cmb_alerta";
            this.cmb_alerta.ReadOnly = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "circulo_verde_16x16.png");
            this.imageList1.Images.SetKeyName(1, "circulo_amarillo_16x16.png");
            this.imageList1.Images.SetKeyName(2, "circulo_rojo_16x16.png");
            // 
            // FrmIn_producto_asignacion_lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 543);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl_lote);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIn_producto_asignacion_lote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de lote";
            this.Load += new System.EventHandler(this.FrmIn_producto_asignacion_lote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto_det)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_alerta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_producto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl_lote;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_lote;
        private DevExpress.XtraGrid.Columns.GridColumn col_pr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_lote_codigo;
        private DevExpress.XtraGrid.Columns.GridColumn col_lote_fecha_fab;
        private DevExpress.XtraGrid.Columns.GridColumn col_lote_fecha_vcto;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdProducto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_producto_det;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn col_cantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_alerta;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn col_alerta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}