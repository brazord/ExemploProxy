var funcionario = new Funcionario();
funcionario.Nome = "Alex";
funcionario.Cargo = CargoFuncionario.CEO;

var proxy = new AcessoPastaProxy(funcionario);
proxy.AcessarPasta();