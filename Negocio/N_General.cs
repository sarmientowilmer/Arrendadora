using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Logica
{
    public class N_General
    {
        public ClsDatos Data = new ClsDatos();
        public string GsPath;
        public string ConectaA;
        public void ConectarA (string ConectaA)
        {
            //Data.ConectaA = ConectaA;
            this.ConectaA = ConectaA;
        }
        public void Cadena(string path)
        {
            //Data.Cadena(path);
            if (GsPath==null)  GsPath = path;
        }

        public void Cadena(string path, string Servidor)
        {
            //Data.ConectaA = Servidor;
            Data.GsPath = path;
            ConectaA = Servidor;
            //Data.Cadena(path);
            if (GsPath == null) GsPath = path;
        }

        public void DatosServidoryPath(string pathprograma)
        {

            //Data.DatosServidoryPath(pathprograma);
            //Data.Cadena();
            GsPath = Data.GsPath;
        }

    }
}
