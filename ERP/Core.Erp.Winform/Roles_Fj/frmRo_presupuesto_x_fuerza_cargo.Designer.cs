namespace Core.Erp.Winform.Roles_Fj
{
    partial class frmRo_presupuesto_x_fuerza_cargo
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlPresupuesto = new DevExpress.XtraGrid.GridControl();
            this.gridViewPresupuesto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_idcargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCargo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdFuerza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFuerza = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_fuerza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_CantidadVpp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Presupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_diasEfectivos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Dias_SyD_y_Feriado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_BaseVariable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPeriodos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Colpe_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbnominaTipo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcionProcesoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbnomina = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
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
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
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
            this.ucGe_Menu.Size = new System.Drawing.Size(947, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
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
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlPresupuesto);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 100);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(947, 337);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Presupuesto por fuerza y cargo";
            // 
            // gridControlPresupuesto
            // 
            this.gridControlPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPresupuesto.Location = new System.Drawing.Point(2, 21);
            this.gridControlPresupuesto.MainView = this.gridViewPresupuesto;
            this.gridControlPresupuesto.Name = "gridControlPresupuesto";
            this.gridControlPresupuesto.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbCargo,
            this.cmbFuerza});
            this.gridControlPresupuesto.Size = new System.Drawing.Size(943, 314);
            this.gridControlPresupuesto.TabIndex = 0;
            this.gridControlPresupuesto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPresupuesto});
            // 
            // gridViewPresupuesto
            // 
            this.gridViewPresupuesto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_idcargo,
            this.Col_IdFuerza,
            this.Col_Anio,
            this.Col_Mes,
            this.Col_CantidadVpp,
            this.Col_Presupuesto,
            this.Col_Observacion,
            this.Col_diasEfectivos,
            this.Col_Dias_SyD_y_Feriado,
            this.Col_BaseVariable});
            this.gridViewPresupuesto.GridControl = this.gridControlPresupuesto;
            this.gridViewPresupuesto.Name = "gridViewPresupuesto";
            this.gridViewPresupuesto.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewPresupuesto.OptionsView.ShowAutoFilterRow = true;
            this.gridViewPresupuesto.OptionsView.ShowFooter = true;
            this.gridViewPresupuesto.OptionsView.ShowGroupPanel = false;
            this.gridViewPresupuesto.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewPresupuesto_CellValueChanged);
            this.gridViewPresupuesto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridViewPresupuesto_KeyUp);
            // 
            // Col_idcargo
            // 
            this.Col_idcargo.Caption = "Cargo";
            this.Col_idcargo.ColumnEdit = this.cmbCargo;
            this.Col_idcargo.FieldName = "IdCargo";
            this.Col_idcargo.Name = "Col_idcargo";
            this.Col_idcargo.Visible = true;
            this.Col_idcargo.VisibleIndex = 0;
            this.Col_idcargo.Width = 166;
            // 
            // cmbCargo
            // 
            this.cmbCargo.AutoHeight = false;
            this.cmbCargo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_cargo});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Col_cargo
            // 
            this.Col_cargo.Caption = "Cargo";
            this.Col_cargo.FieldName = "ca_descripcion";
            this.Col_cargo.Name = "Col_cargo";
            this.Col_cargo.Visible = true;
            this.Col_cargo.VisibleIndex = 0;
            // 
            // Col_IdFuerza
            // 
            this.Col_IdFuerza.Caption = "Fuerza";
            this.Col_IdFuerza.ColumnEdit = this.cmbFuerza;
            this.Col_IdFuerza.FieldName = "IdFuerza";
            this.Col_IdFuerza.Name = "Col_IdFuerza";
            this.Col_IdFuerza.Visible = true;
            this.Col_IdFuerza.VisibleIndex = 1;
            this.Col_IdFuerza.Width = 140;
            // 
            // cmbFuerza
            // 
            this.cmbFuerza.AutoHeight = false;
            this.cmbFuerza.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFuerza.Name = "cmbFuerza";
            this.cmbFuerza.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_fuerza});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_fuerza
            // 
            this.col_fuerza.Caption = "Fuerza";
            this.col_fuerza.FieldName = "fu_descripcion";
            this.col_fuerza.Name = "col_fuerza";
            this.col_fuerza.Visible = true;
            this.col_fuerza.VisibleIndex = 0;
            // 
            // Col_Anio
            // 
            this.Col_Anio.Caption = "Año";
            this.Col_Anio.FieldName = "Anio";
            this.Col_Anio.Name = "Col_Anio";
            this.Col_Anio.Visible = true;
            this.Col_Anio.VisibleIndex = 3;
            this.Col_Anio.Width = 46;
            // 
            // Col_Mes
            // 
            this.Col_Mes.Caption = "Mes";
            this.Col_Mes.FieldName = "Mes";
            this.Col_Mes.Name = "Col_Mes";
            this.Col_Mes.Visible = true;
            this.Col_Mes.VisibleIndex = 4;
            this.Col_Mes.Width = 33;
            // 
            // Col_CantidadVpp
            // 
            this.Col_CantidadVpp.Caption = "Cantidad Empleado";
            this.Col_CantidadVpp.FieldName = "CantidadEmpleados";
            this.Col_CantidadVpp.Name = "Col_CantidadVpp";
            this.Col_CantidadVpp.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_CantidadVpp.Visible = true;
            this.Col_CantidadVpp.VisibleIndex = 7;
            this.Col_CantidadVpp.Width = 89;
            // 
            // Col_Presupuesto
            // 
            this.Col_Presupuesto.Caption = "Presupuesto";
            this.Col_Presupuesto.DisplayFormat.FormatString = "n2";
            this.Col_Presupuesto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Col_Presupuesto.FieldName = "Presupuesto";
            this.Col_Presupuesto.Name = "Col_Presupuesto";
            this.Col_Presupuesto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.Col_Presupuesto.Visible = true;
            this.Col_Presupuesto.VisibleIndex = 8;
            this.Col_Presupuesto.Width = 89;
            // 
            // Col_Observacion
            // 
            this.Col_Observacion.Caption = "Observacion";
            this.Col_Observacion.FieldName = "Observacion";
            this.Col_Observacion.Name = "Col_Observacion";
            this.Col_Observacion.Visible = true;
            this.Col_Observacion.VisibleIndex = 9;
            this.Col_Observacion.Width = 118;
            // 
            // Col_diasEfectivos
            // 
            this.Col_diasEfectivos.Caption = "Dias Efectivos";
            this.Col_diasEfectivos.FieldName = "diasEfectivos";
            this.Col_diasEfectivos.Name = "Col_diasEfectivos";
            this.Col_diasEfectivos.Visible = true;
            this.Col_diasEfectivos.VisibleIndex = 5;
            this.Col_diasEfectivos.Width = 80;
            // 
            // Col_Dias_SyD_y_Feriado
            // 
            this.Col_Dias_SyD_y_Feriado.Caption = "# SyD y feriado";
            this.Col_Dias_SyD_y_Feriado.FieldName = "Dias_SyD_y_Feriado";
            this.Col_Dias_SyD_y_Feriado.Name = "Col_Dias_SyD_y_Feriado";
            this.Col_Dias_SyD_y_Feriado.Visible = true;
            this.Col_Dias_SyD_y_Feriado.VisibleIndex = 6;
            this.Col_Dias_SyD_y_Feriado.Width = 83;
            // 
            // Col_BaseVariable
            // 
            this.Col_BaseVariable.Caption = "Base Variable";
            this.Col_BaseVariable.FieldName = "BaseVariable";
            this.Col_BaseVariable.Name = "Col_BaseVariable";
            this.Col_BaseVariable.Visible = true;
            this.Col_BaseVariable.VisibleIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 155;
            this.labelControl3.Text = "Período:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(2, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 154;
            this.labelControl4.Text = "Proceso:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 153;
            this.labelControl5.Text = "Nómina:";
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.Location = new System.Drawing.Point(71, 74);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodos.Properties.DisplayMember = "pe_Descripcion";
            this.cmbPeriodos.Properties.ValueMember = "IdPeriodo";
            this.cmbPeriodos.Properties.View = this.gridView2;
            this.cmbPeriodos.Size = new System.Drawing.Size(347, 20);
            this.cmbPeriodos.TabIndex = 152;
            this.cmbPeriodos.EditValueChanged += new System.EventHandler(this.cmbPeriodos_EditValueChanged);
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
            // cmbnominaTipo
            // 
            this.cmbnominaTipo.Location = new System.Drawing.Point(71, 49);
            this.cmbnominaTipo.Name = "cmbnominaTipo";
            this.cmbnominaTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnominaTipo.Properties.DisplayMember = "DescripcionProcesoNomina";
            this.cmbnominaTipo.Properties.ReadOnly = true;
            this.cmbnominaTipo.Properties.ValueMember = "IdNomina_TipoLiqui";
            this.cmbnominaTipo.Properties.View = this.gridView3;
            this.cmbnominaTipo.Size = new System.Drawing.Size(347, 20);
            this.cmbnominaTipo.TabIndex = 151;
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
            // cmbnomina
            // 
            this.cmbnomina.Location = new System.Drawing.Point(71, 23);
            this.cmbnomina.Name = "cmbnomina";
            this.cmbnomina.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbnomina.Properties.DisplayMember = "Descripcion";
            this.cmbnomina.Properties.ReadOnly = true;
            this.cmbnomina.Properties.ValueMember = "IdNomina_Tipo";
            this.cmbnomina.Properties.View = this.searchLookUpEdit1View;
            this.cmbnomina.Size = new System.Drawing.Size(347, 20);
            this.cmbnomina.TabIndex = 150;
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
            // frmRo_presupuesto_x_fuerza_cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 437);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cmbPeriodos);
            this.Controls.Add(this.cmbnominaTipo);
            this.Controls.Add(this.cmbnomina);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_presupuesto_x_fuerza_cargo";
            this.Text = "frmRo_presupuesto_x_fuerza_cargo";
            this.Load += new System.EventHandler(this.frmRo_presupuesto_x_fuerza_cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnominaTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbnomina.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlPresupuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdFuerza;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Anio;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Mes;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CantidadVpp;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Presupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_idcargo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbCargo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Col_cargo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbFuerza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_fuerza;
        private DevExpress.XtraGrid.Columns.GridColumn Col_diasEfectivos;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Dias_SyD_y_Feriado;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn Colpe_Descripcion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnominaTipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcionProcesoNomina;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbnomina;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_BaseVariable;
    }
}