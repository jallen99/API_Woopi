using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Teste2.Services
{
    public class Calculadora
    {
        public double Sum(double a, double b)
        {
            return (a+b);
        }
        public string Sum(string a, string b)
        {
            double res;
            try
            {
                res = Convert.ToDouble(a) + Convert.ToDouble(b);

            }
            catch
            {
                return null;
            }
            return Convert.ToString(res);
        }
    }
}