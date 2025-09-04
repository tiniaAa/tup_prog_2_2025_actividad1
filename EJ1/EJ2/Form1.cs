using Actividaden_Aula_1.Models;

namespace Actividaden_Aula_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cilindro objeto_1 = new Cilindro(3, 3);
            textBox1.Text = objeto_1.Describir();

            //Cubo objeto_2 = new Cubo(3);
            //textBox1.Text = objeto_2.Describir();


            //Ortoedro objeto_3 = new Ortoedro(7,7,21);
            //textBox1.Text = objeto_3.Describir();

            //Cilindro objeto_4 = new Cilindro(9, 13);

            //Cubo Objeto_5 = new Cubo(7);
            //textBox1.Text = Objeto_5.Describir();

            //Cilindro objeto_6 = new Cilindro(13,23);
            //textBox1.Text = objeto_6.Describir();


         





        }
    }
}
