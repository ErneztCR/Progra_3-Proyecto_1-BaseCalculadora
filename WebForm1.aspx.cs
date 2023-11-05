using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class Global
    {
        public static float num1 { get; set; }
        public static float num2 { get; set; }
        public static float resultado { get; set; }
        public static bool activo { get; set; }

        public static string v2 = "";

        public static string operador { get; set; }
    }

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Cambiar el texto a color verde
            Pantalla_.ForeColor = System.Drawing.Color.Green;

            // Alinear el texto al centro del label
            Pantalla_.Style["text-align"] = "center";

            // Aplicar la fuente al Label
            Pantalla_.Attributes["style"] = "font-family: 'Calculator', sans-serif;"; 

            // Cambiar el tamaño de la fuente
            Pantalla_.Style["font-size"] = "45px";

            // Ajusta el espaciado entre los caracteres
            Pantalla_.Style["letter-spacing"] = "5px";
        }

        protected void Btn_0_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "0";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "0");
                Pantalla_.Text = Pantalla_.Text + "0";
            }
        }

        protected void Btn_1_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "1";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "1");
                Pantalla_.Text = Pantalla_.Text + "1";

            }
        }

        protected void Btn_2_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "2";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "2");
                Pantalla_.Text = Pantalla_.Text + "2";
            }
        }

        protected void Btn_3_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "3";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "3");
                Pantalla_.Text = Pantalla_.Text + "3";
            }
        }

        protected void Btn_4_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "4";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "4");
                Pantalla_.Text = Pantalla_.Text + "4";
            }
        }

        protected void Btn_5_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "5";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "5");
                Pantalla_.Text = Pantalla_.Text + "5";
            }
        }

        protected void Btn_6_Click(object sender, EventArgs e)
        {

            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "6";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "6");
                Pantalla_.Text = Pantalla_.Text + "6";
            }
        }

        protected void Btn_7_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "7";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "7");
                Pantalla_.Text = Pantalla_.Text + "7";
            }
        }

        protected void Btn_8_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "8";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "8");
                Pantalla_.Text = Pantalla_.Text + "8";
            }
        }

        protected void Btn_9_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + "9";
            }
            else
            {
                Global.num2 = float.Parse(Global.v2 + "9");
                Pantalla_.Text = Pantalla_.Text + "9";
            }
        }

        protected void Btn_suma_Click(object sender, EventArgs e)
        {
            Global.operador = "+";
            Global.num1 = float.Parse(Pantalla_.Text);
            Pantalla_.Text = Pantalla_.Text + "+";
            Global.activo = true;
        }

        protected void Btn_resta_Click(object sender, EventArgs e)
        {
            Global.operador = "-";
            Global.num1 = float.Parse(Pantalla_.Text);
            Pantalla_.Text = Pantalla_.Text + "-";
            Global.activo = true;
        }

        protected void Btn_multiplicación_Click(object sender, EventArgs e)
        {
            Global.operador = "*";
            Global.num1 = float.Parse(Pantalla_.Text);
            Pantalla_.Text = Pantalla_.Text + "*";
            Global.activo = true;
        }

        protected void Btn_división_Click(object sender, EventArgs e)
        {
            Global.operador = "/";
            Global.num1 = float.Parse(Pantalla_.Text);
            Pantalla_.Text = Pantalla_.Text + "/";
            Global.activo = true;
        }

        protected void Btn_2_raíz_x_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                float num = float.Parse(Pantalla_.Text);
                Global.resultado = (float)Math.Sqrt(num);
                Pantalla_.Text = Global.resultado.ToString();
            }
        }

        protected void Btn_x_exp_y_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Global.num1 = float.Parse(Pantalla_.Text);
                Global.operador = "^";
                Pantalla_.Text = Pantalla_.Text + "^";
                Global.activo = true;
            }
        }

        protected void Btn_10_exp_x_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                float x = float.Parse(Pantalla_.Text);
                double resultado = Math.Pow(10, x);
                Pantalla_.Text = resultado.ToString();
            }
        }

        protected void Btn_log_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                double numero = double.Parse(Pantalla_.Text);
                if (numero > 0)
                {
                    double resultado = Math.Log10(numero);
                    Pantalla_.Text = resultado.ToString();
                }
                else
                {
                    Pantalla_.Text = "Error"; // El numero digitado tiene que ser mayor a 0
                }
            }
        }

        protected void Btn_x_exp_2_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                float x = float.Parse(Pantalla_.Text);
                float resultado = x * x;

                Pantalla_.Text = resultado.ToString();
            }
        }

        protected void Btn_fact_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                float numero = float.Parse(Pantalla_.Text);

                float resultado = CalcularFactorial(numero);

                Pantalla_.Text = resultado.ToString();
            }
        }

        private float CalcularFactorial(float n)
        {
            if (n == 0)
            {
                return 1; // El factorial de 0 es 1
            }
            else
            {
                float factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }

        protected void Btn_camb_sig_Click(object sender, EventArgs e)
        {
            if (Global.activo == false && Pantalla_.Text.Length > 0)
            {
                double numero = double.Parse(Pantalla_.Text);
                numero = -numero;
                Pantalla_.Text = numero.ToString();
            }
        }

        protected void Btn_coma_Click(object sender, EventArgs e)
        {
            if (Global.activo == false)
            {
                Pantalla_.Text = Pantalla_.Text + ".";
            }
            else
            {
                Global.v2 += ".";
                Pantalla_.Text = Pantalla_.Text + ".";
            }
        }

        protected void Btn_c_Click(object sender, EventArgs e)
        {
            Global.num1 = 0;
            Global.num2 = 0;
            Global.resultado = 0;
            Global.activo = false;
            Global.v2 = "";
            Global.operador = "";

            // Limpiar toda la pantalla
            Pantalla_.Text = "";
        }

        protected void Btn_borrar_Click(object sender, EventArgs e)
        {
            // Agrega aquí el código para manejar el evento Click del botón "Btn_borrar"
            // Por ejemplo, para borrar un carácter de la pantalla:
            if (Pantalla_.Text.Length > 0)
            {
                Pantalla_.Text = Pantalla_.Text.Substring(0, Pantalla_.Text.Length - 1);
            }
        }

        protected void Btn_igual_Click(object sender, EventArgs e)
        {
            switch (Global.operador)
            {
                case "+":
                    Global.resultado = Global.num1 + Global.num2;
                    Pantalla_.Text = Pantalla_.Text + "=" + Global.resultado.ToString();
                    break;
                case "-":
                    Global.resultado = Global.num1 - Global.num2;
                    Pantalla_.Text = Pantalla_.Text + "=" + Global.resultado.ToString();
                    break;
                case "*":
                    Global.resultado = Global.num1 * Global.num2;
                    Pantalla_.Text = Pantalla_.Text + "=" + Global.resultado.ToString();
                    break;
                case "/":
                    Global.resultado = Global.num1 / Global.num2;
                    Pantalla_.Text = Pantalla_.Text + "=" + Global.resultado.ToString();
                    break;
                case "^":
                    Global.resultado = (float)Math.Pow(Global.num1, Global.num2);
                    Pantalla_.Text = Global.resultado.ToString();
                    Global.activo = false;
                    break;
            }
        }
    }
}
