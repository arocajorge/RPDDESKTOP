using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Bancos
{
   public class XBAN_FJ_Rpt004_saldos_Info
    {
        public int IdEmpresa { get; set; }
        public int IdBanco { get; set; }
        public string IdUsuario { get; set; }
        public string nom_cuenta_banco { get; set; }
        public double Saldo_inicial { get; set; }
        public double Saldo_final { get; set; }

    }
}
