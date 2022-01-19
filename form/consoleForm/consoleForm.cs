using System;

class program{
    static void Main()
    {
        const string PAIS = "Brasil";
        int numCasa, cep, phone, idade,ddd;
        string nome, rua, cidade, uf, bairro,nasc;
        Console.WriteLine("Insira suas informações para Cadastro\n\n");

        Console.WriteLine("Dados Pessoais:\n\n");
        Console.WriteLine("Nome: ");
        nome = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nascimento: ");
        nasc = Console.ReadLine();
        Console.WriteLine("DDD: ");
        ddd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Telefone: ");
        phone = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\nCadastro de Endereço:\n\n");
        Console.WriteLine("Rua: ");
        rua = Console.ReadLine();

        Console.WriteLine("Numero: ");
        numCasa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bairro: ");
        bairro = Console.ReadLine();

        Console.WriteLine("CEP [Não use pontuação]: ");
        cep = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Cidade: ");
        cidade = Console.ReadLine();

        Console.WriteLine("UF: ");
        uf = Console.ReadLine();

        Console.WriteLine("\n\nDados Pessoais Cadastrados:\n\n");
        Console.WriteLine("Nome: {0}\nIdade: {1}\nNascimento: {2}\nTelefone: ({3}) {4}\n\n",nome,idade,nasc,ddd,phone);
        Console.WriteLine("Endereço:\n\n");
        Console.WriteLine("Rua: {0}\nNumero: {1}\nCEP: {2}\nBairro: {3}\nCidade: {4}\nUF: {5}\nPaís: {6}", rua, numCasa, cep, bairro, cidade, uf,PAIS);

    }
}
