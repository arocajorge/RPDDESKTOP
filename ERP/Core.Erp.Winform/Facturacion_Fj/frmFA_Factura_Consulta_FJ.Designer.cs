namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmFA_Factura_Consulta_FJ
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
            this.gridConsultaCot = new DevExpress.XtraGrid.GridControl();
            this.gridView_factruras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Vendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_tipoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCbteVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_plazo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodCbteVta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_serie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_serie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_NumFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_fech_venc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_tipo_venta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vt_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_factruras)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridConsultaCot
            // 
            this.gridConsultaCot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsultaCot.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridConsultaCot.Location = new System.Drawing.Point(0, 198);
            this.gridConsultaCot.MainView = this.gridView_factruras;
            this.gridConsultaCot.Margin = new System.Windows.Forms.Padding(4);
            this.gridConsultaCot.Name = "gridConsultaCot";
            this.gridConsultaCot.Size = new System.Drawing.Size(1492, 254);
            this.gridConsultaCot.TabIndex = 19;
            this.gridConsultaCot.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_factruras});
            // 
            // gridView_factruras
            // 
            this.gridView_factruras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Sucursal,
            this.Bodega,
            this.Cliente,
            this.Vendedor,
            this.vt_tipoDoc,
            this.IVA,
            this.Subtotal,
            this.Total,
            this.IdCbteVta,
            this.vt_fecha,
            this.vt_plazo,
            this.CodCbteVta,
            this.vt_serie1,
            this.vt_serie2,
            this.vt_NumFactura,
            this.vt_fech_venc,
            this.vt_tipo_venta,
            this.vt_Observacion,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView_factruras.GridControl = this.gridConsultaCot;
            this.gridView_factruras.Name = "gridView_factruras";
            this.gridView_factruras.OptionsBehavior.Editable = false;
            this.gridView_factruras.OptionsView.ShowAutoFilterRow = true;
            this.gridView_factruras.OptionsView.ShowFooter = true;
            this.gridView_factruras.OptionsView.ShowGroupPanel = false;
            this.gridView_factruras.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Sucursal, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Bodega, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.vt_NumFactura, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView_factruras.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_factruras_RowCellStyle);
            this.gridView_factruras.DoubleClick += new System.EventHandler(this.gridView_factruras_DoubleClick);
            // 
            // Sucursal
            // 
            this.Sucursal.Caption = "Sucursal";
            this.Sucursal.FieldName = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.Visible = true;
            this.Sucursal.VisibleIndex = 1;
            this.Sucursal.Width = 157;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Width = 58;
            // 
            // Cliente
            // 
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 4;
            this.Cliente.Width = 227;
            // 
            // Vendedor
            // 
            this.Vendedor.Caption = "Vendedor";
            this.Vendedor.FieldName = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Width = 103;
            // 
            // vt_tipoDoc
            // 
            this.vt_tipoDoc.Caption = "Tipo Doc";
            this.vt_tipoDoc.FieldName = "vt_tipoDoc";
            this.vt_tipoDoc.Name = "vt_tipoDoc";
            this.vt_tipoDoc.Width = 77;
            // 
            // IVA
            // 
            this.IVA.Caption = "IVA";
            this.IVA.DisplayFormat.FormatString = "$ #,#######0.00;$ #,#######0.00";
            this.IVA.FieldName = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.Width = 28;
            // 
            // Subtotal
            // 
            this.Subtotal.Caption = "Subtotal";
            this.Subtotal.DisplayFormat.FormatString = "$ #,#######0.00;$ #,#######0.00";
            this.Subtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Subtotal.FieldName = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.Width = 47;
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.DisplayFormat.FormatString = "n2";
            this.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Total.FieldName = "Total";
            this.Total.Name = "Total";
            this.Total.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:n2}")});
            this.Total.Visible = true;
            this.Total.VisibleIndex = 6;
            this.Total.Width = 129;
            // 
            // IdCbteVta
            // 
            this.IdCbteVta.Caption = "Id Cbte Vta";
            this.IdCbteVta.FieldName = "IdCbteVta";
            this.IdCbteVta.Name = "IdCbteVta";
            this.IdCbteVta.Visible = true;
            this.IdCbteVta.VisibleIndex = 0;
            this.IdCbteVta.Width = 83;
            // 
            // vt_fecha
            // 
            this.vt_fecha.Caption = "Fecha";
            this.vt_fecha.FieldName = "vt_fecha";
            this.vt_fecha.Name = "vt_fecha";
            this.vt_fecha.Visible = true;
            this.vt_fecha.VisibleIndex = 3;
            this.vt_fecha.Width = 182;
            // 
            // vt_plazo
            // 
            this.vt_plazo.Caption = "vt_plazo";
            this.vt_plazo.FieldName = "vt_plazo";
            this.vt_plazo.Name = "vt_plazo";
            this.vt_plazo.Width = 137;
            // 
            // CodCbteVta
            // 
            this.CodCbteVta.Caption = "CodCbteVta";
            this.CodCbteVta.FieldName = "CodCbteVta";
            this.CodCbteVta.Name = "CodCbteVta";
            this.CodCbteVta.Width = 175;
            // 
            // vt_serie1
            // 
            this.vt_serie1.Caption = "Serie1";
            this.vt_serie1.FieldName = "vt_serie1";
            this.vt_serie1.Name = "vt_serie1";
            this.vt_serie1.Width = 57;
            // 
            // vt_serie2
            // 
            this.vt_serie2.Caption = "Serie2";
            this.vt_serie2.FieldName = "vt_serie2";
            this.vt_serie2.Name = "vt_serie2";
            this.vt_serie2.Width = 55;
            // 
            // vt_NumFactura
            // 
            this.vt_NumFactura.Caption = "# Factura";
            this.vt_NumFactura.FieldName = "vt_NumFactura";
            this.vt_NumFactura.Name = "vt_NumFactura";
            this.vt_NumFactura.Visible = true;
            this.vt_NumFactura.VisibleIndex = 2;
            this.vt_NumFactura.Width = 155;
            // 
            // vt_fech_venc
            // 
            this.vt_fech_venc.Caption = "Fecha Venc.";
            this.vt_fech_venc.FieldName = "vt_fech_venc";
            this.vt_fech_venc.Name = "vt_fech_venc";
            this.vt_fech_venc.Width = 94;
            // 
            // vt_tipo_venta
            // 
            this.vt_tipo_venta.Caption = "vt_tipo_venta";
            this.vt_tipo_venta.FieldName = "vt_tipo_venta";
            this.vt_tipo_venta.Name = "vt_tipo_venta";
            this.vt_tipo_venta.Width = 157;
            // 
            // vt_Observacion
            // 
            this.vt_Observacion.Caption = "Observación";
            this.vt_Observacion.FieldName = "vt_Observacion";
            this.vt_Observacion.Name = "vt_Observacion";
            this.vt_Observacion.Visible = true;
            this.vt_Observacion.VisibleIndex = 5;
            this.vt_Observacion.Width = 235;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Valor cobrado";
            this.gridColumn1.FieldName = "valor_cobro";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "valor_cobro", "{0:n2}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 7;
            this.gridColumn1.Width = 125;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Saldo";
            this.gridColumn2.FieldName = "vt_saldo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "vt_saldo", "{0:n2}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 8;
            this.gridColumn2.Width = 116;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "# CbteCble";
            this.gridColumn3.FieldName = "IdCbteCble";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 9;
            this.gridColumn3.Width = 65;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Estado";
            this.gridColumn4.FieldName = "Estado";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 10;
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = true;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 9, 12, 16, 21, 44, 584);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 11, 12, 16, 21, 44, 584);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1492, 198);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 21;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnDuplicar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnDuplicar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnDuplicar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1492, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1492, 198);
            this.panel2.TabIndex = 23;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cant forma pago";
            this.gridColumn5.FieldName = "cant_forma_pago";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IdFormaPago";
            this.gridColumn6.FieldName = "IdFormaPago";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Forma pago";
            this.gridColumn7.FieldName = "nom_FormaPago";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // frmFA_Factura_Consulta_FJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 474);
            this.Controls.Add(this.gridConsultaCot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFA_Factura_Consulta_FJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas - Consulta";
            this.Load += new System.EventHandler(this.frmFA_Factura_Consulta_FJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaCot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_factruras)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridConsultaCot;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_factruras;
        private DevExpress.XtraGrid.Columns.GridColumn Sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Vendedor;
        private DevExpress.XtraGrid.Columns.GridColumn vt_tipoDoc;
        private DevExpress.XtraGrid.Columns.GridColumn IVA;
        private DevExpress.XtraGrid.Columns.GridColumn Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn IdCbteVta;
        private DevExpress.XtraGrid.Columns.GridColumn vt_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn vt_plazo;
        private DevExpress.XtraGrid.Columns.GridColumn CodCbteVta;
        private DevExpress.XtraGrid.Columns.GridColumn vt_serie1;
        private DevExpress.XtraGrid.Columns.GridColumn vt_serie2;
        private DevExpress.XtraGrid.Columns.GridColumn vt_NumFactura;
        private DevExpress.XtraGrid.Columns.GridColumn vt_fech_venc;
        private DevExpress.XtraGrid.Columns.GridColumn vt_tipo_venta;
        private DevExpress.XtraGrid.Columns.GridColumn vt_Observacion;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;

    }
}