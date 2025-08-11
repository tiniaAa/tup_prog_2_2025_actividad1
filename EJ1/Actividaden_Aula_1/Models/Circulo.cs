using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    internal class Circulo
    {
        public double Radio { get; set; }
        public Circulo(double radio) 
        {
            Radio = radio;
        }
        public double CalcularArea()
        {
            double area = Math.PI*Math.Pow(Radio,2);
            return area;
        }
        public string Describir()
        {

            return @$"
{{
""Tipo"":""Circulo"",
""Radio"":""{Radio.ToString("f2")}"",
""Area"":""{CalcularArea().ToString("f2")}"",


}}";
        }


    }
}
