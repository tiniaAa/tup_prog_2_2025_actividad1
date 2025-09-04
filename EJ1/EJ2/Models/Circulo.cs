using EJ2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    public  class Circulo:FiguraPlana
    {
        public double Radio { get; set; }
        public Circulo(double radio) 
        {
            Radio = radio;
        }
        public override double CalcularArea()
        {
            double area = Math.PI*Math.Pow(Radio,2);
            return area;
        }
        public override string Descripcion()
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
