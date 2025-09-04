using EJ2.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividaden_Aula_1.Models
{
    public  class Ortoedro:FiguraVolumetricas
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
        public override Double CalcularArea()
        {
            double areaBase = Bases[0].CalcularArea();
            double areaLateral = Laterales[0].CalcularArea();

            return areaBase*2+areaLateral*4;

        }
        public override double CalcularVolumen()
        {

            double volumen = Bases[0].CalcularArea() * Laterales[0].Largo;


            return volumen;
        }
        public override string Descripcion()
        {
            double area = CalcularArea();
            double volumen = CalcularVolumen();

            string descripcion = $@"

{{
""Tipo"":""Ortoedro"",
""Bases"":
[
    {Bases[0].Descripcion()},
    {Bases[1].Descripcion()}
],
""Laterales"":
[
    {Laterales[0].Descripcion()},
    {Laterales[1].Descripcion()},
    {Laterales[2].Descripcion()},
    {Laterales[3].Descripcion()},
],
""Area"":""{CalcularArea().ToString("f2", CultureInfo.InvariantCulture)}"",
""Volumen"":""{CalcularVolumen().ToString("f2", CultureInfo.InvariantCulture)}""
}}
";
            return descripcion;
            }
        }
}
