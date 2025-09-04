using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    public class cuadrado:Ortoedro
    {
        public double Ancho { get; set; }
        public double Largo { get; set; }

        public cuadrado (double lado ): base (lado,lado,lado)
        {
            Ancho = lado;
            Largo = lado;
        }
        public double  CalcularArea()
        {
            double area = Ancho*Largo;
            return area ;
        }
        

        public override string Descripcion()
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
