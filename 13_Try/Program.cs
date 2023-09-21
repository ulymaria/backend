public class Program
{
    public static void Main()
    {
        // O try serve para tratar um erro e não parar a execução do programa 
        //Se ocorrer qualquer erro dentro  do bloco try, o sistema interrompe
        //a execução do bloco e vai para o catch
        try
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº {numero}");
        }
        catch (OverFlowException)
        {
            Console.WriteLine("O número digitado é maior que o limite aceito");
        }
        //Tratando exceção de erro específica de formato
        catch (FormatExeception)
        {
            Console.WriteLine("Digite um número inteiro");
        }
        //catch é o tratamento do erro, normalmente colocamos as mensgens de acordo
        //com o tempo do erro, para melhor compreensão do usuário
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro: {erro.Message} {erro}");
        }
        finally
        {
            Console.WriteLine($" No bloco finally o programa entra independentimente de exerceção");
        }
    }
}