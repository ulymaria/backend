public class Program
{
    public static void Main()
    {


        var pessoa1 = new
        {
            nome = "Graziely",
            idade = 20
        };

        var pessoa2 = new
        {
            nome = "Sandra",
            idade = 52
        };

        Console.WriteLine($"A Pessoa 1 se chama {pessoa1.nome} e a Pessoa 2 {pessoa2.nome}");


        Console.WriteLine("Digite o modelo do carro");
        string modeloDigitado = Console.ReadLine();
         Console.WriteLine("Digite a marca do carro");
        string marcaDigitado = Console.ReadLine();
         Console.WriteLine("Digite o ano do carro");
        string anoDigitado = Console.ReadLine();
        
        
        var carro1 = new
        {
            modelo = modeloDigitado,
            marca = marcaDigitado,
            ano = anoDigitado
          
    };
    Console.WriteLine($"O meu Carro é {carro1.modelo}, marca {carro1.marca} e foi fabricado em {carro1.ano}.");
 

    }

}