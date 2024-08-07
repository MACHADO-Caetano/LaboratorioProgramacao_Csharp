﻿using System.Net;

Empresa empresa = new Empresa();
static int Menu()
{

    System.Console.WriteLine("1 - Cadastrar funcionário de tempo integral");
    System.Console.WriteLine("2 - Cadastrar funcionário de meio período");
    System.Console.WriteLine("3 - Remover funcionário");
    System.Console.WriteLine("4 - Exibir informações de todos os funcionários");
    System.Console.WriteLine("5 - Adicionar projeto(s) a um funcionário");
    System.Console.WriteLine("0 - Sair do programa");
    int opcao = Convert.ToInt32(Console.ReadLine());
    return opcao;
}
bool again = true;
while (again == true)
{
    switch (Menu())
    {
        case 1:
            System.Console.WriteLine("Informe o nome completo do funcionário:");
            string? nome = Console.ReadLine();
            System.Console.WriteLine("Informe a matrícula do funcionário:");
            int matricula = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Informe o salário mensal do funcionário:");
            double salario_mensal = Convert.ToDouble(Console.ReadLine());
            FuncionarioTempoIntegral funcionario = new FuncionarioTempoIntegral(nome, matricula, salario_mensal);
            empresa.Adicionar(funcionario);
            break;

        case 2:
            System.Console.WriteLine("Informe o nome completo do funcionário:");
            nome = Console.ReadLine();
            System.Console.WriteLine("Informe a matrícula do funcionário:");
            matricula = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Informe o salário por hora do funcionário:");
            double salario_hora = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Informe a quantidade de horas trabalhadas pelo funcionário:");
            float horas_trabalhadas = Convert.ToSingle(Console.ReadLine());
            FuncionarioMeioPeriodo funcionario2 = new FuncionarioMeioPeriodo(nome, matricula, salario_hora, horas_trabalhadas);
            empresa.Adicionar(funcionario2);
            break;

        case 3:
            System.Console.WriteLine("Informe a matrícula do funcionário que deseja remover:");
            matricula = Convert.ToInt32(Console.ReadLine());
            empresa.RemoverFuncionario(matricula);
            break;

        case 4:
            empresa.ExibirFuncionarios();
            break;

        case 5:
            empresa.ExibirFuncionarios();
            System.Console.WriteLine("Informe a matrícula do funcionário que deseja adicionar projeto(s):");
            matricula = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < empresa.Funcionarios.Count; i++)
            {
                System.Console.WriteLine("Informe o nome do projeto:");
                string projeto = Console.ReadLine();
                empresa.Funcionarios[i].AdicionarProjeto(matricula, projeto);
                System.Console.WriteLine("Projeto adicionado!");
            }
            break;

        case 0:
            again = false;
            break;

        default:
            break;
    }
}

