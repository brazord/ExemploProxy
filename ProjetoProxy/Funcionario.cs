public class Funcionario
{
    public string Nome { get; set; }
    public CargoFuncionario Cargo { get; set; }
}

public enum CargoFuncionario
{
    CEO,
    Gerente,
    Programador,
}