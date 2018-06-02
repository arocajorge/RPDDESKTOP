namespace Core.Erp.Winform.Roles_Graf
{
    partial class frmRo_Liquidacion_Vacaciones_Consul_Graf
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
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControlVacaciones = new DevExpress.XtraGrid.GridControl();
            this.gridViewVacaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpe_nombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_cedulaRuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_ca_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_de_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Anio_Desde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Anio_Hasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Dias_a_disfrutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVacaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.CargarTodasBodegas = false;
            this.ucGe_Menu.CargarTodasSucursales = true;
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enable_boton_anular = true;
            this.ucGe_Menu.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu.Enable_boton_consultar = true;
            this.ucGe_Menu.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu.Enable_boton_Duplicar = true;
            this.ucGe_Menu.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu.Enable_boton_GenerarXml = true;
            this.ucGe_Menu.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu.Enable_boton_Importar_XML = true;
            this.ucGe_Menu.Enable_boton_imprimir = true;
            this.ucGe_Menu.Enable_boton_LoteCheque = true;
            this.ucGe_Menu.Enable_boton_modificar = true;
            this.ucGe_Menu.Enable_boton_nuevo = true;
            this.ucGe_Menu.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu.Enable_boton_periodo = true;
            this.ucGe_Menu.Enable_boton_salir = true;
            this.ucGe_Menu.Enable_btnImpExcel = true;
            this.ucGe_Menu.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 6, 5, 14, 57, 31, 960);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 8, 5, 14, 57, 31, 960);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(790, 175);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = true;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = false;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnCancelarCuotas_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnCancelarCuotas_ItemClick(this.ucGe_Menu_event_btnCancelarCuotas_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlVacaciones);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 175);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(790, 274);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControlVacaciones
            // 
            this.gridControlVacaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlVacaciones.Location = new System.Drawing.Point(2, 2);
            this.gridControlVacaciones.MainView = this.gridViewVacaciones;
            this.gridControlVacaciones.Name = "gridControlVacaciones";
            this.gridControlVacaciones.Size = new System.Drawing.Size(786, 270);
            this.gridControlVacaciones.TabIndex = 13;
            this.gridControlVacaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVacaciones});
            // 
            // gridViewVacaciones
            // 
            this.gridViewVacaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpe_nombreCompleto,
            this.Col_pe_cedulaRuc,
            this.Col_ca_descripcion,
            this.Col_de_descripcion,
            this.Col_Anio_Desde,
            this.Col_Anio_Hasta,
            this.Col_Dias_a_disfrutar});
            this.gridViewVacaciones.GridControl = this.gridControlVacaciones;
            this.gridViewVacaciones.Name = "gridViewVacaciones";
            this.gridViewVacaciones.OptionsBehavior.Editable = false;
            this.gridViewVacaciones.OptionsBehavior.ReadOnly = true;
            this.gridViewVacaciones.OptionsView.ShowAutoFilterRow = true;
            this.gridViewVacaciones.OptionsView.ShowGroupPanel = false;
            this.gridViewVacaciones.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewVacaciones_FocusedRowChanged);
            // 
            // colpe_nombreCompleto
            // 
            this.colpe_nombreCompleto.Caption = "Nombre del Empleado";
            this.colpe_nombreCompleto.FieldName = "pe_nombreCompleto";
            this.colpe_nombreCompleto.Name = "colpe_nombreCompleto";
            this.colpe_nombreCompleto.OptionsColumn.AllowEdit = false;
            this.colpe_nombreCompleto.Visible = true;
            this.colpe_nombreCompleto.VisibleIndex = 0;
            this.colpe_nombreCompleto.Width = 465;
            // 
            // Col_pe_cedulaRuc
            // 
            this.Col_pe_cedulaRuc.Caption = "Cedula";
            this.Col_pe_cedulaRuc.FieldName = "pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Name = "Col_pe_cedulaRuc";
            this.Col_pe_cedulaRuc.Visible = true;
            this.Col_pe_cedulaRuc.VisibleIndex = 1;
            this.Col_pe_cedulaRuc.Width = 148;
            // 
            // Col_ca_descripcion
            // 
            this.Col_ca_descripcion.Caption = "Cargo";
            this.Col_ca_descripcion.FieldName = "ca_descripcion";
            this.Col_ca_descripcion.Name = "Col_ca_descripcion";
            this.Col_ca_descripcion.Visible = true;
            this.Col_ca_descripcion.VisibleIndex = 3;
            this.Col_ca_descripcion.Width = 148;
            // 
            // Col_de_descripcion
            // 
            this.Col_de_descripcion.Caption = "Departamento";
            this.Col_de_descripcion.FieldName = "de_descripcion";
            this.Col_de_descripcion.Name = "Col_de_descripcion";
            this.Col_de_descripcion.Visible = true;
            this.Col_de_descripcion.VisibleIndex = 2;
            this.Col_de_descripcion.Width = 148;
            // 
            // Col_Anio_Desde
            // 
            this.Col_Anio_Desde.Caption = "Perido desde:";
            this.Col_Anio_Desde.FieldName = "Anio_Desde";
            this.Col_Anio_Desde.Name = "Col_Anio_Desde";
            this.Col_Anio_Desde.Visible = true;
            this.Col_Anio_Desde.VisibleIndex = 4;
            this.Col_Anio_Desde.Width = 148;
            // 
            // Col_Anio_Hasta
            // 
            this.Col_Anio_Hasta.Caption = "Hasta";
            this.Col_Anio_Hasta.FieldName = "Anio_Hasta";
            this.Col_Anio_Hasta.Name = "Col_Anio_Hasta";
            this.Col_Anio_Hasta.Visible = true;
            this.Col_Anio_Hasta.VisibleIndex = 5;
            this.Col_Anio_Hasta.Width = 157;
            // 
            // Col_Dias_a_disfrutar
            // 
            this.Col_Dias_a_disfrutar.Caption = "Dias Vacaciones";
            this.Col_Dias_a_disfrutar.FieldName = "Dias_a_disfrutar";
            this.Col_Dias_a_disfrutar.Name = "Col_Dias_a_disfrutar";
            this.Col_Dias_a_disfrutar.Visible = true;
            this.Col_Dias_a_disfrutar.VisibleIndex = 6;
            // 
            // frmRo_Liquidacion_Vacaciones_Consul_Graf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 449);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Liquidacion_Vacaciones_Consul_Graf";
            this.Text = "frmRo_Liquidacion_Vacasiones_Consul";
            this.Load += new System.EventHandler(this.frmRo_Liquidacion_Vacaciones_Consul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlVacaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVacaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlVacaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVacaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colpe_nombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_cedulaRuc;
        private DevExpress.XtraGrid.Columns.GridColumn Col_ca_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_de_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Anio_Desde;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Anio_Hasta;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Dias_a_disfrutar;
    }
}