using System;

public class EmailService
{
    public void EnviarEmailAumentoSalario(Funcionario funcionario, decimal novoSalario)
    {
        Console.WriteLine($"E-mail enviado para {funcionario.Nome}: Seu novo salário é {novoSalario:C}");
    }
}