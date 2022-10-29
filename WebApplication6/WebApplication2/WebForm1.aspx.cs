using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.ServiceReference1;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox3.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient cliente = new ServiceReference1.WebService1SoapClient();
            decimal resu = cliente.Suma(decimal.Parse(TextBox1.Text), decimal.Parse(TextBox2.Text));
            TextBox3.Text = resu.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient cliente = new ServiceReference1.WebService1SoapClient();
            decimal resu = cliente.Resta(decimal.Parse(TextBox1.Text), decimal.Parse(TextBox2.Text));
            TextBox3.Text = resu.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient cliente = new ServiceReference1.WebService1SoapClient();
            decimal resu = cliente.Multiplicacion (decimal.Parse(TextBox1.Text), decimal.Parse(TextBox2.Text));
            TextBox3.Text = resu.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient cliente = new ServiceReference1.WebService1SoapClient();
            decimal resu = cliente.Division(decimal.Parse(TextBox1.Text), decimal.Parse(TextBox2.Text));
            TextBox3.Text = resu.ToString();
        }
    }
}