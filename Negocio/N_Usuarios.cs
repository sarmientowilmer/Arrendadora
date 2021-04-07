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
    public class N_Usuarios : N_General
    {
        M_Usuarios C_Usuarios = new M_Usuarios();
        //ClsDatos Data = new ClsDatos();
        public bool Existe(int Id, bool CargarDatos)
        {
            DataTable DT = new DataTable();
            DT = Data.ConsultaT("SELECT * FROM Usuarios WHERE Id= " + Id);
            bool ExisteRegistro = false;
            if (DT.Rows.Count > 0)
            {
                ExisteRegistro = true;
                if (CargarDatos)
                {
                    C_Usuarios.Id = Convert.ToInt32(DT.Rows[0]["Id"]);
                    C_Usuarios.Apellido1 = DT.Rows[0]["Apellido1"].ToString();
                    C_Usuarios.Apellido2 = DT.Rows[0]["Apellido2"].ToString();
                    C_Usuarios.Nombres = DT.Rows[0]["Nombres"].ToString();
                    C_Usuarios.Clave = DT.Rows[0]["Clave"].ToString();
                    C_Usuarios.Tipo = DT.Rows[0]["Tipo"].ToString();
                    C_Usuarios.Cod_empresa = Convert.ToInt32(DT.Rows[0]["Cod_empresa"]);
                    C_Usuarios.Arrendadora = Convert.ToBoolean(DT.Rows[0]["Arrendadora"]);
                    C_Usuarios.Contabilidad = Convert.ToBoolean(DT.Rows[0]["Contabilidad"]);
                    C_Usuarios.IngArren = Convert.ToBoolean(DT.Rows[0]["IngArren"]);
                    C_Usuarios.IngContab = Convert.ToBoolean(DT.Rows[0]["IngContab"]);
                    C_Usuarios.Cons_contab = Convert.ToBoolean(DT.Rows[0]["Cons_contab"]);
                }
            }
            return ExisteRegistro;
        }
        public M_Usuarios Consultar(int Id)
        {
            if (Existe(Id, true))
            {
                return C_Usuarios;
            }
            else
            {
                return null;
            }
        }

        public int ValidaUsuario(int Id, string Pass)
        {
            int resultado = 0;
            if (Existe(Id, true))
            {
                if (C_Usuarios.Clave == Pass) { resultado = 1; }
                else { resultado = 2; }
            }
            return resultado;
        }

        public int EsAdmin(int Id, string Pass)
        {
            int resultado = 0;
            if (Existe(Id, true))
            {
                if (C_Usuarios.Tipo == "A")
                {
                    if (C_Usuarios.Clave == Pass) { resultado = 1; }
                    else { resultado = 2; }
                }
            }
            return resultado;
        }

        public DataTable Consultar()
        {
            return Data.ConsultaT("SELECT * FROM Usuarios");
        }
        public long Insertar(M_Usuarios Usuarios)
        {
            return Data.Accion("INSERT INTO Usuarios (Id,Apellido1,Apellido2,Nombres,Clave,Tipo,Cod_empresa,Arrendadora,Contabilidad,IngArren,IngContab,Cons_contab) VALUES (" + Usuarios.Id + ", '" + Usuarios.Apellido1 + "'" + ", '" + Usuarios.Apellido2 + "'" + ", '" + Usuarios.Nombres + "'" + ", '" + Usuarios.Clave + "'" + ", '" + Usuarios.Tipo + "'" + "," + Usuarios.Cod_empresa + "," + Usuarios.Arrendadora + "," + Usuarios.Contabilidad + "," + Usuarios.IngArren + "," + Usuarios.IngContab + "," + Usuarios.Cons_contab + ");");
        }
        public long Actualizar(M_Usuarios Usuarios)
        {
            return Data.Accion("UPDATE Usuarios SET Id=" + Usuarios.Id + ",Apellido1='" + Usuarios.Apellido1 + "'" + ",Apellido2='" + Usuarios.Apellido2 + "'" + ",Nombres='" + Usuarios.Nombres + "'" + ",Clave='" + Usuarios.Clave + "'" + ",Tipo='" + Usuarios.Tipo + "'" + ",Cod_empresa=" + Usuarios.Cod_empresa + ",Arrendadora=" + Usuarios.Arrendadora + ",Contabilidad=" + Usuarios.Contabilidad + ",IngArren=" + Usuarios.IngArren + ",IngContab=" + Usuarios.IngContab + ",Cons_contab=" + Usuarios.Cons_contab + " WHERE Id= " + Usuarios.Id + ";");
        }
        public long Nuevo(M_Usuarios Usuarios)
        {
            Dictionary<string, object> Parametros = new Dictionary<string, object>
         {
           {"Id", Usuarios.Id},
           {"Apellido1", Usuarios.Apellido1},
           {"Apellido2", Usuarios.Apellido2},
           {"Nombres", Usuarios.Nombres},
           {"Clave", Usuarios.Clave},
           {"Tipo", Usuarios.Tipo},
           {"Cod_empresa", Usuarios.Cod_empresa},
           {"Arrendadora", Usuarios.Arrendadora},
           {"Contabilidad", Usuarios.Contabilidad},
           {"IngArren", Usuarios.IngArren},
           {"IngContab", Usuarios.IngContab},
           {"Cons_contab", Usuarios.Cons_contab}
         };
            return Data.EjecutarSPEscalar("{CALL sp_Nuevo_Usuarios(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}", Parametros);
        }
    }
}
