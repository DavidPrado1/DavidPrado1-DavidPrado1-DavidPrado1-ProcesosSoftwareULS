using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication6
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public WebService1()
        {

        }

        [WebMethod]
        public decimal Suma(decimal x, decimal y)
        {
            decimal resultado = x + y;
            return resultado;
        }
        [WebMethod]
        public decimal Resta(decimal x, decimal y)
        {
            decimal resultado = x - y;
            return resultado;
        }
        [WebMethod]
        public decimal Multiplicacion(decimal x, decimal y)
        {
            decimal resultado = x * y;
            return resultado;
        }
        [WebMethod]
        public decimal Division(decimal x, decimal y)
        {
            decimal resultado = x / y;
            return resultado;
        }
    }
}
