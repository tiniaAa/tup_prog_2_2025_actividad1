using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    internal class RectanguloDesarrollado
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public RectanguloDesarrollado(double radio, double altura) 
        { 
            Ancho=altura;

            Largo = 2*Math.PI*radio;
        }
        public double CalcularArea()
        {
            double area = Largo * Ancho;
            return area ;
        }


    }
}
