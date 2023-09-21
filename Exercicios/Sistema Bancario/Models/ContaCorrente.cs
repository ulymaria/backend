namespace SistemaBancario.Models
{
    public class ContaCorrente
    {
        public string titular;
        private decimal saldo;

        public ContaCorrente(string titular, decimal saldo)
        {
            this.titular = titular;
            this.saldo = 0.0M;
        }
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo disponivel na conta de {titular}: R${saldo}");

        }
        public void Depositar(decimal valor)
        {
            
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de R${valor} realizado com sucesso.");
                ConsultarSaldo();
            }
                else{
                    Console.WriteLine("O valor do depósito deve ser maior que zero.");
                }
        }
        public void Sacar(decimal valor)
        {
            if (valor > 0)
            {
                if (valor <= saldo)
                {
                    saldo -= valor;
                    Console.WriteLine($"Saque de R${valor} realizado com sucesso.");
                    ConsultarSaldo();
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente para realizar o saque.");
                }

            }
        }
            
    }
}