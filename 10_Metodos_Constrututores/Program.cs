using Models;

public class Program
{
    public static void Main()
    {
        //Criar um objeto de classe Pessoa
        /*
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Julia";
        pesssoa1.idade = 16;

        //Alternativa de um objeto instanciado sem construtor
        pessoa pessoa1 = new Pessoa {
            nome = "Gabriella" ,
            idade = 16
        }
       */

        //Instanciando um objeto com método construtor
        Pessoa pessoa1 = new Pessoa("Julia", 16);

        //Chamando o método Cantar da classe Pessoa
        pessoa1.Cantar();

        Pessoa pessoa2 = new Pessoa("Ana Clara", 16);
        pessoa2.Cantar();

        Pessoa pessoa3 = new Pessoa("Rafaela", 16);
        pessoa3.Cantar();
    }
}
