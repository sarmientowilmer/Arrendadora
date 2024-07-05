using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoDatos;
using Modelo;

namespace Negocio
{
    public class N_Movimiento_Contable : N_General
    {
        public M_Movimiento_Contable C_Movimiento_Contable = new M_Movimiento_Contable();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(string Tipo_comp, int No_comp, int Item, int Cod_empresa, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Movimiento_Contable WHERE Tipo_comp='" + Tipo_comp + "'" + " and No_comp=" + No_comp + " and Item=" + Item + " and Cod_empresa=" + Cod_empresa);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Movimiento_Contable.Seccion = Convert.ToInt32(DT.Rows[0]["Seccion"]);
                    C_Movimiento_Contable.Item = Convert.ToInt32(DT.Rows[0]["Item"]);
                    C_Movimiento_Contable.Tipo_comp = DT.Rows[0]["Tipo_comp"].ToString();
                    C_Movimiento_Contable.No_comp = Convert.ToInt32(DT.Rows[0]["No_comp"]);
                    C_Movimiento_Contable.Cuenta = DT.Rows[0]["Cuenta"].ToString();
                    C_Movimiento_Contable.Tipo_aux = DT.Rows[0]["Tipo_aux"].ToString();
                    C_Movimiento_Contable.Id_aux = Convert.ToInt32(DT.Rows[0]["Id_aux"]);
                    C_Movimiento_Contable.Dv = DT.Rows[0]["Dv"].ToString();
                    C_Movimiento_Contable.Descripcion = DT.Rows[0]["Descripcion"].ToString();
                    C_Movimiento_Contable.Valor_debito = Convert.ToDouble(DT.Rows[0]["Valor_debito"]);
                    C_Movimiento_Contable.Valor_credito = Convert.ToDouble(DT.Rows[0]["Valor_credito"]);
                    C_Movimiento_Contable.Centro_costo = Convert.ToInt32(DT.Rows[0]["Centro_costo"]);
                    C_Movimiento_Contable.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Movimiento_Contable Consultar(string Tipo_comp, int No_comp, int Item, int Cod_empresa)
        {
            if (Existe(Tipo_comp, No_comp, Item, Cod_empresa, true))
            {
                return C_Movimiento_Contable;
            }
            else
            {
                return null;
            }
        }
        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Movimiento_Contable");
        }

        public DataTable Consultar(string Tipo_comp, int No_comp)
        {
            return Data.ConsultaT("SELECT * FROM Movimiento_Contable WHERE tipo_comp='"+Tipo_comp + " AND no_comp="+No_comp);
        }

        public long Insertar(M_Movimiento_Contable Movimiento_Contable)
        {
            return Data.Accion("INSERT INTO Movimiento_Contable (Seccion,Item,Tipo_comp,No_comp,Cuenta,Tipo_aux,Id_aux,Dv,Descripcion,Valor_debito,Valor_credito,Centro_costo,Cod_empresa) VALUES (" + Movimiento_Contable.Seccion + "," + Movimiento_Contable.Item + ", '" + Movimiento_Contable.Tipo_comp + "'" + "," + Movimiento_Contable.No_comp + ", '" + Movimiento_Contable.Cuenta + "'" + ", '" + Movimiento_Contable.Tipo_aux + "'" + "," + Movimiento_Contable.Id_aux + ", '" + Movimiento_Contable.Dv + "'" + ", '" + Movimiento_Contable.Descripcion + "'" + "," + Movimiento_Contable.Valor_debito + "," + Movimiento_Contable.Valor_credito + "," + Movimiento_Contable.Centro_costo + "," + Movimiento_Contable.Cod_empresa + ");");
        }
        public long Actualizar(M_Movimiento_Contable Movimiento_Contable)
        {
            return Data.Accion("UPDATE Movimiento_Contable SET Seccion=" + Movimiento_Contable.Seccion + ",Item=" + Movimiento_Contable.Item + ",Tipo_comp='" + Movimiento_Contable.Tipo_comp + "'" + ",No_comp=" + Movimiento_Contable.No_comp + ",Cuenta='" + Movimiento_Contable.Cuenta + "'" + ",Tipo_aux='" + Movimiento_Contable.Tipo_aux + "'" + ",Id_aux=" + Movimiento_Contable.Id_aux + ",Dv='" + Movimiento_Contable.Dv + "'" + ",Descripcion='" + Movimiento_Contable.Descripcion + "'" + ",Valor_debito=" + Movimiento_Contable.Valor_debito + ",Valor_credito=" + Movimiento_Contable.Valor_credito + ",Centro_costo=" + Movimiento_Contable.Centro_costo + ",Cod_empresa=" + Movimiento_Contable.Cod_empresa + " WHERE Tipo_comp='" + Movimiento_Contable.Tipo_comp + "'" + " and No_comp=" + Movimiento_Contable.No_comp + " and Item=" + Movimiento_Contable.Item + " and Cod_empresa=" + Movimiento_Contable.Cod_empresa + ";");
        }
        public long Nuevo(M_Movimiento_Contable Movimiento_Contable)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Seccion", Movimiento_Contable.Seccion},
           {"Item", Movimiento_Contable.Item},
           {"Tipo_comp", Movimiento_Contable.Tipo_comp},
           {"No_comp", Movimiento_Contable.No_comp},
           {"Cuenta", Movimiento_Contable.Cuenta},
           {"Tipo_aux", Movimiento_Contable.Tipo_aux},
           {"Id_aux", Movimiento_Contable.Id_aux},
           {"Dv", Movimiento_Contable.Dv},
           {"Descripcion", Movimiento_Contable.Descripcion},
           {"Valor_debito", Movimiento_Contable.Valor_debito},
           {"Valor_credito", Movimiento_Contable.Valor_credito},
           {"Centro_costo", Movimiento_Contable.Centro_costo},
           {"Cod_empresa", Movimiento_Contable.Cod_empresa}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Movimiento_Contable(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
