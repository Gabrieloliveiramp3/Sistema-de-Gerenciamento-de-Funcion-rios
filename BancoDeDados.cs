public class BancoDeDados
{
    private List<Funcionario> funcionarios = new List<Funcionario>();

    public void SalvarFuncionario( Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
        Console.WriteLine($"Funcionário {funcionario.Nome} salvo no banco de dados.");
    }

    public List<Funcionario> ObterTodosFuncionarios()
    {
        return funcionarios;
    }

    internal void SalvarFuncionario(string v) => throw new NotImplementedException();
}