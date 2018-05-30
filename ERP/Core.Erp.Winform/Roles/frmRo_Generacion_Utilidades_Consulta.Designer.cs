namespace Core.Erp.Winform.Roles
{
    partial class frmRo_Generacion_Utilidades_Consulta
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
            this.gridControlUtilidad = new DevExpress.XtraGrid.GridControl();
            this.gridViewUtilidad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilidadDerechoIndividual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUtilidadCargaFamiliar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Cerrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Procesado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_FechaIni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_pe_FechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUtilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUtilidad)).BeginInit();
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2018, 3, 18, 0, 19, 10, 100);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2018, 5, 18, 0, 19, 10, 100);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(990, 97);
            this.ucGe_Menu.TabIndex = 1;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing;
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
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.OnlyInCustomizing;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_distribuir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btn_imprimir_lote = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_fechas = false;
            this.ucGe_Menu.Visible_Grupo_Cancelaciones = false;
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
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControlUtilidad);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 97);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(990, 392);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControlUtilidad
            // 
            this.gridControlUtilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUtilidad.Location = new System.Drawing.Point(2, 2);
            this.gridControlUtilidad.MainView = this.gridViewUtilidad;
            this.gridControlUtilidad.Name = "gridControlUtilidad";
            this.gridControlUtilidad.Size = new System.Drawing.Size(986, 388);
            this.gridControlUtilidad.TabIndex = 0;
            this.gridControlUtilidad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUtilidad});
            this.gridControlUtilidad.Click += new System.EventHandler(this.gridControlUtilidad_Click);
            // 
            // gridViewUtilidad
            // 
            this.gridViewUtilidad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdPeriodo,
            this.colUtilidadDerechoIndividual,
            this.colUtilidadCargaFamiliar,
            this.Col_Cerrado,
            this.Col_Procesado,
            this.Col_pe_FechaIni,
            this.Col_pe_FechaFin});
            this.gridViewUtilidad.GridControl = this.gridControlUtilidad;
            this.gridViewUtilidad.Name = "gridViewUtilidad";
            this.gridViewUtilidad.OptionsView.ShowGroupPanel = false;
            this.gridViewUtilidad.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewUtilidad_RowClick);
            this.gridViewUtilidad.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewUtilidad_RowCellClick);
            // 
            // ColIdPeriodo
            // 
            this.ColIdPeriodo.Caption = "Periodo";
            this.ColIdPeriodo.FieldName = "IdPeriodo";
            this.ColIdPeriodo.Name = "ColIdPeriodo";
            this.ColIdPeriodo.Visible = true;
            this.ColIdPeriodo.VisibleIndex = 0;
            this.ColIdPeriodo.Width = 74;
            // 
            // colUtilidadDerechoIndividual
            // 
            this.colUtilidadDerechoIndividual.Caption = "Total Utilidad Individual";
            this.colUtilidadDerechoIndividual.FieldName = "UtilidadDerechoIndividual";
            this.colUtilidadDerechoIndividual.Name = "colUtilidadDerechoIndividual";
            this.colUtilidadDerechoIndividual.Visible = true;
            this.colUtilidadDerechoIndividual.VisibleIndex = 5;
            this.colUtilidadDerechoIndividual.Width = 126;
            // 
            // colUtilidadCargaFamiliar
            // 
            this.colUtilidadCargaFamiliar.Caption = "Utilidad por Carga Familiar";
            this.colUtilidadCargaFamiliar.FieldName = "UtilidadCargaFamiliar";
            this.colUtilidadCargaFamiliar.Name = "colUtilidadCargaFamiliar";
            this.colUtilidadCargaFamiliar.Visible = true;
            this.colUtilidadCargaFamiliar.VisibleIndex = 6;
            this.colUtilidadCargaFamiliar.Width = 172;
            // 
            // Col_Cerrado
            // 
            this.Col_Cerrado.Caption = "Cerrado";
            this.Col_Cerrado.FieldName = "Cerrado";
            this.Col_Cerrado.Name = "Col_Cerrado";
            this.Col_Cerrado.Visible = true;
            this.Col_Cerrado.VisibleIndex = 3;
            this.Col_Cerrado.Width = 59;
            // 
            // Col_Procesado
            // 
            this.Col_Procesado.Caption = "Procesado";
            this.Col_Procesado.FieldName = "Procesado";
            this.Col_Procesado.Name = "Col_Procesado";
            this.Col_Procesado.Visible = true;
            this.Col_Procesado.VisibleIndex = 4;
            this.Col_Procesado.Width = 228;
            // 
            // Col_pe_FechaIni
            // 
            this.Col_pe_FechaIni.Caption = "Desde";
            this.Col_pe_FechaIni.FieldName = "pe_FechaIni";
            this.Col_pe_FechaIni.Name = "Col_pe_FechaIni";
            this.Col_pe_FechaIni.Visible = true;
            this.Col_pe_FechaIni.VisibleIndex = 1;
            this.Col_pe_FechaIni.Width = 174;
            // 
            // Col_pe_FechaFin
            // 
            this.Col_pe_FechaFin.Caption = "Hasta";
            this.Col_pe_FechaFin.FieldName = "pe_FechaFin";
            this.Col_pe_FechaFin.Name = "Col_pe_FechaFin";
            this.Col_pe_FechaFin.Visible = true;
            this.Col_pe_FechaFin.VisibleIndex = 2;
            this.Col_pe_FechaFin.Width = 135;
            // 
            // frmRo_Generacion_Utilidades_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 489);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmRo_Generacion_Utilidades_Consulta";
            this.Text = "Consulta de Reparto de Utilidades por Año";
            this.Load += new System.EventHandler(this.frmRo_Generacion_Utilidades_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUtilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUtilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlUtilidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUtilidad;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilidadDerechoIndividual;
        private DevExpress.XtraGrid.Columns.GridColumn colUtilidadCargaFamiliar;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Cerrado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Procesado;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_FechaIni;
        private DevExpress.XtraGrid.Columns.GridColumn Col_pe_FechaFin;
    }
}