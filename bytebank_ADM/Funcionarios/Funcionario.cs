using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string cpf, double salario, string Nome)
        {
            this.CPF = cpf;
            this.Salario = salario;
            this.Nome = Nome;
            totalDeFuncionarios++;
        }
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
        

        public static int totalDeFuncionarios { get; private set; }    
    }
}
