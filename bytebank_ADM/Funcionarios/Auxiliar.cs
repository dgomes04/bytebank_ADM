using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar:Funcionario
    {
        public Auxiliar(string cpf,string nome):base(cpf,2000,nome)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 0.10;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
    }
}
