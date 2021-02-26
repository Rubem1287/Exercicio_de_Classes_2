using System;
using System.Globalization;
namespace Exercicio_de_Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;

            Funcionario funcionario = new Funcionario();
            Funcionario funcionario1 = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionário : ");
            Console.Write("Nome : ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Salário : ");
            funcionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo Funcionário : ");
            Console.Write("Nome : ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário : ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = (funcionario.salario + funcionario1.salario) / 2.0;

            Console.WriteLine("Salário Médio = " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
