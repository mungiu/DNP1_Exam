using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceTemperature
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private static TemperatureConverter.Class1 tempConv = new TemperatureConverter.Class1();
        [WebMethod]
        public double ConvertToCelsius(double temperatureF)
        {
            return tempConv.CtoF(temperatureF);
        }

        [WebMethod]
        public double ConvertToFahrenheit(double temperatureC)
        {
            return tempConv.FtoC(temperatureC);
        }
    }
}
