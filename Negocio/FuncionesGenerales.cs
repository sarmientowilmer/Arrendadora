using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class FuncionesGenerales
    {
        public void MensajeEstado(ref StatusStrip SS, string Mensaje)
        {
            SS.Items["TSSEstado"].Text = Mensaje;
        }
        public bool ExisteArchivo(string Ruta)
        {
            if(System.IO.File.Exists(Ruta)) { return true; }
            else { return false; }
        }
        public void CargarCombo(ref ComboBox combo, DataTable DS, string CampoDescripcion, string CampoID, bool AgregaTodosALista=false, string Descripcion="", string Valor="")
        {
            //clsN.DatosServidoryPath(Application.StartupPath);
            combo.DataSource = null;
            combo.Items.Clear();
            if (DS.Rows.Count > 0)
            {

                if (AgregaTodosALista)
                {
                    DataRow Fila = DS.NewRow();
                    if (!string.IsNullOrEmpty(Descripcion))
                    {
                        Fila[CampoDescripcion] = Descripcion;
                        Fila[CampoID] = Valor;
                        DS.Rows.InsertAt(Fila, 0);
                    }
                }

                combo.DataSource = DS;
                combo.DisplayMember = CampoDescripcion;
                combo.ValueMember = CampoID;

                /*                foreach (DataRow fila in DS.Tables[0].Rows)
                                {
                                    combo.Items.Add(fila[CampoDescripcion]);
                                }*/
            }
        }

        public void ControlValidado(object sender, EventArgs e, ref ErrorProvider EP, string TipoDato, int CantidadDecimales = 2, bool MostrarSeparadorMiles = false)
        {
            Control Ctl = (Control)sender;
            switch (Ctl.GetType().Name)
            {
                case "TextBox":
                    if (!string.IsNullOrWhiteSpace(Ctl.Text))
                    {
                        if (MostrarSeparadorMiles)
                        {
                            switch (TipoDato)
                            {
                                case "int32":
                                    Ctl.Text = string.Format("{0:N0}", Convert.ToInt32(SinSeparadorMiles(Ctl.Text)));
                                    break;
                                case "int64":
                                    Ctl.Text = string.Format("{0:N0}", Convert.ToInt64(Ctl.Text));
                                    break;
                                case "decimal":
                                    Ctl.Text = string.Format("{0:N0}", Convert.ToDecimal(Ctl.Text));
                                    break;
                                case "double":
                                    Ctl.Text = string.Format("{0:N" + CantidadDecimales + "}", Convert.ToDouble(Ctl.Text));
                                    break;
                            }
                        }
                        EP.SetError(Ctl, string.Empty);
                    }
                    break;
                case "ComboBox":
                    ComboBox Combo = (ComboBox)sender;
                    if (!string.IsNullOrWhiteSpace(Ctl.Text) && Combo.SelectedValue != null)
                    {
                        EP.SetError(Ctl, string.Empty);
                    }
                    break;
            }

        }

        public void ValidarControles(ref object sender, ref CancelEventArgs e, ref ErrorProvider EP, string TipoDato, int NumDecimales, bool ValidaVacio)
        {
            //string Mensaje = "";
            Control Ctl = (Control)sender;
            if (!string.IsNullOrWhiteSpace(Ctl.Text))
            {
                switch (Ctl.GetType().Name)
                {
                    case "TextBox":
                        switch (TipoDato)
                        {
                            case "int32":
                                if (!Int32.TryParse(SinSeparadorMiles(Ctl.Text), out int Numero))
                                {
                                    e.Cancel = true;
                                    //Mensaje = "Revise el número ingresado, excede el valor permitido para este campo";
                                    EP.SetError(Ctl, "Revise el número ingresado, excede el valor permitido para este campo");
                                    //MessageBox.Show("Revise el número ingresado, excede el valor permitido para este campo");
                                }
                                else
                                {
                                    //Tb.Text = string.Format("{0:N0}", Convert.ToInt32(Tb.Text));
                                    //EP.SetError(Tb, string.Empty);
                                }
                                break;
                            case "int64":
                                if (!Int64.TryParse(Ctl.Text, out long Entero64))
                                {
                                    e.Cancel = true;
                                    EP.SetError(Ctl, "Revise el número ingresado, excede el valor permitido para este campo");
                                    MessageBox.Show("Revise el número ingresado, excede el valor permitido para este campo");
                                }
                                else
                                {
                                    Ctl.Text = string.Format("{0:N0}", Convert.ToInt64(Ctl.Text));
                                    EP.SetError(Ctl, string.Empty);
                                }
                                break;
                            case "float":
                                if (!float.TryParse(Ctl.Text, out float NumeroFloat))
                                {
                                    e.Cancel = true;
                                    EP.SetError(Ctl, "Revise el número ingresado, excede el valor permitido para este campo");
                                    MessageBox.Show("Revise el número ingresado, excede el valor permitido para este campo");
                                }
                                else
                                {
                                    Ctl.Text = string.Format("{0:N" + NumDecimales + "}", Convert.ToDouble(Ctl.Text));
                                    EP.SetError(Ctl, string.Empty);
                                }
                                break;
                            case "double":
                                if (!double.TryParse(Ctl.Text, out double NumeroDoble))
                                {
                                    e.Cancel = true;
                                    EP.SetError(Ctl, "Revise el número ingresado, excede el valor permitido para este campo");
                                    MessageBox.Show("Revise el número ingresado, excede el valor permitido para este campo");
                                }
                                else
                                {
                                    Ctl.Text = string.Format("{0:N" + NumDecimales + "}", Convert.ToDouble(Ctl.Text));
                                    EP.SetError(Ctl, string.Empty);
                                }
                                break;

                        }
                        break;
                    case "ComboBox":
                        ComboBox Combo = (ComboBox)sender;
                        if (Combo.SelectedValue == null)
                        {
                            EP.SetError(Ctl, "Debe seleccionar una opción del listado");
                        }
                        break;
                }
            }
            else
            {
                if (ValidaVacio)
                {
                    if (sender.GetType().Name == "TextBox")
                    {
                        if (string.IsNullOrWhiteSpace(Ctl.Text)) { EP.SetError(Ctl, "Debe ingresar la información de " + Ctl.Tag); }
                    }
                    if (sender.GetType().Name == "ComboBox")
                    {
                        if (string.IsNullOrWhiteSpace(Ctl.Text)) { EP.SetError(Ctl, "Debe seleccionar una opción para " + Ctl.Tag); }
                    }
                    //falta implementar para un checkbox y option
                }
            }
        }

        public string SinSeparadorMiles(string Numero)
        {
            if (!string.IsNullOrEmpty(Numero))
            {
                CultureInfo Cultura = CultureInfo.CurrentCulture;
                NumberStyles Estilo = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
                if (Int32.TryParse(Numero, Estilo, Cultura, out int Temp)) return Temp.ToString();
                if (double.TryParse(Numero, Estilo, Cultura, out double DTemp)) return DTemp.ToString();
                return "";
            }
            else return "";
        }

        public void ValidaNumeros(ref KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void ValidaNumerosDec(string Texto, ref KeyPressEventArgs e, int CantDecimales)
        {
            int NumDecimales = 0;
            bool YaIngresoSimboloDecimal = false;
            CultureInfo CC = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (Texto.IndexOf(CC.NumberFormat.NumberDecimalSeparator) > 0)
            {
                YaIngresoSimboloDecimal = true;
                NumDecimales = Convert.ToInt32(Texto.Substring(Texto.IndexOf(CC.NumberFormat.NumberDecimalSeparator)).Length);
            }

            if (Char.IsDigit(e.KeyChar))
            {
                if (YaIngresoSimboloDecimal)
                {
                    if (NumDecimales <= CantDecimales)
                    {
                        NumDecimales++;
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = false;
                }
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString() == CC.NumberFormat.NumberDecimalSeparator)
            {
                if (!YaIngresoSimboloDecimal)
                {
                    YaIngresoSimboloDecimal = true;
                    NumDecimales = 0;
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            else
            {
                e.Handled = true;
            }
        }


        public void ValidarLetras(ref KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

    }
}
