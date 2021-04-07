using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using Modelo;

namespace Logica
{
    public class N_Saldos_Diarios:N_General
    {
        public M_Saldos_Diarios C_Saldos_Diarios = new M_Saldos_Diarios();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(DateTime Fecha_proceso, int Tipo_servicio, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Saldos_Diarios WHERE Fecha_proceso= #" + Fecha_proceso.ToString("yyyy-MM-dd") + "# and Tipo_servicio=" + Tipo_servicio);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Saldos_Diarios.Fecha_proceso = Convert.ToDateTime(DT.Rows[0]["Fecha_proceso"]);
                    C_Saldos_Diarios.Tipo_servicio = Convert.ToInt32(DT.Rows[0]["Tipo_servicio"]);
                    C_Saldos_Diarios.Saldo_anterior = Convert.ToDouble(DT.Rows[0]["Saldo_anterior"]);
                    C_Saldos_Diarios.Cantidad_ingresos = Convert.ToInt32(DT.Rows[0]["Cantidad_ingresos"]);
                    C_Saldos_Diarios.Total_ingresos = Convert.ToDouble(DT.Rows[0]["Total_ingresos"]);
                    C_Saldos_Diarios.Cantidad_egresos = Convert.ToInt32(DT.Rows[0]["Cantidad_egresos"]);
                    C_Saldos_Diarios.Total_egresos = Convert.ToDouble(DT.Rows[0]["Total_egresos"]);
                    C_Saldos_Diarios.Nuevo_saldo = Convert.ToDouble(DT.Rows[0]["Nuevo_saldo"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Saldos_Diarios Consultar(DateTime Fecha_proceso, int Tipo_servicio)
        {
            if (Existe(Fecha_proceso, Tipo_servicio, true))
            {
                return C_Saldos_Diarios;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Saldos_Diarios");
        }
        public DataTable ConsultarDT(DateTime Fecha_proceso, int Tipo_servicio)
        {
            return Data.ConsultaT("SELECT * FROM Saldos_Diarios WHERE tipo_servicio=" + Tipo_servicio + " AND Fecha_proceso=#" + Fecha_proceso.ToString("yyyy-MM-dd") + "#;");
        }
        public DataTable ConsultarDT(DateTime Fecha_proceso)
        {
            return Data.ConsultaT("SELECT * FROM Saldos_Diarios WHERE (Tipo_servicio=2 OR Tipo_servicio=21)" + " AND Fecha_proceso=#" + Fecha_proceso.ToString("yyyy-MM-dd") + "#;");
        }
        public long Insertar(M_Saldos_Diarios Saldos_Diarios)
        {
            return Data.Accion("INSERT INTO Saldos_Diarios (Fecha_proceso,Tipo_servicio,Saldo_anterior,Cantidad_ingresos,Total_ingresos,Cantidad_egresos,Total_egresos,Nuevo_saldo) VALUES (#" + Saldos_Diarios.Fecha_proceso.ToString("yyyy-MM-dd") + "#," + Saldos_Diarios.Tipo_servicio + "," + Saldos_Diarios.Saldo_anterior + "," + Saldos_Diarios.Cantidad_ingresos + "," + Saldos_Diarios.Total_ingresos + "," + Saldos_Diarios.Cantidad_egresos + "," + Saldos_Diarios.Total_egresos + "," + Saldos_Diarios.Nuevo_saldo + ");");
        }
        public long Actualizar(M_Saldos_Diarios Saldos_Diarios)
        {
            return Data.Accion("UPDATE Saldos_Diarios SET Fecha_proceso=#" + Saldos_Diarios.Fecha_proceso.ToString("yyyy-MM-dd") + "#,Tipo_servicio=" + Saldos_Diarios.Tipo_servicio + ",Saldo_anterior=" + Saldos_Diarios.Saldo_anterior + ",Cantidad_ingresos=" + Saldos_Diarios.Cantidad_ingresos + ",Total_ingresos=" + Saldos_Diarios.Total_ingresos + ",Cantidad_egresos=" + Saldos_Diarios.Cantidad_egresos + ",Total_egresos=" + Saldos_Diarios.Total_egresos + ",Nuevo_saldo=" + Saldos_Diarios.Nuevo_saldo + " WHERE Fecha_proceso= #" + Saldos_Diarios.Fecha_proceso.ToString("yyyy-MM-dd") + "# and Tipo_servicio=" + Saldos_Diarios.Tipo_servicio + ";");
        }
        public long Nuevo(M_Saldos_Diarios Saldos_Diarios)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Fecha_proceso", Saldos_Diarios.Fecha_proceso},
           {"Tipo_servicio", Saldos_Diarios.Tipo_servicio},
           {"Saldo_anterior", Saldos_Diarios.Saldo_anterior},
           {"Cantidad_ingresos", Saldos_Diarios.Cantidad_ingresos},
           {"Total_ingresos", Saldos_Diarios.Total_ingresos},
           {"Cantidad_egresos", Saldos_Diarios.Cantidad_egresos},
           {"Total_egresos", Saldos_Diarios.Total_egresos},
           {"Nuevo_saldo", Saldos_Diarios.Nuevo_saldo}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Saldos_Diarios(?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }

        public N_Saldos_Diarios SaldoAnterior(DateTime Fecha, int tipo_servicio_)
        {
            if (Existe(Fecha, tipo_servicio_, true))
            {
            }
            else
            {
                DateTime? Ultimafecha = UltimaFecha(tipo_servicio_);
                if (Ultimafecha != null)
                {
                    if (Fecha < Ultimafecha)
                    {
                        DateTime UltimaFechaAntesde = UltimaFechaAntesDe(2, Convert.ToDateTime(Fecha));
                        if (Existe(UltimaFechaAntesde, tipo_servicio_, true))
                        {
                            C_Saldos_Diarios.Fecha_proceso = Fecha;
                            C_Saldos_Diarios.Saldo_anterior = C_Saldos_Diarios.Nuevo_saldo;
                            C_Saldos_Diarios.Cantidad_ingresos = C_Saldos_Diarios.Cantidad_egresos = 0;
                            C_Saldos_Diarios.Total_ingresos = C_Saldos_Diarios.Total_egresos = 0;
                            if (Insertar(C_Saldos_Diarios) == 1)
                            {
                            }
                            else
                            {
                                //MessageBox.Show("Error en la creación del saldo anterior");
                            }
                        }
                    }
                    else
                    {
                        //la fecha no es menor
                        if (Existe(Convert.ToDateTime(Ultimafecha), tipo_servicio_, true))
                        {
                            C_Saldos_Diarios.Fecha_proceso = Fecha;
                            C_Saldos_Diarios.Saldo_anterior = C_Saldos_Diarios.Nuevo_saldo;
                            C_Saldos_Diarios.Cantidad_ingresos = C_Saldos_Diarios.Cantidad_egresos = 0;
                            C_Saldos_Diarios.Total_ingresos = C_Saldos_Diarios.Total_egresos = 0;
                            if (Insertar(C_Saldos_Diarios) == 1)
                            {
                            }
                            else
                            {
                                //MessageBox.Show("Error en la creación del saldo anterior");
                            }
                        }
                    }
                }
            }
            return this;
        }

        public long RegistrarMovimiento(DateTime Fecha_proceso, int Tipo_servicio, double Valor, string Tipo, string Signo)
        {
            N_Saldos_Generales Saldos_Generales = new N_Saldos_Generales();
            //Saldos_Generales.Cadena(Data.GsPath, Data.ConectaA);
            long resultado = -2;
            if (Existe(Fecha_proceso, Tipo_servicio, true))
            {
                if (Tipo == "OI")
                {
                    if (Signo == "+")
                    {
                        C_Saldos_Diarios.Total_ingresos += Valor;
                        C_Saldos_Diarios.Cantidad_ingresos++;
                    }
                    else
                    {
                        C_Saldos_Diarios.Total_ingresos -= Valor;
                        C_Saldos_Diarios.Cantidad_ingresos--;
                    }
                }
                if (Tipo == "OE")
                {
                    if (Signo == "+")
                    {
                        C_Saldos_Diarios.Total_egresos += Valor;
                        C_Saldos_Diarios.Cantidad_egresos++;
                    }
                    else
                    {
                        C_Saldos_Diarios.Total_egresos -= Valor;
                        C_Saldos_Diarios.Cantidad_egresos--;
                    }
                }
                C_Saldos_Diarios.Nuevo_saldo = C_Saldos_Diarios.Saldo_anterior + C_Saldos_Diarios.Total_ingresos - C_Saldos_Diarios.Total_egresos;
                resultado = Actualizar(C_Saldos_Diarios);
                if (resultado == 1)
                {
                    if (Tipo == "OI")
                    {
                        if (Saldos_Generales.RegistrarMovimiento(Tipo_servicio, Signo, Valor) == -1)
                        {
                            resultado = -3;
                        }
                    }
                    if (Tipo == "OE")
                    {
                        if (Signo == "+")
                        {
                            if (Saldos_Generales.RegistrarMovimiento(Tipo_servicio, "-", Valor) == -1)
                            {
                                resultado = -3;
                            }
                        }
                        if (Signo == "-")
                        {
                            if (Saldos_Generales.RegistrarMovimiento(Tipo_servicio, "+", Valor) == -1)
                            {
                                resultado = -3;
                            }

                        }
                    }
                }
            }
            return resultado;
        }

        public DateTime? UltimaFecha(int Tipo_servicio)
        {
            DateTime? resultado=null;
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("select max(fecha_proceso) as ultima_fecha from saldos_diarios where tipo_servicio=" + Tipo_servicio + ";");
            if (DT.Rows.Count > 0)
            {
                resultado = Convert.ToDateTime(DT.Rows[0]["ultima_fecha"]);
            }
            return resultado;
        }
        public DateTime UltimaFechaAntesDe(int Tipo_servicio, DateTime Fecha)
        {
            DateTime resultado=Convert.ToDateTime("01/01/1900");
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("select max(fecha_proceso) as ultima_fecha from saldos_diarios where tipo_servicio=" + Tipo_servicio + " and fecha_proceso<#" + Fecha.ToString("yyyy-MM-dd") + "#;");
            if (DT.Rows.Count > 0)
            {
                resultado = Convert.ToDateTime(DT.Rows[0]["ultima_fecha"]);
            }
            return resultado;
        }
    }
}
