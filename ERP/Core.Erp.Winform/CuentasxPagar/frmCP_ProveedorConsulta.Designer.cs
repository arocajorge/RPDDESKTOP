namespace Core.Erp.Winform.CuentasxPagar
{
    partial class frmCP_ProveedorConsulta
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
            this.gridControlProveedor = new DevExpress.XtraGrid.GridControl();
            this.UltraGridProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNomProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColGirar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdCtaCble_cxp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpe_telefonoOfic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTelefonoCasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColCelular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTipoDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRazon_Social = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_clase = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_clase = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGridProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_clase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlProveedor
            // 
            this.gridControlProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProveedor.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlProveedor.Location = new System.Drawing.Point(0, 0);
            this.gridControlProveedor.MainView = this.UltraGridProveedor;
            this.gridControlProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControlProveedor.Name = "gridControlProveedor";
            this.gridControlProveedor.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_clase});
            this.gridControlProveedor.Size = new System.Drawing.Size(1304, 269);
            this.gridControlProveedor.TabIndex = 15;
            this.gridControlProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UltraGridProveedor});
            // 
            // UltraGridProveedor
            // 
            this.UltraGridProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdProveedor,
            this.ColNomProveedor,
            this.ColGirar,
            this.ColIdCtaCble_cxp,
            this.ColCedulaRuc,
            this.colEstado,
            this.ColDireccion,
            this.colCorreo,
            this.colpe_telefonoOfic,
            this.ColTelefonoCasa,
            this.colTelefonoContacto,
            this.ColCodigo,
            this.ColCelular,
            this.ColTipoDoc,
            this.ColRazon_Social,
            this.col_clase});
            this.UltraGridProveedor.CustomizationFormBounds = new System.Drawing.Rectangle(519, 397, 216, 178);
            this.UltraGridProveedor.GridControl = this.gridControlProveedor;
            this.UltraGridProveedor.Name = "UltraGridProveedor";
            this.UltraGridProveedor.OptionsView.ShowAutoFilterRow = true;
            this.UltraGridProveedor.OptionsView.ShowGroupPanel = false;
            this.UltraGridProveedor.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.UltraGridProveedor_RowCellStyle);
            this.UltraGridProveedor.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.UltraGridProveedor_CellValueChanging);
            this.UltraGridProveedor.DoubleClick += new System.EventHandler(this.UltraGridProveedor_DoubleClick);
            // 
            // ColIdProveedor
            // 
            this.ColIdProveedor.Caption = "IdProveedor";
            this.ColIdProveedor.FieldName = "IdProveedor";
            this.ColIdProveedor.Name = "ColIdProveedor";
            this.ColIdProveedor.OptionsColumn.AllowEdit = false;
            this.ColIdProveedor.OptionsColumn.ReadOnly = true;
            this.ColIdProveedor.Visible = true;
            this.ColIdProveedor.VisibleIndex = 0;
            this.ColIdProveedor.Width = 132;
            // 
            // ColNomProveedor
            // 
            this.ColNomProveedor.Caption = "Nombre";
            this.ColNomProveedor.FieldName = "pr_nombre";
            this.ColNomProveedor.Name = "ColNomProveedor";
            this.ColNomProveedor.OptionsColumn.AllowEdit = false;
            this.ColNomProveedor.OptionsColumn.ReadOnly = true;
            this.ColNomProveedor.Visible = true;
            this.ColNomProveedor.VisibleIndex = 2;
            this.ColNomProveedor.Width = 421;
            // 
            // ColGirar
            // 
            this.ColGirar.Caption = "Gira Cheque";
            this.ColGirar.FieldName = "pr_girar_cheque_a";
            this.ColGirar.Name = "ColGirar";
            this.ColGirar.OptionsColumn.AllowEdit = false;
            this.ColGirar.OptionsColumn.ReadOnly = true;
            this.ColGirar.Width = 119;
            // 
            // ColIdCtaCble_cxp
            // 
            this.ColIdCtaCble_cxp.Caption = "IdCtaCble_CXP";
            this.ColIdCtaCble_cxp.FieldName = "IdCtaCble_CXP";
            this.ColIdCtaCble_cxp.Name = "ColIdCtaCble_cxp";
            this.ColIdCtaCble_cxp.OptionsColumn.AllowEdit = false;
            this.ColIdCtaCble_cxp.OptionsColumn.ReadOnly = true;
            this.ColIdCtaCble_cxp.Width = 90;
            // 
            // ColCedulaRuc
            // 
            this.ColCedulaRuc.Caption = "Cedula/Ruc";
            this.ColCedulaRuc.FieldName = "Persona_Info.pe_cedulaRuc";
            this.ColCedulaRuc.Name = "ColCedulaRuc";
            this.ColCedulaRuc.OptionsColumn.ReadOnly = true;
            this.ColCedulaRuc.Visible = true;
            this.ColCedulaRuc.VisibleIndex = 4;
            this.ColCedulaRuc.Width = 219;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "pr_estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.OptionsColumn.ReadOnly = true;
            this.colEstado.Width = 50;
            // 
            // ColDireccion
            // 
            this.ColDireccion.Caption = "Direccion";
            this.ColDireccion.FieldName = "Persona_Info.pe_direccion";
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.OptionsColumn.ReadOnly = true;
            this.ColDireccion.Visible = true;
            this.ColDireccion.VisibleIndex = 5;
            this.ColDireccion.Width = 128;
            // 
            // colCorreo
            // 
            this.colCorreo.Caption = "Correo";
            this.colCorreo.FieldName = "Persona_Info.pe_correo";
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.OptionsColumn.ReadOnly = true;
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 6;
            this.colCorreo.Width = 125;
            // 
            // colpe_telefonoOfic
            // 
            this.colpe_telefonoOfic.Caption = "Telf. Oficina";
            this.colpe_telefonoOfic.FieldName = "Persona_Info.pe_telefonoOfic";
            this.colpe_telefonoOfic.Name = "colpe_telefonoOfic";
            this.colpe_telefonoOfic.OptionsColumn.ReadOnly = true;
            this.colpe_telefonoOfic.Width = 116;
            // 
            // ColTelefonoCasa
            // 
            this.ColTelefonoCasa.Caption = "Telf. Casa";
            this.ColTelefonoCasa.FieldName = "Persona_Info.pe_telefonoCasa";
            this.ColTelefonoCasa.Name = "ColTelefonoCasa";
            this.ColTelefonoCasa.OptionsColumn.ReadOnly = true;
            this.ColTelefonoCasa.Width = 76;
            // 
            // colTelefonoContacto
            // 
            this.colTelefonoContacto.Caption = "Tel.Contacto";
            this.colTelefonoContacto.FieldName = "Persona_Info.pe_telfono_Contacto";
            this.colTelefonoContacto.Name = "colTelefonoContacto";
            this.colTelefonoContacto.OptionsColumn.ReadOnly = true;
            this.colTelefonoContacto.Width = 131;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Caption = "Codigo";
            this.ColCodigo.FieldName = "pr_codigo";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.OptionsColumn.ReadOnly = true;
            this.ColCodigo.Width = 82;
            // 
            // ColCelular
            // 
            this.ColCelular.Caption = "Celular";
            this.ColCelular.FieldName = "Persona_Info.pe_celular";
            this.ColCelular.Name = "ColCelular";
            this.ColCelular.OptionsColumn.ReadOnly = true;
            this.ColCelular.Width = 106;
            // 
            // ColTipoDoc
            // 
            this.ColTipoDoc.Caption = "Tipo Doc.";
            this.ColTipoDoc.FieldName = "Persona_Info.IdTipoDocumento";
            this.ColTipoDoc.Name = "ColTipoDoc";
            this.ColTipoDoc.OptionsColumn.ReadOnly = true;
            this.ColTipoDoc.Visible = true;
            this.ColTipoDoc.VisibleIndex = 3;
            this.ColTipoDoc.Width = 113;
            // 
            // ColRazon_Social
            // 
            this.ColRazon_Social.Caption = "Razon/Social";
            this.ColRazon_Social.FieldName = "Persona_Info.pe_razonSocial";
            this.ColRazon_Social.Name = "ColRazon_Social";
            this.ColRazon_Social.OptionsColumn.ReadOnly = true;
            this.ColRazon_Social.Width = 137;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 486);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1304, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 217);
            this.panel1.TabIndex = 17;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2018, 2, 23, 8, 44, 27, 183);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2018, 4, 23, 8, 44, 27, 184);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1304, 213);
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_distribuir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlProveedor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1304, 269);
            this.panel2.TabIndex = 18;
            // 
            // cmb_clase
            // 
            this.cmb_clase.AutoHeight = false;
            this.cmb_clase.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_clase.DisplayMember = "descripcion_clas_prove";
            this.cmb_clase.Name = "cmb_clase";
            this.cmb_clase.ValueMember = "IdClaseProveedor";
            this.cmb_clase.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Clase";
            this.gridColumn1.FieldName = "descripcion_clas_prove";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 1531;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "IdClaseProveedor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 203;
            // 
            // col_clase
            // 
            this.col_clase.Caption = "Clase proveedor";
            this.col_clase.ColumnEdit = this.cmb_clase;
            this.col_clase.FieldName = "IdClaseProveedor";
            this.col_clase.Name = "col_clase";
            this.col_clase.Visible = true;
            this.col_clase.VisibleIndex = 1;
            this.col_clase.Width = 459;
            // 
            // frmCP_ProveedorConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCP_ProveedorConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Proveedor";
            this.Load += new System.EventHandler(this.frmCP_ProveedorConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UltraGridProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_clase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView UltraGridProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn ColNomProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn ColGirar;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdCtaCble_cxp;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn ColCedulaRuc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Columns.GridColumn ColDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_telefonoOfic;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn ColTelefonoCasa;
        private DevExpress.XtraGrid.Columns.GridColumn ColCelular;
        private DevExpress.XtraGrid.Columns.GridColumn ColTipoDoc;
        private DevExpress.XtraGrid.Columns.GridColumn ColRazon_Social;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoContacto;
        private DevExpress.XtraGrid.Columns.GridColumn col_clase;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_clase;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}