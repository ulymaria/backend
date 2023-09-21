
class Program 
{
          public static void Main()
  {
     for(int i = 1; i <= 10; i++)
     {
        Console.WriteLine($"Estou passando pela {i}ª vez no bloco");

     }
    // Criando uma tabuada utilizando o for
    int num = 5;
    for (int cont = 1; cont <=10; cont++)
     {
      //num é a variável que estou gerando a tabuada 
     // cont é a variável contadora atá 10
     Console.WriteLine($"{num} x {cont} = {cont * num}"); 
     }

      // Declarando um vetor do tipo inteiro com 4 espaços
      int[] notas = new int[4];
      // Declarar um vetor atribuido valores
      string[] meses = {"Jan", "Fev"};

      int[] alunos = new int[6] ;
      alunos[4] = 3;
      alunos[5] = 11;
      alunos[3] = 7;
      alunos[0] = 20;
      alunos[2] = 8;
      alunos[1] = 12;

      int soma = 0; //Santos
      int maior = 0; //Bianca
      int menor = 10000; //Ana
      //For para ler todos os valores dos vetores e escreve-los
      for (int i = 0; i < alunos.Lenght; i++){
        Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
      }

      //Foreach / para cada elemento do vetor alunos para fazer a tarefa de somar e descobrir o maior e menor
      Foreach (int douglas in alunos){
        soma = soma + douglas;
        if(douglas > maior){
            maior = douglas;
        }
        if(douglas < menor){
            menor = douglas;
        }

     }
     Console.WriteLine($"Soms é {soma} o maior é {maior}  e o menor é {menor}");
     Array (int i = 0; i < alunos.Lenght; i++){
        Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
     }
  }

}