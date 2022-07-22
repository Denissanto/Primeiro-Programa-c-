namespace Primeiro_Programa_Mark_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NB1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                //NB1.Text == ""? "0" : NB1.Text -> Ternario
                //Parse -> Mudar o tipo do atributo
                int nb1 = int.Parse(NB1.Text == "" ? "0" : NB1.Text);

                //Pegar o Resto
                if (nb1 % 2 == 1)
                {
                    MessageBox.Show("Impar");
                }
                if (nb1 % 2 == 0)
                {
                    MessageBox.Show("Par");
                }
            }
        }
    }
}