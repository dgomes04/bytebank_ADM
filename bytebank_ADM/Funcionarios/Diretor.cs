using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor:FuncionarioAutenticavel
    {
        public Diretor(string cpf, string nome) : base(cpf, 5000, nome)
        {
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }
        
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
