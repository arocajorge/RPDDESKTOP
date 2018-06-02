﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt026_Info
  {
      public string pe_apellido { get; set; }
      public string pe_nombre { get; set; }
      public string pe_cedulaRuc { get; set; }
      public int IdEmpresa { get; set; }
      public decimal IdEmpleado { get; set; }
      public int IdSolicitudVaca { get; set; }
      public System.DateTime Anio_Desde { get; set; }
      public System.DateTime Anio_Hasta { get; set; }
      public int Dias_pendiente { get; set; }
      public int Dias_a_disfrutar { get; set; }
      public int Dias_q_Corresponde { get; set; }
      public int AnioServicio { get; set; }
      public System.DateTime Fecha { get; set; }
      public System.DateTime Fecha_Desde { get; set; }
      public System.DateTime Fecha_Hasta { get; set; }
      public System.DateTime Fecha_Retorno { get; set; }
      public string Observacion { get; set; }
      public string de_descripcion { get; set; }
      public Nullable<long> Canceladas { get; set; }
      public string Gozadas_Pgadas { get; set; }
      public Nullable<System.DateTime> em_fechaIngaRol { get; set; }
      public string ca_descripcion { get; set; }
      public double ValorCancelado { get; set; }
      public System.DateTime FechaPago { get; set; }
      public int Anio { get; set; }
      public string Mes { get; set; }
      public double Total_Remuneracion { get; set; }
      public double Total_Vacaciones { get; set; }
      public double Valor_Cancelar { get; set; }
      public Nullable<double> Iess { get; set; }
      public int secuencia { get; set; }
    }
}
