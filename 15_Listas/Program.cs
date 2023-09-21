using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
        //Criando uma lista de números inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos à lista
        listaNumeros.Add(10); //posiçâo [0] 
        listaNumeros.Add(20); //posiçâo [1] 
        listaNumeros.Add(45); //posiçâo [2] 

        //Contando a quantidade de elementos em nossa lista
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(6); // posição [3]
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");

        Console.WriteLine("------------------------");

        //Criem uma nova lista de nomes e adicionem alguns nomes a ela
        //e exibem a quantidade de nomes que contém nessa lista 

        List<string> listaNomes = new List<string>();
        listaNomes.Add("Julia"); //posiçâo [0] 
        listaNomes.Add("Gabi"); //posiçâo [1] 
        listaNomes.Add("Ana"); //posiçâo [2] 
        listaNomes.Add("Maria"); //posiçâo [3] 
        listaNomes.Add("Grazi"); //posiçâo [4] 
        listaNomes.Add("Rafa"); //posiçâo [5] 
        listaNomes.Add("Vitoria"); //posiçâo [6] 

        Console.WriteLine($"Neste momento temos {listaNomes.Count} nomes");

        foreach (string item in listaNomes)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("------------------------");

        //Criando uma lista já atribuido valores
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        numeros.Add(10);

        //Iterando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        numeros.Remove(2); // Remove o elemento  buscando pelo conteudo
        numeros.RemoveAt(4); //Remove pela posição (índice)
        numeros.RemoveRange(2, 2); // Remove o elemento da posição 2 e os proximos 2

        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        //Criando uma nova lista com objetow da  Classe Aluno
        List<Aluno> ListaAlunos = new List<Aluno>();

        //Adicionando um novo aluno à ListaAluno
        Aluno novoAluno = new Aluno("Julia", 16);
        ListaAlunos.Add(novoAluno);

        ListaAlunos.Add(new Aluno("Gabi", 15));
        ListaAlunos.Add(new Aluno("Marcelo", 21));
        ListaAlunos.Add(new Aluno("Paula", 15));
        ListaAlunos.Add(new Aluno("Murilo", 21));
        ListaAlunos.Add(new Aluno("Sandra", 52));
        ListaAlunos.Add(new Aluno("Gerson", 53));
        ListaAlunos.Add(new Aluno("Felipe", 28));


        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno item in ListaAlunos)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");
        }

        // Criando uma nova lista, filtrandoe ordenando por nome
        //LINQ  utilizando sintaxe de consulta 
        var consulta = from aluno in ListaAlunos
                       where aluno.idade > 18 // where = onde 
                       orderby aluno.nome // orderby = ordernar essa lista por ordem alfabetica
                       select aluno;     // select = retorno da variavel
        Console.WriteLine("Lista de alunos maiores de 18 anos");
        foreach (var item in consulta)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");

        }
        //LINQ utilizando Sintaxe de método
        var metodo = ListaAlunos
                              .Where(aluno => aluno.idade < 18)
                              .OrderBy(aluno => aluno.nome);
        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo)
        {
            Console.WriteLine($"Nome aluno: {item.nome} idade {item.idade}");

        }

    }
}