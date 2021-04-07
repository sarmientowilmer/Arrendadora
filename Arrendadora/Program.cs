using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrendadora
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static string GsPath;
        public static string gsServidor = "Access";
        public static string GsPathData = "";
        public static long IdUsuario = 0;
        public static string Nombre_Empresa = "";
        public static bool BDAccess = false;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GsPath = Application.StartupPath;
            FrmSplash FrmS = new FrmSplash();
            FrmS.ShowDialog();
            FrmS.Dispose();
            FrmLogin FrmL = new FrmLogin();
            FrmL.ShowDialog();
            if (FrmL.DialogResult== DialogResult.OK)
            {
                //Application.Run(new FrmPrincipal());
                //LeerDatoServidoryPath();
                FrmPrincipal FrmPrin = new FrmPrincipal();
                Application.Run(FrmPrin);
            }
            else
            {
                Application.Exit();
            }


        }

        public static void LeerDatoServidoryPath()
        {
            string DATO;
            string pathprograma = Application.StartupPath; 
            string sNombreEquipo;

            //if (ConectaA == null)
            //{
            //string archivo = Application.StartupPath + @"\datoserv.txt";
            string archivo = pathprograma + @"\datoserv.txt";
            System.IO.StreamReader file =
            new System.IO.StreamReader(archivo);
            if ((DATO = file.ReadLine()) != " ")
            {

                sNombreEquipo = @"\\" + DATO.Trim() + @"\";
                DATO = file.ReadLine();
                if (DATO != " ")
                {
                    //gsServidor = "";
                    if (!string.IsNullOrWhiteSpace(DATO))
                    {
                        GsPathData = sNombreEquipo + DATO.Trim() + @"\";
                    }
                }
                DATO = file.ReadLine();
                if (DATO != " ")
                {
                    //gsServidor = "";
                    if (!string.IsNullOrWhiteSpace(DATO))
                    {
                        gsServidor = DATO.Trim();
                    }
                }
            }
            else
            {
                if (DATO == " ")
                {
                    //MessageBox.Show( Application.CommonAppDataPath);
                    sNombreEquipo = pathprograma.Substring(0, 3);
                    GsPath = sNombreEquipo + pathprograma.Substring(3, pathprograma.Length - 3) + @"\";
                    gsServidor = "localhost";
                }
            }
            file.Close();
            //}

        }


        public static void MensajeEstado(string Mensaje)
        {
            //FrmPrin.MensajeEstado(Mensaje);

        }
    }
}
