﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logica
{
    public class N_Conversion
    {
        private string[] UNIDADES = { "", "un ", "dos ", "tres ", "cuatro ", "cinco ", "seis ", "siete ", "ocho ", "nueve " };
        private string[] DECENAS = {"diez ", "once ", "doce ", "trece ", "catorce ", "quince ", "dieciseis ",
        "diecisiete ", "dieciocho ", "diecinueve", "veinte ", "treinta ", "cuarenta ",
        "cincuenta ", "sesenta ", "setenta ", "ochenta ", "noventa "};
        private string[] CENTENAS = {"", "ciento ", "doscientos ", "trecientos ", "cuatrocientos ", "quinientos ", "seiscientos ",
        "setecientos ", "ochocientos ", "novecientos "};

        private Regex r;

        public string Convertir(string numero, bool mayusculas, string moneda = "PESOS")
        {

            string literal = "";
            string parte_decimal;
            //si el numero utiliza (.) en lugar de (,) -> se reemplaza
            numero = numero.Replace(".", ",");

            //si el numero no tiene parte decimal, se le agrega ,00

            if (numero.IndexOf(",") == -1)
            {
                numero = numero + ",00";
            }
            //se valida formato de entrada -> 0,00 y 999 999 999,00
            r = new Regex(@"\d{1,9},\d{1,2}");
            MatchCollection mc = r.Matches(numero);
            if (mc.Count > 0)
            {
                //se divide el numero 0000000,00 -> entero y decimal
                string[] Num = numero.Split(',');

                string MN = " M.L.";
                if (moneda != "PESOS")
                    MN = "";

                //de da formato al numero decimal
                parte_decimal = moneda + " " + Num[1] + "/100" + MN;
                //se convierte el numero a literal
                if (int.Parse(Num[0]) == 0)
                {//si el valor es cero
                    literal = "cero ";
                }
                else if (int.Parse(Num[0]) > 999999)
                {//si es millon
                    literal = GetMillones(Num[0]);
                }
                else if (int.Parse(Num[0]) > 999)
                {//si es miles
                    literal = GetMiles(Num[0]);
                }
                else if (int.Parse(Num[0]) > 99)
                {//si es centena
                    literal = GetCentenas(Num[0]);
                }
                else if (int.Parse(Num[0]) > 9)
                {//si es decena
                    literal = GetDecenas(Num[0]);
                }
                else
                {//sino unidades -> 9
                    literal = GetUnidades(Num[0]);
                }
                //devuelve el resultado en mayusculas o minusculas
                if (mayusculas)
                {
                    return (literal + parte_decimal).ToUpper();
                }
                else
                {
                    return (literal + parte_decimal);
                }
            }
            else
            {//error, no se puede convertir
                return literal = null;
            }
        }

        /* funciones para convertir los numeros a literales */

        private string GetUnidades(string numero)
        {   // 1 - 9
            //si tuviera algun 0 antes se lo quita -> 09 = 9 o 009=9
            string num = numero.Substring(numero.Length - 1);
            return UNIDADES[int.Parse(num)];
        }

        private string GetDecenas(string num)
        {// 99
            int n = int.Parse(num);
            if (n < 10)
            {//para casos como -> 01 - 09
                return GetUnidades(num);
            }
            else if (n > 19)
            {//para 20...99
                string u = GetUnidades(num);
                if (u.Equals(""))
                { //para 20,30,40,50,60,70,80,90
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 8];
                }
                else
                {
                    return DECENAS[int.Parse(num.Substring(0, 1)) + 8] + "y " + u;
                }
            }
            else
            {//numeros entre 11 y 19
                return DECENAS[n - 10];
            }
        }

        private string GetCentenas(string num)
        {// 999 o 099
            if (int.Parse(num) > 99)
            {//es centena
                if (int.Parse(num) == 100)
                {//caso especial
                    return " cien ";
                }
                else
                {
                    return CENTENAS[int.Parse(num.Substring(0, 1))] + GetDecenas(num.Substring(1));
                }
            }
            else
            {//por Ej. 099
             //se quita el 0 antes de convertir a decenas
                return GetDecenas(int.Parse(num) + "");
            }
        }

        private string GetMiles(string numero)
        {// 999 999
         //obtiene las centenas
            string c = numero.Substring(numero.Length - 3);
            //obtiene los miles
            string m = numero.Substring(0, numero.Length - 3);
            string n = "";
            //se comprueba que miles tenga valor entero
            if (int.Parse(m) > 0)
            {
                n = GetCentenas(m);
                return n + "mil " + GetCentenas(c);
            }
            else
            {
                return "" + GetCentenas(c);
            }

        }

        private string GetMillones(string numero)
        { //000 000 000
          //se obtiene los miles
            string miles = numero.Substring(numero.Length - 6);
            //se obtiene los millones
            string millon = numero.Substring(0, numero.Length - 6);
            string n = "";
            if (millon.Length > 1)
            {
                n = GetCentenas(millon) + "millones ";
            }
            else
            {
                n = GetUnidades(millon) + "millon ";
            }
            return n + GetMiles(miles);
        }

    }
}
