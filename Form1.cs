namespace CadastraAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Aluno a = new Aluno();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTexto_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
           

            lblTexto.Text = "\n\n Nome Informado: " + txtNome.Text;
            lblTexto.Text += "\n\n Endereço: " + txtEndereco.Text;
               
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            lblTexto.Text += "\n\n Sua Média é: " + a.calculaMedia(nota1, nota2, nota3);
            lblTexto.Text += "\n\n Sua Situação é: " + a.calcularSituacao(a.calculaMedia(nota1, nota2, nota3));
        }
    }
}