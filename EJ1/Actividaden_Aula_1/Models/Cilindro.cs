using System;
using System.Collections.Generic;
using System.Linq;
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
        //falta realizar describir
    }
}
