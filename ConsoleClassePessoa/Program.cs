using System;

namespace ConsoleClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o Nome: ");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite sua Idade: ");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu Rg: ");
            pessoa.rg = Console.ReadLine();

            Console.WriteLine("Digite seu Cpf: ");
            pessoa.cpf = Console.ReadLine();    

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("Rg: {0}", pessoa.rg);
            Console.WriteLine("Cpf: {0}", pessoa.cpf);

            Pessoa pessoaFlavia = new Pessoa();
            pessoa.nome = "Flávia Meireles do Nascimento";
            pessoa.idade = 47;
            pessoa.rg = "7.777-777";
            pessoa.cpf = "777.777.777-77";

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("Rg: {0}", pessoa.rg);
            Console.WriteLine("Cpf: {0}", pessoa.cpf);

            pessoa.Acenar(pessoaFlavia);
            pessoa.PerguntaIdade(pessoaFlavia);
        }

    }
}
