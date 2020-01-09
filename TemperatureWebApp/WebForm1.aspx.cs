using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TemperatureWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CtoF_Click(object sender, EventArgs e)
        {
            TemperatureService.WebService1SoapClient client = new TemperatureService.WebService1SoapClient();
            result.Text = client.ConvertToFahrenheit(double.Parse(input.Text)).ToString();
        }

        protected void FtoC_Click(object sender, EventArgs e)
        {
            TemperatureService.WebService1SoapClient client = new TemperatureService.WebService1SoapClient();
            result.Text = client.ConvertToCelsius(double.Parse(input.Text)).ToString();
        }
    }
}