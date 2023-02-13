using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CalculatorLibrary;

namespace CalcWeb1
{
    [WebService(Namespace = "mikescalculator.org")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    //Below allows service to be called from a script using ASP.NET AJAX. Comment out to disable.
    [System.Web.Script.Services.ScriptService]

    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string calculate(string first, string second, char sign)
        {
            string result;
            CalcClass calculator = new CalcClass();
            
            switch(sign)
            {
                case '+':
                    {
                        result = calculator.Add(Convert.ToInt32(first), Convert.ToInt32(second)).ToString();
                        break;
                    }
                case '-':
                    {
                        result = calculator.Subtract(Convert.ToInt32(first), Convert.ToInt32(second)).ToString();
                        break;
                    }
                default:
                    result = "Invalid";
                    break;
            }
            return result;
        }
    }
}