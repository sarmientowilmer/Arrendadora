using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class M_Inmuebles
    {
        public int Cod_inmueble { get; set; }
        public int Tipo_inmueble { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public bool Agua { get; set; }
        public bool Luz { get; set; }
        public bool Telefono { get; set; }
        public string No_telefono { get; set; }
        public bool Parabolica { get; set; }
        public bool Vigilancia { get; set; }
        public bool Administracion { get; set; }
        public string Estado { get; set; }
        public double Canonarrendar { get; set; }
        public int Ultimocont { get; set; }
        public byte Cod_direccion { get; set; }
        public string No_direccion { get; set; }
        public string No_direccion_puerta { get; set; }
        public int Cod_barrio { get; set; }
        public int Llave_ciudad { get; set; }
        public byte Destino_inmueble { get; set; }
        public double Valorventa { get; set; }
        public string Ambito { get; set; }
        public int Cod_empresa { get; set; }
        public double Valor_admon { get; set; }
        public string Observaciones { get; set; }
        public bool Gas { get; set; }
        public int Estrato { get; set; }
        public int Metraje { get; set; }
        public int No_contratos_arren { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int Matricula_inm { get; set; }

    }
}
