using EJ2.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    public  class Rectangulo:FiguraPlana
    {
        
        public double Ancho {get;set;}
        public double Largo {get;set;}

        public Rectangulo(double ancho, double largo ) 
        {
            Ancho = ancho;
            Largo = largo;
             
        }
        public override string Descripcion()
        {
            return $@"
{{
    ""Tipo"":""Rectangulo"",
    ""Largo"":""{Largo.ToString("f2", CultureInfo.InvariantCulture)}"",
    ""Ancho"":""{Ancho.ToString("f2", CultureInfo.InvariantCulture)}"",
    ""Area"":""{CalcularArea().ToString("f2",CultureInfo.InvariantCulture)}""
}}";

        }
   
        public override Double CalcularArea()
        {
            return Largo*Ancho;
        }
            




    }
}
