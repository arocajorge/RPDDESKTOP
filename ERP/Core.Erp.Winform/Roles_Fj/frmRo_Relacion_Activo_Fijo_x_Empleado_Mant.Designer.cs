namespace Core.Erp.Winform.Roles_Fj
{
    partial class frmRo_Relacion_Activo_Fijo_x_Empleado_Mant
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl_empleados_Actuales = new DevExpress.XtraGrid.GridControl();
            this.gridView_empleados_actuales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_idEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_empleado = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Co_IdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_NomCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_de_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Co_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Fecha_Asignacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Fecha_Hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_cmb_activo_Fijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_activo_Fijo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Af_DescripcionCorta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdCentroCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_centro_costo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_IdCentroCosto_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_subcentro = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Centro_costo_ = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_empleados_Actuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_empleados_actuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_activo_Fijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1209, 29);
            this.ucGe_Menu.TabIndex = 0;
            this.ucGe_Menu.Visible_bntAnular = false;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
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
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl_empleados_Actuales);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 29);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1209, 497);
            this.panelControl1.TabIndex = 1;
            // 
            // gridControl_empleados_Actuales
            // 
            this.gridControl_empleados_Actuales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_empleados_Actuales.Location = new System.Drawing.Point(2, 2);
            this.gridControl_empleados_Actuales.MainView = this.gridView_empleados_actuales;
            this.gridControl_empleados_Actuales.Name = "gridControl_empleados_Actuales";
            this.gridControl_empleados_Actuales.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_empleado,
            this.repositoryItemCheckEdit1,
            this.cmb_activo_Fijo,
            this.cmb_centro_costo,
            this.cmb_subcentro});
            this.gridControl_empleados_Actuales.Size = new System.Drawing.Size(1205, 493);
            this.gridControl_empleados_Actuales.TabIndex = 3;
            this.gridControl_empleados_Actuales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_empleados_actuales});
            // 
            // gridView_empleados_actuales
            // 
            this.gridView_empleados_actuales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_idEmpleado,
            this.col_cargo,
            this.col_ubicacion,
            this.Col_Fecha_Asignacion,
            this.Col_Fecha_Hasta,
            this.col_check,
            this.col_cmb_activo_Fijo,
            this.Col_IdCentroCosto,
            this.Col_IdCentroCosto_sub_centro_costo});
            this.gridView_empleados_actuales.GridControl = this.gridControl_empleados_Actuales;
            this.gridView_empleados_actuales.Name = "gridView_empleados_actuales";
            this.gridView_empleados_actuales.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_empleados_actuales.OptionsView.ShowAutoFilterRow = true;
            this.gridView_empleados_actuales.OptionsView.ShowFooter = true;
            this.gridView_empleados_actuales.OptionsView.ShowGroupPanel = false;
            this.gridView_empleados_actuales.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView_empleados_actuales_CellValueChanged_1);
            this.gridView_empleados_actuales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView_empleados_actuales_KeyDown);
            // 
            // col_idEmpleado
            // 
            this.col_idEmpleado.Caption = "empleado";
            this.col_idEmpleado.ColumnEdit = this.cmb_empleado;
            this.col_idEmpleado.FieldName = "IdEmpleado";
            this.col_idEmpleado.Name = "col_idEmpleado";
            this.col_idEmpleado.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.col_idEmpleado.Visible = true;
            this.col_idEmpleado.VisibleIndex = 0;
            this.col_idEmpleado.Width = 330;
            // 
            // cmb_empleado
            // 
            this.cmb_empleado.AutoHeight = false;
            this.cmb_empleado.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_empleado.Name = "cmb_empleado";
            this.cmb_empleado.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Co_IdEmpleado,
            this.Col_pe_NomCompleto,
            this.Col_pe_cedulaRuc,
            this.Col_de_descripcion,
            this.Co_cargo});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Co_IdEmpleado
            // 
            this.Co_IdEmpleado.Caption = "Id";
            this.Co_IdEmpleado.FieldName = "IdEmpleado";
            this.Co_IdEmpleado.Name = "Co_IdEmpleado";
            this.Co_IdEmpleado.Visible = true;
            this.Co_IdEmpleado.VisibleIndex = 0;
            this.Co_IdEmpleado.Width = 60;
            // 
            // Col_pe_NomCompleto
            // 
            this.Col_pe_NomCompleto.Caption = "Nombres";
            this.Col_pe_NomCompleto.FieldName = "pe_NomCompleto";
            this.Col_pe_NomCompleto.Name = "Col_pe_NomCompleto";
            this.Col_pe_NomCompleto.Visible = true;
            this.Col_pe_NomCompleto.VisibleIndex = 2;
            this.Col_pe_NomCompleto.Width = 326;
            // 
            // Col_pe_cedulaRuc
            // 
            this.Col_pe_cedulaRuc.Caption = "Cedula";
            this.Col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Name = "Col_pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Visible = true;
            this.Col_pe_cedulaRuc.VisibleIndex = 1;
            this.Col_pe_cedulaRuc.Width = 116;
            // 
            // Col_de_descripcion
            // 
            this.Col_de_descripcion.Caption = "Departamento";
            this.Col_de_descripcion.FieldName = "de_descripcion";
            this.Col_de_descripcion.Name = "Col_de_descripcion";
            this.Col_de_descripcion.Visible = true;
            this.Col_de_descripcion.VisibleIndex = 4;
            this.Col_de_descripcion.Width = 326;
            // 
            // Co_cargo
            // 
            this.Co_cargo.Caption = "Cargo";
            this.Co_cargo.FieldName = "cargo";
            this.Co_cargo.Name = "Co_cargo";
            this.Co_cargo.Visible = true;
            this.Co_cargo.VisibleIndex = 3;
            this.Co_cargo.Width = 333;
            // 
            // col_cargo
            // 
            this.col_cargo.Caption = "Cargo";
            this.col_cargo.Name = "col_cargo";
            this.col_cargo.Width = 225;
            // 
            // col_ubicacion
            // 
            this.col_ubicacion.Caption = "ubicacion";
            this.col_ubicacion.Name = "col_ubicacion";
            this.col_ubicacion.Width = 367;
            // 
            // Col_Fecha_Asignacion
            // 
            this.Col_Fecha_Asignacion.Caption = "Fecha Desde";
            this.Col_Fecha_Asignacion.FieldName = "Fecha_Asignacion";
            this.Col_Fecha_Asignacion.Name = "Col_Fecha_Asignacion";
            this.Col_Fecha_Asignacion.Width = 81;
            // 
            // Col_Fecha_Hasta
            // 
            this.Col_Fecha_Hasta.Caption = "Fecha Hasta";
            this.Col_Fecha_Hasta.FieldName = "Fecha_Hasta";
            this.Col_Fecha_Hasta.Name = "Col_Fecha_Hasta";
            this.Col_Fecha_Hasta.Width = 85;
            // 
            // col_check
            // 
            this.col_check.Caption = "*";
            this.col_check.ColumnEdit = this.repositoryItemCheckEdit1;
            this.col_check.FieldName = "check";
            this.col_check.Name = "col_check";
            this.col_check.Width = 20;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // col_cmb_activo_Fijo
            // 
            this.col_cmb_activo_Fijo.Caption = "Activo fijo";
            this.col_cmb_activo_Fijo.ColumnEdit = this.cmb_activo_Fijo;
            this.col_cmb_activo_Fijo.FieldName = "IdActivo_fijo";
            this.col_cmb_activo_Fijo.Name = "col_cmb_activo_Fijo";
            this.col_cmb_activo_Fijo.Visible = true;
            this.col_cmb_activo_Fijo.VisibleIndex = 1;
            this.col_cmb_activo_Fijo.Width = 330;
            // 
            // cmb_activo_Fijo
            // 
            this.cmb_activo_Fijo.AutoHeight = false;
            this.cmb_activo_Fijo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_activo_Fijo.DisplayMember = "Af_DescripcionCorta";
            this.cmb_activo_Fijo.Name = "cmb_activo_Fijo";
            this.cmb_activo_Fijo.ValueMember = "IdActivoFijo";
            this.cmb_activo_Fijo.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Af_DescripcionCorta});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Af_DescripcionCorta
            // 
            this.Col_Af_DescripcionCorta.Caption = "Activo fijo";
            this.Col_Af_DescripcionCorta.FieldName = "Af_DescripcionCorta";
            this.Col_Af_DescripcionCorta.Name = "Col_Af_DescripcionCorta";
            this.Col_Af_DescripcionCorta.Visible = true;
            this.Col_Af_DescripcionCorta.VisibleIndex = 0;
            // 
            // Col_IdCentroCosto
            // 
            this.Col_IdCentroCosto.Caption = "Centro costo";
            this.Col_IdCentroCosto.ColumnEdit = this.cmb_centro_costo;
            this.Col_IdCentroCosto.FieldName = "IdCentroCosto";
            this.Col_IdCentroCosto.Name = "Col_IdCentroCosto";
            this.Col_IdCentroCosto.OptionsColumn.AllowEdit = false;
            this.Col_IdCentroCosto.Visible = true;
            this.Col_IdCentroCosto.VisibleIndex = 2;
            this.Col_IdCentroCosto.Width = 259;
            // 
            // cmb_centro_costo
            // 
            this.cmb_centro_costo.AutoHeight = false;
            this.cmb_centro_costo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_centro_costo.DisplayMember = "Centro_costo";
            this.cmb_centro_costo.Name = "cmb_centro_costo";
            this.cmb_centro_costo.ValueMember = "IdCentroCosto";
            this.cmb_centro_costo.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Centro_costo});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Centro_costo
            // 
            this.Col_Centro_costo.Caption = "Centro costo";
            this.Col_Centro_costo.FieldName = "Centro_costo";
            this.Col_Centro_costo.Name = "Col_Centro_costo";
            this.Col_Centro_costo.Visible = true;
            this.Col_Centro_costo.VisibleIndex = 0;
            // 
            // Col_IdCentroCosto_sub_centro_costo
            // 
            this.Col_IdCentroCosto_sub_centro_costo.Caption = "Subcentro costo";
            this.Col_IdCentroCosto_sub_centro_costo.ColumnEdit = this.cmb_subcentro;
            this.Col_IdCentroCosto_sub_centro_costo.FieldName = "IdCentroCosto_sub_centro_costo";
            this.Col_IdCentroCosto_sub_centro_costo.Name = "Col_IdCentroCosto_sub_centro_costo";
            this.Col_IdCentroCosto_sub_centro_costo.OptionsColumn.AllowEdit = false;
            this.Col_IdCentroCosto_sub_centro_costo.Visible = true;
            this.Col_IdCentroCosto_sub_centro_costo.VisibleIndex = 3;
            this.Col_IdCentroCosto_sub_centro_costo.Width = 268;
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
            this.Col_Centro_costo_});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Centro_costo_
            // 
            this.Col_Centro_costo_.Caption = "Subcentro costo";
            this.Col_Centro_costo_.FieldName = "Centro_costo";
            this.Col_Centro_costo_.Name = "Col_Centro_costo_";
            this.Col_Centro_costo_.Visible = true;
            this.Col_Centro_costo_.VisibleIndex = 0;
            // 
            // frmRo_Relacion_Activo_Fijo_x_Empleado_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 526);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Relacion_Activo_Fijo_x_Empleado_Mant";
            this.Text = "frmRo_Relacion_Activo_Fijo_x_Empleado_Mant";
            this.Load += new System.EventHandler(this.frmRo_Relacion_Activo_Fijo_x_Empleado_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_empleados_Actuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_empleados_actuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_activo_Fijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_centro_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_subcentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl_empleados_Actuales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_empleados_actuales;
        private DevExpress.XtraGrid.Columns.GridColumn col_idEmpleado;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_empleado;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Co_IdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_NomCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn Col_de_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Co_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn col_cargo;
        private DevExpress.XtraGrid.Columns.GridColumn col_ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha_Asignacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha_Hasta;
        private DevExpress.XtraGrid.Columns.GridColumn col_check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_cmb_activo_Fijo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_activo_Fijo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Af_DescripcionCorta;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdCentroCosto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_centro_costo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdCentroCosto_sub_centro_costo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_subcentro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Centro_costo_;
    }
}