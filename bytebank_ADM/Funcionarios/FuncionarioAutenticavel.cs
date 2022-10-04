using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel:Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario, string Nome) : base(cpf, salario, Nome)
        {
        }

        public string Senha { get; set; }
        public string Login { get; set; }
        public bool Autenticar(string login, string senha)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}
