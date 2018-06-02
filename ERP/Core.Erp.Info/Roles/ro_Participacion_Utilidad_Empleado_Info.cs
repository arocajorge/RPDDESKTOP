
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Roles
{
    public class ro_Participacion_Utilidad_Empleado_Info
    {
        public int IdEmpresa { get; set; }
        public int IdUtilidad { get; set; }
        public decimal IdEmpleado { get; set; }
        public double DiasTrabajados { get; set; }
        public double CargasFamiliares { get; set; }
        public double ValorIndividual { get; set; }
        public double ValorCargaFamiliar { get; set; }
        public double ValorExedenteIESS { get; set; }
        public double ValorTotal { get; set; }
        public string Observacion { get; set; }

        // vista
        public Nullable<System.DateTime> em_fecha_ingreso { get; set; }
        public Nullable<System.DateTime> em_fechaSalida { get; set; }
        public Nullable<System.DateTime> em_fechaTerminoContra { get; set; }
        public Nullable<System.DateTime> em_fechaIngaRol { get; set; }
        public ro_Participacion_Utilidad_Empleado_Info() { }
        public string pe_cedulaRuc { get; set; }
        public string em_status { get; set; }
        public string NomCompleto { get; set; }
        public string cargo { get; set; }
        public int diasTrabajo { get; set; }
        public int cargas { get; set; }
        public double alicuotaIndividual { get; set; }
        public double subTotalIndividual { get; set; }
        public double diasTrabAnual { get; set; }
        public double factorA { get; set; }
        public double alicuotaCarga { get; set; }
        public double subTotalCarga { get; set; }
        public double exedenteIESS { get; set; }
        public double valorEntregar { get; set; }

    }
}
