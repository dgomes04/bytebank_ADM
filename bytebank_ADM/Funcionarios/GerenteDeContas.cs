using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas:FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf, string nome) : base(cpf, 4000, nome)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 0.05;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

    }
}
