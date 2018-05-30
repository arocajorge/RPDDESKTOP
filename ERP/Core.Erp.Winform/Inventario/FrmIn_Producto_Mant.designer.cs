namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Producto_Mant
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
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl_Producto = new System.Windows.Forms.TabControl();
            this.tab_descripcion = new System.Windows.Forms.TabPage();
            this.groupBoxLogo = new System.Windows.Forms.GroupBox();
            this.btn_imagen = new DevExpress.XtraEditors.SimpleButton();
            this.pic_imagen = new System.Windows.Forms.PictureBox();
            this.chk_se_distribuye = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_porcentaje_2 = new DevExpress.XtraEditors.TextEdit();
            this.txt_porcentaje_3 = new DevExpress.XtraEditors.TextEdit();
            this.txt_porcentaje_4 = new DevExpress.XtraEditors.TextEdit();
            this.txt_porcentaje_5 = new DevExpress.XtraEditors.TextEdit();
            this.cmb_signo_5 = new System.Windows.Forms.ComboBox();
            this.cmb_signo_4 = new System.Windows.Forms.ComboBox();
            this.cmb_signo_3 = new System.Windows.Forms.ComboBox();
            this.cmb_signo_2 = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_precio_1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_precio_2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_precio_3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_precio_4 = new DevExpress.XtraEditors.TextEdit();
            this.txt_precio_5 = new DevExpress.XtraEditors.TextEdit();
            this.cmbMarca = new Core.Erp.Winform.Controles.UCIn_MarcaCmb();
            this.grupo_lote = new DevExpress.XtraEditors.GroupControl();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.de_fecha_vcto_lote = new DevExpress.XtraEditors.DateEdit();
            this.txt_codigo_lote = new DevExpress.XtraEditors.TextEdit();
            this.de_fecha_fab_lote = new DevExpress.XtraEditors.DateEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCodImp_IVA = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCod_Impuesto_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_impuesto_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCodigo_SRI_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ucIn_Presentacion = new Core.Erp.Winform.Controles.UCIn_Presentacion();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUnidadMedida_Consumo = new Core.Erp.Winform.Controles.UCIn_UnidadMedidaCmb();
            this.ucIn_Linea_Grup_SubGr = new Core.Erp.Winform.Controles.ucIn_Linea_Grup_SubGr();
            this.cmbUnidadMedida = new Core.Erp.Winform.Controles.UCIn_UnidadMedidaCmb();
            this.codigoBarraProducto = new DevExpress.XtraEditors.BarCodeControl();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tab_productosxPuntoVta = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeList_Bodega_x_Sucursal = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlComposicion = new DevExpress.XtraGrid.GridControl();
            this.gridViewComposicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProductoHijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProductoHijo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_unidad_medida_comp = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo_prov = new System.Windows.Forms.TextBox();
            this.cmb_tipoProducto = new Core.Erp.Winform.Controles.UCIn_TipoProductoCmb();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkModulo_AF = new System.Windows.Forms.CheckBox();
            this.chkModulo_Inven = new System.Windows.Forms.CheckBox();
            this.chkModulo_Compras = new System.Windows.Forms.CheckBox();
            this.chkModulo_Venta = new System.Windows.Forms.CheckBox();
            this.cmb_producto_padre = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.inproductoxtbbodegaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctPlanctaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctCentrocostoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctCentrocostoInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ctPlanctaInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialogImagenGrande = new System.Windows.Forms.OpenFileDialog();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl_Producto.SuspendLayout();
            this.tab_descripcion.SuspendLayout();
            this.groupBoxLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_se_distribuye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo_lote)).BeginInit();
            this.grupo_lote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_vcto_lote.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_vcto_lote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo_lote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_fab_lote.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_fab_lote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCodImp_IVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            this.tab_productosxPuntoVta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList_Bodega_x_Sucursal)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComposicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComposicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoHijo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida_comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto_padre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inproductoxtbbodegaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 876);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1221, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 836);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tabControl_Producto);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 151);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1217, 685);
            this.panel5.TabIndex = 47;
            // 
            // tabControl_Producto
            // 
            this.tabControl_Producto.Controls.Add(this.tab_descripcion);
            this.tabControl_Producto.Controls.Add(this.tab_productosxPuntoVta);
            this.tabControl_Producto.Controls.Add(this.tabPage1);
            this.tabControl_Producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Producto.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl_Producto.Name = "tabControl_Producto";
            this.tabControl_Producto.SelectedIndex = 0;
            this.tabControl_Producto.Size = new System.Drawing.Size(1217, 685);
            this.tabControl_Producto.TabIndex = 9;
            // 
            // tab_descripcion
            // 
            this.tab_descripcion.Controls.Add(this.groupBoxLogo);
            this.tab_descripcion.Controls.Add(this.chk_se_distribuye);
            this.tab_descripcion.Controls.Add(this.groupControl1);
            this.tab_descripcion.Controls.Add(this.cmbMarca);
            this.tab_descripcion.Controls.Add(this.grupo_lote);
            this.tab_descripcion.Controls.Add(this.label9);
            this.tab_descripcion.Controls.Add(this.cmbCodImp_IVA);
            this.tab_descripcion.Controls.Add(this.chkActivo);
            this.tab_descripcion.Controls.Add(this.labelControl2);
            this.tab_descripcion.Controls.Add(this.ucIn_Presentacion);
            this.tab_descripcion.Controls.Add(this.label6);
            this.tab_descripcion.Controls.Add(this.cmbUnidadMedida_Consumo);
            this.tab_descripcion.Controls.Add(this.ucIn_Linea_Grup_SubGr);
            this.tab_descripcion.Controls.Add(this.cmbUnidadMedida);
            this.tab_descripcion.Controls.Add(this.codigoBarraProducto);
            this.tab_descripcion.Controls.Add(this.txtCodigoBarra);
            this.tab_descripcion.Controls.Add(this.txtObservacion);
            this.tab_descripcion.Controls.Add(this.label3);
            this.tab_descripcion.Controls.Add(this.label19);
            this.tab_descripcion.Controls.Add(this.label39);
            this.tab_descripcion.Controls.Add(this.label7);
            this.tab_descripcion.Location = new System.Drawing.Point(4, 25);
            this.tab_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tab_descripcion.Name = "tab_descripcion";
            this.tab_descripcion.Padding = new System.Windows.Forms.Padding(4);
            this.tab_descripcion.Size = new System.Drawing.Size(1209, 656);
            this.tab_descripcion.TabIndex = 6;
            this.tab_descripcion.Text = "Descripcion de Producto";
            this.tab_descripcion.UseVisualStyleBackColor = true;
            this.tab_descripcion.Click += new System.EventHandler(this.tab_descripcion_Click);
            // 
            // groupBoxLogo
            // 
            this.groupBoxLogo.Controls.Add(this.btn_imagen);
            this.groupBoxLogo.Controls.Add(this.pic_imagen);
            this.groupBoxLogo.Location = new System.Drawing.Point(177, 404);
            this.groupBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLogo.Name = "groupBoxLogo";
            this.groupBoxLogo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLogo.Size = new System.Drawing.Size(461, 210);
            this.groupBoxLogo.TabIndex = 89;
            this.groupBoxLogo.TabStop = false;
            this.groupBoxLogo.Text = "Imágen";
            // 
            // btn_imagen
            // 
            this.btn_imagen.Location = new System.Drawing.Point(213, 181);
            this.btn_imagen.Margin = new System.Windows.Forms.Padding(4);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(56, 23);
            this.btn_imagen.TabIndex = 1;
            this.btn_imagen.Text = "...";
            this.btn_imagen.Click += new System.EventHandler(this.btn_imagen_Click);
            // 
            // pic_imagen
            // 
            this.pic_imagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_imagen.Location = new System.Drawing.Point(4, 19);
            this.pic_imagen.Margin = new System.Windows.Forms.Padding(4);
            this.pic_imagen.Name = "pic_imagen";
            this.pic_imagen.Size = new System.Drawing.Size(453, 154);
            this.pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_imagen.TabIndex = 0;
            this.pic_imagen.TabStop = false;
            // 
            // chk_se_distribuye
            // 
            this.chk_se_distribuye.Location = new System.Drawing.Point(175, 345);
            this.chk_se_distribuye.Margin = new System.Windows.Forms.Padding(4);
            this.chk_se_distribuye.Name = "chk_se_distribuye";
            this.chk_se_distribuye.Properties.Caption = "Se distribuye";
            this.chk_se_distribuye.Size = new System.Drawing.Size(257, 21);
            this.chk_se_distribuye.TabIndex = 88;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_porcentaje_2);
            this.groupControl1.Controls.Add(this.txt_porcentaje_3);
            this.groupControl1.Controls.Add(this.txt_porcentaje_4);
            this.groupControl1.Controls.Add(this.txt_porcentaje_5);
            this.groupControl1.Controls.Add(this.cmb_signo_5);
            this.groupControl1.Controls.Add(this.cmb_signo_4);
            this.groupControl1.Controls.Add(this.cmb_signo_3);
            this.groupControl1.Controls.Add(this.cmb_signo_2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_precio_1);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txt_precio_2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txt_precio_3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_precio_4);
            this.groupControl1.Controls.Add(this.txt_precio_5);
            this.groupControl1.Location = new System.Drawing.Point(661, 260);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(433, 172);
            this.groupControl1.TabIndex = 87;
            this.groupControl1.Text = "Políticas de precio";
            // 
            // txt_porcentaje_2
            // 
            this.txt_porcentaje_2.Location = new System.Drawing.Point(284, 57);
            this.txt_porcentaje_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_porcentaje_2.Name = "txt_porcentaje_2";
            this.txt_porcentaje_2.Size = new System.Drawing.Size(100, 22);
            this.txt_porcentaje_2.TabIndex = 92;
            this.txt_porcentaje_2.EditValueChanged += new System.EventHandler(this.txt_porcentaje_2_EditValueChanged);
            // 
            // txt_porcentaje_3
            // 
            this.txt_porcentaje_3.Location = new System.Drawing.Point(284, 84);
            this.txt_porcentaje_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_porcentaje_3.Name = "txt_porcentaje_3";
            this.txt_porcentaje_3.Size = new System.Drawing.Size(100, 22);
            this.txt_porcentaje_3.TabIndex = 93;
            this.txt_porcentaje_3.EditValueChanged += new System.EventHandler(this.txt_porcentaje_3_EditValueChanged);
            // 
            // txt_porcentaje_4
            // 
            this.txt_porcentaje_4.Location = new System.Drawing.Point(284, 112);
            this.txt_porcentaje_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_porcentaje_4.Name = "txt_porcentaje_4";
            this.txt_porcentaje_4.Size = new System.Drawing.Size(100, 22);
            this.txt_porcentaje_4.TabIndex = 94;
            this.txt_porcentaje_4.EditValueChanged += new System.EventHandler(this.txt_porcentaje_4_EditValueChanged);
            // 
            // txt_porcentaje_5
            // 
            this.txt_porcentaje_5.Location = new System.Drawing.Point(284, 140);
            this.txt_porcentaje_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_porcentaje_5.Name = "txt_porcentaje_5";
            this.txt_porcentaje_5.Size = new System.Drawing.Size(100, 22);
            this.txt_porcentaje_5.TabIndex = 95;
            this.txt_porcentaje_5.EditValueChanged += new System.EventHandler(this.txt_porcentaje_5_EditValueChanged);
            // 
            // cmb_signo_5
            // 
            this.cmb_signo_5.FormattingEnabled = true;
            this.cmb_signo_5.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmb_signo_5.Location = new System.Drawing.Point(205, 140);
            this.cmb_signo_5.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_signo_5.Name = "cmb_signo_5";
            this.cmb_signo_5.Size = new System.Drawing.Size(71, 24);
            this.cmb_signo_5.TabIndex = 91;
            this.cmb_signo_5.SelectedIndexChanged += new System.EventHandler(this.cmb_signo_5_SelectedIndexChanged);
            // 
            // cmb_signo_4
            // 
            this.cmb_signo_4.FormattingEnabled = true;
            this.cmb_signo_4.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmb_signo_4.Location = new System.Drawing.Point(205, 112);
            this.cmb_signo_4.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_signo_4.Name = "cmb_signo_4";
            this.cmb_signo_4.Size = new System.Drawing.Size(71, 24);
            this.cmb_signo_4.TabIndex = 90;
            this.cmb_signo_4.SelectedIndexChanged += new System.EventHandler(this.cmb_signo_4_SelectedIndexChanged);
            // 
            // cmb_signo_3
            // 
            this.cmb_signo_3.FormattingEnabled = true;
            this.cmb_signo_3.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmb_signo_3.Location = new System.Drawing.Point(205, 84);
            this.cmb_signo_3.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_signo_3.Name = "cmb_signo_3";
            this.cmb_signo_3.Size = new System.Drawing.Size(71, 24);
            this.cmb_signo_3.TabIndex = 89;
            this.cmb_signo_3.SelectedIndexChanged += new System.EventHandler(this.cmb_signo_3_SelectedIndexChanged);
            // 
            // cmb_signo_2
            // 
            this.cmb_signo_2.FormattingEnabled = true;
            this.cmb_signo_2.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmb_signo_2.Location = new System.Drawing.Point(205, 55);
            this.cmb_signo_2.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_signo_2.Name = "cmb_signo_2";
            this.cmb_signo_2.Size = new System.Drawing.Size(71, 24);
            this.cmb_signo_2.TabIndex = 88;
            this.cmb_signo_2.SelectedIndexChanged += new System.EventHandler(this.cmb_signo_2_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 31);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 16);
            this.labelControl1.TabIndex = 77;
            this.labelControl1.Text = "Precio 1:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 143);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 16);
            this.labelControl7.TabIndex = 86;
            this.labelControl7.Text = "Precio 5:";
            // 
            // txt_precio_1
            // 
            this.txt_precio_1.Location = new System.Drawing.Point(99, 28);
            this.txt_precio_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precio_1.Name = "txt_precio_1";
            this.txt_precio_1.Size = new System.Drawing.Size(100, 22);
            this.txt_precio_1.TabIndex = 78;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 114);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 16);
            this.labelControl6.TabIndex = 85;
            this.labelControl6.Text = "Precio 4:";
            // 
            // txt_precio_2
            // 
            this.txt_precio_2.Location = new System.Drawing.Point(99, 57);
            this.txt_precio_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precio_2.Name = "txt_precio_2";
            this.txt_precio_2.Size = new System.Drawing.Size(100, 22);
            this.txt_precio_2.TabIndex = 79;
            this.txt_precio_2.EditValueChanged += new System.EventHandler(this.txt_precio_2_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 87);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 16);
            this.labelControl5.TabIndex = 84;
            this.labelControl5.Text = "Precio 3:";
            // 
            // txt_precio_3
            // 
            this.txt_precio_3.Location = new System.Drawing.Point(99, 84);
            this.txt_precio_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precio_3.Name = "txt_precio_3";
            this.txt_precio_3.Size = new System.Drawing.Size(100, 22);
            this.txt_precio_3.TabIndex = 80;
            this.txt_precio_3.EditValueChanged += new System.EventHandler(this.txt_precio_3_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 59);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 16);
            this.labelControl4.TabIndex = 83;
            this.labelControl4.Text = "Precio 2:";
            // 
            // txt_precio_4
            // 
            this.txt_precio_4.Location = new System.Drawing.Point(99, 112);
            this.txt_precio_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precio_4.Name = "txt_precio_4";
            this.txt_precio_4.Size = new System.Drawing.Size(100, 22);
            this.txt_precio_4.TabIndex = 81;
            this.txt_precio_4.EditValueChanged += new System.EventHandler(this.txt_precio_4_EditValueChanged);
            // 
            // txt_precio_5
            // 
            this.txt_precio_5.Location = new System.Drawing.Point(99, 140);
            this.txt_precio_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_precio_5.Name = "txt_precio_5";
            this.txt_precio_5.Size = new System.Drawing.Size(100, 22);
            this.txt_precio_5.TabIndex = 82;
            this.txt_precio_5.EditValueChanged += new System.EventHandler(this.txt_precio_5_EditValueChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.Location = new System.Drawing.Point(177, 105);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(340, 30);
            this.cmbMarca.TabIndex = 76;
            // 
            // grupo_lote
            // 
            this.grupo_lote.Controls.Add(this.label13);
            this.grupo_lote.Controls.Add(this.label12);
            this.grupo_lote.Controls.Add(this.label11);
            this.grupo_lote.Controls.Add(this.de_fecha_vcto_lote);
            this.grupo_lote.Controls.Add(this.txt_codigo_lote);
            this.grupo_lote.Controls.Add(this.de_fecha_fab_lote);
            this.grupo_lote.Location = new System.Drawing.Point(661, 133);
            this.grupo_lote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grupo_lote.Name = "grupo_lote";
            this.grupo_lote.Size = new System.Drawing.Size(433, 122);
            this.grupo_lote.TabIndex = 75;
            this.grupo_lote.Text = "Datos lote";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 78;
            this.label13.Text = "Código lote:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 77;
            this.label12.Text = "Fecha vcto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 76;
            this.label11.Text = "Fecha fab:";
            // 
            // de_fecha_vcto_lote
            // 
            this.de_fecha_vcto_lote.EditValue = null;
            this.de_fecha_vcto_lote.Location = new System.Drawing.Point(131, 89);
            this.de_fecha_vcto_lote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.de_fecha_vcto_lote.Name = "de_fecha_vcto_lote";
            this.de_fecha_vcto_lote.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha_vcto_lote.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_fecha_vcto_lote.Size = new System.Drawing.Size(155, 22);
            this.de_fecha_vcto_lote.TabIndex = 1;
            // 
            // txt_codigo_lote
            // 
            this.txt_codigo_lote.Location = new System.Drawing.Point(131, 33);
            this.txt_codigo_lote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_codigo_lote.Name = "txt_codigo_lote";
            this.txt_codigo_lote.Size = new System.Drawing.Size(288, 22);
            this.txt_codigo_lote.TabIndex = 2;
            // 
            // de_fecha_fab_lote
            // 
            this.de_fecha_fab_lote.EditValue = null;
            this.de_fecha_fab_lote.Location = new System.Drawing.Point(131, 62);
            this.de_fecha_fab_lote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.de_fecha_fab_lote.Name = "de_fecha_fab_lote";
            this.de_fecha_fab_lote.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_fecha_fab_lote.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.de_fecha_fab_lote.Size = new System.Drawing.Size(155, 22);
            this.de_fecha_fab_lote.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 74;
            this.label9.Text = "Observación:";
            // 
            // cmbCodImp_IVA
            // 
            this.cmbCodImp_IVA.Location = new System.Drawing.Point(177, 370);
            this.cmbCodImp_IVA.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCodImp_IVA.Name = "cmbCodImp_IVA";
            this.cmbCodImp_IVA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCodImp_IVA.Properties.DisplayMember = "nom_impuesto";
            this.cmbCodImp_IVA.Properties.ValueMember = "IdCod_Impuesto";
            this.cmbCodImp_IVA.Properties.View = this.gridView6;
            this.cmbCodImp_IVA.Size = new System.Drawing.Size(139, 22);
            this.cmbCodImp_IVA.TabIndex = 2;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCod_Impuesto_iva,
            this.colnom_impuesto_iva,
            this.colporcentaje_iva,
            this.colIdCodigo_SRI_iva});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCod_Impuesto_iva
            // 
            this.colIdCod_Impuesto_iva.Caption = "IdCod_Impuesto";
            this.colIdCod_Impuesto_iva.FieldName = "IdCod_Impuesto";
            this.colIdCod_Impuesto_iva.Name = "colIdCod_Impuesto_iva";
            this.colIdCod_Impuesto_iva.Visible = true;
            this.colIdCod_Impuesto_iva.VisibleIndex = 2;
            this.colIdCod_Impuesto_iva.Width = 76;
            // 
            // colnom_impuesto_iva
            // 
            this.colnom_impuesto_iva.Caption = "Impuesto";
            this.colnom_impuesto_iva.FieldName = "nom_impuesto";
            this.colnom_impuesto_iva.Name = "colnom_impuesto_iva";
            this.colnom_impuesto_iva.Visible = true;
            this.colnom_impuesto_iva.VisibleIndex = 0;
            this.colnom_impuesto_iva.Width = 591;
            // 
            // colporcentaje_iva
            // 
            this.colporcentaje_iva.Caption = "porcentaje";
            this.colporcentaje_iva.FieldName = "porcentaje";
            this.colporcentaje_iva.Name = "colporcentaje_iva";
            this.colporcentaje_iva.Visible = true;
            this.colporcentaje_iva.VisibleIndex = 1;
            this.colporcentaje_iva.Width = 235;
            // 
            // colIdCodigo_SRI_iva
            // 
            this.colIdCodigo_SRI_iva.Caption = "IdCodigo_SRI";
            this.colIdCodigo_SRI_iva.FieldName = "IdCodigo_SRI";
            this.colIdCodigo_SRI_iva.Name = "colIdCodigo_SRI_iva";
            this.colIdCodigo_SRI_iva.Visible = true;
            this.colIdCodigo_SRI_iva.VisibleIndex = 3;
            this.colIdCodigo_SRI_iva.Width = 239;
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(495, 345);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(100, 21);
            this.chkActivo.TabIndex = 55;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 374);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "IVA:";
            // 
            // ucIn_Presentacion
            // 
            this.ucIn_Presentacion.Location = new System.Drawing.Point(172, 203);
            this.ucIn_Presentacion.Margin = new System.Windows.Forms.Padding(5);
            this.ucIn_Presentacion.Name = "ucIn_Presentacion";
            this.ucIn_Presentacion.Size = new System.Drawing.Size(340, 33);
            this.ucIn_Presentacion.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Modelo:";
            // 
            // cmbUnidadMedida_Consumo
            // 
            this.cmbUnidadMedida_Consumo.Location = new System.Drawing.Point(175, 174);
            this.cmbUnidadMedida_Consumo.Margin = new System.Windows.Forms.Padding(5);
            this.cmbUnidadMedida_Consumo.Name = "cmbUnidadMedida_Consumo";
            this.cmbUnidadMedida_Consumo.Size = new System.Drawing.Size(325, 31);
            this.cmbUnidadMedida_Consumo.TabIndex = 68;
            // 
            // ucIn_Linea_Grup_SubGr
            // 
            this.ucIn_Linea_Grup_SubGr.Location = new System.Drawing.Point(661, 7);
            this.ucIn_Linea_Grup_SubGr.Margin = new System.Windows.Forms.Padding(5);
            this.ucIn_Linea_Grup_SubGr.Name = "ucIn_Linea_Grup_SubGr";
            this.ucIn_Linea_Grup_SubGr.Size = new System.Drawing.Size(449, 118);
            this.ucIn_Linea_Grup_SubGr.SubGrupoInfo = null;
            this.ucIn_Linea_Grup_SubGr.TabIndex = 67;
            this.ucIn_Linea_Grup_SubGr.Visible_Todos_cmb_Categoria = false;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.Location = new System.Drawing.Point(175, 140);
            this.cmbUnidadMedida.Margin = new System.Windows.Forms.Padding(5);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(325, 32);
            this.cmbUnidadMedida.TabIndex = 63;
            this.cmbUnidadMedida.event_cmbUnidadMedida_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_UnidadMedidaCmb.delegate_cmbUnidadMedida_EditValueChanged(this.cmbUnidadMedida_event_cmbUnidadMedida_EditValueChanged);
            // 
            // codigoBarraProducto
            // 
            this.codigoBarraProducto.Location = new System.Drawing.Point(177, 42);
            this.codigoBarraProducto.Margin = new System.Windows.Forms.Padding(4);
            this.codigoBarraProducto.Name = "codigoBarraProducto";
            this.codigoBarraProducto.Padding = new System.Windows.Forms.Padding(13, 2, 13, 0);
            this.codigoBarraProducto.Size = new System.Drawing.Size(419, 58);
            this.codigoBarraProducto.Symbology = code128Generator1;
            this.codigoBarraProducto.TabIndex = 38;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(177, 12);
            this.txtCodigoBarra.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoBarra.MaxLength = 200;
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(417, 22);
            this.txtCodigoBarra.TabIndex = 27;
            this.txtCodigoBarra.TextChanged += new System.EventHandler(this.txtCodigoBarra_TextChanged);
            this.txtCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarra_KeyPress);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(177, 245);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(321, 93);
            this.txtObservacion.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Código Barra:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 114);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 17);
            this.label19.TabIndex = 28;
            this.label19.Text = "Marca:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(19, 180);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(136, 17);
            this.label39.TabIndex = 26;
            this.label39.Text = "Unidad de Consumo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Unidad de Medida";
            // 
            // tab_productosxPuntoVta
            // 
            this.tab_productosxPuntoVta.Controls.Add(this.groupBox2);
            this.tab_productosxPuntoVta.Location = new System.Drawing.Point(4, 25);
            this.tab_productosxPuntoVta.Margin = new System.Windows.Forms.Padding(4);
            this.tab_productosxPuntoVta.Name = "tab_productosxPuntoVta";
            this.tab_productosxPuntoVta.Padding = new System.Windows.Forms.Padding(4);
            this.tab_productosxPuntoVta.Size = new System.Drawing.Size(1209, 656);
            this.tab_productosxPuntoVta.TabIndex = 9;
            this.tab_productosxPuntoVta.Text = "Sucursal y bodega";
            this.tab_productosxPuntoVta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeList_Bodega_x_Sucursal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1201, 648);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // treeList_Bodega_x_Sucursal
            // 
            this.treeList_Bodega_x_Sucursal.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7});
            this.treeList_Bodega_x_Sucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList_Bodega_x_Sucursal.Location = new System.Drawing.Point(4, 19);
            this.treeList_Bodega_x_Sucursal.Margin = new System.Windows.Forms.Padding(4);
            this.treeList_Bodega_x_Sucursal.Name = "treeList_Bodega_x_Sucursal";
            this.treeList_Bodega_x_Sucursal.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList_Bodega_x_Sucursal.OptionsPrint.UsePrintStyles = true;
            this.treeList_Bodega_x_Sucursal.OptionsView.ShowIndicator = false;
            this.treeList_Bodega_x_Sucursal.ParentFieldName = "IdPadre";
            this.treeList_Bodega_x_Sucursal.Size = new System.Drawing.Size(1193, 625);
            this.treeList_Bodega_x_Sucursal.TabIndex = 1;
            this.treeList_Bodega_x_Sucursal.BeforeFocusNode += new DevExpress.XtraTreeList.BeforeFocusNodeEventHandler(this.treeList_Bodega_x_Sucursal_BeforeFocusNode);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "IdEmpresa";
            this.treeListColumn1.FieldName = "IdEmpresa";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Descripcion";
            this.treeListColumn2.FieldName = "Nombre";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 1122;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Estado";
            this.treeListColumn3.FieldName = "Estado";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Nivel";
            this.treeListColumn4.FieldName = "Nivel";
            this.treeListColumn4.Name = "treeListColumn4";
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "IdSucursal";
            this.treeListColumn5.FieldName = "IdSucursal";
            this.treeListColumn5.Name = "treeListColumn5";
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "IdBodega";
            this.treeListColumn6.FieldName = "IdBodega";
            this.treeListColumn6.Name = "treeListColumn6";
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "*";
            this.treeListColumn7.FieldName = "Checked";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 0;
            this.treeListColumn7.Width = 58;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlComposicion);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1209, 656);
            this.tabPage1.TabIndex = 10;
            this.tabPage1.Text = "Composición";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControlComposicion
            // 
            this.gridControlComposicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlComposicion.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlComposicion.Location = new System.Drawing.Point(4, 4);
            this.gridControlComposicion.MainView = this.gridViewComposicion;
            this.gridControlComposicion.Margin = new System.Windows.Forms.Padding(4);
            this.gridControlComposicion.Name = "gridControlComposicion";
            this.gridControlComposicion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProductoHijo_grid,
            this.cmb_unidad_medida_comp});
            this.gridControlComposicion.Size = new System.Drawing.Size(1201, 648);
            this.gridControlComposicion.TabIndex = 9;
            this.gridControlComposicion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewComposicion});
            // 
            // gridViewComposicion
            // 
            this.gridViewComposicion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProductoHijo,
            this.colCantidad,
            this.gridColumn3});
            this.gridViewComposicion.GridControl = this.gridControlComposicion;
            this.gridViewComposicion.Name = "gridViewComposicion";
            this.gridViewComposicion.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewComposicion.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProductoHijo
            // 
            this.colIdProductoHijo.Caption = "Descripción";
            this.colIdProductoHijo.ColumnEdit = this.cmbProductoHijo_grid;
            this.colIdProductoHijo.FieldName = "IdProductoHijo";
            this.colIdProductoHijo.Name = "colIdProductoHijo";
            this.colIdProductoHijo.Visible = true;
            this.colIdProductoHijo.VisibleIndex = 0;
            this.colIdProductoHijo.Width = 442;
            // 
            // cmbProductoHijo_grid
            // 
            this.cmbProductoHijo_grid.AutoHeight = false;
            this.cmbProductoHijo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductoHijo_grid.Name = "cmbProductoHijo_grid";
            this.cmbProductoHijo_grid.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpr_descripcion,
            this.colIdProducto});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion_combo";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 0;
            this.colpr_descripcion.Width = 892;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "IdProducto";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 1;
            this.colIdProducto.Width = 288;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            this.colCantidad.Width = 176;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "U. Medida";
            this.gridColumn3.ColumnEdit = this.cmb_unidad_medida_comp;
            this.gridColumn3.FieldName = "IdUnidadMedida";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 154;
            // 
            // cmb_unidad_medida_comp
            // 
            this.cmb_unidad_medida_comp.AutoHeight = false;
            this.cmb_unidad_medida_comp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_unidad_medida_comp.DisplayMember = "Descripcion";
            this.cmb_unidad_medida_comp.Name = "cmb_unidad_medida_comp";
            this.cmb_unidad_medida_comp.ValueMember = "IdUnidadMedida";
            this.cmb_unidad_medida_comp.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ID";
            this.gridColumn4.FieldName = "IdUnidadMedida";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 194;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Descripción";
            this.gridColumn5.FieldName = "Descripcion";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 578;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtCodigo_prov);
            this.panel4.Controls.Add(this.cmb_tipoProducto);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.groupBox5);
            this.panel4.Controls.Add(this.cmb_producto_padre);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtDescripcion2);
            this.panel4.Controls.Add(this.lblAnulado);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblIdProducto);
            this.panel4.Controls.Add(this.txtCodigo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1217, 151);
            this.panel4.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 78;
            this.label8.Text = "Cód. prov.:";
            // 
            // txtCodigo_prov
            // 
            this.txtCodigo_prov.Location = new System.Drawing.Point(419, 12);
            this.txtCodigo_prov.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo_prov.MaxLength = 30;
            this.txtCodigo_prov.Name = "txtCodigo_prov";
            this.txtCodigo_prov.Size = new System.Drawing.Size(201, 22);
            this.txtCodigo_prov.TabIndex = 79;
            // 
            // cmb_tipoProducto
            // 
            this.cmb_tipoProducto.Location = new System.Drawing.Point(848, 6);
            this.cmb_tipoProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_tipoProducto.Name = "cmb_tipoProducto";
            this.cmb_tipoProducto.Size = new System.Drawing.Size(333, 30);
            this.cmb_tipoProducto.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 42);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 76;
            this.label10.Text = "Código padre";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkModulo_AF);
            this.groupBox5.Controls.Add(this.chkModulo_Inven);
            this.groupBox5.Controls.Add(this.chkModulo_Compras);
            this.groupBox5.Controls.Add(this.chkModulo_Venta);
            this.groupBox5.Location = new System.Drawing.Point(947, 50);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(247, 69);
            this.groupBox5.TabIndex = 73;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modulos donde se muestra";
            // 
            // chkModulo_AF
            // 
            this.chkModulo_AF.AutoSize = true;
            this.chkModulo_AF.Location = new System.Drawing.Point(133, 41);
            this.chkModulo_AF.Margin = new System.Windows.Forms.Padding(4);
            this.chkModulo_AF.Name = "chkModulo_AF";
            this.chkModulo_AF.Size = new System.Drawing.Size(94, 21);
            this.chkModulo_AF.TabIndex = 3;
            this.chkModulo_AF.Text = "Activo Fijo";
            this.chkModulo_AF.UseVisualStyleBackColor = true;
            // 
            // chkModulo_Inven
            // 
            this.chkModulo_Inven.AutoSize = true;
            this.chkModulo_Inven.Location = new System.Drawing.Point(15, 41);
            this.chkModulo_Inven.Margin = new System.Windows.Forms.Padding(4);
            this.chkModulo_Inven.Name = "chkModulo_Inven";
            this.chkModulo_Inven.Size = new System.Drawing.Size(92, 21);
            this.chkModulo_Inven.TabIndex = 2;
            this.chkModulo_Inven.Text = "Inventario";
            this.chkModulo_Inven.UseVisualStyleBackColor = true;
            // 
            // chkModulo_Compras
            // 
            this.chkModulo_Compras.AutoSize = true;
            this.chkModulo_Compras.Location = new System.Drawing.Point(133, 21);
            this.chkModulo_Compras.Margin = new System.Windows.Forms.Padding(4);
            this.chkModulo_Compras.Name = "chkModulo_Compras";
            this.chkModulo_Compras.Size = new System.Drawing.Size(86, 21);
            this.chkModulo_Compras.TabIndex = 1;
            this.chkModulo_Compras.Text = "Compras";
            this.chkModulo_Compras.UseVisualStyleBackColor = true;
            // 
            // chkModulo_Venta
            // 
            this.chkModulo_Venta.AutoSize = true;
            this.chkModulo_Venta.Location = new System.Drawing.Point(16, 18);
            this.chkModulo_Venta.Margin = new System.Windows.Forms.Padding(4);
            this.chkModulo_Venta.Name = "chkModulo_Venta";
            this.chkModulo_Venta.Size = new System.Drawing.Size(74, 21);
            this.chkModulo_Venta.TabIndex = 0;
            this.chkModulo_Venta.Text = "Ventas";
            this.chkModulo_Venta.UseVisualStyleBackColor = true;
            // 
            // cmb_producto_padre
            // 
            this.cmb_producto_padre.Location = new System.Drawing.Point(113, 41);
            this.cmb_producto_padre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_producto_padre.Name = "cmb_producto_padre";
            this.cmb_producto_padre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_producto_padre.Properties.DisplayMember = "pr_descripcion_combo";
            this.cmb_producto_padre.Properties.ValueMember = "IdProducto";
            this.cmb_producto_padre.Properties.View = this.searchLookUpEdit1View;
            this.cmb_producto_padre.Size = new System.Drawing.Size(825, 22);
            this.cmb_producto_padre.TabIndex = 75;
            this.cmb_producto_padre.EditValueChanged += new System.EventHandler(this.cmb_producto_padre_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "IdProducto";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 113;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Producto";
            this.gridColumn2.FieldName = "pr_descripcion_combo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 1073;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombre 2:";
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(113, 108);
            this.txtDescripcion2.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion2.Multiline = true;
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(825, 35);
            this.txtDescripcion2.TabIndex = 29;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(967, 123);
            this.lblAnulado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(182, 25);
            this.lblAnulado.TabIndex = 53;
            this.lblAnulado.Text = "*** ANULADO ***";
            this.lblAnulado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Código:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 70);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(825, 34);
            this.txtNombre.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tipo Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre:";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.BackColor = System.Drawing.SystemColors.Control;
            this.lblIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdProducto.Enabled = false;
            this.lblIdProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdProducto.Location = new System.Drawing.Point(629, 14);
            this.lblIdProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(79, 24);
            this.lblIdProducto.TabIndex = 23;
            this.lblIdProducto.Text = "0";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 11);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(209, 22);
            this.txtCodigo.TabIndex = 25;
            // 
            // inproductoxtbbodegaInfoBindingSource
            // 
            this.inproductoxtbbodegaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_producto_x_tb_bodega_Info);
            // 
            // ctPlanctaInfoBindingSource
            // 
            this.ctPlanctaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // ctCentrocostoInfoBindingSource
            // 
            this.ctCentrocostoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Centro_costo_Info);
            // 
            // ctCentrocostoInfoBindingSource1
            // 
            this.ctCentrocostoInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Centro_costo_Info);
            // 
            // ctPlanctaInfoBindingSource1
            // 
            this.ctPlanctaInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // tbCatalogoInfoBindingSource
            // 
            this.tbCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Catalogo_Info);
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
            this.ucGe_Menu.Margin = new System.Windows.Forms.Padding(5);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(1221, 36);
            this.ucGe_Menu.TabIndex = 6;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = true;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
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
            this.ucGe_Menu.event_btnImprimir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnImprimir_Click(this.ucGe_Menu_event_btnImprimir_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1221, 840);
            this.panelControl1.TabIndex = 7;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 36);
            this.xtraScrollableControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1221, 840);
            this.xtraScrollableControl1.TabIndex = 8;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "pr_estado";
            this.gridColumn12.FieldName = "pr_estado";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // FrmIn_Producto_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 898);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmIn_Producto_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Producto_Mant_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIn_Producto_Mant_FormClosed);
            this.Load += new System.EventHandler(this.FrmIn_ProductoMantenimiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabControl_Producto.ResumeLayout(false);
            this.tab_descripcion.ResumeLayout(false);
            this.tab_descripcion.PerformLayout();
            this.groupBoxLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_se_distribuye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje_5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupo_lote)).EndInit();
            this.grupo_lote.ResumeLayout(false);
            this.grupo_lote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_vcto_lote.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_vcto_lote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo_lote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_fab_lote.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_fecha_fab_lote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCodImp_IVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            this.tab_productosxPuntoVta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList_Bodega_x_Sucursal)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComposicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComposicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoHijo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_unidad_medida_comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_producto_padre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inproductoxtbbodegaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagenGrande;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.BindingSource inproductoxtbbodegaInfoBindingSource;
        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource;
        private System.Windows.Forms.BindingSource ctCentrocostoInfoBindingSource;
        private System.Windows.Forms.BindingSource ctCentrocostoInfoBindingSource1;
        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource1;
        private System.Windows.Forms.BindingSource tbCatalogoInfoBindingSource;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Label label1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkModulo_Compras;
        private System.Windows.Forms.CheckBox chkModulo_Venta;
        private System.Windows.Forms.CheckBox chkModulo_AF;
        private System.Windows.Forms.CheckBox chkModulo_Inven;
        private System.Windows.Forms.TabControl tabControl_Producto;
        private System.Windows.Forms.TabPage tab_descripcion;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private Controles.UCIn_Presentacion ucIn_Presentacion;
        private System.Windows.Forms.Label label6;
        private Controles.UCIn_UnidadMedidaCmb cmbUnidadMedida_Consumo;
        private Controles.ucIn_Linea_Grup_SubGr ucIn_Linea_Grup_SubGr;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCodImp_IVA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_impuesto_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCodigo_SRI_iva;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Controles.UCIn_UnidadMedidaCmb cmbUnidadMedida;
        private DevExpress.XtraEditors.BarCodeControl codigoBarraProducto;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tab_productosxPuntoVta;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraTreeList.TreeList treeList_Bodega_x_Sucursal;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridControlComposicion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewComposicion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProductoHijo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProductoHijo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SearchLookUpEdit cmb_producto_padre;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.GroupControl grupo_lote;
        private DevExpress.XtraEditors.TextEdit txt_codigo_lote;
        private DevExpress.XtraEditors.DateEdit de_fecha_vcto_lote;
        private DevExpress.XtraEditors.DateEdit de_fecha_fab_lote;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Controles.UCIn_MarcaCmb cmbMarca;
        private Controles.UCIn_TipoProductoCmb cmb_tipoProducto;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_precio_5;
        private DevExpress.XtraEditors.TextEdit txt_precio_4;
        private DevExpress.XtraEditors.TextEdit txt_precio_3;
        private DevExpress.XtraEditors.TextEdit txt_precio_2;
        private DevExpress.XtraEditors.TextEdit txt_precio_1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chk_se_distribuye;
        private System.Windows.Forms.GroupBox groupBoxLogo;
        private DevExpress.XtraEditors.SimpleButton btn_imagen;
        private System.Windows.Forms.PictureBox pic_imagen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo_prov;
        private System.Windows.Forms.ComboBox cmb_signo_5;
        private System.Windows.Forms.ComboBox cmb_signo_4;
        private System.Windows.Forms.ComboBox cmb_signo_3;
        private System.Windows.Forms.ComboBox cmb_signo_2;
        private DevExpress.XtraEditors.TextEdit txt_porcentaje_2;
        private DevExpress.XtraEditors.TextEdit txt_porcentaje_3;
        private DevExpress.XtraEditors.TextEdit txt_porcentaje_4;
        private DevExpress.XtraEditors.TextEdit txt_porcentaje_5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_unidad_medida_comp;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;

    }
}