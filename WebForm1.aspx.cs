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

    }

    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            Global.num1 = float.Parse(Pantalla_.Text);
            Pantalla_.Text = Pantalla_.Text + "+";
            Global.activo = true;
        }

        protected void Btn_igual_Click(object sender, EventArgs e)
        {
            Pantalla_.Text = Pantalla_.Text + "=" + (Global.num1 + Global.num2).ToString();
        }
    }
}