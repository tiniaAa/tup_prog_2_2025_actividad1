using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    internal class Cubo
    {
       
        public cuadrado[] cubo = new cuadrado[6]; 
        
        public Cubo(double lado )
        {
            for (int i =0; i < 6; i++)
            {
                cubo[i] = new cuadrado(lado);
            }
        }
        public double CalcularArea()
        {
            return 4 * cubo[0].CalcularArea();
        }
        public double CalcularVolumen()
        {
            double volumen = cubo[0].Ancho;
            return Math.Pow(volumen,3);
        }
        //metodo describir(falta investigar json)

    }
}
