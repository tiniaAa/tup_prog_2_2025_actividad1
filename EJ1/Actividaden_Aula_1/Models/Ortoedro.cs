using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    internal class Ortoedro
    {
        public Rectangulo[] Laterales = new Rectangulo[4];
        public Rectangulo[] Bases = new Rectangulo[2];


        public Ortoedro(double anchoBase, double ladoComun,double largoLateral)
        {
            //Bases del ortoedro 
            Bases[0] = new Rectangulo(anchoBase, ladoComun);
            Bases[1] = new Rectangulo(anchoBase, ladoComun);

            //Laterales del orotoedro 
            for (int i =0; i < 4; i++)
            {
                Laterales[i]= new Rectangulo(ladoComun, largoLateral);
            }
        }
        public Double CalcularArea()
        {
            double areaBase = Bases[0].CalcularArea();
            double areaLateral = Laterales[0].CalcularArea();

            return areaBase*2+areaLateral*4;

        }
        public double CalcularVolumen()
        {

            double volumen = Bases[0].CalcularArea() * Laterales[0].Largo;


            return volumen;
        }
        public string Describir()
        {
            double area = CalcularArea();
            double volumen = CalcularVolumen();

            string descripcion = $@"

{{
""Tipo"":""Ortoedro"",
""Bases"":
[
    {Bases[0].Describir()},
    {Bases[1].Describir()}
],
""Laterales"":
[
    {Laterales[0].Describir()},
    {Laterales[1].Describir()},
    {Laterales[2].Describir()},
    {Laterales[3].Describir()},
],
""Area"":""{CalcularArea()}"",
""Volumen"":""{CalcularVolumen()}""
}}
";
            return descripcion;
            }
        }
}
