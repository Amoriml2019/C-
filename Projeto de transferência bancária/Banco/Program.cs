using System;


namespace Banco
{
    class Program
    {
       static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Lucas Amorim");
            Console.WriteLine(minhaConta.ToString());
        }
    }
}