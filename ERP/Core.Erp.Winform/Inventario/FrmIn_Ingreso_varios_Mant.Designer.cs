namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Ingreso_varios_Mant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIn_Ingreso_varios_Mant));
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu_Superior_Mant1 = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlantilla = new System.Windows.Forms.LinkLabel();
            this.cmbTipoMovi = new Core.Erp.Winform.Controles.UCIn_TipoMoviInv_Cmb();
            this.cmbMotivoInv = new Core.Erp.Winform.Controles.UCIn_MotivoInvCmb();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.ucIn_Sucursal_Bodega1 = new Core.Erp.Winform.Controles.UCIn_Sucursal_Bodega();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumIngreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlProductos = new DevExpress.XtraGrid.GridControl();
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNuevoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colSecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProducto_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto_cmbgrid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_lote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_fecha_vcto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad_sin_conversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_cantidad_convertida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo_sin_conversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmv_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida_convertida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUnidadMedida_sinConversion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv = new Core.Erp.Winform.Controles.UCInv_GridCbte_Cble_x_Ing_Egr_Inv();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida_convertida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 686);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1283, 32);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 0;
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
            this.ucGe_Menu_Superior_Mant1.Size = new System.Drawing.Size(1283, 36);
            this.ucGe_Menu_Superior_Mant1.TabIndex = 1;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant1.Visible_bntImprimir = true;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 194);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlantilla);
            this.groupBox1.Controls.Add(this.cmbTipoMovi);
            this.groupBox1.Controls.Add(this.cmbMotivoInv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblAnulado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.ucIn_Sucursal_Bodega1);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtNumIngreso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1283, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales:";
            // 
            // lblPlantilla
            // 
            this.lblPlantilla.AutoSize = true;
            this.lblPlantilla.Location = new System.Drawing.Point(8, 166);
            this.lblPlantilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlantilla.Name = "lblPlantilla";
            this.lblPlantilla.Size = new System.Drawing.Size(342, 17);
            this.lblPlantilla.TabIndex = 22;
            this.lblPlantilla.TabStop = true;
            this.lblPlantilla.Text = "Descargar plantilla para funcionalidad copiar y pegar";
            this.lblPlantilla.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPlantilla_LinkClicked);
            // 
            // cmbTipoMovi
            // 
            this.cmbTipoMovi.Location = new System.Drawing.Point(797, 50);
            this.cmbTipoMovi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoMovi.Name = "cmbTipoMovi";
            this.cmbTipoMovi.Size = new System.Drawing.Size(461, 30);
            this.cmbTipoMovi.TabIndex = 16;
            this.cmbTipoMovi.Visible_buton_Acciones = true;
            // 
            // cmbMotivoInv
            // 
            this.cmbMotivoInv.Location = new System.Drawing.Point(797, 81);
            this.cmbMotivoInv.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbMotivoInv.Name = "cmbMotivoInv";
            this.cmbMotivoInv.Size = new System.Drawing.Size(461, 32);
            this.cmbMotivoInv.TabIndex = 15;
            this.cmbMotivoInv.Tipo_Ing_Egr = ein_Tipo_Ing_Egr.ING;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipo de movimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Motivo Inv:";
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(437, 57);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(158, 25);
            this.lblAnulado.TabIndex = 10;
            this.lblAnulado.Text = "*** Anulado ***";
            this.lblAnulado.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(123, 119);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(1013, 43);
            this.txtObservacion.TabIndex = 7;
            // 
            // ucIn_Sucursal_Bodega1
            // 
            this.ucIn_Sucursal_Bodega1.Location = new System.Drawing.Point(47, 48);
            this.ucIn_Sucursal_Bodega1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucIn_Sucursal_Bodega1.Name = "ucIn_Sucursal_Bodega1";
            this.ucIn_Sucursal_Bodega1.Size = new System.Drawing.Size(588, 63);
            this.ucIn_Sucursal_Bodega1.TabIndex = 6;
            this.ucIn_Sucursal_Bodega1.TipoCarga = Core.Erp.Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            this.ucIn_Sucursal_Bodega1.Visible_cmb_bodega = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(996, 15);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(139, 22);
            this.dtpFecha.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(316, 16);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNumIngreso
            // 
            this.txtNumIngreso.Location = new System.Drawing.Point(103, 16);
            this.txtNumIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumIngreso.Name = "txtNumIngreso";
            this.txtNumIngreso.Size = new System.Drawing.Size(132, 22);
            this.txtNumIngreso.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(923, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Ingreso:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 230);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 456);
            this.panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1283, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1275, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControlProductos
            // 
            this.gridControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProductos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlProductos.Location = new System.Drawing.Point(4, 4);
            this.gridControlProductos.MainView = this.gridViewProductos;
            this.gridControlProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlProductos.Name = "gridControlProductos";
            this.gridControlProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProducto_grid,
            this.repositoryItemImageEdit1,
            this.cmb_unidad_medida,
            this.cmb_unidad_medida_convertida});
            this.gridControlProductos.Size = new System.Drawing.Size(1267, 419);
            this.gridControlProductos.TabIndex = 0;
            this.gridControlProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNuevoProducto,
            this.colSecuencia,
            this.colIdProducto,
            this.coldm_cantidad_sin_conversion,
            this.coldm_cantidad_convertida,
            this.colmv_costo_sin_conversion,
            this.colmv_costo,
            this.coldm_observacion,
            this.col_IdUnidadMedida,
            this.colIdUnidadMedida_sinConversion});
            this.gridViewProductos.CustomizationFormBounds = new System.Drawing.Rectangle(796, 401, 216, 192);
            this.gridViewProductos.GridControl = this.gridControlProductos;
            this.gridViewProductos.Images = this.imageList1;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewProductos.OptionsView.ShowFooter = true;
            this.gridViewProductos.OptionsView.ShowGroupPanel = false;
            this.gridViewProductos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewProductos_RowCellClick);
            this.gridViewProductos.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewProductos_RowCellStyle);
            this.gridViewProductos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProductos_FocusedRowChanged);
            this.gridViewProductos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewProductos_CellValueChanged);
            this.gridViewProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProductos_KeyDown);
            // 
            // colNuevoProducto
            // 
            this.colNuevoProducto.Caption = "*";
            this.colNuevoProducto.ColumnEdit = this.repositoryItemImageEdit1;
            this.colNuevoProducto.Name = "colNuevoProducto";
            this.colNuevoProducto.OptionsColumn.AllowEdit = false;
            this.colNuevoProducto.Visible = true;
            this.colNuevoProducto.VisibleIndex = 0;
            this.colNuevoProducto.Width = 58;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Images = this.imageList1;
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo_32x32.png");
            // 
            // colSecuencia
            // 
            this.colSecuencia.Caption = "Secuencia";
            this.colSecuencia.FieldName = "Secuencia";
            this.colSecuencia.Name = "colSecuencia";
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "Producto";
            this.colIdProducto.ColumnEdit = this.cmbProducto_grid;
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 1;
            this.colIdProducto.Width = 620;
            // 
            // cmbProducto_grid
            // 
            this.cmbProducto_grid.AutoHeight = false;
            this.cmbProducto_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProducto_grid.Name = "cmbProducto_grid";
            this.cmbProducto_grid.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto_cmbgrid,
            this.colpr_descripcion,
            this.Col_lote,
            this.Col_fecha_vcto,
            this.col_nom_presentacion});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto_cmbgrid
            // 
            this.colIdProducto_cmbgrid.Caption = "ID";
            this.colIdProducto_cmbgrid.FieldName = "IdProducto";
            this.colIdProducto_cmbgrid.Name = "colIdProducto_cmbgrid";
            this.colIdProducto_cmbgrid.Visible = true;
            this.colIdProducto_cmbgrid.VisibleIndex = 4;
            this.colIdProducto_cmbgrid.Width = 82;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 0;
            this.colpr_descripcion.Width = 794;
            // 
            // Col_lote
            // 
            this.Col_lote.Caption = "Lote";
            this.Col_lote.FieldName = "lote_num_lote";
            this.Col_lote.Name = "Col_lote";
            this.Col_lote.Visible = true;
            this.Col_lote.VisibleIndex = 2;
            this.Col_lote.Width = 283;
            // 
            // Col_fecha_vcto
            // 
            this.Col_fecha_vcto.Caption = "Fecha Experación";
            this.Col_fecha_vcto.FieldName = "lote_fecha_vcto";
            this.Col_fecha_vcto.Name = "Col_fecha_vcto";
            this.Col_fecha_vcto.Visible = true;
            this.Col_fecha_vcto.VisibleIndex = 3;
            this.Col_fecha_vcto.Width = 247;
            // 
            // col_nom_presentacion
            // 
            this.col_nom_presentacion.Caption = "Presentacion";
            this.col_nom_presentacion.FieldName = "nom_Presentacion";
            this.col_nom_presentacion.Name = "col_nom_presentacion";
            this.col_nom_presentacion.Visible = true;
            this.col_nom_presentacion.VisibleIndex = 1;
            this.col_nom_presentacion.Width = 328;
            // 
            // coldm_cantidad_sin_conversion
            // 
            this.coldm_cantidad_sin_conversion.Caption = "Cantidad";
            this.coldm_cantidad_sin_conversion.FieldName = "dm_cantidad_sinConversion";
            this.coldm_cantidad_sin_conversion.Name = "coldm_cantidad_sin_conversion";
            this.coldm_cantidad_sin_conversion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dm_cantidad_sinConversion", "{0:n2}")});
            this.coldm_cantidad_sin_conversion.Visible = true;
            this.coldm_cantidad_sin_conversion.VisibleIndex = 3;
            this.coldm_cantidad_sin_conversion.Width = 193;
            // 
            // coldm_cantidad_convertida
            // 
            this.coldm_cantidad_convertida.Caption = "Cantidad convertida";
            this.coldm_cantidad_convertida.FieldName = "dm_cantidad";
            this.coldm_cantidad_convertida.Name = "coldm_cantidad_convertida";
            this.coldm_cantidad_convertida.OptionsColumn.AllowEdit = false;
            this.coldm_cantidad_convertida.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "dm_cantidad", "{0:n2}")});
            this.coldm_cantidad_convertida.Width = 154;
            // 
            // colmv_costo_sin_conversion
            // 
            this.colmv_costo_sin_conversion.Caption = "Costo";
            this.colmv_costo_sin_conversion.FieldName = "mv_costo_sinConversion";
            this.colmv_costo_sin_conversion.Name = "colmv_costo_sin_conversion";
            this.colmv_costo_sin_conversion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mv_costo_sinConversion", "{0:n2}")});
            this.colmv_costo_sin_conversion.Visible = true;
            this.colmv_costo_sin_conversion.VisibleIndex = 4;
            this.colmv_costo_sin_conversion.Width = 193;
            // 
            // colmv_costo
            // 
            this.colmv_costo.Caption = "Costo convertido";
            this.colmv_costo.FieldName = "mv_costo";
            this.colmv_costo.Name = "colmv_costo";
            this.colmv_costo.OptionsColumn.AllowEdit = false;
            this.colmv_costo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "mv_costo", "{0:n2}")});
            this.colmv_costo.Width = 133;
            // 
            // coldm_observacion
            // 
            this.coldm_observacion.Caption = "Observación por Producto";
            this.coldm_observacion.FieldName = "dm_observacion";
            this.coldm_observacion.Name = "coldm_observacion";
            this.coldm_observacion.Width = 202;
            // 
            // col_IdUnidadMedida
            // 
            this.col_IdUnidadMedida.Caption = "IdUnidadMedida convertida";
            this.col_IdUnidadMedida.ColumnEdit = this.cmb_unidad_medida_convertida;
            this.col_IdUnidadMedida.FieldName = "IdUnidadMedida";
            this.col_IdUnidadMedida.Name = "col_IdUnidadMedida";
            this.col_IdUnidadMedida.OptionsColumn.AllowEdit = false;
            this.col_IdUnidadMedida.OptionsColumn.ReadOnly = true;
            this.col_IdUnidadMedida.Width = 140;
            // 
            // cmb_unidad_medida_convertida
            // 
            this.cmb_unidad_medida_convertida.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_unidad_medida_convertida.AutoHeight = false;
            this.cmb_unidad_medida_convertida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_unidad_medida_convertida.DisplayMember = "Descripcion2";
            this.cmb_unidad_medida_convertida.Name = "cmb_unidad_medida_convertida";
            this.cmb_unidad_medida_convertida.ReadOnly = true;
            this.cmb_unidad_medida_convertida.ValueMember = "IdUnidadMedida";
            this.cmb_unidad_medida_convertida.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colIdUnidadMedida_sinConversion
            // 
            this.colIdUnidadMedida_sinConversion.Caption = "Unidad medida";
            this.colIdUnidadMedida_sinConversion.ColumnEdit = this.cmb_unidad_medida;
            this.colIdUnidadMedida_sinConversion.FieldName = "IdUnidadMedida_sinConversion";
            this.colIdUnidadMedida_sinConversion.Name = "colIdUnidadMedida_sinConversion";
            this.colIdUnidadMedida_sinConversion.OptionsColumn.AllowEdit = false;
            this.colIdUnidadMedida_sinConversion.OptionsColumn.ReadOnly = true;
            this.colIdUnidadMedida_sinConversion.Visible = true;
            this.colIdUnidadMedida_sinConversion.VisibleIndex = 2;
            this.colIdUnidadMedida_sinConversion.Width = 139;
            // 
            // cmb_unidad_medida
            // 
            this.cmb_unidad_medida.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.cmb_unidad_medida.AutoHeight = false;
            this.cmb_unidad_medida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_unidad_medida.DisplayMember = "Descripcion2";
            this.cmb_unidad_medida.Name = "cmb_unidad_medida";
            this.cmb_unidad_medida.ReadOnly = true;
            this.cmb_unidad_medida.ValueMember = "IdUnidadMedida";
            this.cmb_unidad_medida.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1275, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diario Contable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucInv_GridCbte_Cble_x_Ing_Egr_Inv
            // 
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv.Location = new System.Drawing.Point(4, 4);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv.Name = "ucInv_GridCbte_Cble_x_Ing_Egr_Inv";
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv.Size = new System.Drawing.Size(1267, 418);
            this.ucInv_GridCbte_Cble_x_Ing_Egr_Inv.TabIndex = 0;
            // 
            // FrmIn_Ingreso_varios_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 718);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant1);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIn_Ingreso_varios_Mant";
            this.Text = "Ingresos Varios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Ingreso_varios_Mant_FormClosing);
            this.Load += new System.EventHandler(this.FrmIn_Ingreso_varios_Mant_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida_convertida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservacion;
        private Controles.UCIn_Sucursal_Bodega ucIn_Sucursal_Bodega1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNumIngreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControlProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.Columns.GridColumn colSecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad_convertida;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProducto_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto_cmbgrid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Label label7;
        private Controles.UCIn_MotivoInvCmb cmbMotivoInv;
        private Controles.UCIn_TipoMoviInv_Cmb cmbTipoMovi;
        private Controles.UCInv_GridCbte_Cble_x_Ing_Egr_Inv ucInv_GridCbte_Cble_x_Ing_Egr_Inv;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida_sinConversion;
        private DevExpress.XtraGrid.Columns.GridColumn colNuevoProducto;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn coldm_cantidad_sin_conversion;
        private DevExpress.XtraGrid.Columns.GridColumn colmv_costo_sin_conversion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida_convertida;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.LinkLabel lblPlantilla;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_lote;
        private DevExpress.XtraGrid.Columns.GridColumn Col_fecha_vcto;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_presentacion;
    }
}