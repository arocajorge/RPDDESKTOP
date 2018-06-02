
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Cus.Erp.Reports.FJ.Roles
{
    public class XROL_Rpt002_Info
    {
        public string em_nombre { get; set; }

        public byte[] em_logo { get; set; }

        public int IdEmpresa { get; set; }
        public int IdNominaTipo { get; set; }
        public Nullable<int> pe_anio { get; set; }
        public Nullable<int> pe_mes { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string Nombres { get; set; }
        public string ru_descripcion { get; set; }
        public string ca_descripcion { get; set; }
        public string zo_descripcion { get; set; }
        public string fu_descripcion { get; set; }
        public int ru_orden { get; set; }
        public Nullable<double> Expr1 { get; set; }
        public decimal IdEmpleado { get; set; }
        public string ru_tipo { get; set; }
       
        
        public double Ingresos { get; set; }
        public double Egresos { get; set; }
        public string NombreComercial { get; set; }


        public Nullable<int> DiasTraba { get; set; }
        public Nullable<double> Quincena { get; set; }
        public Nullable<double> FindeMes { get; set; }
        public Nullable<double> Variable { get; set; }
        public Nullable<double> FondoReserva { get; set; }
    }
}
