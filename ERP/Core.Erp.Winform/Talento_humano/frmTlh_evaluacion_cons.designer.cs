namespace Core.Erp.Winform.Talento_humano
{
    partial class frmTlh_evaluacion_cons
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
            this.gridControl_Grupo = new DevExpress.XtraGrid.GridControl();
            this.gridView_Grupo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_IdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Fecha_evaluacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Grupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Grupo)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 8, 27, 20, 57, 51, 443);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 10, 27, 20, 57, 51, 443);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(777, 80);
            this.ucGe_Menu.TabIndex = 2;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu.Visible_Grupo_filtro = false;
            this.ucGe_Menu.Visible_Grupo_Impresion = false;
            this.ucGe_Menu.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu.Visible_Pie_fechas_Boton_buscar = false;
            this.ucGe_Menu.Visible_ribbon_control = true;
            this.ucGe_Menu.Visible_sucursal = false;
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            // 
            // gridControl_Grupo
            // 
            this.gridControl_Grupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Grupo.Location = new System.Drawing.Point(0, 80);
            this.gridControl_Grupo.MainView = this.gridView_Grupo;
            this.gridControl_Grupo.Name = "gridControl_Grupo";
            this.gridControl_Grupo.Size = new System.Drawing.Size(777, 325);
            this.gridControl_Grupo.TabIndex = 3;
            this.gridControl_Grupo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Grupo});
            // 
            // gridView_Grupo
            // 
            this.gridView_Grupo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_IdBodega,
            this.Col_Fecha_evaluacion,
            this.Col_Observacion,
            this.Col_estado});
            this.gridView_Grupo.GridControl = this.gridControl_Grupo;
            this.gridView_Grupo.Name = "gridView_Grupo";
            this.gridView_Grupo.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Grupo.OptionsView.ShowGroupPanel = false;
            // 
            // Col_IdBodega
            // 
            this.Col_IdBodega.Caption = "Id";
            this.Col_IdBodega.FieldName = "IdCalendario";
            this.Col_IdBodega.Name = "Col_IdBodega";
            this.Col_IdBodega.Visible = true;
            this.Col_IdBodega.VisibleIndex = 0;
            this.Col_IdBodega.Width = 74;
            // 
            // Col_Observacion
            // 
            this.Col_Observacion.Caption = "Observacion";
            this.Col_Observacion.FieldName = "Observacion";
            this.Col_Observacion.Name = "Col_Observacion";
            this.Col_Observacion.Visible = true;
            this.Col_Observacion.VisibleIndex = 2;
            this.Col_Observacion.Width = 590;
            // 
            // Col_estado
            // 
            this.Col_estado.Caption = "Estado";
            this.Col_estado.FieldName = "estado";
            this.Col_estado.Name = "Col_estado";
            // 
            // Col_Fecha_evaluacion
            // 
            this.Col_Fecha_evaluacion.Caption = "Fecha evaluacion";
            this.Col_Fecha_evaluacion.FieldName = "Fecha_evaluacion";
            this.Col_Fecha_evaluacion.Name = "Col_Fecha_evaluacion";
            this.Col_Fecha_evaluacion.Visible = true;
            this.Col_Fecha_evaluacion.VisibleIndex = 1;
            this.Col_Fecha_evaluacion.Width = 95;
            // 
            // frmTlh_evaluacion_cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 405);
            this.Controls.Add(this.gridControl_Grupo);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmTlh_evaluacion_cons";
            this.Text = "Evaluacion consulta Consulta";
            this.Load += new System.EventHandler(this.frminv_categoria_cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Grupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Grupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControl_Grupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Grupo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_IdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Col_estado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Fecha_evaluacion;

    }
}