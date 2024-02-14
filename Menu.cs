public class Menu
{
    public BancoDeDados BD = new BancoDeDados();
    public CalculadoraSalario CS = new CalculadoraSalario();
    public EmailService email = new EmailService();

    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("1: Cadastrar Funcionario\n2: Calcular Salario\n3: Enviar Email\n4: Mostrar Funcionario\n5: Sair");
        Console.Write("Digite a opcao :");
        string opcao = Console.ReadLine()!;
        int opcao1 = int.Parse(opcao);

        switch (opcao1)
        {
            case 1:
                Console.WriteLine("Digite o funcionario que deseja cadastrar");
                string func = Console.ReadLine();
                BD.SalvarFuncionario(func);
                break;

            case 2:
                Console.Write("Digite  quantas horas o Funcionario trabalhou: ");
                decimal horasTrabalhadas = decimal.Parse(Console.ReadLine()!);
                Console.WriteLine("Digite o valor da hora trabalhada :");
                decimal valorHora = decimal.Parse(Console.ReadLine());
                CS.CalcularSalario(horasTrabalhadas, valorHora);
                //Console.WriteLine($"O valor do Salario do Funcionario  e {horasTrabalhadas * valorHora}");
                break;

            case 3:
                Console.WriteLine("Digite o funcionario que deseja enviar email");
                string envioEmail = Console.ReadLine();
                Console.WriteLine("Digite o novo salario :");
                decimal salario = decimal.Parse(Console.ReadLine());
                email.EnviarEmailAumentoSalario(, salario);
                break;

            case 4:
                BD.ObterTodosFuncionarios();
                break;

            case 5:
                Console.WriteLine("Good Bye!");
                break;

            default:
                Console.WriteLine("Opcao Invalida");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirMenu();
                break;
        }
    }

    private void CadastrarFuncionario()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de Funcionario");
        Console.Write("Registre um Funcionario: ");
        string nomeDoFuncionario = Console.ReadLine()!;
        BD.SalvarFuncionario(nomeDoFuncionario);
        Console.WriteLine($"O Funcionario {nomeDoFuncionario} Registrado com sucesso!\n");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}