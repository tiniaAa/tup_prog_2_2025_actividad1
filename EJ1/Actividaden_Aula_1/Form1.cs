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
            Ortoedro objeto_3 = new Ortoedro(7,7,21);
            textBox1.Text = objeto_3.Describir();

        }
    }
}
