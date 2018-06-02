namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Nomina_horas_extras_mant
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl_nominahe = new DevExpress.XtraGrid.GridControl();
            this.gridView_nominahe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_CedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_empleado = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_NombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_FechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_time_entrada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_time_entrada2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_time_salida1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_time_salida2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_hora_extra25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_hora_extra50 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_hora_extra100 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_hora_trabajada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbnomina = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbnominaTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcionProcesoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPeriodos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Core.Erp.Winform.Roles.frmRo_WaitForm_Espera), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_nominahe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_nominahe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = false;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(849, 29);
            this.ucGe_Menu.TabIndex = 10;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = false;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_event_btnGuardar_Click);
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnAnular_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnAnular_Click(this.ucGe_Menu_event_btnAnular_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.xtraTabControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 126);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(849, 464);
            this.groupControl2.TabIndex = 12;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 21);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(845, 441);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl_nominahe);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(839, 413);
            this.xtraTabPage1.Text = "Detalle de la nomina";
            // 
            // gridControl_nominahe
            // 
            this.gridControl_nominahe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_nominahe.Location = new System.Drawing.Point(0, 0);
            this.gridControl_nominahe.MainView = this.gridView_nominahe;
            this.gridControl_nominahe.Name = "gridControl_nominahe";
            this.gridControl_nominahe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_empleado});
            this.gridControl_nominahe.Size = new System.Drawing.Size(839, 413);
            this.gridControl_nominahe.TabIndex = 5;
            this.gridControl_nominahe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_nominahe});
            // 
            // gridView_nominahe
            // 
            this.gridView_nominahe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_CedulaRuc,
            this.Col_IdEmpleado,
            this.Col_FechaRegistro,
            this.Col_time_entrada1,
            this.Col_time_entrada2,
            this.Col_time_salida1,
            this.Col_time_salida2,
            this.Col_hora_extra25,
            this.Col_hora_extra50,
            this.Col_hora_extra100,
            this.Col_hora_trabajada});
            this.gridView_nominahe.GridControl = this.gridControl_nominahe;
            this.gridView_nominahe.Name = "gridView_nominahe";
            this.gridView_nominahe.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_nominahe.OptionsView.ShowAutoFilterRow = true;
            this.gridView_nominahe.OptionsView.ShowFooter = true;
            this.gridView_nominahe.OptionsView.ShowGroupPanel = false;
            this.gridView_nominahe.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_planificacion_RowCellClick);
            this.gridView_nominahe.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Efectividad_RowCellStyle);
            this.gridView_nominahe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_Efectividad_KeyDown);
            // 
            // Col_CedulaRuc
            // 
            this.Col_CedulaRuc.Caption = "Cedula";
            this.Col_CedulaRuc.FieldName = "CedulaRuc";
            this.Col_CedulaRuc.Name = "Col_CedulaRuc";
            this.Col_CedulaRuc.OptionsColumn.AllowEdit = false;
            this.Col_CedulaRuc.Visible = true;
            this.Col_CedulaRuc.VisibleIndex = 0;
            this.Col_CedulaRuc.Width = 78;
            // 
            // Col_IdEmpleado
            // 
            this.Col_IdEmpleado.Caption = "Empleado";
            this.Col_IdEmpleado.ColumnEdit = this.cmb_empleado;
            this.Col_IdEmpleado.FieldName = "IdEmpleado";
            this.Col_IdEmpleado.Name = "Col_IdEmpleado";
            this.Col_IdEmpleado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.Col_IdEmpleado.Visible = true;
            this.Col_IdEmpleado.VisibleIndex = 1;
            this.Col_IdEmpleado.Width = 257;
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.AutoHeight = false;
            this.cmb_empleado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_empleado.DisplayMember = "NomCompleto";
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.ValueMember = "IdEmpleado";
            this.cmb_empleado.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_NombreCompleto});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_NombreCompleto
            // 
            this.Col_NombreCompleto.Caption = "Empleado";
            this.Col_NombreCompleto.FieldName = "NomCompleto";
            this.Col_NombreCompleto.Name = "Col_NombreCompleto";
            this.Col_NombreCompleto.Visible = true;
            this.Col_NombreCompleto.VisibleIndex = 0;
            // 
            // Col_FechaRegistro
            // 
            this.Col_FechaRegistro.Caption = "Fecha";
            this.Col_FechaRegistro.FieldName = "FechaRegistro";
            this.Col_FechaRegistro.Name = "Col_FechaRegistro";
            this.Col_FechaRegistro.OptionsColumn.AllowEdit = false;
            this.Col_FechaRegistro.Visible = true;
            this.Col_FechaRegistro.VisibleIndex = 2;
            this.Col_FechaRegistro.Width = 50;
            // 
            // Col_time_entrada1
            // 
            this.Col_time_entrada1.Caption = "Entrada1";
            this.Col_time_entrada1.FieldName = "time_entrada1";
            this.Col_time_entrada1.Name = "Col_time_entrada1";
            this.Col_time_entrada1.OptionsColumn.AllowEdit = false;
            this.Col_time_entrada1.Visible = true;
            this.Col_time_entrada1.VisibleIndex = 3;
            this.Col_time_entrada1.Width = 50;
            // 
            // Col_time_entrada2
            // 
            this.Col_time_entrada2.Caption = "Entrada2";
            this.Col_time_entrada2.FieldName = "time_entrada2";
            this.Col_time_entrada2.Name = "Col_time_entrada2";
            this.Col_time_entrada2.OptionsColumn.AllowEdit = false;
            this.Col_time_entrada2.Visible = true;
            this.Col_time_entrada2.VisibleIndex = 5;
            this.Col_time_entrada2.Width = 50;
            // 
            // Col_time_salida1
            // 
            this.Col_time_salida1.Caption = "Salida1";
            this.Col_time_salida1.FieldName = "time_salida1";
            this.Col_time_salida1.Name = "Col_time_salida1";
            this.Col_time_salida1.OptionsColumn.AllowEdit = false;
            this.Col_time_salida1.Visible = true;
            this.Col_time_salida1.VisibleIndex = 4;
            this.Col_time_salida1.Width = 50;
            // 
            // Col_time_salida2
            // 
            this.Col_time_salida2.Caption = "salida2";
            this.Col_time_salida2.FieldName = "time_salida2";
            this.Col_time_salida2.Name = "Col_time_salida2";
            this.Col_time_salida2.OptionsColumn.AllowEdit = false;
            this.Col_time_salida2.Visible = true;
            this.Col_time_salida2.VisibleIndex = 6;
            this.Col_time_salida2.Width = 50;
            // 
            // Col_hora_extra25
            // 
            this.Col_hora_extra25.Caption = "Horas25";
            this.Col_hora_extra25.FieldName = "hora_extra25";
            this.Col_hora_extra25.Name = "Col_hora_extra25";
            this.Col_hora_extra25.OptionsColumn.AllowEdit = false;
            this.Col_hora_extra25.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "hora_extra25", "{0:n2}")});
            this.Col_hora_extra25.Visible = true;
            this.Col_hora_extra25.VisibleIndex = 7;
            this.Col_hora_extra25.Width = 55;
            // 
            // Col_hora_extra50
            // 
            this.Col_hora_extra50.Caption = "Horas50";
            this.Col_hora_extra50.FieldName = "hora_extra50";
            this.Col_hora_extra50.Name = "Col_hora_extra50";
            this.Col_hora_extra50.OptionsColumn.AllowEdit = false;
            this.Col_hora_extra50.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "hora_extra50", "{0:n2}")});
            this.Col_hora_extra50.Visible = true;
            this.Col_hora_extra50.VisibleIndex = 8;
            this.Col_hora_extra50.Width = 50;
            // 
            // Col_hora_extra100
            // 
            this.Col_hora_extra100.Caption = "Horas100";
            this.Col_hora_extra100.FieldName = "hora_extra100";
            this.Col_hora_extra100.Name = "Col_hora_extra100";
            this.Col_hora_extra100.OptionsColumn.AllowEdit = false;
            this.Col_hora_extra100.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "hora_extra100", "{0:n2}")});
            this.Col_hora_extra100.Visible = true;
            this.Col_hora_extra100.VisibleIndex = 9;
            this.Col_hora_extra100.Width = 55;
            // 
            // Col_hora_trabajada
            // 
            this.Col_hora_trabajada.Caption = "Total Horas";
            this.Col_hora_trabajada.FieldName = "hora_trabajada";
            this.Col_hora_trabajada.Name = "Col_hora_trabajada";
            this.Col_hora_trabajada.OptionsColumn.AllowEdit = false;
            this.Col_hora_trabajada.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "hora_trabajada", "{0:n2}")});
            this.Col_hora_trabajada.Visible = true;
            this.Col_hora_trabajada.VisibleIndex = 10;
            this.Col_hora_trabajada.Width = 76;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cmbnomina);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.cmbnominaTipo);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.cmbPeriodos);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(849, 97);
            this.groupControl1.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 161;
            this.labelControl3.Text = "Período:";
            // 
            // cmbnomina
            // 
            this.cmbnomina.Location = new System.Drawing.Point(80, 24);
            this.cmbnomina.Name = "cmbnomina";
            this.cmbnomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnomina.Properties.DisplayMember = "Descripcion";
            this.cmbnomina.Properties.ValueMember = "IdNomina_Tipo";
            this.cmbnomina.Properties.View = this.searchLookUpEdit1View;
            this.cmbnomina.Size = new System.Drawing.Size(247, 20);
            this.cmbnomina.TabIndex = 156;
            this.cmbnomina.EditValueChanged += new System.EventHandler(this.cmbnomina_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColDescripcion});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.Caption = "Nomina";
            this.ColDescripcion.FieldName = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.Visible = true;
            this.ColDescripcion.VisibleIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 160;
            this.labelControl4.Text = "Proceso:";
            // 
            // cmbnominaTipo
            // 
            this.cmbnominaTipo.Location = new System.Drawing.Point(80, 47);
            this.cmbnominaTipo.Name = "cmbnominaTipo";
            this.cmbnominaTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnominaTipo.Properties.DisplayMember = "DescripcionProcesoNomina";
            this.cmbnominaTipo.Properties.ValueMember = "IdNomina_TipoLiqui";
            this.cmbnominaTipo.Properties.View = this.gridView3;
            this.cmbnominaTipo.Size = new System.Drawing.Size(247, 20);
            this.cmbnominaTipo.TabIndex = 157;
            this.cmbnominaTipo.EditValueChanged += new System.EventHandler(this.cmbnominaTipo_EditValueChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColDescripcionProcesoNomina});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // ColDescripcionProcesoNomina
            // 
            this.ColDescripcionProcesoNomina.Caption = "Proceso";
            this.ColDescripcionProcesoNomina.FieldName = "DescripcionProcesoNomina";
            this.ColDescripcionProcesoNomina.Name = "ColDescripcionProcesoNomina";
            this.ColDescripcionProcesoNomina.Visible = true;
            this.ColDescripcionProcesoNomina.VisibleIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 159;
            this.labelControl5.Text = "Nómina:";
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.Location = new System.Drawing.Point(80, 71);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodos.Properties.DisplayMember = "pe_Descripcion";
            this.cmbPeriodos.Properties.ValueMember = "IdPeriodo";
            this.cmbPeriodos.Properties.View = this.gridView2;
            this.cmbPeriodos.Size = new System.Drawing.Size(247, 20);
            this.cmbPeriodos.TabIndex = 158;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdPeriodo,
            this.Colpe_Descripcion});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ColIdPeriodo
            // 
            this.ColIdPeriodo.Caption = "Id Periodo";
            this.ColIdPeriodo.FieldName = "IdPeriodo";
            this.ColIdPeriodo.Name = "ColIdPeriodo";
            this.ColIdPeriodo.Visible = true;
            this.ColIdPeriodo.VisibleIndex = 0;
            this.ColIdPeriodo.Width = 168;
            // 
            // Colpe_Descripcion
            // 
            this.Colpe_Descripcion.Caption = "Descripcion";
            this.Colpe_Descripcion.FieldName = "pe_Descripcion";
            this.Colpe_Descripcion.Name = "Colpe_Descripcion";
            this.Colpe_Descripcion.Visible = true;
            this.Colpe_Descripcion.VisibleIndex = 1;
            this.Colpe_Descripcion.Width = 984;
            // 
            // frmRo_Nomina_horas_extras_mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 590);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Nomina_horas_extras_mant";
            this.Text = "Nomina horas extras";
            this.Load += new System.EventHandler(this.frmRo_Efectividad_entrega_x_periodo_xempleado_mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_nominahe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_nominahe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gridControl_nominahe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_nominahe;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnomina;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnominaTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcionProcesoNomina;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_FechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn Col_time_entrada1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_time_entrada2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_time_salida1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_time_salida2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_hora_extra25;
        private DevExpress.XtraGrid.Columns.GridColumn Col_hora_extra50;
        private DevExpress.XtraGrid.Columns.GridColumn Col_hora_extra100;
        private DevExpress.XtraGrid.Columns.GridColumn Col_hora_trabajada;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CedulaRuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_empleado;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_NombreCompleto;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}