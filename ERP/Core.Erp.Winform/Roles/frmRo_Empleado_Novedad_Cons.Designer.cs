namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Empleado_Novedad_Cons
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.grdLista = new DevExpress.XtraGrid.GridControl();
            this.roEmpleadoNovedadCabInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.roEmpleadoNovedadCabInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoNovedadCabInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoNovedadCabInfoBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdLista
            // 
            this.grdLista.DataSource = this.roEmpleadoNovedadCabInfoBindingSource;
            this.grdLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLista.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridLevelNode1.RelationName = "Level1";
            this.grdLista.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdLista.Location = new System.Drawing.Point(0, 0);
            this.grdLista.MainView = this.gridView;
            this.grdLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdLista.Name = "grdLista";
            this.grdLista.Size = new System.Drawing.Size(1396, 254);
            this.grdLista.TabIndex = 10;
            this.grdLista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.grdLista.Click += new System.EventHandler(this.grdLista_Click);
            // 
            // roEmpleadoNovedadCabInfoBindingSource
            // 
            this.roEmpleadoNovedadCabInfoBindingSource.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Novedad_Info);
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
            this.Col_EstadoCobro,
            this.gridColumn1});
            this.gridView.CustomizationFormBounds = new System.Drawing.Rectangle(851, 328, 216, 185);
            this.gridView.GridControl = this.grdLista;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.ColApellidos, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.AllowEdit = false;
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 1;
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
            this.colIdNovedad.Visible = true;
            this.colIdNovedad.VisibleIndex = 2;
            this.colIdNovedad.Width = 98;
            // 
            // colNomPerComp
            // 
            this.colNomPerComp.Caption = "Nombre Completo";
            this.colNomPerComp.FieldName = "NomPerComp";
            this.colNomPerComp.Name = "colNomPerComp";
            this.colNomPerComp.OptionsColumn.AllowEdit = false;
            this.colNomPerComp.Visible = true;
            this.colNomPerComp.VisibleIndex = 3;
            this.colNomPerComp.Width = 268;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha_Transac";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            this.colFecha.Width = 87;
            // 
            // colRubroDescp
            // 
            this.colRubroDescp.Caption = "Rubro";
            this.colRubroDescp.FieldName = "RubroDescp";
            this.colRubroDescp.Name = "colRubroDescp";
            this.colRubroDescp.OptionsColumn.AllowEdit = false;
            this.colRubroDescp.Visible = true;
            this.colRubroDescp.VisibleIndex = 5;
            this.colRubroDescp.Width = 152;
            // 
            // colEstadoCobro
            // 
            this.colEstadoCobro.Caption = "Estado Cobro";
            this.colEstadoCobro.FieldName = "EstadoCobro";
            this.colEstadoCobro.Name = "colEstadoCobro";
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
            this.colInfoNovedadDet.VisibleIndex = 8;
            this.colInfoNovedadDet.Width = 123;
            // 
            // colInfoNovedadDet1
            // 
            this.colInfoNovedadDet1.Caption = "Valor";
            this.colInfoNovedadDet1.FieldName = "InfoNovedadDet.Valor";
            this.colInfoNovedadDet1.Name = "colInfoNovedadDet1";
            this.colInfoNovedadDet1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colInfoNovedadDet1.Visible = true;
            this.colInfoNovedadDet1.VisibleIndex = 10;
            this.colInfoNovedadDet1.Width = 53;
            // 
            // ColApellidos
            // 
            this.ColApellidos.Caption = "Apellidos";
            this.ColApellidos.FieldName = "InfoPersona.pe_apellido";
            this.ColApellidos.Name = "ColApellidos";
            // 
            // ColApellido
            // 
            this.ColApellido.Caption = "Nombres";
            this.ColApellido.FieldName = "InfoPersona.pe_nombre";
            this.ColApellido.Name = "ColApellido";
            // 
            // ColNumHoras
            // 
            this.ColNumHoras.Caption = "Num Horas";
            this.ColNumHoras.FieldName = "Num_Horas";
            this.ColNumHoras.Name = "ColNumHoras";
            this.ColNumHoras.Visible = true;
            this.ColNumHoras.VisibleIndex = 9;
            this.ColNumHoras.Width = 101;
            // 
            // Col_DescripcionProcesoNomina
            // 
            this.Col_DescripcionProcesoNomina.Caption = "Descuenta en:";
            this.Col_DescripcionProcesoNomina.FieldName = "DescripcionProcesoNomina";
            this.Col_DescripcionProcesoNomina.Name = "Col_DescripcionProcesoNomina";
            this.Col_DescripcionProcesoNomina.Visible = true;
            this.Col_DescripcionProcesoNomina.VisibleIndex = 6;
            this.Col_DescripcionProcesoNomina.Width = 114;
            // 
            // Col_Observacion
            // 
            this.Col_Observacion.Caption = "Observacion";
            this.Col_Observacion.FieldName = "InfoNovedadDet.Observacion";
            this.Col_Observacion.Name = "Col_Observacion";
            this.Col_Observacion.Visible = true;
            this.Col_Observacion.VisibleIndex = 7;
            this.Col_Observacion.Width = 101;
            // 
            // Col_descripcion_tiponomina
            // 
            this.Col_descripcion_tiponomina.Caption = "Nomina";
            this.Col_descripcion_tiponomina.FieldName = "descripcion_tiponomina";
            this.Col_descripcion_tiponomina.Name = "Col_descripcion_tiponomina";
            this.Col_descripcion_tiponomina.Visible = true;
            this.Col_descripcion_tiponomina.VisibleIndex = 0;
            // 
            // Col_pe_cedulaRuc
            // 
            this.Col_pe_cedulaRuc.Caption = "Cedula";
            this.Col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Name = "Col_pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Visible = true;
            this.Col_pe_cedulaRuc.VisibleIndex = 11;
            // 
            // Col_EstadoCobro
            // 
            this.Col_EstadoCobro.Caption = "Estado Cobro";
            this.Col_EstadoCobro.FieldName = "EstadoCobro";
            this.Col_EstadoCobro.Name = "Col_EstadoCobro";
            this.Col_EstadoCobro.Visible = true;
            this.Col_EstadoCobro.VisibleIndex = 12;
            // 
            // roEmpleadoNovedadCabInfoBindingSource1
            // 
            this.roEmpleadoNovedadCabInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Roles.ro_Empleado_Novedad_Info);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1396, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 197);
            this.panel1.TabIndex = 12;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 10, 28, 11, 55, 23, 183);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 12, 28, 11, 55, 23, 183);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1396, 193);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnCancelarCuotas_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnCancelarCuotas_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnCancelarCuotas_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            this.ucGe_Menu_Mantenimiento_x_usuario.Load += new System.EventHandler(this.ucGe_Menu_Mantenimiento_x_usuario_Load);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdLista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1396, 254);
            this.panel2.TabIndex = 13;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Usuario";
            this.gridColumn1.FieldName = "IdUsuario";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 13;
            // 
            // frmRo_Empleado_Novedad_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRo_Empleado_Novedad_Cons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Empleado por Novedades";
            this.Load += new System.EventHandler(this.frmRo_Empleado_Novedad_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoNovedadCabInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roEmpleadoNovedadCabInfoBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdLista;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.BindingSource roEmpleadoNovedadCabInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNomPerComp;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValor;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNovedad;
        private DevExpress.XtraGrid.Columns.GridColumn colRubroDescp;
        private System.Windows.Forms.BindingSource roEmpleadoNovedadCabInfoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn colInfoNovedadDet;
        private DevExpress.XtraGrid.Columns.GridColumn colInfoNovedadDet1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellidos;
        private DevExpress.XtraGrid.Columns.GridColumn ColApellido;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumHoras;
        private DevExpress.XtraGrid.Columns.GridColumn Col_DescripcionProcesoNomina;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_descripcion_tiponomina;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn Col_EstadoCobro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}