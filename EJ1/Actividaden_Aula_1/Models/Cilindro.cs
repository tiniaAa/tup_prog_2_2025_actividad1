using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    internal class Cilindro
    {
        public Circulo[] bases  = new Circulo[2];
        RectanguloDesarrollado rectangulo;

        public Cilindro(double radio, double altura)
        {
            bases[0] = new Circulo(radio);
            bases[1] = new Circulo(radio);

            rectangulo=new RectanguloDesarrollado(radio,altura);
        }

        public double CalcularArea()
        {
            double area = 2 * bases[0].CalcularArea() + rectangulo.CalcularArea();

            return area ;
        }
        public  double CalcularVolumen()
        {
            double volumen = bases[0].CalcularArea() * rectangulo.Largo;
            return volumen;
        }
        public string Describir()
        {
            
            
            return$@"
{{
""Tipo"":""Cilindo"",
""Base"":
[
{bases[0].Describir()},
{bases[1].Describir()}
],

""Rectangulo desarrollado"":{rectangulo.Desscribir()},
""Area"":{CalcularArea().ToString("f2")},
""Volumen"":{CalcularVolumen().ToString("f2")}
}}";
        }
    }
}
