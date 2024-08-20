public class AcessoPastaProxy : IAcessoPasta
{
    private Funcionario _funcionario;
    private AcessoPasta _acessoPasta;

    public AcessoPastaProxy(Funcionario funcionario)
    {
        _funcionario = funcionario;
        
    }

    public void AcessarPasta()
    {
        if (_funcionario.Cargo == CargoFuncionario.CEO)
        {
            _acessoPasta = new AcessoPasta();
            _acessoPasta.AcessarPasta();
        }
        else
        {
            Console.WriteLine("Acesso negado.");
        }
    }
}