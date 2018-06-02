namespace Core.Erp.Winform.Facturacion
{
    partial class frmFa_proforma_cons
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
            this.uc_menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.gridControl_proforma = new DevExpress.XtraGrid.GridControl();
            this.gridView_proforma = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_proforma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_proforma)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_menu
            // 
            this.uc_menu.CargarTodasBodegas = false;
            this.uc_menu.CargarTodasSucursales = true;
            this.uc_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_menu.Enable_boton_anular = true;
            this.uc_menu.Enable_boton_CancelarCuotas = true;
            this.uc_menu.Enable_boton_CargaMarcaciónExcel = true;
            this.uc_menu.Enable_boton_consultar = true;
            this.uc_menu.Enable_boton_DiseñoCheque = true;
            this.uc_menu.Enable_boton_DiseñoChequeComprobante = true;
            this.uc_menu.Enable_boton_Duplicar = true;
            this.uc_menu.Enable_boton_GenerarPeriodos = true;
            this.uc_menu.Enable_boton_GenerarXml = true;
            this.uc_menu.Enable_boton_Habilitar_Reg = true;
            this.uc_menu.Enable_boton_Importar_XML = true;
            this.uc_menu.Enable_boton_imprimir = true;
            this.uc_menu.Enable_boton_LoteCheque = true;
            this.uc_menu.Enable_boton_modificar = true;
            this.uc_menu.Enable_boton_nuevo = true;
            this.uc_menu.Enable_boton_NuevoCheque = true;
            this.uc_menu.Enable_boton_periodo = true;
            this.uc_menu.Enable_boton_salir = true;
            this.uc_menu.Enable_btnImpExcel = true;
            this.uc_menu.Enable_Descargar_Marca_Base_exter = true;
            this.uc_menu.fecha_desde = new System.DateTime(2017, 12, 30, 9, 36, 46, 935);
            this.uc_menu.fecha_hasta = new System.DateTime(2018, 2, 28, 9, 36, 46, 935);
            this.uc_menu.FormConsulta = null;
            this.uc_menu.FormMain = null;
            this.uc_menu.GridControlConsulta = null;
            this.uc_menu.Location = new System.Drawing.Point(0, 0);
            this.uc_menu.Margin = new System.Windows.Forms.Padding(4);
            this.uc_menu.Name = "uc_menu";
            this.uc_menu.Perfil_x_usuario = null;
            this.uc_menu.Size = new System.Drawing.Size(1038, 174);
            this.uc_menu.TabIndex = 0;
            this.uc_menu.Visible_bodega = true;
            this.uc_menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uc_menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uc_menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uc_menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uc_menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.uc_menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_btn_distribuir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.uc_menu.Visible_fechas = true;
            this.uc_menu.Visible_Grupo_Cancelaciones = true;
            this.uc_menu.Visible_Grupo_Diseño_Reporte = false;
            this.uc_menu.Visible_Grupo_filtro = false;
            this.uc_menu.Visible_Grupo_Impresion = true;
            this.uc_menu.Visible_Grupo_Otras_Trans = true;
            this.uc_menu.Visible_Grupo_Transacciones = true;
            this.uc_menu.Visible_Pie_fechas_Boton_buscar = true;
            this.uc_menu.Visible_ribbon_control = true;
            this.uc_menu.Visible_sucursal = false;
            this.uc_menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick);
            this.uc_menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick);
            this.uc_menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.uc_menu_event_btnconsultar_ItemClick);
            this.uc_menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick);
            this.uc_menu.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick);
            this.uc_menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick);
            this.uc_menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click);
            // 
            // gridControl_proforma
            // 
            this.gridControl_proforma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_proforma.Location = new System.Drawing.Point(0, 174);
            this.gridControl_proforma.MainView = this.gridView_proforma;
            this.gridControl_proforma.Name = "gridControl_proforma";
            this.gridControl_proforma.Size = new System.Drawing.Size(1038, 378);
            this.gridControl_proforma.TabIndex = 1;
            this.gridControl_proforma.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_proforma});
            // 
            // gridView_proforma
            // 
            this.gridView_proforma.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView_proforma.GridControl = this.gridControl_proforma;
            this.gridView_proforma.Name = "gridView_proforma";
            this.gridView_proforma.OptionsBehavior.ReadOnly = true;
            this.gridView_proforma.OptionsView.ShowAutoFilterRow = true;
            this.gridView_proforma.OptionsView.ShowFooter = true;
            this.gridView_proforma.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Sucursal";
            this.gridColumn1.FieldName = "Su_Descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 324;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "# Proforma";
            this.gridColumn2.FieldName = "IdProforma";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 120;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cliente";
            this.gridColumn3.FieldName = "pe_nombreCompleto";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 481;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha";
            this.gridColumn4.FieldName = "pf_fecha";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 159;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Observación";
            this.gridColumn5.FieldName = "pf_observacion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 391;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Subtotal";
            this.gridColumn6.DisplayFormat.FormatString = "n2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "pd_subtotal";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pd_subtotal", "{0:n2}")});
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 82;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "IVA";
            this.gridColumn7.DisplayFormat.FormatString = "n2";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "pd_iva";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pd_iva", "{0:n2}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 82;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Total";
            this.gridColumn8.DisplayFormat.FormatString = "n2";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "pd_total";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "pd_total", "{0:n2}")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 95;
            // 
            // frmFa_proforma_cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 552);
            this.Controls.Add(this.gridControl_proforma);
            this.Controls.Add(this.uc_menu);
            this.Name = "frmFa_proforma_cons";
            this.Text = "Consulta de proformas";
            this.Load += new System.EventHandler(this.frmFa_proforma_cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_proforma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_proforma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario uc_menu;
        private DevExpress.XtraGrid.GridControl gridControl_proforma;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_proforma;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}