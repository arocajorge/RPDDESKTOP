﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;
using System.Linq;
using Core.Erp.Info.General;
namespace Core.Erp.Reportes.Facturacion
{
    public partial class XFAC_Rpt008_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public List<XFAC_Rpt008_Info> lstRpt { get; set; }

        public XFAC_Rpt008_rpt()
        {
            InitializeComponent();
        }

        public XFAC_Rpt008_rpt(string IdUsuario)
        {
            InitializeComponent();
            
            //lblIdusuario.Text = IdUsuario;
            //lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XFAC_Rpt008_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                if (lstRpt.Count() > 0)
                {
                    if (lstRpt.Where(q=>q.orden > 0).Count() > 0)
                    {
                        float Height = tbl_factura.Rows[1].HeightF;
                        tbl_factura.Rows.Remove(tbl_factura.Rows[1]);
                        tbl_factura.HeightF -= Height;
                        Detail.HeightF = 16;
                    }
                    Funciones funcion = new Funciones();                    
                    lstRpt.ForEach(q => q.valorEnLetras = funcion.NumeroALetras(lstRpt.Sum(v => v.vt_total).ToString()));    
                }
              this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XFAC_Rpt008_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XFAC_Rpt008_rpt) };
            }
        }
    }
}
