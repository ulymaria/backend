using Sesi.Model;

class Progam
{
    public static void Main()
    {
        //criando uma variavel aluno1 e instanciando da classe Aluno
       var aluno1 = new Aluno();
       aluno1.nome = "Julia";
       aluno1.idade = 16;
       aluno1.turma = "2º EM";


       //Chamando o método da classe Aluno
       aluno1.Apresentar();

      Aluno aluno2 = new Aluno();
      aluno2.nome = "Julia";
      aluno2.idade = 16;
      aluno2.turma = "2º EM";



      aluno2.Apresentar();{
      aluno2.AdicionarFaltas(10);
      aluno2.Apresentar();

        //Chamar método ResumoFaltas
        aluno2.ResumoFaltas();
        
      }

    }
}