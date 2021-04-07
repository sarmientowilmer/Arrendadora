using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Contrato_Arren
    {
        public int No_contrato { get; set; }
        public string Tipo_id { get; set; }
        public int Id_inquilino { get; set; }
        public string Dv { get; set; }
        public int Cod_inmueble { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_vencimiento { get; set; }
        public DateTime Fecha_pago { get; set; }
        public DateTime Pago_hasta { get; set; }
        public double Canon { get; set; }
        public int Periodo { get; set; }
        public int Prorrogas { get; set; }
        public string Estado { get; set; }
        public string Formapago { get; set; }
        public bool Enabogado { get; set; }
        public DateTime FEntAbogado { get; set; }
        public bool Sujeto_iva { get; set; }
        public int Cod_empresa { get; set; }
        public int Cod_empresa_conta { get; set; }
        public bool EnConciliacion { get; set; }
        public DateTime Fecha_enconciliacion { get; set; }
        public double Tasa_admon_prop { get; set; }
        public int Forma_pago_prop { get; set; }
        public string No_cuenta_prop { get; set; }
        public string Clase_cuenta_prop { get; set; }
        public string Entidad_prop { get; set; }
        public DateTime Fecha_pago_prop { get; set; }
        public DateTime Pago_hasta_prop { get; set; }
        public bool Sujeto_iva_prop { get; set; }
        public double Saldo_canon { get; set; }
        public double Saldo_intereses { get; set; }
        public DateTime Ultimopago { get; set; }
        public bool Condominio { get; set; }
        public DateTime Liq_hasta { get; set; }
        public double Canonprop { get; set; }
        public bool Comisionadmon { get; set; }

        //public static explicit operator M_Contrato_Arren(DataRow v)
        //{
        //    return Clase(v);
        //}


        //private  M_Contrato_Arren Clase(DataRow v)
        //{
        //    No_contrato = Convert.ToInt32(v["no_contrato"]);
        //    Tipo_id = v["tipo_id"].ToString();
        //    Id_inquilino = Convert.ToInt32(v["id_inquilino"]);
        //    Dv = v["dv"].ToString();
        //    Cod_inmueble = Convert.ToInt32(v["cod_inmueble"]);
        //    Fecha_inicio = Convert.ToDateTime(v["fecha_inicio"]);
        //    Fecha_vencimiento = Convert.ToDateTime(v["fecha_vencimiento"]);
        //    Fecha_pago = Convert.ToDateTime(v["fecha_pago"]);
        //    Pago_hasta = Convert.ToDateTime(v["pago_hasta"]);
        //    Canon = Convert.ToDouble(v["canon"]);
        //    Periodo = Convert.ToInt32(v["periodo"]);
        //    Prorrogas = Convert.ToInt32(v["prorrogas"]);
        //    Estado = v["estado"].ToString();
        //    Formapago = v["formapago"].ToString();
        //    Enabogado = Convert.ToBoolean(v["enabogado"]);
        //    FEntAbogado = Convert.ToDateTime(v["fentabogado"]);
        //    Sujeto_iva = Convert.ToBoolean(v["sujeto_iva"]);
        //    Cod_empresa = Convert.ToInt32(v["cod_empresa"]);
        //    Cod_empresa_conta = Convert.ToInt32(v["cod_empresa_contab"]);
        //    EnConciliacion = Convert.ToBoolean(v["enconciliacion"]);
        //    Fecha_enconciliacion = Convert.ToDateTime(v["fecha_enconciliacion"]);
        //    Tasa_admon_prop = Convert.ToDouble(v["tasa_admon_prop"]);
        //    Forma_pago_prop = Convert.ToInt32(v["forma_pago_prop"]);
        //    No_cuenta_prop = v["no_cuenta_prop"].ToString();
        //    Clase_cuenta_prop = v["clase_cuenta_prop"].ToString();
        //    Entidad_prop = v["entidad_prop"].ToString();
        //    Fecha_pago_prop = Convert.ToDateTime(v["fecha_pago_prop"]);
        //    Pago_hasta_prop = Convert.ToDateTime(v["pago_hasta_prop"]);
        //    Sujeto_iva_prop = Convert.ToBoolean(v["sujeto_iva_prop"]);
        //    Saldo_canon = Convert.ToDouble(v["saldo_canon"]);
        //    Saldo_intereses = Convert.ToDouble(v["saldo_intereses"]);
        //    Ultimopago = Convert.ToDateTime(v["ultimopago"]);
        //    Condominio = Convert.ToBoolean(v["condominiio"]);
        //    Liq_hasta = Convert.ToDateTime(v["liq_hasta"]);
        //    Canonprop = Convert.ToDouble(v["canonprop"]);
        //    Comisionadmon = Convert.ToBoolean(v["comisionadmon"]);
        //}
    }
}
