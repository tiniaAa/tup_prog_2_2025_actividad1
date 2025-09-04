using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    public class RectanguloDesarrollado:Rectangulo
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public RectanguloDesarrollado(double radio, double altura) :base (2 * Math.PI * radio, altura)
        { 
           
        }
        public double CalcularArea()
        {
            double area = Largo * Ancho;
            return area ;
        }
        public override string Descripcion()
        {
            return @$"";
        }

    }
}
