using System;

class atividade { 
    static void Main()
    {
        const string NAME = "SantLuzz";
        int v1, v2, soma,sub, op;


        Console.WriteLine("Soma de Inteiros - {0}\n", NAME);
        Console.WriteLine("Deseja Realizar 1. Soma ou 2. Subtração ou 3.Sair?\n");
        op=Convert.ToInt32(Console.ReadLine());
        if(op == 1)
        {
            Console.WriteLine("Operação de Adição\n\n");
            Console.WriteLine("Digite um valor inteiro: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um valor inteiro");
            v2 = Convert.ToInt32(Console.ReadLine());
            soma = v1 + v2;
            Console.WriteLine("Resulta: {0} - {1} = {2}", v1, v2,soma);
        }else if(op == 2)
        {
            Console.WriteLine("Operação de Subtração\n\n");
            Console.WriteLine("Digite um numero inteiro: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero inteiro: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            sub = v1 - v2;
            Console.WriteLine("Resultado: {0} - {1} = {2}", v1, v2, sub);
        }else
        {
            Console.WriteLine("Obrigado!!!");
        }
    }
}

