using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Collections;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using System.Linq;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public partial class XACTF_FJ_Rpt003_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XACTF_FJ_Rpt003_Rpt()
        {
            InitializeComponent();
        }
        XACTF_FJ_Rpt003_Bus bus = new XACTF_FJ_Rpt003_Bus();
        List<XACTF_FJ_Rpt003_Info> lista = new List<XACTF_FJ_Rpt003_Info>();

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int IdEmpresa_ = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                string IdCentro_ = Convert.ToString(Parameters["IdCentro"].Value);
                string IsSubcentro_ = Convert.ToString(Parameters["IsSubcentro"].Value);
                bool ubicacion_actual = Convert.ToBoolean(Parameters["ubicacion"].Value);
                
                if ((IdCentro_ != "" && IdCentro_ != null)&&(IsSubcentro_ == "" || IsSubcentro_ != null))
                {
                    lista =bus.Get_List_Activos(IdEmpresa_,IdCentro_,ubicacion_actual,Convert.ToDateTime( fi.Value),Convert.ToDateTime( ff.Value));
                }

                if ((IdCentro_ != "" && IdCentro_ != null) && (IsSubcentro_ != "" && IsSubcentro_ != null))
                {
                    lista = bus.Get_List_Activos(IdEmpresa_, IdCentro_, IsSubcentro_, ubicacion_actual, Convert.ToDateTime(fi.Value), Convert.ToDateTime(ff.Value));
                }

                if ((IdCentro_ == "" || IdCentro_ == null) && (IsSubcentro_ == "" || IsSubcentro_ != null))
                {
                    lista = bus.Get_List_Activos(IdEmpresa_, ubicacion_actual, Convert.ToDateTime(fi.Value), Convert.ToDateTime(ff.Value));
                }

               
                this.DataSource = lista;

            }
            catch (Exception ex)
            {


            }

        }

    }
}
