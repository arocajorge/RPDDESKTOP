namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmFa_PreFacturacion_Mantenimiento
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
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.gridControl_prefacturacion = new DevExpress.XtraGrid.GridControl();
            this.gridView_prefacturacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_grupo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_subcentro = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_proceso_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_valor_ganancia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_impuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_impuesto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_producto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtvalorafacturar = new DevExpress.XtraEditors.TextEdit();
            this.txttotalequipos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Observacion = new DevExpress.XtraEditors.MemoEdit();
            this.ucIn_Sucursal_Bodega1 = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.chk_estado_cierre = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_centro_costo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblAnulado = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.de_Fecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_IdPreFacturacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucCon_Periodo1 = new Core.Erp.Winform.Controles.UCCon_Periodo();
            this.cmb_proceso = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chk_seleccionar_visibles_det = new DevExpress.XtraEditors.CheckEdit();
            this.btn_imprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btn_facturar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_eliminar_detalle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_agregar_detalle = new DevExpress.XtraEditors.SimpleButton();
            this.chk_fee = new DevExpress.XtraEditors.CheckEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.frmGe_Esperar), true, true);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tp_detalle = new DevExpress.XtraTab.XtraTabPage();
            this.tp_activos = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_activos = new DevExpress.XtraGrid.GridControl();
            this.gridView_activos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_activo_act = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_subcentro_act = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_grupo_act = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_reprocesar_activos = new System.Windows.Forms.ToolStripButton();
            this.tp_otros = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_otros = new DevExpress.XtraGrid.GridControl();
            this.gridView_otros = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_act_otros = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_subcentro_otros = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_prefacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_prefacturacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_proceso_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_impuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalorafacturar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotalequipos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado_cierre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdPreFacturacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_proceso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_seleccionar_visibles_det.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_fee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tp_detalle.SuspendLayout();
            this.tp_activos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_activos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_activos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_activo_act)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro_act)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_act)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tp_otros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_otros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_otros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_act_otros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro_otros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
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
            this.ucGe_Menu_Superior_Mant1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu_Superior_Mant1.Name = "ucGe_Menu_Superior_Mant1";
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1354, 36);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 1;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = true;
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
            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnlimpiar_Click(this.ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_Superior_Mant1_event_btnAnular_Click);
            this.ucGe_Menu_Superior_Mant1.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant1_event_btnSalir_Click);
            // 
            // gridControl_prefacturacion
            // 
            this.gridControl_prefacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_prefacturacion.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_prefacturacion.Location = new System.Drawing.Point(0, 88);
            this.gridControl_prefacturacion.MainView = this.gridView_prefacturacion;
            this.gridControl_prefacturacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_prefacturacion.Name = "gridControl_prefacturacion";
            this.gridControl_prefacturacion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_impuesto,
            this.cmb_grupo,
            this.cmb_subcentro,
            this.cmb_proceso_grid,
            this.cmb_producto});
            this.gridControl_prefacturacion.Size = new System.Drawing.Size(1348, 299);
            this.gridControl_prefacturacion.TabIndex = 2;
            this.gridControl_prefacturacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_prefacturacion});
            // 
            // gridView_prefacturacion
            // 
            this.gridView_prefacturacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.col_subtotal,
            this.col_valor_ganancia,
            this.col_impuesto,
            this.col_iva,
            this.col_total,
            this.col_check,
            this.gridColumn20});
            this.gridView_prefacturacion.GridControl = this.gridControl_prefacturacion;
            this.gridView_prefacturacion.GroupCount = 1;
            this.gridView_prefacturacion.GroupFormat = "[#image]{1} {2}";
            this.gridView_prefacturacion.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_ganancia", this.col_valor_ganancia, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subtotal", this.col_subtotal, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", this.col_total, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_iva", this.col_iva, "{0:n2}")});
            this.gridView_prefacturacion.Name = "gridView_prefacturacion";
            this.gridView_prefacturacion.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_prefacturacion.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_prefacturacion.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView_prefacturacion.OptionsView.ShowFooter = true;
            this.gridView_prefacturacion.OptionsView.ShowGroupPanel = false;
            this.gridView_prefacturacion.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView_prefacturacion.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView_prefacturacion_RowStyle);
            this.gridView_prefacturacion.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_prefacturacion_FocusedRowChanged);
            this.gridView_prefacturacion.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_prefacturacion_CellValueChanged);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Grupo";
            this.gridColumn3.ColumnEdit = this.cmb_grupo;
            this.gridColumn3.FieldName = "IdGrupo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 210;
            // 
            // cmb_grupo
            // 
            this.cmb_grupo.AutoHeight = false;
            this.cmb_grupo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_grupo.DisplayMember = "nom_Grupo";
            this.cmb_grupo.Name = "cmb_grupo";
            this.cmb_grupo.ValueMember = "IdGrupo";
            this.cmb_grupo.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn14});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "ID";
            this.gridColumn13.FieldName = "IdGrupo";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            this.gridColumn13.Width = 295;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Grupo";
            this.gridColumn14.FieldName = "nom_Grupo";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 0;
            this.gridColumn14.Width = 1439;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Subcentro de costo";
            this.gridColumn4.ColumnEdit = this.cmb_subcentro;
            this.gridColumn4.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 213;
            // 
            // cmb_subcentro
            // 
            this.cmb_subcentro.AutoHeight = false;
            this.cmb_subcentro.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_subcentro.DisplayMember = "Centro_costo";
            this.cmb_subcentro.Name = "cmb_subcentro";
            this.cmb_subcentro.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmb_subcentro.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn15,
            this.gridColumn16});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "ID";
            this.gridColumn15.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 1;
            this.gridColumn15.Width = 317;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Subcentro";
            this.gridColumn16.FieldName = "Centro_costo";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 0;
            this.gridColumn16.Width = 1417;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Proceso";
            this.gridColumn5.ColumnEdit = this.cmb_proceso_grid;
            this.gridColumn5.FieldName = "IdProceso_prefacturacion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 259;
            // 
            // cmb_proceso_grid
            // 
            this.cmb_proceso_grid.AutoHeight = false;
            this.cmb_proceso_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_proceso_grid.DisplayMember = "Value";
            this.cmb_proceso_grid.Name = "cmb_proceso_grid";
            this.cmb_proceso_grid.ValueMember = "Key";
            this.cmb_proceso_grid.View = this.gridView4;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "ID";
            this.gridColumn17.FieldName = "Key";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            this.gridColumn17.Width = 233;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Proceso";
            this.gridColumn18.FieldName = "Value";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            this.gridColumn18.Width = 1501;
            // 
            // col_subtotal
            // 
            this.col_subtotal.Caption = "Subtotal";
            this.col_subtotal.DisplayFormat.FormatString = "n2";
            this.col_subtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_subtotal.FieldName = "subtotal";
            this.col_subtotal.Name = "col_subtotal";
            this.col_subtotal.OptionsColumn.AllowEdit = false;
            this.col_subtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subtotal", "{0:n2}")});
            this.col_subtotal.Visible = true;
            this.col_subtotal.VisibleIndex = 4;
            this.col_subtotal.Width = 123;
            // 
            // col_valor_ganancia
            // 
            this.col_valor_ganancia.Caption = "Valor ganancia";
            this.col_valor_ganancia.DisplayFormat.FormatString = "n2";
            this.col_valor_ganancia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_valor_ganancia.FieldName = "valor_ganancia";
            this.col_valor_ganancia.Name = "col_valor_ganancia";
            this.col_valor_ganancia.OptionsColumn.AllowEdit = false;
            this.col_valor_ganancia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_ganancia", "{0:n2}")});
            this.col_valor_ganancia.Visible = true;
            this.col_valor_ganancia.VisibleIndex = 5;
            this.col_valor_ganancia.Width = 123;
            // 
            // col_impuesto
            // 
            this.col_impuesto.Caption = "Impuesto";
            this.col_impuesto.ColumnEdit = this.cmb_impuesto;
            this.col_impuesto.FieldName = "IdCod_Impuesto";
            this.col_impuesto.Name = "col_impuesto";
            this.col_impuesto.Visible = true;
            this.col_impuesto.VisibleIndex = 6;
            this.col_impuesto.Width = 123;
            // 
            // cmb_impuesto
            // 
            this.cmb_impuesto.AutoHeight = false;
            this.cmb_impuesto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_impuesto.DisplayMember = "nom_impuesto";
            this.cmb_impuesto.Name = "cmb_impuesto";
            this.cmb_impuesto.ValueMember = "IdCod_Impuesto";
            this.cmb_impuesto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "ID";
            this.gridColumn11.FieldName = "IdCod_Impuesto";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 343;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Impuesto";
            this.gridColumn12.FieldName = "nom_impuesto";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 1391;
            // 
            // col_iva
            // 
            this.col_iva.Caption = "Iva";
            this.col_iva.DisplayFormat.FormatString = "n2";
            this.col_iva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_iva.FieldName = "valor_iva";
            this.col_iva.Name = "col_iva";
            this.col_iva.OptionsColumn.AllowEdit = false;
            this.col_iva.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_iva", "{0:n2}")});
            this.col_iva.Visible = true;
            this.col_iva.VisibleIndex = 7;
            this.col_iva.Width = 123;
            // 
            // col_total
            // 
            this.col_total.Caption = "Total";
            this.col_total.DisplayFormat.FormatString = "n2";
            this.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_total.FieldName = "total";
            this.col_total.Name = "col_total";
            this.col_total.OptionsColumn.AllowEdit = false;
            this.col_total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", "{0:n2}")});
            this.col_total.Visible = true;
            this.col_total.VisibleIndex = 8;
            this.col_total.Width = 146;
            // 
            // col_check
            // 
            this.col_check.Caption = "*";
            this.col_check.FieldName = "seleccionado";
            this.col_check.Name = "col_check";
            this.col_check.Visible = true;
            this.col_check.VisibleIndex = 0;
            this.col_check.Width = 58;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Producto";
            this.gridColumn20.ColumnEdit = this.cmb_producto;
            this.gridColumn20.FieldName = "IdProducto";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 3;
            this.gridColumn20.Width = 356;
            // 
            // cmb_producto
            // 
            this.cmb_producto.AutoHeight = false;
            this.cmb_producto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_producto.DisplayMember = "pr_descripcion";
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.ValueMember = "IdProducto";
            this.cmb_producto.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowAutoFilterRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Producto";
            this.gridColumn21.FieldName = "pr_descripcion";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 1;
            this.gridColumn21.Width = 1149;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "ID";
            this.gridColumn22.FieldName = "IdProducto";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 2;
            this.gridColumn22.Width = 292;
            // 
            // gridColumn23
            // 
            this.gridColumn23.Caption = "Codigo";
            this.gridColumn23.FieldName = "pr_codigo";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 0;
            this.gridColumn23.Width = 293;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtvalorafacturar);
            this.panel1.Controls.Add(this.txttotalequipos);
            this.panel1.Controls.Add(this.labelControl9);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.txt_Observacion);
            this.panel1.Controls.Add(this.ucIn_Sucursal_Bodega1);
            this.panel1.Controls.Add(this.chk_estado_cierre);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.cmb_centro_costo);
            this.panel1.Controls.Add(this.lblAnulado);
            this.panel1.Controls.Add(this.labelControl6);
            this.panel1.Controls.Add(this.labelControl5);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.de_Fecha);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txt_IdPreFacturacion);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.ucCon_Periodo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 192);
            this.panel1.TabIndex = 4;
            // 
            // txtvalorafacturar
            // 
            this.txtvalorafacturar.Location = new System.Drawing.Point(778, 150);
            this.txtvalorafacturar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtvalorafacturar.Name = "txtvalorafacturar";
            this.txtvalorafacturar.Size = new System.Drawing.Size(139, 22);
            this.txtvalorafacturar.TabIndex = 30;
            // 
            // txttotalequipos
            // 
            this.txttotalequipos.Location = new System.Drawing.Point(778, 118);
            this.txttotalequipos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttotalequipos.Name = "txttotalequipos";
            this.txttotalequipos.Size = new System.Drawing.Size(139, 22);
            this.txttotalequipos.TabIndex = 29;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(651, 153);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(116, 16);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Valor disponibilidad:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(651, 119);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(82, 16);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Total equipos:";
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Location = new System.Drawing.Point(184, 133);
            this.txt_Observacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(416, 48);
            this.txt_Observacion.TabIndex = 12;
            // 
            // ucIn_Sucursal_Bodega1
            // 
            this.ucIn_Sucursal_Bodega1.Location = new System.Drawing.Point(651, 44);
            this.ucIn_Sucursal_Bodega1.Margin = new System.Windows.Forms.Padding(5);
            this.ucIn_Sucursal_Bodega1.Name = "ucIn_Sucursal_Bodega1";
            this.ucIn_Sucursal_Bodega1.Size = new System.Drawing.Size(437, 65);
            this.ucIn_Sucursal_Bodega1.TabIndex = 26;
            this.ucIn_Sucursal_Bodega1.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.todos;
            this.ucIn_Sucursal_Bodega1.Visible_cmb_bodega = true;
            // 
            // chk_estado_cierre
            // 
            this.chk_estado_cierre.Location = new System.Drawing.Point(660, 7);
            this.chk_estado_cierre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_estado_cierre.Name = "chk_estado_cierre";
            this.chk_estado_cierre.Properties.Caption = "Cerrado";
            this.chk_estado_cierre.Size = new System.Drawing.Size(199, 21);
            this.chk_estado_cierre.TabIndex = 25;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(35, 44);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(95, 16);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Centro de costo:";
            // 
            // cmb_centro_costo
            // 
            this.cmb_centro_costo.Location = new System.Drawing.Point(184, 41);
            this.cmb_centro_costo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_centro_costo.Name = "cmb_centro_costo";
            this.cmb_centro_costo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo.Properties.DisplayMember = "Centro_costo";
            this.cmb_centro_costo.Properties.ValueMember = "IdCentroCosto";
            this.cmb_centro_costo.Properties.View = this.searchLookUpEdit1View;
            this.cmb_centro_costo.Size = new System.Drawing.Size(416, 22);
            this.cmb_centro_costo.TabIndex = 23;
            this.cmb_centro_costo.EditValueChanged += new System.EventHandler(this.cmb_centro_costo_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn32,
            this.gridColumn42});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn32
            // 
            this.gridColumn32.Caption = "ID";
            this.gridColumn32.FieldName = "IdCentroCosto";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 1;
            this.gridColumn32.Width = 102;
            // 
            // gridColumn42
            // 
            this.gridColumn42.Caption = "Centro de costo";
            this.gridColumn42.FieldName = "Centro_costo";
            this.gridColumn42.Name = "gridColumn42";
            this.gridColumn42.Visible = true;
            this.gridColumn42.VisibleIndex = 0;
            this.gridColumn42.Width = 396;
            // 
            // lblAnulado
            // 
            this.lblAnulado.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(464, 9);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(177, 24);
            this.lblAnulado.TabIndex = 18;
            this.lblAnulado.Text = "***ANULADO***";
            this.lblAnulado.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(35, 107);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 16);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Desde:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(35, 73);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 16);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Periodo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(868, 9);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 16);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Fecha:";
            // 
            // de_Fecha
            // 
            this.de_Fecha.EditValue = new System.DateTime(2016, 4, 22, 12, 36, 16, 861);
            this.de_Fecha.Location = new System.Drawing.Point(915, 6);
            this.de_Fecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.de_Fecha.Name = "de_Fecha";
            this.de_Fecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_Fecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_Fecha.Size = new System.Drawing.Size(145, 22);
            this.de_Fecha.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 135);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Observación:";
            // 
            // txt_IdPreFacturacion
            // 
            this.txt_IdPreFacturacion.Location = new System.Drawing.Point(184, 9);
            this.txt_IdPreFacturacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_IdPreFacturacion.Name = "txt_IdPreFacturacion";
            this.txt_IdPreFacturacion.Properties.ReadOnly = true;
            this.txt_IdPreFacturacion.Size = new System.Drawing.Size(120, 22);
            this.txt_IdPreFacturacion.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "# Pre-facturación:";
            // 
            // ucCon_Periodo1
            // 
            this.ucCon_Periodo1.Enabled_cmb_Periodo = true;
            this.ucCon_Periodo1.Enabled_de_Desde = true;
            this.ucCon_Periodo1.Enabled_de_Hasta = true;
            this.ucCon_Periodo1.Location = new System.Drawing.Point(92, 66);
            this.ucCon_Periodo1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucCon_Periodo1.Name = "ucCon_Periodo1";
            this.ucCon_Periodo1.ReadOnly_cmb_Periodo = false;
            this.ucCon_Periodo1.ReadOnly_de_Desde = true;
            this.ucCon_Periodo1.ReadOnly_de_Hasta = true;
            this.ucCon_Periodo1.Size = new System.Drawing.Size(399, 69);
            this.ucCon_Periodo1.TabIndex = 9;
            this.ucCon_Periodo1.Visible_cmb_Periodo = true;
            this.ucCon_Periodo1.Visible_de_Desde = true;
            this.ucCon_Periodo1.Visible_de_Hasta = true;
            this.ucCon_Periodo1.Visible_lblDesde = false;
            this.ucCon_Periodo1.Visible_lblHasta = true;
            this.ucCon_Periodo1.Visible_lblPeriodo = false;
            this.ucCon_Periodo1.event_delegate_cmb_Periodo_EditValueChanged += new Core.Erp.Winform.Controles.UCCon_Periodo.delegate_cmb_Periodo_EditValueChanged(this.ucCon_Periodo1_event_delegate_cmb_Periodo_EditValueChanged);
            // 
            // cmb_proceso
            // 
            this.cmb_proceso.Location = new System.Drawing.Point(107, 28);
            this.cmb_proceso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_proceso.Name = "cmb_proceso";
            this.cmb_proceso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_proceso.Properties.DisplayMember = "Value";
            this.cmb_proceso.Properties.ValueMember = "Key";
            this.cmb_proceso.Properties.View = this.gridView1;
            this.cmb_proceso.Size = new System.Drawing.Size(297, 22);
            this.cmb_proceso.TabIndex = 26;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Proceso";
            this.gridColumn1.FieldName = "Value";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 1431;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 303;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 31);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 16);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Proceso:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chk_seleccionar_visibles_det);
            this.groupControl1.Controls.Add(this.btn_imprimir);
            this.groupControl1.Controls.Add(this.btn_facturar);
            this.groupControl1.Controls.Add(this.btn_eliminar_detalle);
            this.groupControl1.Controls.Add(this.btn_agregar_detalle);
            this.groupControl1.Controls.Add(this.chk_fee);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cmb_proceso);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1348, 88);
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "Agregar/quitar Proceso";
            // 
            // chk_seleccionar_visibles_det
            // 
            this.chk_seleccionar_visibles_det.Location = new System.Drawing.Point(32, 54);
            this.chk_seleccionar_visibles_det.Name = "chk_seleccionar_visibles_det";
            this.chk_seleccionar_visibles_det.Properties.Caption = "Seleccionar visibles";
            this.chk_seleccionar_visibles_det.Size = new System.Drawing.Size(372, 21);
            this.chk_seleccionar_visibles_det.TabIndex = 31;
            this.chk_seleccionar_visibles_det.CheckedChanged += new System.EventHandler(this.chk_seleccionar_visibles_det_CheckedChanged);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_imprimir.Image = global::Core.Erp.Winform.Properties.Resources.imprimir16;
            this.btn_imprimir.Location = new System.Drawing.Point(819, 27);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(98, 23);
            this.btn_imprimir.TabIndex = 30;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_facturar
            // 
            this.btn_facturar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_facturar.Image = global::Core.Erp.Winform.Properties.Resources.check_16x16;
            this.btn_facturar.Location = new System.Drawing.Point(934, 27);
            this.btn_facturar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(98, 23);
            this.btn_facturar.TabIndex = 29;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // btn_eliminar_detalle
            // 
            this.btn_eliminar_detalle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_eliminar_detalle.Image = global::Core.Erp.Winform.Properties.Resources.eliminar;
            this.btn_eliminar_detalle.Location = new System.Drawing.Point(703, 27);
            this.btn_eliminar_detalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar_detalle.Name = "btn_eliminar_detalle";
            this.btn_eliminar_detalle.Size = new System.Drawing.Size(98, 23);
            this.btn_eliminar_detalle.TabIndex = 28;
            this.btn_eliminar_detalle.Text = "Eliminar";
            this.btn_eliminar_detalle.Click += new System.EventHandler(this.btn_eliminar_detalle_Click);
            // 
            // btn_agregar_detalle
            // 
            this.btn_agregar_detalle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_agregar_detalle.Image = global::Core.Erp.Winform.Properties.Resources.Add_16_x_16;
            this.btn_agregar_detalle.Location = new System.Drawing.Point(590, 27);
            this.btn_agregar_detalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_detalle.Name = "btn_agregar_detalle";
            this.btn_agregar_detalle.Size = new System.Drawing.Size(98, 23);
            this.btn_agregar_detalle.TabIndex = 26;
            this.btn_agregar_detalle.Text = "Agregar";
            this.btn_agregar_detalle.Click += new System.EventHandler(this.btn_agregar_detalle_Click);
            // 
            // chk_fee
            // 
            this.chk_fee.EditValue = true;
            this.chk_fee.Location = new System.Drawing.Point(423, 28);
            this.chk_fee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_fee.Name = "chk_fee";
            this.chk_fee.Properties.Caption = "Aplica % ganancia";
            this.chk_fee.Size = new System.Drawing.Size(143, 21);
            this.chk_fee.TabIndex = 26;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 228);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tp_detalle;
            this.xtraTabControl1.Size = new System.Drawing.Size(1354, 418);
            this.xtraTabControl1.TabIndex = 29;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp_detalle,
            this.tp_activos,
            this.tp_otros});
            // 
            // tp_detalle
            // 
            this.tp_detalle.Controls.Add(this.gridControl_prefacturacion);
            this.tp_detalle.Controls.Add(this.groupControl1);
            this.tp_detalle.Name = "tp_detalle";
            this.tp_detalle.Size = new System.Drawing.Size(1348, 387);
            this.tp_detalle.Text = "Detalle";
            // 
            // tp_activos
            // 
            this.tp_activos.Controls.Add(this.gridControl_activos);
            this.tp_activos.Controls.Add(this.toolStrip1);
            this.tp_activos.Name = "tp_activos";
            this.tp_activos.Size = new System.Drawing.Size(1348, 387);
            this.tp_activos.Text = "Activos";
            // 
            // gridControl_activos
            // 
            this.gridControl_activos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_activos.Location = new System.Drawing.Point(0, 27);
            this.gridControl_activos.MainView = this.gridView_activos;
            this.gridControl_activos.Name = "gridControl_activos";
            this.gridControl_activos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_activo_act,
            this.cmb_subcentro_act,
            this.cmb_grupo_act});
            this.gridControl_activos.Size = new System.Drawing.Size(1348, 360);
            this.gridControl_activos.TabIndex = 0;
            this.gridControl_activos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_activos});
            // 
            // gridView_activos
            // 
            this.gridView_activos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn19,
            this.gridColumn24,
            this.gridColumn40});
            this.gridView_activos.GridControl = this.gridControl_activos;
            this.gridView_activos.Name = "gridView_activos";
            this.gridView_activos.OptionsView.ShowAutoFilterRow = true;
            this.gridView_activos.OptionsView.ShowFooter = true;
            this.gridView_activos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Activo";
            this.gridColumn6.ColumnEdit = this.cmb_activo_act;
            this.gridColumn6.FieldName = "IdActivoFijo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 223;
            // 
            // cmb_activo_act
            // 
            this.cmb_activo_act.AutoHeight = false;
            this.cmb_activo_act.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_activo_act.DisplayMember = "Af_DescripcionCorta";
            this.cmb_activo_act.Name = "cmb_activo_act";
            this.cmb_activo_act.ValueMember = "IdActivoFijo";
            this.cmb_activo_act.View = this.gridView6;
            // 
            // gridView6
            // 
            this.gridView6.ActiveFilterString = "[IdActivoFijo] = ?";
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn25,
            this.gridColumn26});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "ID";
            this.gridColumn25.FieldName = "IdActivoFijo";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 1;
            this.gridColumn25.Width = 121;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Activo fijo";
            this.gridColumn26.FieldName = "Af_DescripcionCorta";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 0;
            this.gridColumn26.Width = 651;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Subcentro";
            this.gridColumn7.ColumnEdit = this.cmb_subcentro_act;
            this.gridColumn7.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 195;
            // 
            // cmb_subcentro_act
            // 
            this.cmb_subcentro_act.AutoHeight = false;
            this.cmb_subcentro_act.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_subcentro_act.DisplayMember = "Centro_costo";
            this.cmb_subcentro_act.Name = "cmb_subcentro_act";
            this.cmb_subcentro_act.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmb_subcentro_act.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn35,
            this.gridColumn37});
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn35
            // 
            this.gridColumn35.Caption = "ID";
            this.gridColumn35.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 1;
            this.gridColumn35.Width = 190;
            // 
            // gridColumn37
            // 
            this.gridColumn37.Caption = "Subcentro";
            this.gridColumn37.FieldName = "Centro_costo";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 0;
            this.gridColumn37.Width = 1544;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Grupo";
            this.gridColumn8.ColumnEdit = this.cmb_grupo_act;
            this.gridColumn8.FieldName = "IdGrupo";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 164;
            // 
            // cmb_grupo_act
            // 
            this.cmb_grupo_act.AutoHeight = false;
            this.cmb_grupo_act.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_grupo_act.DisplayMember = "nom_Grupo";
            this.cmb_grupo_act.Name = "cmb_grupo_act";
            this.cmb_grupo_act.ValueMember = "IdGrupo";
            this.cmb_grupo_act.View = this.repositoryItemSearchLookUpEdit3View;
            // 
            // repositoryItemSearchLookUpEdit3View
            // 
            this.repositoryItemSearchLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn38,
            this.gridColumn39});
            this.repositoryItemSearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit3View.Name = "repositoryItemSearchLookUpEdit3View";
            this.repositoryItemSearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit3View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn38
            // 
            this.gridColumn38.Caption = "ID";
            this.gridColumn38.FieldName = "IdGrupo";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 1;
            this.gridColumn38.Width = 241;
            // 
            // gridColumn39
            // 
            this.gridColumn39.Caption = "Grupo";
            this.gridColumn39.FieldName = "nom_Grupo";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.Visible = true;
            this.gridColumn39.VisibleIndex = 0;
            this.gridColumn39.Width = 1493;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "% ganancia";
            this.gridColumn9.FieldName = "por_ganancia";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 61;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Periodo ini";
            this.gridColumn10.FieldName = "IdPeriodo_ini";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 66;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Periodo fin";
            this.gridColumn19.FieldName = "IdPeriodo_fin";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 5;
            this.gridColumn19.Width = 63;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Depr. x scc";
            this.gridColumn24.DisplayFormat.FormatString = "n2";
            this.gridColumn24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn24.FieldName = "valor_depr_x_scc";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_depr_x_scc", "{0:n2}")});
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 6;
            // 
            // gridColumn40
            // 
            this.gridColumn40.Caption = "Valor mov.";
            this.gridColumn40.DisplayFormat.FormatString = "n2";
            this.gridColumn40.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn40.FieldName = "valor_movilizacion";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_movilizacion", "{0:n2}")});
            this.gridColumn40.Visible = true;
            this.gridColumn40.VisibleIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_reprocesar_activos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1348, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_reprocesar_activos
            // 
            this.btn_reprocesar_activos.Image = global::Core.Erp.Winform.Properties.Resources.re_hacer_16x16;
            this.btn_reprocesar_activos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reprocesar_activos.Name = "btn_reprocesar_activos";
            this.btn_reprocesar_activos.Size = new System.Drawing.Size(103, 24);
            this.btn_reprocesar_activos.Text = "Reprocesar";
            this.btn_reprocesar_activos.Click += new System.EventHandler(this.btn_reprocesar_activos_Click);
            // 
            // tp_otros
            // 
            this.tp_otros.Controls.Add(this.gridControl_otros);
            this.tp_otros.Name = "tp_otros";
            this.tp_otros.Size = new System.Drawing.Size(1348, 387);
            this.tp_otros.Text = "Otros";
            // 
            // gridControl_otros
            // 
            this.gridControl_otros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_otros.Location = new System.Drawing.Point(0, 0);
            this.gridControl_otros.MainView = this.gridView_otros;
            this.gridControl_otros.Name = "gridControl_otros";
            this.gridControl_otros.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_act_otros,
            this.cmb_subcentro_otros});
            this.gridControl_otros.Size = new System.Drawing.Size(1348, 387);
            this.gridControl_otros.TabIndex = 1;
            this.gridControl_otros.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_otros});
            // 
            // gridView_otros
            // 
            this.gridView_otros.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn27,
            this.gridColumn30,
            this.gridColumn36,
            this.gridColumn33});
            this.gridView_otros.GridControl = this.gridControl_otros;
            this.gridView_otros.Name = "gridView_otros";
            this.gridView_otros.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_otros.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView_otros.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_otros.OptionsView.ShowFooter = true;
            this.gridView_otros.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Activo";
            this.gridColumn27.ColumnEdit = this.cmb_act_otros;
            this.gridColumn27.FieldName = "IdActivoFijo";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 1;
            this.gridColumn27.Width = 500;
            // 
            // cmb_act_otros
            // 
            this.cmb_act_otros.AutoHeight = false;
            this.cmb_act_otros.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_act_otros.DisplayMember = "Af_DescripcionCorta";
            this.cmb_act_otros.Name = "cmb_act_otros";
            this.cmb_act_otros.ValueMember = "IdActivoFijo";
            this.cmb_act_otros.View = this.gridView9;
            // 
            // gridView9
            // 
            this.gridView9.ActiveFilterString = "[IdActivoFijo] = ?";
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn28,
            this.gridColumn29});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowAutoFilterRow = true;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "ID";
            this.gridColumn28.FieldName = "IdActivoFijo";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 1;
            this.gridColumn28.Width = 121;
            // 
            // gridColumn29
            // 
            this.gridColumn29.Caption = "Activo fijo";
            this.gridColumn29.FieldName = "Af_DescripcionCorta";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 0;
            this.gridColumn29.Width = 651;
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "Subcentro";
            this.gridColumn30.ColumnEdit = this.cmb_subcentro_otros;
            this.gridColumn30.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 0;
            this.gridColumn30.Width = 404;
            // 
            // cmb_subcentro_otros
            // 
            this.cmb_subcentro_otros.AutoHeight = false;
            this.cmb_subcentro_otros.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_subcentro_otros.DisplayMember = "Centro_costo";
            this.cmb_subcentro_otros.Name = "cmb_subcentro_otros";
            this.cmb_subcentro_otros.ValueMember = "IdCentroCosto_sub_centro_costo";
            this.cmb_subcentro_otros.View = this.gridView10;
            // 
            // gridView10
            // 
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn31,
            this.gridColumn34});
            this.gridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView10.OptionsView.ShowAutoFilterRow = true;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn31
            // 
            this.gridColumn31.Caption = "ID";
            this.gridColumn31.FieldName = "IdCentroCosto_sub_centro_costo";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 1;
            this.gridColumn31.Width = 273;
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "Subcentro de costo";
            this.gridColumn34.FieldName = "Centro_costo";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 0;
            this.gridColumn34.Width = 1461;
            // 
            // gridColumn36
            // 
            this.gridColumn36.Caption = "Valor";
            this.gridColumn36.DisplayFormat.FormatString = "n2";
            this.gridColumn36.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn36.FieldName = "valor";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor", "{0:n2}")});
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 3;
            this.gridColumn36.Width = 128;
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "Observación";
            this.gridColumn33.FieldName = "observacion";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 2;
            this.gridColumn33.Width = 702;
            // 
            // frmFa_PreFacturacion_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 646);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFa_PreFacturacion_Mantenimiento";
            this.Text = "frmFa_PreFacturacion_Mantenimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFa_PreFacturacion_Mantenimiento_FormClosed);
            this.Load += new System.EventHandler(this.frmFa_PreFacturacion_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_prefacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_prefacturacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_proceso_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_impuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtvalorafacturar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttotalequipos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_estado_cierre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_Fecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdPreFacturacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_proceso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_seleccionar_visibles_det.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_fee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tp_detalle.ResumeLayout(false);
            this.tp_activos.ResumeLayout(false);
            this.tp_activos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_activos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_activos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_activo_act)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro_act)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_grupo_act)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tp_otros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_otros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_otros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_act_otros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro_otros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private DevExpress.XtraGrid.GridControl gridControl_prefacturacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_prefacturacion;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraEditors.LabelControl lblAnulado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit de_Fecha;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_IdPreFacturacion;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Controles.UCCon_Periodo ucCon_Periodo1;
        private DevExpress.XtraEditors.MemoEdit txt_Observacion;
        private DevExpress.XtraEditors.CheckEdit chk_estado_cierre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_proceso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chk_fee;
        private DevExpress.XtraEditors.SimpleButton btn_eliminar_detalle;
        private DevExpress.XtraEditors.SimpleButton btn_agregar_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_grupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_subcentro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_proceso_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn col_subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn col_valor_ganancia;
        private DevExpress.XtraGrid.Columns.GridColumn col_impuesto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_impuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn col_iva;
        private DevExpress.XtraGrid.Columns.GridColumn col_total;
        private DevExpress.XtraGrid.Columns.GridColumn col_check;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_producto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraEditors.SimpleButton btn_facturar;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega1;
        private DevExpress.XtraEditors.TextEdit txtvalorafacturar;
        private DevExpress.XtraEditors.TextEdit txttotalequipos;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btn_imprimir;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tp_detalle;
        private DevExpress.XtraTab.XtraTabPage tp_activos;
        private DevExpress.XtraGrid.GridControl gridControl_activos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_activos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_reprocesar_activos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_activo_act;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_subcentro_act;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_grupo_act;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit3View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraTab.XtraTabPage tp_otros;
        private DevExpress.XtraGrid.GridControl gridControl_otros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_otros;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_act_otros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_subcentro_otros;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraEditors.CheckEdit chk_seleccionar_visibles_det;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}