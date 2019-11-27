using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio
{
    public partial class Form1 : Form
    {
        int g_nroant = 0;
        string g_salida = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraducir_Click(object sender, EventArgs e)
        {
            string cadena1 = txtEntrada.Text.Trim();
            
            for (int i = 0; i < cadena1.Length; i++)
            {
                ProcesarLetra(cadena1.Substring(i, 1));
            }
            txtSalida.Text = g_salida;
        }

        private void ProcesarLetra(string letra) 
        {
            switch (letra) 
            {
                case "a":
                    if (g_nroant == 2)
                    {
                        g_salida += " 2";
                    }
                    else 
                    {
                        g_salida += "2";
                        g_nroant = 2;
                    }
                    break;
                case "b":
                    if (g_nroant == 2)
                    {
                        g_salida += " 22";
                    }
                    else
                    {
                        g_salida += "22";
                        g_nroant = 2;
                    }
                    break;
                case "c":
                    if (g_nroant == 2)
                    {
                        g_salida += " 222";
                    }
                    else
                    {
                        g_salida += "2222";
                        g_nroant = 2;
                    }
                    break;
                case "d":
                    if (g_nroant == 3)
                    {
                        g_salida += " 3";
                    }
                    else
                    {
                        g_salida += "3";
                        g_nroant = 3;
                    }
                    break;
                case "e":
                    if (g_nroant == 3)
                    {
                        g_salida += " 33";
                    }
                    else
                    {
                        g_salida += "33";
                        g_nroant = 3;
                    }
                    break;
                case "f":
                    if (g_nroant == 3)
                    {
                        g_salida += " 3333";
                    }
                    else
                    {
                        g_salida += "333";
                        g_nroant = 3;
                    }
                    break;
                case "g":
                    if (g_nroant == 4)
                    {
                        g_salida += " 4";
                    }
                    else
                    {
                        g_salida += "4";
                        g_nroant = 4;
                    }
                    break;
                case "h":
                    if (g_nroant == 4)
                    {
                        g_salida += " 44";
                    }
                    else
                    {
                        g_salida += "44";
                        g_nroant = 4;
                    }
                    break;
                case "i":
                    if (g_nroant == 4)
                    {
                        g_salida += " 444";
                    }
                    else
                    {
                        g_salida += "444";
                        g_nroant = 4;
                    }
                    break;
                case "j":
                    if (g_nroant == 5)
                    {
                        g_salida += " 5";
                    }
                    else
                    {
                        g_salida += "5";
                        g_nroant = 5;
                    }
                    break;
                case "k":
                    if (g_nroant == 5)
                    {
                        g_salida += " 55";
                    }
                    else
                    {
                        g_salida += "55";
                        g_nroant = 5;
                    }
                    break;
                case "l":
                    if (g_nroant == 5)
                    {
                        g_salida += " 555";
                    }
                    else
                    {
                        g_salida += "555";
                        g_nroant = 5;
                    }
                    break;
                case "m":
                    if (g_nroant == 6)
                    {
                        g_salida += " 6";
                    }
                    else
                    {
                        g_salida += "6";
                        g_nroant = 6;
                    }
                    break;
                case "n":
                    if (g_nroant == 6)
                    {
                        g_salida += " 66";
                    }
                    else
                    {
                        g_salida += "66";
                        g_nroant = 6;
                    }
                    break;
                case "o":
                    if (g_nroant == 6)
                    {
                        g_salida += " 666";
                    }
                    else
                    {
                        g_salida += "666";
                        g_nroant = 6;
                    }
                    break;
                case "p":
                    if (g_nroant == 7)
                    {
                        g_salida += " 7";
                    }
                    else
                    {
                        g_salida += "7";
                        g_nroant = 7;
                    }
                    break;
                case "q":
                    if (g_nroant == 7)
                    {
                        g_salida += " 77";
                    }
                    else
                    {
                        g_salida += "77";
                        g_nroant = 7;
                    }
                    break;
                case "r":
                    if (g_nroant == 7)
                    {
                        g_salida += " 777";
                    }
                    else
                    {
                        g_salida += "777";
                        g_nroant = 7;
                    }
                    break;
                case "s":
                    if (g_nroant == 7)
                    {
                        g_salida += " 7777";
                    }
                    else
                    {
                        g_salida += "7777";
                        g_nroant = 7;
                    }
                    break;
                case "t":
                    if (g_nroant == 8)
                    {
                        g_salida += " 8";
                    }
                    else
                    {
                        g_salida += "8";
                        g_nroant = 8;
                    }
                    break;
                case "u":
                    if (g_nroant == 8)
                    {
                        g_salida += " 88";
                    }
                    else
                    {
                        g_salida += "88";
                        g_nroant = 8;
                    }
                    break;
                case "v":
                    if (g_nroant == 8)
                    {
                        g_salida += " 888";
                    }
                    else
                    {
                        g_salida += "888";
                        g_nroant = 8;
                    }
                    break;
                case "w":
                    if (g_nroant == 9)
                    {
                        g_salida += " 9";
                    }
                    else
                    {
                        g_salida += "9";
                        g_nroant = 9;
                    }
                    break;
                case "x":
                    if (g_nroant == 9)
                    {
                        g_salida += " 99";
                    }
                    else
                    {
                        g_salida += "99";
                        g_nroant = 9;
                    }
                    break;
                case "y":
                    if (g_nroant == 9)
                    {
                        g_salida += " 999";
                    }
                    else
                    {
                        g_salida += "999";
                        g_nroant = 9;
                    }
                    break;
                case "z":
                    if (g_nroant == 9)
                    {
                        g_salida += " 9999";
                    }
                    else
                    {
                        g_salida += "9999";
                        g_nroant = 9;
                    }
                    break;
                case " ":
                    g_salida += " ";
                    g_nroant = -1;
                    break;

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEntrada.Clear();
            txtSalida.Clear();
            g_nroant = 0;
            g_salida = null;
        }
    }
}
