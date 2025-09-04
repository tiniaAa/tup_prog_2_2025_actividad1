using EJ2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    public class Cilindo:FiguraVolumetricas
    {
        public Circulo[] bases  = new Circulo[2];
        RectanguloDesarrollado rectangulo;

        public Cilindro(double radio, double altura)
        {
            bases[0] = new Circulo(radio);
            bases[1] = new Circulo(radio);

            rectangulo=new RectanguloDesarrollado(radio,altura);
        }

        public override double CalcularArea()
        {
            double area = 2 * bases[0].CalcularArea() + rectangulo.CalcularArea();

            return area ;
        }
        public  override double CalcularVolumen()
        {
            double volumen = bases[0].CalcularArea() * rectangulo.Largo;
            return volumen;
        }
        public override string Descripcion()
        {
            
            
            return$@"
{{
""Tipo"":""Cilindo"",
""Base"":
[
{bases[0].Descripcion()},
{bases[1].Descripcion()}
],

""Rectangulo desarrollado"":{rectangulo.Descripcion()},
""Area"":{CalcularArea().ToString("f2")},
""Volumen"":{CalcularVolumen().ToString("f2")}
}}";
        }
    }
}
