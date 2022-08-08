using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastraAluno
{
    internal class Aluno
    {
        private String nome;
        private String endereco;
        private double nota1;
        private double nota2;
        private double nota3;
        private double dtNasc;
        private double media;

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double DtNasc { get => dtNasc; set => dtNasc = value; }
        public double Media { get => media; set => media = value; }

        public Aluno()
        {

        }
        public double calculaMedia(double nota1, double nota2, double nota3)
        {
            media = (nota1 + nota2 + nota3) / 3;
             return media ;
        }

        public String calcularSituacao(double situacao)
        {
            
           if (media >= 7)
            {
                return "Aprovado";
            } else
            {
                return "Reprovado";
            }
        }
    }

}
