using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    internal class Rectangulo
    {
        
        public double Ancho {get;set;}
        public double Largo {get;set;}

        public Rectangulo(double ancho, double largo ) 
        {
            Ancho = ancho;
            Largo = largo;
             
        }
        public string Describir()
        {
            return $"Rectangulo : {Ancho},{Largo}";

        }
   
        public Double CalcularArea()
        {
            return Largo*Ancho;
        }
            




    }
}
