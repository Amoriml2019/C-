using System;
using System.Runtime.CompilerServices;

namespace Banco
{

    public class Conta
    {
        
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }
        

        public Conta(TipoConta TipoConta, double Saldo, double Credito, string Nome)
        {
            this.TipoConta = TipoConta; 
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.Nome = Nome;
        }
        public bool Sacar(double valorSaque)
        {
        
        //Validação de saldo insuficiente
        if (this.Saldo - valorSaque < (this.Credito * - 1)){
            Console.WriteLine("Saldo Insuficiente!");
            return false;
        }

        this.Saldo -= valorSaque;

        // Alerta de Saldo insuficiente
        Console.WriteLine("Saldo atual da Conta de {0} é {1}", this.Nome, this.Saldo);    
        return true;
        }   
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

             Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Trasferir(double valorTrasferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTrasferencia)){
                contaDestino.Depositar(valorTrasferencia);
            }
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " ! ";
            retorno += "Nome " + this.Nome + " ! ";
            retorno += "Saldo " + this.Saldo + " ! ";
            retorno += "Crédito " + this.Credito;
            return retorno;  
        }
    }

}