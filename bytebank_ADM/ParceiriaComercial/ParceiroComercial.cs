using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.ParceiriaComercial
{
    public class ParceiroComercial : IAutenticavel
    {
      
        public string Senha { get; set; }
        public string Login { get; set; }

        public bool Autenticar(string login, string senha)
        {

            return this.Login == login && senha == this.Senha;
        }
    }
}
