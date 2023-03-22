using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        double Palio = 20000;
        double Corolla = 90000;
        double Porshe = 500000;
        int opcaoCarro;
        double valorGuardado;
        string nome;
        double valorCarro = 0;
        int meses;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite quanto dinheiro deseja guardar por mês: ");
        valorGuardado = double.Parse(Console.ReadLine());

        Console.Write("Qual opção de carro você deseja? Digite 1 para Palio, 2 para Corolla e 3 para Porshe: ");
        opcaoCarro = int.Parse(Console.ReadLine());

        if (opcaoCarro == 1)
        {
            valorCarro = Palio;
        }
        
        if (opcaoCarro == 2)
        {
            valorCarro = Corolla;
        }
       
        if (opcaoCarro == 3)
        {
            valorCarro = Porshe;
        }

       meses = (int)(valorCarro / valorGuardado);

        //Math.Ceiling -> Essa Função Arredonda números inteiros.

        Console.WriteLine(nome + ", você precisará guardar dinheiro por " + meses + " meses para comprar o carro escolhido.");
    }
}
