using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcDemo
{
    public partial class calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            calcservice.CalcServiceSoapClient calc = new calcservice.CalcServiceSoapClient();
            double y=calc.add(double.Parse(num1.Text), double.Parse(num2.Text));
            num3.Text = y.ToString();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            calcservice.CalcServiceSoapClient calc = new calcservice.CalcServiceSoapClient();
            double y = calc.sub(double.Parse(num1.Text), Double.Parse(num2.Text));
            num3.Text = y.ToString();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            calcservice.CalcServiceSoapClient calc = new calcservice.CalcServiceSoapClient();
            double y = calc.multiply(double.Parse(num1.Text), Double.Parse(num2.Text));
            num3.Text = y.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            calcservice.CalcServiceSoapClient calc = new calcservice.CalcServiceSoapClient();
            double y = calc.division(double.Parse(num1.Text), Double.Parse(num2.Text));
            num3.Text = y.ToString();
        }
    }
}