namespace Core.Erp.Reportes.Roles
{
    partial class XROL_Rpt020_frm
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
            this.ucRo_Menu = new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes();
            this.SuspendLayout();
            // 
            // ucRo_Menu
            // 
            this.ucRo_Menu.caption_bei_check1 = "Check";
            this.ucRo_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucRo_Menu.EnableBotonImprimir = true;
            this.ucRo_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucRo_Menu.Name = "ucRo_Menu";
            this.ucRo_Menu.Size = new System.Drawing.Size(970, 80);
            this.ucRo_Menu.TabIndex = 0;
            this.ucRo_Menu.Visible_bei_check1 = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbCentroCosto = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbDivision = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbEmpleado = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbNominaTipo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucRo_Menu.VisibleCmbNominaTipoLiqui = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbPeriodo = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleCmbRubro = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleDepartamento = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleEstado = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.VisibleGrupoFecha = true;
            this.ucRo_Menu.VisibleGrupoFiltro1 = true;
            this.ucRo_Menu.VisibleGrupoFiltro2 = true;
            this.ucRo_Menu.VisubleArea = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucRo_Menu.event_cmdCargar_ItemClick += new Core.Erp.Reportes.Controles.UCRo_Menu_Reportes.delegate_cmdCargar_ItemClick(this.ucRo_Menu_event_cmdCargar_ItemClick);
            // 
            // XROL_Rpt020_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 506);
            this.Controls.Add(this.ucRo_Menu);
            this.Name = "XROL_Rpt020_frm";
            this.Text = "XROL_Rpt020_frm";
            this.Load += new System.EventHandler(this.XROL_Rpt020_frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCRo_Menu_Reportes ucRo_Menu;

    }
}