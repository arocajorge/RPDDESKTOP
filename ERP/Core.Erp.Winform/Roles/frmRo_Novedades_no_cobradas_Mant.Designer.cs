namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Novedades_no_cobradas_Mant
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.roEmpleadoNovedadCabInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.roEmpleadoNovedadCabInfoBindingSource1 = new System.Windows.Forms.BindingSource();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btn_buscar = new DevExpress.XtraEditors.SimpleButton();
            this.dtp_fecha_corte = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdLista = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNovedad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomPerComp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRubroDescp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfoNovedadDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInfoNovedadDet1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNumHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_DescripcionProcesoNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_descripcion_tiponomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_EstadoCobro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoNovedadCabInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoNovedadCabInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_corte.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_corte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roEmpleadoNovedadCabInfoBindingSource
            // 
            this.roEmpleadoNovedadCabInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Novedad_Info);
            // 
            // roEmpleadoNovedadCabInfoBindingSource1
            // 
            this.roEmpleadoNovedadCabInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Novedad_Info);
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
            this.ucGe_Menu.Size = new System.Drawing.Size(1026, 29);
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
            this.ucGe_Menu.Visible_btnGuardar = false;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            this.ucGe_Menu.event_btnGuardar_y_Salir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_y_Salir_Click(this.ucGe_Menu_event_btnGuardar_y_Salir_Click);
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            this.ucGe_Menu.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_event_btnSalir_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btn_buscar);
            this.splitContainerControl1.Panel1.Controls.Add(this.dtp_fecha_corte);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.grdLista);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1026, 355);
            this.splitContainerControl1.SplitterPosition = 31;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btn_buscar
            // 
            this.btn_buscar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_buscar.Image = global::Core.Erp.Winform.Properties.Resources.Buscar_16x164;
            this.btn_buscar.Location = new System.Drawing.Point(240, 6);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(83, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Consultar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dtp_fecha_corte
            // 
            this.dtp_fecha_corte.EditValue = null;
            this.dtp_fecha_corte.Location = new System.Drawing.Point(79, 6);
            this.dtp_fecha_corte.Name = "dtp_fecha_corte";
            this.dtp_fecha_corte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fecha_corte.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtp_fecha_corte.Size = new System.Drawing.Size(143, 20);
            this.dtp_fecha_corte.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fecha corte:";
            // 
            // grdLista
            // 
            this.grdLista.DataSource = this.roEmpleadoNovedadCabInfoBindingSource;
            this.grdLista.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.grdLista.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdLista.Location = new System.Drawing.Point(0, 0);
            this.grdLista.MainView = this.gridView;
            this.grdLista.Name = "grdLista";
            this.grdLista.Size = new System.Drawing.Size(1026, 319);
            this.grdLista.TabIndex = 12;
            this.grdLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colIdNovedad,
            this.colNomPerComp,
            this.colFecha,
            this.colRubroDescp,
            this.colEstadoCobro,
            this.colTotalValor,
            this.colEstado,
            this.colInfoNovedadDet,
            this.colInfoNovedadDet1,
            this.ColApellidos,
            this.ColApellido,
            this.ColNumHoras,
            this.Col_DescripcionProcesoNomina,
            this.Col_Observacion,
            this.Col_descripcion_tiponomina,
            this.Col_pe_cedulaRuc,
            this.Col_EstadoCobro});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(851, 328, 216, 185);
            this.gridView.GridControl = this.grdLista;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColApellidos, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.AllowEdit = false;
            this.colIdEmpleado.Width = 77;
            // 
            // colIdNovedad
            // 
            this.colIdNovedad.Caption = "Número Novedad";
            this.colIdNovedad.FieldName = "IdNovedad";
            this.colIdNovedad.Name = "colIdNovedad";
            this.colIdNovedad.OptionsColumn.AllowEdit = false;
            this.colIdNovedad.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colIdNovedad.Width = 98;
            // 
            // colNomPerComp
            // 
            this.colNomPerComp.Caption = "Nombre Completo";
            this.colNomPerComp.FieldName = "NomPerComp";
            this.colNomPerComp.Name = "colNomPerComp";
            this.colNomPerComp.OptionsColumn.AllowEdit = false;
            this.colNomPerComp.Visible = true;
            this.colNomPerComp.VisibleIndex = 1;
            this.colNomPerComp.Width = 221;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha_Transac";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            this.colFecha.Width = 87;
            // 
            // colRubroDescp
            // 
            this.colRubroDescp.Caption = "Rubro";
            this.colRubroDescp.FieldName = "RubroDescp";
            this.colRubroDescp.Name = "colRubroDescp";
            this.colRubroDescp.OptionsColumn.AllowEdit = false;
            this.colRubroDescp.Visible = true;
            this.colRubroDescp.VisibleIndex = 3;
            this.colRubroDescp.Width = 152;
            // 
            // colEstadoCobro
            // 
            this.colEstadoCobro.Caption = "Estado Cobro";
            this.colEstadoCobro.FieldName = "EstadoCobro";
            this.colEstadoCobro.Name = "colEstadoCobro";
            this.colEstadoCobro.OptionsColumn.AllowEdit = false;
            // 
            // colTotalValor
            // 
            this.colTotalValor.Caption = "Valor Total";
            this.colTotalValor.FieldName = "TotalValor";
            this.colTotalValor.Name = "colTotalValor";
            this.colTotalValor.OptionsColumn.AllowEdit = false;
            this.colTotalValor.Width = 71;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "InfoNovedadDet.Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Width = 43;
            // 
            // colInfoNovedadDet
            // 
            this.colInfoNovedadDet.Caption = "Fecha de Pago";
            this.colInfoNovedadDet.FieldName = "InfoNovedadDet.FechaPago";
            this.colInfoNovedadDet.Name = "colInfoNovedadDet";
            this.colInfoNovedadDet.Visible = true;
            this.colInfoNovedadDet.VisibleIndex = 7;
            this.colInfoNovedadDet.Width = 123;
            // 
            // colInfoNovedadDet1
            // 
            this.colInfoNovedadDet1.Caption = "Valor";
            this.colInfoNovedadDet1.FieldName = "InfoNovedadDet.Valor";
            this.colInfoNovedadDet1.Name = "colInfoNovedadDet1";
            this.colInfoNovedadDet1.OptionsColumn.AllowEdit = false;
            this.colInfoNovedadDet1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colInfoNovedadDet1.Visible = true;
            this.colInfoNovedadDet1.VisibleIndex = 6;
            this.colInfoNovedadDet1.Width = 72;
            // 
            // ColApellidos
            // 
            this.ColApellidos.Caption = "Apellidos";
            this.ColApellidos.FieldName = "InfoPersona.pe_apellido";
            this.ColApellidos.Name = "ColApellidos";
            this.ColApellidos.OptionsColumn.AllowEdit = false;
            // 
            // ColApellido
            // 
            this.ColApellido.Caption = "Nombres";
            this.ColApellido.FieldName = "InfoPersona.pe_nombre";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.OptionsColumn.AllowEdit = false;
            // 
            // ColNumHoras
            // 
            this.ColNumHoras.Caption = "Num Horas";
            this.ColNumHoras.FieldName = "Num_Horas";
            this.ColNumHoras.Name = "ColNumHoras";
            this.ColNumHoras.OptionsColumn.AllowEdit = false;
            this.ColNumHoras.Width = 101;
            // 
            // Col_DescripcionProcesoNomina
            // 
            this.Col_DescripcionProcesoNomina.Caption = "Descuenta en:";
            this.Col_DescripcionProcesoNomina.FieldName = "DescripcionProcesoNomina";
            this.Col_DescripcionProcesoNomina.Name = "Col_DescripcionProcesoNomina";
            this.Col_DescripcionProcesoNomina.OptionsColumn.AllowEdit = false;
            this.Col_DescripcionProcesoNomina.Visible = true;
            this.Col_DescripcionProcesoNomina.VisibleIndex = 4;
            this.Col_DescripcionProcesoNomina.Width = 114;
            // 
            // Col_Observacion
            // 
            this.Col_Observacion.Caption = "Observacion";
            this.Col_Observacion.FieldName = "InfoNovedadDet.Observacion";
            this.Col_Observacion.Name = "Col_Observacion";
            this.Col_Observacion.OptionsColumn.AllowEdit = false;
            this.Col_Observacion.Visible = true;
            this.Col_Observacion.VisibleIndex = 5;
            this.Col_Observacion.Width = 172;
            // 
            // Col_descripcion_tiponomina
            // 
            this.Col_descripcion_tiponomina.Caption = "Nomina";
            this.Col_descripcion_tiponomina.FieldName = "descripcion_tiponomina";
            this.Col_descripcion_tiponomina.Name = "Col_descripcion_tiponomina";
            this.Col_descripcion_tiponomina.OptionsColumn.AllowEdit = false;
            this.Col_descripcion_tiponomina.Visible = true;
            this.Col_descripcion_tiponomina.VisibleIndex = 0;
            // 
            // Col_pe_cedulaRuc
            // 
            this.Col_pe_cedulaRuc.Caption = "Cedula";
            this.Col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Name = "Col_pe_cedulaRuc";
            this.Col_pe_cedulaRuc.OptionsColumn.AllowEdit = false;
            // 
            // Col_EstadoCobro
            // 
            this.Col_EstadoCobro.Caption = "Estado Cobro";
            this.Col_EstadoCobro.FieldName = "EstadoCobro";
            this.Col_EstadoCobro.Name = "Col_EstadoCobro";
            this.Col_EstadoCobro.OptionsColumn.AllowEdit = false;
            this.Col_EstadoCobro.Visible = true;
            this.Col_EstadoCobro.VisibleIndex = 8;
            // 
            // frmRo_Novedades_no_cobradas_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 384);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Novedades_no_cobradas_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Empleado por Novedades";
            this.Load += new System.EventHandler(this.frmRo_Novedades_no_cobradas_Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoNovedadCabInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoNovedadCabInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_corte.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_corte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource roEmpleadoNovedadCabInfoBindingSource;
        private System.Windows.Forms.BindingSource roEmpleadoNovedadCabInfoBindingSource1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl grdLista;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNovedad;
        private DevExpress.XtraGrid.Columns.GridColumn colNomPerComp;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colRubroDescp;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValor;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colInfoNovedadDet;
        private DevExpress.XtraGrid.Columns.GridColumn colInfoNovedadDet1;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellidos;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellido;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumHoras;
        private DevExpress.XtraGrid.Columns.GridColumn Col_DescripcionProcesoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_descripcion_tiponomina;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn Col_EstadoCobro;
        private DevExpress.XtraEditors.DateEdit dtp_fecha_corte;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_buscar;
    }
}