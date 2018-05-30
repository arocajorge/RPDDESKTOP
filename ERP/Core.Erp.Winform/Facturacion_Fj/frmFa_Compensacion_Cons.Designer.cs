namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class frmFa_Compensacion_Cons
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
            this.gc_planificacion = new DevExpress.XtraGrid.GridControl();
            this.gvw_planificacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.Col_nom_Centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_nom_Centro_costo_sub_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_valor_a_financiar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_num_cuotas_meses_x_banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_num_cuotas_meses_x_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_tasa_interes_anual_x_banco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_tasa_interes_anual_x_centro_costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gc_planificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_planificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_planificacion
            // 
            this.gc_planificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_planificacion.Location = new System.Drawing.Point(0, 158);
            this.gc_planificacion.MainView = this.gvw_planificacion;
            this.gc_planificacion.Name = "gc_planificacion";
            this.gc_planificacion.Size = new System.Drawing.Size(867, 299);
            this.gc_planificacion.TabIndex = 8;
            this.gc_planificacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvw_planificacion});
            // 
            // gvw_planificacion
            // 
            this.gvw_planificacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_nom_Centro_costo,
            this.Col_nom_Centro_costo_sub_centro_costo,
            this.Col_valor_a_financiar,
            this.Col_num_cuotas_meses_x_banco,
            this.Col_num_cuotas_meses_x_centro_costo,
            this.Col_tasa_interes_anual_x_banco,
            this.Col_tasa_interes_anual_x_centro_costo,
            this.Col_observacion});
            this.gvw_planificacion.GridControl = this.gc_planificacion;
            this.gvw_planificacion.Name = "gvw_planificacion";
            this.gvw_planificacion.OptionsView.ShowAutoFilterRow = true;
            this.gvw_planificacion.OptionsView.ShowGroupPanel = false;
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 457);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(867, 26);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 7;
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
            this.ucGe_Menu.fecha_desde = new System.DateTime(2017, 8, 7, 17, 5, 13, 387);
            this.ucGe_Menu.fecha_hasta = new System.DateTime(2017, 10, 7, 17, 5, 13, 387);
            this.ucGe_Menu.FormConsulta = null;
            this.ucGe_Menu.FormMain = null;
            this.ucGe_Menu.GridControlConsulta = null;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Perfil_x_usuario = null;
            this.ucGe_Menu.Size = new System.Drawing.Size(867, 158);
            this.ucGe_Menu.TabIndex = 6;
            this.ucGe_Menu.Visible_bodega = false;
            this.ucGe_Menu.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Never;
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
            this.ucGe_Menu.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
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
            this.ucGe_Menu.event_btnNuevo_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnNuevo_ItemClick(this.ucGe_Menu_event_btnNuevo_ItemClick);
            this.ucGe_Menu.event_btnModificar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnModificar_ItemClick(this.ucGe_Menu_event_btnModificar_ItemClick);
            this.ucGe_Menu.event_btnconsultar_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnconsultar_ItemClick(this.ucGe_Menu_event_btnconsultar_ItemClick);
            this.ucGe_Menu.event_btnAnular_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnAnular_ItemClick(this.ucGe_Menu_event_btnAnular_ItemClick);
            this.ucGe_Menu.event_btnSalir_ItemClick += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnSalir_ItemClick(this.ucGe_Menu_event_btnSalir_ItemClick);
            this.ucGe_Menu.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_event_btnBuscar_Click);
            // 
            // Col_nom_Centro_costo
            // 
            this.Col_nom_Centro_costo.Caption = "Centro costo";
            this.Col_nom_Centro_costo.FieldName = "nom_Centro_costo";
            this.Col_nom_Centro_costo.Name = "Col_nom_Centro_costo";
            this.Col_nom_Centro_costo.Visible = true;
            this.Col_nom_Centro_costo.VisibleIndex = 0;
            this.Col_nom_Centro_costo.Width = 256;
            // 
            // Col_nom_Centro_costo_sub_centro_costo
            // 
            this.Col_nom_Centro_costo_sub_centro_costo.Caption = "SubCentro costo";
            this.Col_nom_Centro_costo_sub_centro_costo.FieldName = "nom_Centro_costo_sub_centro_costo";
            this.Col_nom_Centro_costo_sub_centro_costo.Name = "Col_nom_Centro_costo_sub_centro_costo";
            this.Col_nom_Centro_costo_sub_centro_costo.Visible = true;
            this.Col_nom_Centro_costo_sub_centro_costo.VisibleIndex = 1;
            this.Col_nom_Centro_costo_sub_centro_costo.Width = 212;
            // 
            // Col_valor_a_financiar
            // 
            this.Col_valor_a_financiar.Caption = "Valor financiado";
            this.Col_valor_a_financiar.FieldName = "valor_a_financiar";
            this.Col_valor_a_financiar.Name = "Col_valor_a_financiar";
            this.Col_valor_a_financiar.Visible = true;
            this.Col_valor_a_financiar.VisibleIndex = 3;
            this.Col_valor_a_financiar.Width = 100;
            // 
            // Col_num_cuotas_meses_x_banco
            // 
            this.Col_num_cuotas_meses_x_banco.Caption = "Nº cuota banco";
            this.Col_num_cuotas_meses_x_banco.FieldName = "num_cuotas_meses_x_banco";
            this.Col_num_cuotas_meses_x_banco.Name = "Col_num_cuotas_meses_x_banco";
            this.Col_num_cuotas_meses_x_banco.Visible = true;
            this.Col_num_cuotas_meses_x_banco.VisibleIndex = 4;
            this.Col_num_cuotas_meses_x_banco.Width = 100;
            // 
            // Col_num_cuotas_meses_x_centro_costo
            // 
            this.Col_num_cuotas_meses_x_centro_costo.Caption = "Nº centro costo";
            this.Col_num_cuotas_meses_x_centro_costo.FieldName = "num_cuotas_meses_x_centro_costo";
            this.Col_num_cuotas_meses_x_centro_costo.Name = "Col_num_cuotas_meses_x_centro_costo";
            this.Col_num_cuotas_meses_x_centro_costo.Visible = true;
            this.Col_num_cuotas_meses_x_centro_costo.VisibleIndex = 5;
            this.Col_num_cuotas_meses_x_centro_costo.Width = 100;
            // 
            // Col_tasa_interes_anual_x_banco
            // 
            this.Col_tasa_interes_anual_x_banco.Caption = "Tasa interes banco";
            this.Col_tasa_interes_anual_x_banco.FieldName = "tasa_interes_anual_x_banco";
            this.Col_tasa_interes_anual_x_banco.Name = "Col_tasa_interes_anual_x_banco";
            this.Col_tasa_interes_anual_x_banco.Visible = true;
            this.Col_tasa_interes_anual_x_banco.VisibleIndex = 6;
            this.Col_tasa_interes_anual_x_banco.Width = 100;
            // 
            // Col_tasa_interes_anual_x_centro_costo
            // 
            this.Col_tasa_interes_anual_x_centro_costo.Caption = "Tasa interce CC";
            this.Col_tasa_interes_anual_x_centro_costo.FieldName = "tasa_interes_anual_x_centro_costo";
            this.Col_tasa_interes_anual_x_centro_costo.Name = "Col_tasa_interes_anual_x_centro_costo";
            this.Col_tasa_interes_anual_x_centro_costo.Visible = true;
            this.Col_tasa_interes_anual_x_centro_costo.VisibleIndex = 7;
            this.Col_tasa_interes_anual_x_centro_costo.Width = 100;
            // 
            // Col_observacion
            // 
            this.Col_observacion.Caption = "Observacion";
            this.Col_observacion.FieldName = "observacion";
            this.Col_observacion.Name = "Col_observacion";
            this.Col_observacion.Visible = true;
            this.Col_observacion.VisibleIndex = 2;
            this.Col_observacion.Width = 196;
            // 
            // frmFa_Compensacion_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 483);
            this.Controls.Add(this.gc_planificacion);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu);
            this.Name = "frmFa_Compensacion_Cons";
            this.Text = "frmFa_Compensacion_Cons";
            this.Load += new System.EventHandler(this.frmFa_Compensacion_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_planificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvw_planificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_planificacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvw_planificacion;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu;
        private DevExpress.XtraGrid.Columns.GridColumn Col_nom_Centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_nom_Centro_costo_sub_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_valor_a_financiar;
        private DevExpress.XtraGrid.Columns.GridColumn Col_num_cuotas_meses_x_banco;
        private DevExpress.XtraGrid.Columns.GridColumn Col_num_cuotas_meses_x_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_tasa_interes_anual_x_banco;
        private DevExpress.XtraGrid.Columns.GridColumn Col_tasa_interes_anual_x_centro_costo;
        private DevExpress.XtraGrid.Columns.GridColumn Col_observacion;
    }
}