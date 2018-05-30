namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_OrdenGiroConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCP_OrdenGiroConsulta));
            this.gridControlOG = new DevExpress.XtraGrid.GridControl();
            this.UltraGrid_OrdenGiro = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCbteCble_Ogiro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltc_TipoCbte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_fechaOg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_FechaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_subtotal_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_subtotal_siniva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_baseImponible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCtaCble_CXP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_ret = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_serie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colre_NumRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado_Cancelacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_valorpagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colco_valoriva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_Retencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tipo_flujo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tipo_flujo = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tiene_ingresos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_tiene_ingresos = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.lst_img = new System.Windows.Forms.ImageList(this.components);
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_NumRetencion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_serie2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_serie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Num_Autorizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_OrdenGiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tiene_ingresos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlOG
            // 
            this.gridControlOG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOG.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlOG.Location = new System.Drawing.Point(0, 0);
            this.gridControlOG.MainView = this.UltraGrid_OrdenGiro;
            this.gridControlOG.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlOG.Name = "gridControlOG";
            this.gridControlOG.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_tipo_flujo,
            this.cmb_tiene_ingresos});
            this.gridControlOG.Size = new System.Drawing.Size(1603, 271);
            this.gridControlOG.TabIndex = 14;
            this.gridControlOG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGrid_OrdenGiro});
            // 
            // UltraGrid_OrdenGiro
            // 
            this.UltraGrid_OrdenGiro.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCbteCble_Ogiro,
            this.coltc_TipoCbte,
            this.colco_fechaOg,
            this.colco_factura,
            this.colco_FechaFactura,
            this.colNomProveedor,
            this.colco_observacion,
            this.colco_subtotal_iva,
            this.colco_subtotal_siniva,
            this.colco_baseImponible,
            this.colEstado,
            this.colIdCtaCble_CXP,
            this.colIdEmpresa_ret,
            this.colIdRetencion,
            this.colre_serie,
            this.colre_NumRetencion,
            this.colEstado_Cancelacion,
            this.colTotal,
            this.colSaldo,
            this.colco_valorpagar,
            this.colco_valoriva,
            this.colTotal_Retencion,
            this.col_tipo_flujo,
            this.gridColumn5,
            this.col_tiene_ingresos,
            this.gridColumn6,
            this.Col_NumRetencion,
            this.Col_serie2,
            this.Col_serie1,
            this.Col_Num_Autorizacion,
            this.gridColumn7});
            this.UltraGrid_OrdenGiro.CustomizationFormBounds = new System.Drawing.Rectangle(519, 397, 216, 178);
            this.UltraGrid_OrdenGiro.GridControl = this.gridControlOG;
            this.UltraGrid_OrdenGiro.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "co_total", this.colTotal, "{0:c2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "saldo", this.colSaldo, "{0:c2}")});
            this.UltraGrid_OrdenGiro.Images = this.lst_img;
            this.UltraGrid_OrdenGiro.Name = "UltraGrid_OrdenGiro";
            this.UltraGrid_OrdenGiro.OptionsView.ShowAutoFilterRow = true;
            this.UltraGrid_OrdenGiro.OptionsView.ShowGroupPanel = false;
            this.UltraGrid_OrdenGiro.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdCbteCble_Ogiro, DevExpress.Data.ColumnSortOrder.Descending)});
            this.UltraGrid_OrdenGiro.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.UltraGrid_OrdenGiro_RowCellClick);
            this.UltraGrid_OrdenGiro.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.UltraGrid_OrdenGiro_RowCellStyle);
            this.UltraGrid_OrdenGiro.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.UltraGrid_OrdenGiro_FocusedRowChanged);
            this.UltraGrid_OrdenGiro.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.UltraGrid_OrdenGiro_CellValueChanged);
            this.UltraGrid_OrdenGiro.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.UltraGrid_OrdenGiro_CellValueChanging);
            // 
            // colIdCbteCble_Ogiro
            // 
            this.colIdCbteCble_Ogiro.Caption = "#Cbte";
            this.colIdCbteCble_Ogiro.FieldName = "IdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.Name = "colIdCbteCble_Ogiro";
            this.colIdCbteCble_Ogiro.OptionsColumn.AllowEdit = false;
            this.colIdCbteCble_Ogiro.OptionsColumn.ReadOnly = true;
            this.colIdCbteCble_Ogiro.OptionsFilter.AllowFilter = false;
            this.colIdCbteCble_Ogiro.Visible = true;
            this.colIdCbteCble_Ogiro.VisibleIndex = 0;
            this.colIdCbteCble_Ogiro.Width = 56;
            // 
            // coltc_TipoCbte
            // 
            this.coltc_TipoCbte.Caption = "Tipo Comp. CxP";
            this.coltc_TipoCbte.FieldName = "tc_TipoCbte";
            this.coltc_TipoCbte.Name = "coltc_TipoCbte";
            this.coltc_TipoCbte.OptionsColumn.AllowEdit = false;
            this.coltc_TipoCbte.OptionsColumn.ReadOnly = true;
            this.coltc_TipoCbte.Width = 87;
            // 
            // colco_fechaOg
            // 
            this.colco_fechaOg.Caption = "Fecha Comp. CxP";
            this.colco_fechaOg.FieldName = "co_fechaOg";
            this.colco_fechaOg.Name = "colco_fechaOg";
            this.colco_fechaOg.OptionsColumn.AllowEdit = false;
            this.colco_fechaOg.OptionsColumn.ReadOnly = true;
            this.colco_fechaOg.Width = 110;
            // 
            // colco_factura
            // 
            this.colco_factura.Caption = "# Documento";
            this.colco_factura.FieldName = "co_factura";
            this.colco_factura.Name = "colco_factura";
            this.colco_factura.OptionsColumn.AllowEdit = false;
            this.colco_factura.OptionsColumn.ReadOnly = true;
            this.colco_factura.Visible = true;
            this.colco_factura.VisibleIndex = 1;
            this.colco_factura.Width = 104;
            // 
            // colco_FechaFactura
            // 
            this.colco_FechaFactura.Caption = "Fecha Documento";
            this.colco_FechaFactura.FieldName = "co_FechaFactura";
            this.colco_FechaFactura.Name = "colco_FechaFactura";
            this.colco_FechaFactura.OptionsColumn.AllowEdit = false;
            this.colco_FechaFactura.OptionsColumn.ReadOnly = true;
            this.colco_FechaFactura.Visible = true;
            this.colco_FechaFactura.VisibleIndex = 2;
            this.colco_FechaFactura.Width = 104;
            // 
            // colNomProveedor
            // 
            this.colNomProveedor.Caption = "Proveedor";
            this.colNomProveedor.FieldName = "InfoProveedor.pr_nombre";
            this.colNomProveedor.Name = "colNomProveedor";
            this.colNomProveedor.OptionsColumn.AllowEdit = false;
            this.colNomProveedor.OptionsColumn.ReadOnly = true;
            this.colNomProveedor.Visible = true;
            this.colNomProveedor.VisibleIndex = 3;
            this.colNomProveedor.Width = 156;
            // 
            // colco_observacion
            // 
            this.colco_observacion.Caption = "Observación";
            this.colco_observacion.FieldName = "co_observacion";
            this.colco_observacion.Name = "colco_observacion";
            this.colco_observacion.OptionsColumn.AllowEdit = false;
            this.colco_observacion.OptionsColumn.ReadOnly = true;
            this.colco_observacion.Visible = true;
            this.colco_observacion.VisibleIndex = 4;
            this.colco_observacion.Width = 87;
            // 
            // colco_subtotal_iva
            // 
            this.colco_subtotal_iva.Caption = "Subtotal IVA";
            this.colco_subtotal_iva.DisplayFormat.FormatString = "n2";
            this.colco_subtotal_iva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_subtotal_iva.FieldName = "co_subtotal_iva";
            this.colco_subtotal_iva.Name = "colco_subtotal_iva";
            this.colco_subtotal_iva.OptionsColumn.AllowEdit = false;
            this.colco_subtotal_iva.OptionsColumn.ReadOnly = true;
            this.colco_subtotal_iva.Width = 81;
            // 
            // colco_subtotal_siniva
            // 
            this.colco_subtotal_siniva.Caption = "Subtotal sin IVA";
            this.colco_subtotal_siniva.DisplayFormat.FormatString = "n2";
            this.colco_subtotal_siniva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_subtotal_siniva.FieldName = "co_subtotal_siniva";
            this.colco_subtotal_siniva.Name = "colco_subtotal_siniva";
            this.colco_subtotal_siniva.OptionsColumn.AllowEdit = false;
            this.colco_subtotal_siniva.OptionsColumn.ReadOnly = true;
            this.colco_subtotal_siniva.Width = 101;
            // 
            // colco_baseImponible
            // 
            this.colco_baseImponible.Caption = "Base Imponible";
            this.colco_baseImponible.DisplayFormat.FormatString = "n2";
            this.colco_baseImponible.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_baseImponible.FieldName = "co_baseImponible";
            this.colco_baseImponible.Name = "colco_baseImponible";
            this.colco_baseImponible.OptionsColumn.AllowEdit = false;
            this.colco_baseImponible.OptionsColumn.ReadOnly = true;
            this.colco_baseImponible.Width = 91;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Width = 84;
            // 
            // colIdCtaCble_CXP
            // 
            this.colIdCtaCble_CXP.FieldName = "IdCtaCble_CXP";
            this.colIdCtaCble_CXP.Name = "colIdCtaCble_CXP";
            this.colIdCtaCble_CXP.OptionsColumn.ReadOnly = true;
            // 
            // colIdEmpresa_ret
            // 
            this.colIdEmpresa_ret.FieldName = "IdEmpresa_ret";
            this.colIdEmpresa_ret.Name = "colIdEmpresa_ret";
            this.colIdEmpresa_ret.OptionsColumn.ReadOnly = true;
            // 
            // colIdRetencion
            // 
            this.colIdRetencion.FieldName = "IdRetencion";
            this.colIdRetencion.Name = "colIdRetencion";
            this.colIdRetencion.OptionsColumn.ReadOnly = true;
            // 
            // colre_serie
            // 
            this.colre_serie.FieldName = "re_serie";
            this.colre_serie.Name = "colre_serie";
            this.colre_serie.OptionsColumn.ReadOnly = true;
            // 
            // colre_NumRetencion
            // 
            this.colre_NumRetencion.FieldName = "re_NumRetencion";
            this.colre_NumRetencion.Name = "colre_NumRetencion";
            this.colre_NumRetencion.OptionsColumn.ReadOnly = true;
            // 
            // colEstado_Cancelacion
            // 
            this.colEstado_Cancelacion.Caption = "Estado de Cancelacion";
            this.colEstado_Cancelacion.FieldName = "Estado_Cancelacion";
            this.colEstado_Cancelacion.Name = "colEstado_Cancelacion";
            this.colEstado_Cancelacion.OptionsColumn.ReadOnly = true;
            this.colEstado_Cancelacion.Visible = true;
            this.colEstado_Cancelacion.VisibleIndex = 8;
            this.colEstado_Cancelacion.Width = 67;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "n2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "co_total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 79;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.DisplayFormat.FormatString = "n2";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo.FieldName = "saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.ReadOnly = true;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 6;
            this.colSaldo.Width = 88;
            // 
            // colco_valorpagar
            // 
            this.colco_valorpagar.Caption = "Valor a pagar";
            this.colco_valorpagar.DisplayFormat.FormatString = "n2";
            this.colco_valorpagar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_valorpagar.FieldName = "co_valorpagar";
            this.colco_valorpagar.Name = "colco_valorpagar";
            this.colco_valorpagar.OptionsColumn.ReadOnly = true;
            this.colco_valorpagar.Width = 113;
            // 
            // colco_valoriva
            // 
            this.colco_valoriva.Caption = "IVA";
            this.colco_valoriva.DisplayFormat.FormatString = "n2";
            this.colco_valoriva.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colco_valoriva.FieldName = "co_valoriva";
            this.colco_valoriva.Name = "colco_valoriva";
            // 
            // colTotal_Retencion
            // 
            this.colTotal_Retencion.Caption = "Total Reten.";
            this.colTotal_Retencion.DisplayFormat.FormatString = "n2";
            this.colTotal_Retencion.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal_Retencion.FieldName = "Total_Retencion";
            this.colTotal_Retencion.Name = "colTotal_Retencion";
            this.colTotal_Retencion.Visible = true;
            this.colTotal_Retencion.VisibleIndex = 7;
            this.colTotal_Retencion.Width = 78;
            // 
            // col_tipo_flujo
            // 
            this.col_tipo_flujo.Caption = "Tipo flujo";
            this.col_tipo_flujo.ColumnEdit = this.cmb_tipo_flujo;
            this.col_tipo_flujo.FieldName = "IdTipoFlujo";
            this.col_tipo_flujo.Name = "col_tipo_flujo";
            this.col_tipo_flujo.Visible = true;
            this.col_tipo_flujo.VisibleIndex = 9;
            this.col_tipo_flujo.Width = 237;
            // 
            // cmb_tipo_flujo
            // 
            this.cmb_tipo_flujo.AutoHeight = false;
            this.cmb_tipo_flujo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tipo_flujo.DisplayMember = "Descricion2";
            this.cmb_tipo_flujo.Name = "cmb_tipo_flujo";
            this.cmb_tipo_flujo.ValueMember = "IdTipoFlujo";
            this.cmb_tipo_flujo.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdTipoFlujo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 93;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Flujo";
            this.gridColumn2.FieldName = "Descricion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 798;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tipo";
            this.gridColumn3.FieldName = "Tipo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 170;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Código";
            this.gridColumn4.FieldName = "cod_flujo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 119;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Clase proveedor";
            this.gridColumn5.FieldName = "InfoProveedor.descripcion_clas_prove";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // col_tiene_ingresos
            // 
            this.col_tiene_ingresos.Caption = "Ingresos";
            this.col_tiene_ingresos.ColumnEdit = this.cmb_tiene_ingresos;
            this.col_tiene_ingresos.FieldName = "Tiene_ingresos";
            this.col_tiene_ingresos.Name = "col_tiene_ingresos";
            this.col_tiene_ingresos.Visible = true;
            this.col_tiene_ingresos.VisibleIndex = 10;
            this.col_tiene_ingresos.Width = 64;
            // 
            // cmb_tiene_ingresos
            // 
            this.cmb_tiene_ingresos.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_tiene_ingresos.AutoHeight = false;
            this.cmb_tiene_ingresos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_tiene_ingresos.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmb_tiene_ingresos.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("", true, 0)});
            this.cmb_tiene_ingresos.Name = "cmb_tiene_ingresos";
            this.cmb_tiene_ingresos.ReadOnly = true;
            this.cmb_tiene_ingresos.SmallImages = this.lst_img;
            this.cmb_tiene_ingresos.Click += new System.EventHandler(this.cmb_tiene_ingresos_Click);
            // 
            // lst_img
            // 
            this.lst_img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lst_img.ImageStream")));
            this.lst_img.TransparentColor = System.Drawing.Color.Transparent;
            this.lst_img.Images.SetKeyName(0, "1388723697_1710.ico");
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "De caja";
            this.gridColumn6.ColumnEdit = this.cmb_tiene_ingresos;
            this.gridColumn6.FieldName = "En_conciliacion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 11;
            this.gridColumn6.Width = 60;
            // 
            // Col_NumRetencion
            // 
            this.Col_NumRetencion.Caption = "Num Retencion";
            this.Col_NumRetencion.FieldName = "NumRetencion";
            this.Col_NumRetencion.Name = "Col_NumRetencion";
            // 
            // Col_serie2
            // 
            this.Col_serie2.Caption = "Serie2";
            this.Col_serie2.FieldName = "serie2";
            this.Col_serie2.Name = "Col_serie2";
            // 
            // Col_serie1
            // 
            this.Col_serie1.Caption = "Seri1";
            this.Col_serie1.FieldName = "serie1";
            this.Col_serie1.Name = "Col_serie1";
            // 
            // Col_Num_Autorizacion
            // 
            this.Col_Num_Autorizacion.Caption = "Num. Autorizacion";
            this.Col_Num_Autorizacion.FieldName = "Num_Autorizacion";
            this.Col_Num_Autorizacion.Name = "Col_Num_Autorizacion";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Fecha transacción";
            this.gridColumn7.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn7.FieldName = "Fecha_Transac";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1603, 223);
            this.panel1.TabIndex = 15;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 9, 12, 10, 43, 21, 988);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2017, 11, 12, 10, 43, 21, 988);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1603, 215);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnImprimir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick);
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 494);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1603, 32);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlOG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1603, 271);
            this.panel2.TabIndex = 17;
            // 
            // frmCP_OrdenGiroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 526);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCP_OrdenGiroConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Facturas de Proveedores";
            this.Load += new System.EventHandler(this.frmCP_OrdenGiroConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGrid_OrdenGiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tipo_flujo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_tiene_ingresos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

      
        private DevExpress.XtraGrid.GridControl gridControlOG;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGrid_OrdenGiro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCbteCble_Ogiro;
        private DevExpress.XtraGrid.Columns.GridColumn coltc_TipoCbte;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colco_factura;
        private DevExpress.XtraGrid.Columns.GridColumn colco_FechaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colco_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colco_subtotal_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colco_subtotal_siniva;
        private DevExpress.XtraGrid.Columns.GridColumn colco_baseImponible;
        private DevExpress.XtraGrid.Columns.GridColumn colco_fechaOg;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble_CXP;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_ret;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn colre_serie;
        private DevExpress.XtraGrid.Columns.GridColumn colre_NumRetencion;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado_Cancelacion;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colco_valorpagar;
        private DevExpress.XtraGrid.Columns.GridColumn colco_valoriva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_Retencion;
        private DevExpress.XtraGrid.Columns.GridColumn col_tipo_flujo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_tipo_flujo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn col_tiene_ingresos;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmb_tiene_ingresos;
        private System.Windows.Forms.ImageList lst_img;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn Col_NumRetencion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_serie2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_serie1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Num_Autorizacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}