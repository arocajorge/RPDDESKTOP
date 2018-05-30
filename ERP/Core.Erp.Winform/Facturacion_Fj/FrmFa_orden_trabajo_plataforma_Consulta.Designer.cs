namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class FrmFa_orden_trabajo_plataforma_Consulta
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
            this.ucGe_Menu_Mantenimiento_x_usuario1 = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlOrden_Trabajo = new DevExpress.XtraGrid.GridControl();
            this.gridViewOrden_Trabajo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOrdenTrabajo_Pla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkm_salida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkm_llegada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_codOrdenTrabajo_Pla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_descrip_equipo_movi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_punto_partida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_punto_llegada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_hora_ini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_hora_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Valor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrden_Trabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrden_Trabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario1
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.CargarTodasSucursales = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde = new System.DateTime(2017, 9, 16, 9, 53, 3, 443);
            this.ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta = new System.DateTime(2017, 11, 16, 9, 53, 3, 443);
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_Menu_Mantenimiento_x_usuario1.Name = "ucGe_Menu_Mantenimiento_x_usuario1";
            this.ucGe_Menu_Mantenimiento_x_usuario1.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Size = new System.Drawing.Size(1016, 164);
            this.ucGe_Menu_Mantenimiento_x_usuario1.TabIndex = 0;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario1.Visible_sucursal = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 473);
            this.ucGe_BarraEstadoInferior_Forms1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1016, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 1;
            // 
            // gridControlOrden_Trabajo
            // 
            this.gridControlOrden_Trabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOrden_Trabajo.Location = new System.Drawing.Point(0, 164);
            this.gridControlOrden_Trabajo.MainView = this.gridViewOrden_Trabajo;
            this.gridControlOrden_Trabajo.Name = "gridControlOrden_Trabajo";
            this.gridControlOrden_Trabajo.Size = new System.Drawing.Size(1016, 309);
            this.gridControlOrden_Trabajo.TabIndex = 2;
            this.gridControlOrden_Trabajo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrden_Trabajo});
            // 
            // gridViewOrden_Trabajo
            // 
            this.gridViewOrden_Trabajo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOrdenTrabajo_Pla,
            this.colDescripcion,
            this.colEquipo,
            this.colkm_salida,
            this.colkm_llegada,
            this.colCliente,
            this.colFecha,
            this.Col_codOrdenTrabajo_Pla,
            this.Col_pe_direccion,
            this.Col_descrip_equipo_movi,
            this.Col_punto_partida,
            this.Col_punto_llegada,
            this.Col_hora_ini,
            this.Col_hora_fin,
            this.Col_Valor,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn4});
            this.gridViewOrden_Trabajo.GridControl = this.gridControlOrden_Trabajo;
            this.gridViewOrden_Trabajo.Name = "gridViewOrden_Trabajo";
            this.gridViewOrden_Trabajo.OptionsBehavior.ReadOnly = true;
            this.gridViewOrden_Trabajo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewOrden_Trabajo.OptionsView.ShowFooter = true;
            this.gridViewOrden_Trabajo.OptionsView.ShowGroupPanel = false;
            this.gridViewOrden_Trabajo.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewOrden_Trabajo_RowCellStyle);
            this.gridViewOrden_Trabajo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewOrden_Trabajo_FocusedRowChanged);
            // 
            // colIdOrdenTrabajo_Pla
            // 
            this.colIdOrdenTrabajo_Pla.Caption = "#Orden";
            this.colIdOrdenTrabajo_Pla.FieldName = "IdOrdenTrabajo_Pla";
            this.colIdOrdenTrabajo_Pla.Name = "colIdOrdenTrabajo_Pla";
            this.colIdOrdenTrabajo_Pla.OptionsColumn.AllowEdit = false;
            this.colIdOrdenTrabajo_Pla.Visible = true;
            this.colIdOrdenTrabajo_Pla.VisibleIndex = 0;
            this.colIdOrdenTrabajo_Pla.Width = 174;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 4;
            this.colDescripcion.Width = 232;
            // 
            // colEquipo
            // 
            this.colEquipo.Caption = "Equipo";
            this.colEquipo.FieldName = "Equipo";
            this.colEquipo.Name = "colEquipo";
            this.colEquipo.OptionsColumn.AllowEdit = false;
            this.colEquipo.Width = 100;
            // 
            // colkm_salida
            // 
            this.colkm_salida.Caption = "km salida";
            this.colkm_salida.FieldName = "km_salida";
            this.colkm_salida.Name = "colkm_salida";
            this.colkm_salida.OptionsColumn.AllowEdit = false;
            this.colkm_salida.Visible = true;
            this.colkm_salida.VisibleIndex = 7;
            this.colkm_salida.Width = 78;
            // 
            // colkm_llegada
            // 
            this.colkm_llegada.Caption = "km llegada";
            this.colkm_llegada.FieldName = "km_llegada";
            this.colkm_llegada.Name = "colkm_llegada";
            this.colkm_llegada.OptionsColumn.AllowEdit = false;
            this.colkm_llegada.Visible = true;
            this.colkm_llegada.VisibleIndex = 8;
            this.colkm_llegada.Width = 78;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "nom_Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.AllowEdit = false;
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 1;
            this.colCliente.Width = 267;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "Fecha";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 6;
            this.colFecha.Width = 78;
            // 
            // Col_codOrdenTrabajo_Pla
            // 
            this.Col_codOrdenTrabajo_Pla.Caption = "Cod. Orden";
            this.Col_codOrdenTrabajo_Pla.FieldName = "codOrdenTrabajo_Pla";
            this.Col_codOrdenTrabajo_Pla.Name = "Col_codOrdenTrabajo_Pla";
            // 
            // Col_pe_direccion
            // 
            this.Col_pe_direccion.Caption = "Direccion";
            this.Col_pe_direccion.FieldName = "pe_direccion";
            this.Col_pe_direccion.Name = "Col_pe_direccion";
            // 
            // Col_descrip_equipo_movi
            // 
            this.Col_descrip_equipo_movi.Caption = "Descripcion movimiento";
            this.Col_descrip_equipo_movi.FieldName = "descrip_equipo_movi";
            this.Col_descrip_equipo_movi.Name = "Col_descrip_equipo_movi";
            // 
            // Col_punto_partida
            // 
            this.Col_punto_partida.Caption = "Punto Partido";
            this.Col_punto_partida.FieldName = "punto_partida";
            this.Col_punto_partida.Name = "Col_punto_partida";
            this.Col_punto_partida.Visible = true;
            this.Col_punto_partida.VisibleIndex = 9;
            this.Col_punto_partida.Width = 78;
            // 
            // Col_punto_llegada
            // 
            this.Col_punto_llegada.Caption = "Punto llegada";
            this.Col_punto_llegada.FieldName = "punto_llegada";
            this.Col_punto_llegada.Name = "Col_punto_llegada";
            // 
            // Col_hora_ini
            // 
            this.Col_hora_ini.Caption = "Hora inicio";
            this.Col_hora_ini.FieldName = "hora_ini";
            this.Col_hora_ini.Name = "Col_hora_ini";
            // 
            // Col_hora_fin
            // 
            this.Col_hora_fin.Caption = "Hora Fin";
            this.Col_hora_fin.FieldName = "hora_fin";
            this.Col_hora_fin.Name = "Col_hora_fin";
            // 
            // Col_Valor
            // 
            this.Col_Valor.Caption = "Valor";
            this.Col_Valor.FieldName = "Valor";
            this.Col_Valor.Name = "Col_Valor";
            this.Col_Valor.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", "{0:n2}")});
            this.Col_Valor.Visible = true;
            this.Col_Valor.VisibleIndex = 10;
            this.Col_Valor.Width = 91;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Factura";
            this.gridColumn2.FieldName = "vt_num_factura";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 11;
            this.gridColumn2.Width = 110;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Punto cargo";
            this.gridColumn3.FieldName = "nom_punto_cargo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 5;
            this.gridColumn3.Width = 107;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Vendedor";
            this.gridColumn1.FieldName = "Ve_Vendedor";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 231;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Chofer";
            this.gridColumn4.FieldName = "Nombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 210;
            // 
            // FrmFa_orden_trabajo_plataforma_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 499);
            this.Controls.Add(this.gridControlOrden_Trabajo);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario1);
            this.Name = "FrmFa_orden_trabajo_plataforma_Consulta";
            this.Text = "Orden de trabajo Consulta";
            this.Load += new System.EventHandler(this.FrmFa_orden_trabajo_plataforma_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrden_Trabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrden_Trabajo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario1;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControlOrden_Trabajo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrden_Trabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTrabajo_Pla;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn colkm_salida;
        private DevExpress.XtraGrid.Columns.GridColumn colkm_llegada;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn Col_codOrdenTrabajo_Pla;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_direccion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_descrip_equipo_movi;
        private DevExpress.XtraGrid.Columns.GridColumn Col_punto_partida;
        private DevExpress.XtraGrid.Columns.GridColumn Col_punto_llegada;
        private DevExpress.XtraGrid.Columns.GridColumn Col_hora_ini;
        private DevExpress.XtraGrid.Columns.GridColumn Col_hora_fin;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Valor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}