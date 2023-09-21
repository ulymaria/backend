// Exercicio Calculado a média de 3 notas de um aluno 

//Receber o nome do aluno e armenizaqr em uma variavel do tipo string
Console.WriteLine("Informe o nome do aluno:");
string nome = Console.ReadLine();
// Receber a nota 1, converter e armenizarem uma variavel int
Console.WriteLine("Digite a nota 1:");
int nota1 = int.Parse(Console.ReadLine());

// Receber a nota 2, converter e amenizar em uma variavel int 
Console.WriteLine("Digite a nota 2:");
int nota2 = int.Parse(Console.ReadLine());


// Receber a nota 3, converter e amenizar em uma variavel int 
Console.WriteLine("Digite a nota 3:");
int nota3 = int.Parse(Console.ReadLine());

// Declarar uma variavel do tipo int, para receber a média das notas
// (nota1 + nota2 + nota3) / 3 

int media = ( nota1 + nota2 + nota3 ) / 3;
//Exebir uma mensagem se o aluno está aprovado considerando nota acima de 7
if (media >=7){
    Console.WriteLine($"{nome} Parábens! você foi aprovado(a).");
}else {
 Console.WriteLine($"{nome} Parábens você foi reprovado(a).");

}
