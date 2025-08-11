using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    internal class cuadrado
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public cuadrado (double lado )
        {
            Ancho = lado;
            Largo = lado;
        }
        public double  CalcularArea()
        {
            double area = Ancho*Largo;
            return area ;
        }
        

        public string Describir()
        {

            return $@"
{{
""Tipo"":""Cuadrado"",
""Largo"":""{Largo.ToString("f2")}"",
""Ancho"":""{Ancho.ToString("f2")}"",
""Area"":""{CalcularArea().ToString("f2")}""
}}
";
        }
    }
}
