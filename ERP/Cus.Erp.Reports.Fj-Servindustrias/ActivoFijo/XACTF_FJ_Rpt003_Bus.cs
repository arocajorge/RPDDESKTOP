using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public class XACTF_FJ_Rpt003_Bus
    {
        XACTF_FJ_Rpt003_Data data = new XACTF_FJ_Rpt003_Data();

        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa, bool UbicacionActual, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            try
            {


                return data.Get_List_Activos(idempresa, UbicacionActual, Fecha_Inicio, Fecha_Fin);

            }
            catch (Exception ex)
            {

                return new List<XACTF_FJ_Rpt003_Info>();

            }
        }

        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa, string IdCentroCosto, bool UbicacionActual, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            try
            {


                return data.Get_List_Activos(idempresa, IdCentroCosto,UbicacionActual,  Fecha_Inicio,Fecha_Fin);

            }
            catch (Exception ex)
            {

                return new List<XACTF_FJ_Rpt003_Info>();

            }
        }


        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa, string IdCentroCosto, string IdSubCentroCosto, bool UbicacionActual, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            try
            {


                return data.Get_List_Activos(idempresa, IdCentroCosto, IdSubCentroCosto,UbicacionActual, Fecha_Inicio,Fecha_Fin);

            }
            catch (Exception ex)
            {

                return new List<XACTF_FJ_Rpt003_Info>();

            }
        }
    }
}
