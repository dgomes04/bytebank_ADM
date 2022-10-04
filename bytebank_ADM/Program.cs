
using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceiriaComercial;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Ultilitário;

CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer Pedro = new Designer("703.224.420-36", "Pedro");

    Diretor Paula = new Diretor("044.426.910-02", "Paula");

    Auxiliar Igor = new Auxiliar("783.865.370-35", "Igor");

    GerenteDeContas Camila = new GerenteDeContas("286.362.780-58", "Camila");

    gerenciador.Registrar(Pedro);
    gerenciador.Registrar(Paula);
    gerenciador.Registrar(Igor);
    gerenciador.Registrar(Camila);

    Console.WriteLine("Total de Bonificação: " + gerenciador.GetBonificacao());

}

UsarSistema();
void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor Roberta = new Diretor("600.683.390-54","Roberta");
    Roberta.Login = Roberta.CPF;
    Roberta.Senha = "123";

    Diretor Ursula = new Diretor("640.414.520-07", "Ursula");
    Ursula.Login = Ursula.CPF;
    Ursula.Senha = "1234";

    ParceiroComercial Joao = new ParceiroComercial();
    Joao.Login = "220.915.140-63";
    Joao.Senha = "12345";

    sistemainterno.Logar(Roberta, "600.683.390-54", "123") ;
    sistemainterno.Logar(Ursula, "640.414.520-07", "1234");
    sistemainterno.Logar(Joao, "220.915.140-63", "12345");
}