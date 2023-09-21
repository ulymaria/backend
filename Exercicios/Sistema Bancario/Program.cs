using SistemaBancario.Models;


class Program
{
  public static void Main()
        {
            Console.WriteLine("Bem-vindo ao Sistema Bnacário!");
            Console.WriteLine("Digite o nome do titular da conta:");
            string titularConta = Console.ReadLine();

            ContaCorrente conta = new ContaCorrente(titularConta, 0);
            string opcao = "";
           
           do
            {
               

               Console.WriteLine("Escolha uma opção:");
               Console.WriteLine("1- Consutar saldo");
               Console.WriteLine("2- Depositar");
               Console.WriteLine("3 Sacar");
               Console.WriteLine("4- Sair");
               opcao = Console.ReadLine(); 
               

               switch (opcao)
               {
                        case "1":
                            conta.ConsultarSaldo();
                            break;
                        case "2":
                            Console.Write("Digite o valor depositado: ");
                            decimal valorDeposito = decimal.Parse(Console.ReadLine());
                            conta.Depositar(valorDeposito);
                            break;
                        
                         case "3":
                            Console.Write("Digite o valor a ser sacado:");
                            decimal valorSaque = decimal.Parse(Console.ReadLine());
                            conta.Sacar(valorSaque);
                            break;

                        case "4":
                           Console.Write("teste");
                            break;
                        
                        default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
               }
    }while (opcao != "0");

    Console.WriteLine("Obrigada por usar o Sistema Bancário!");
        }
}