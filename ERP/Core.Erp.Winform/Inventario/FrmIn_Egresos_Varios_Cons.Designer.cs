﻿namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Egresos_Varios_Cons
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
            this.ucGe_BarraEstado = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl_Egresos_Varios = new DevExpress.XtraGrid.GridControl();
            this.gridView_Egreso_varios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom_sucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_tipo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcm_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstadoAproba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsigno_tipo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo_oc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdSucursal_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMovi_inven_tipo_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNumMovi_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo_Inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesc_mov_inv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_CodMoviInven = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Egresos_Varios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Egreso_varios)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_BarraEstado
            // 
            this.ucGe_BarraEstado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstado.Location = new System.Drawing.Point(0, 562);
            this.ucGe_BarraEstado.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_BarraEstado.Name = "ucGe_BarraEstado";
            this.ucGe_BarraEstado.Size = new System.Drawing.Size(1289, 32);
            this.ucGe_BarraEstado.TabIndex = 0;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2017, 11, 25, 10, 37, 44, 882);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2018, 1, 25, 10, 37, 44, 882);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1289, 191);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 1;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = true;
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
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_ribbon_control = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_Egresos_Varios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 191);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 371);
            this.panel1.TabIndex = 2;
            // 
            // gridControl_Egresos_Varios
            // 
            this.gridControl_Egresos_Varios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Egresos_Varios.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_Egresos_Varios.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Egresos_Varios.MainView = this.gridView_Egreso_varios;
            this.gridControl_Egresos_Varios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_Egresos_Varios.Name = "gridControl_Egresos_Varios";
            this.gridControl_Egresos_Varios.Size = new System.Drawing.Size(1289, 371);
            this.gridControl_Egresos_Varios.TabIndex = 0;
            this.gridControl_Egresos_Varios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Egreso_varios});
            // 
            // gridView_Egreso_varios
            // 
            this.gridView_Egreso_varios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom_sucursal,
            this.colnom_bodega,
            this.colnom_tipo_inv,
            this.colIdNumMovi,
            this.colcm_fecha,
            this.colcm_observacion,
            this.colEstado,
            this.colIdEstadoAproba,
            this.colnom_motivo,
            this.colsigno_tipo_inv,
            this.colIdMotivo_oc,
            this.colIdEmpresa_inv,
            this.colIdSucursal_inv,
            this.colIdBodega_inv,
            this.colIdMovi_inven_tipo_inv,
            this.colIdNumMovi_inv,
            this.colIdMotivo_Inv,
            this.colDesc_mov_inv,
            this.Col_CodMoviInven});
            this.gridView_Egreso_varios.GridControl = this.gridControl_Egresos_Varios;
            this.gridView_Egreso_varios.Name = "gridView_Egreso_varios";
            this.gridView_Egreso_varios.OptionsView.ShowAutoFilterRow = true;
            this.gridView_Egreso_varios.OptionsView.ShowGroupPanel = false;
            this.gridView_Egreso_varios.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_Egreso_varios_RowCellStyle);
            // 
            // colnom_sucursal
            // 
            this.colnom_sucursal.Caption = "Sucursal";
            this.colnom_sucursal.FieldName = "nom_sucursal";
            this.colnom_sucursal.Name = "colnom_sucursal";
            this.colnom_sucursal.OptionsColumn.AllowEdit = false;
            this.colnom_sucursal.Visible = true;
            this.colnom_sucursal.VisibleIndex = 0;
            this.colnom_sucursal.Width = 92;
            // 
            // colnom_bodega
            // 
            this.colnom_bodega.Caption = "Bodega";
            this.colnom_bodega.FieldName = "nom_bodega";
            this.colnom_bodega.Name = "colnom_bodega";
            this.colnom_bodega.OptionsColumn.AllowEdit = false;
            this.colnom_bodega.Visible = true;
            this.colnom_bodega.VisibleIndex = 1;
            this.colnom_bodega.Width = 94;
            // 
            // colnom_tipo_inv
            // 
            this.colnom_tipo_inv.Caption = "Tipo Movi Inventario";
            this.colnom_tipo_inv.FieldName = "nom_tipo_inv";
            this.colnom_tipo_inv.Name = "colnom_tipo_inv";
            this.colnom_tipo_inv.OptionsColumn.AllowEdit = false;
            this.colnom_tipo_inv.Visible = true;
            this.colnom_tipo_inv.VisibleIndex = 4;
            this.colnom_tipo_inv.Width = 88;
            // 
            // colIdNumMovi
            // 
            this.colIdNumMovi.Caption = "#NumMovi";
            this.colIdNumMovi.FieldName = "IdNumMovi";
            this.colIdNumMovi.Name = "colIdNumMovi";
            this.colIdNumMovi.OptionsColumn.AllowEdit = false;
            this.colIdNumMovi.Visible = true;
            this.colIdNumMovi.VisibleIndex = 2;
            this.colIdNumMovi.Width = 65;
            // 
            // colcm_fecha
            // 
            this.colcm_fecha.Caption = "Fecha";
            this.colcm_fecha.FieldName = "cm_fecha";
            this.colcm_fecha.Name = "colcm_fecha";
            this.colcm_fecha.OptionsColumn.AllowEdit = false;
            this.colcm_fecha.Visible = true;
            this.colcm_fecha.VisibleIndex = 3;
            this.colcm_fecha.Width = 60;
            // 
            // colcm_observacion
            // 
            this.colcm_observacion.Caption = "Observación";
            this.colcm_observacion.FieldName = "cm_observacion";
            this.colcm_observacion.Name = "colcm_observacion";
            this.colcm_observacion.OptionsColumn.AllowEdit = false;
            this.colcm_observacion.Visible = true;
            this.colcm_observacion.VisibleIndex = 6;
            this.colcm_observacion.Width = 365;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 64;
            // 
            // colIdEstadoAproba
            // 
            this.colIdEstadoAproba.Caption = "Estado aprobación";
            this.colIdEstadoAproba.FieldName = "IdEstadoAproba";
            this.colIdEstadoAproba.Name = "colIdEstadoAproba";
            this.colIdEstadoAproba.OptionsColumn.AllowEdit = false;
            this.colIdEstadoAproba.Visible = true;
            this.colIdEstadoAproba.VisibleIndex = 9;
            this.colIdEstadoAproba.Width = 167;
            // 
            // colnom_motivo
            // 
            this.colnom_motivo.Caption = "Motivo";
            this.colnom_motivo.FieldName = "nom_motivo";
            this.colnom_motivo.Name = "colnom_motivo";
            this.colnom_motivo.OptionsColumn.AllowEdit = false;
            this.colnom_motivo.Width = 105;
            // 
            // colsigno_tipo_inv
            // 
            this.colsigno_tipo_inv.Caption = "Ing/Egr";
            this.colsigno_tipo_inv.FieldName = "signo_tipo_inv";
            this.colsigno_tipo_inv.Name = "colsigno_tipo_inv";
            this.colsigno_tipo_inv.Visible = true;
            this.colsigno_tipo_inv.VisibleIndex = 5;
            this.colsigno_tipo_inv.Width = 77;
            // 
            // colIdMotivo_oc
            // 
            this.colIdMotivo_oc.FieldName = "IdMotivo_oc";
            this.colIdMotivo_oc.Name = "colIdMotivo_oc";
            // 
            // colIdEmpresa_inv
            // 
            this.colIdEmpresa_inv.FieldName = "IdEmpresa_inv";
            this.colIdEmpresa_inv.Name = "colIdEmpresa_inv";
            // 
            // colIdSucursal_inv
            // 
            this.colIdSucursal_inv.FieldName = "IdSucursal_inv";
            this.colIdSucursal_inv.Name = "colIdSucursal_inv";
            // 
            // colIdBodega_inv
            // 
            this.colIdBodega_inv.FieldName = "IdBodega_inv";
            this.colIdBodega_inv.Name = "colIdBodega_inv";
            // 
            // colIdMovi_inven_tipo_inv
            // 
            this.colIdMovi_inven_tipo_inv.FieldName = "IdMovi_inven_tipo_inv";
            this.colIdMovi_inven_tipo_inv.Name = "colIdMovi_inven_tipo_inv";
            // 
            // colIdNumMovi_inv
            // 
            this.colIdNumMovi_inv.FieldName = "IdNumMovi_inv";
            this.colIdNumMovi_inv.Name = "colIdNumMovi_inv";
            // 
            // colIdMotivo_Inv
            // 
            this.colIdMotivo_Inv.FieldName = "IdMotivo_Inv";
            this.colIdMotivo_Inv.Name = "colIdMotivo_Inv";
            // 
            // colDesc_mov_inv
            // 
            this.colDesc_mov_inv.Caption = "Motivo";
            this.colDesc_mov_inv.FieldName = "Desc_mov_inv";
            this.colDesc_mov_inv.Name = "colDesc_mov_inv";
            this.colDesc_mov_inv.Visible = true;
            this.colDesc_mov_inv.VisibleIndex = 8;
            this.colDesc_mov_inv.Width = 96;
            // 
            // Col_CodMoviInven
            // 
            this.Col_CodMoviInven.Caption = "Secuencia Fisica";
            this.Col_CodMoviInven.FieldName = "CodMoviInven";
            this.Col_CodMoviInven.Name = "Col_CodMoviInven";
            // 
            // FrmIn_Egresos_Varios_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Controls.Add(this.ucGe_BarraEstado);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmIn_Egresos_Varios_Cons";
            this.Text = "Consulta Egresos Varios";
            this.Load += new System.EventHandler(this.FrmIn_Egresos_Varios_Cons_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Egresos_Varios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Egreso_varios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstado;
        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_Egresos_Varios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Egreso_varios;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_sucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_bodega;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_tipo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_fecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcm_observacion;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstadoAproba;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_motivo;
        private DevExpress.XtraGrid.Columns.GridColumn colsigno_tipo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_oc;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdSucursal_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMovi_inven_tipo_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNumMovi_inv;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo_Inv;
        private DevExpress.XtraGrid.Columns.GridColumn colDesc_mov_inv;
        private DevExpress.XtraGrid.Columns.GridColumn Col_CodMoviInven;
    }
}