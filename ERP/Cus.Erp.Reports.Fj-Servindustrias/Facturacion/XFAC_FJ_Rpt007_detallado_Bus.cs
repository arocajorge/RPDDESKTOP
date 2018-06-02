using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt007_detallado_Bus
    {
        XFAC_FJ_Rpt007_detallado_Data oData = new XFAC_FJ_Rpt007_detallado_Data();
        List<XFAC_FJ_Rpt007_detallado_Info> lista_tmp;
        List<XFAC_FJ_Rpt007_detallado_Info> lista;
        public List<XFAC_FJ_Rpt007_detallado_Info> get_list(int IdEmpresa, int IdPeriodo)
        {
            try
            {
                lista_tmp = oData.get_list(IdEmpresa, IdPeriodo);
                lista = new List<XFAC_FJ_Rpt007_detallado_Info>();
                foreach (var item in lista_tmp)
                {
                    XFAC_FJ_Rpt007_detallado_Info info = new XFAC_FJ_Rpt007_detallado_Info();
                    info = item;
                    var operadores = lista_tmp.Where(v => v.IdActivoFijo == item.IdActivoFijo);
                    int contador = 0;
                    foreach (var item_op in operadores)
                    {
                        contador++;
                        if (contador == 1)
                        {
                            info.operdador1 = item_op.pe_nombreCompleto;
                            info.DiasEfectivos_op1 = item_op.DiasEfectivos;
                            info.Total_horas_operadores_op1 = item_op.Total_horas_operadores;
                            info.por_horas_ocupada_la_maquina_vx_ho_op1 = item_op.por_horas_ocupada_la_maquina_vx_ho;
                            info.Promedio_op1 =Convert.ToDouble(Convert.ToDouble( item_op.Total_horas_operadores) / item_op.DiasEfectivos);
                            info.Total_horas = item_op.Total_horas_operadores;
     
                        }
                        else
                        {
                            info.operdador2 = item_op.pe_nombreCompleto;
                            info.DiasEfectivos_op2 = item_op.DiasEfectivos;
                            info.Total_horas_operadores_op2 = item_op.Total_horas_operadores;
                            info.por_horas_ocupada_la_maquina_vx_ho_op2 = item_op.por_horas_ocupada_la_maquina_vx_ho;
                            info.Promedio_op2 = Convert.ToDouble(Convert.ToDouble(item_op.Total_horas_operadores) / item_op.DiasEfectivos);
                            info.Total_horas =info.Total_horas+ item_op.Total_horas_operadores;

                        }
                    }
                   
                    if(lista.Where(v => v.IdActivoFijo == item.IdActivoFijo).Count()==0)
                    lista.Add(info);
                }

                return lista;

            }
            catch (Exception)
            {
                
                throw;
            }
        }


        public List<XFAC_FJ_Rpt007_detallado_Info> get_list(int IdEmpresa, int IdPeriodo, decimal IdCliente)
        {
            try
            {
                lista_tmp = oData.get_list(IdEmpresa, IdPeriodo, IdCliente);
                lista = new List<XFAC_FJ_Rpt007_detallado_Info>();
                foreach (var item in lista_tmp)
                {
                    XFAC_FJ_Rpt007_detallado_Info info = new XFAC_FJ_Rpt007_detallado_Info();
                    info = item;
                    var operadores = lista_tmp.Where(v => v.IdActivoFijo == item.IdActivoFijo);
                    int contador = 0;
                    foreach (var item_op in operadores)
                    {
                        contador++;
                        if (contador == 1)
                        {
                            info.operdador1 = item_op.pe_nombreCompleto;
                            info.DiasEfectivos_op1 = item_op.DiasEfectivos;
                            info.Total_horas_operadores_op1 = item_op.Total_horas_operadores;
                            info.por_horas_ocupada_la_maquina_vx_ho_op1 = item_op.por_horas_ocupada_la_maquina_vx_ho;
                            info.Promedio_op1 = Convert.ToDouble(Convert.ToDouble(item_op.Total_horas_operadores) / item_op.DiasEfectivos);
                            info.Total_horas = item_op.Total_horas_operadores;

                        }
                        else
                        {
                            info.operdador2 = item_op.pe_nombreCompleto;
                            info.DiasEfectivos_op2 = item_op.DiasEfectivos;
                            info.Total_horas_operadores_op2 = item_op.Total_horas_operadores;
                            info.por_horas_ocupada_la_maquina_vx_ho_op2 = item_op.por_horas_ocupada_la_maquina_vx_ho;
                            info.Promedio_op2 = Convert.ToDouble(Convert.ToDouble(item_op.Total_horas_operadores) / item_op.DiasEfectivos);
                            info.Total_horas = info.Total_horas + item_op.Total_horas_operadores;

                        }
                    }

                    if (lista.Where(v => v.IdActivoFijo == item.IdActivoFijo).Count() == 0)
                        lista.Add(info);
                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
