 class ex005 {
    public static void Main()
    {
        //Chamar Método
        ListaDoChurrasco();
    }

 public static void ListaDoChurrasco (){

    //Declarar o vetor com 6 posições tipo string 
        string[] ListaProdutos = new string[6];
    //Receber os produtos que precisam ser comprados
     ListaProdutos[0] = "Carne 3kg";
     for (int i = 0; i < ListaProdutos.Length; i++)
     {
        Console.WriteLine("Informe o produto:");
        string produto = Console.ReadLine();
        ListaProdutos[i] = produto;
     }
    //  Ordenar vetor
    Array.Sort(ListaProdutos);

    //"Para cada" item na lista exebir no console
        foreach (string item in ListaProdutos)
        {
            Console.WriteLine($"Item{item}");
        }

    }

 


public static void SonhosDeConsumo(){
    string[] ListaSonhos = new string[3];
    int[] ValorSonhos = new int[3];
    int soma = 0;

    for (int i = 0; i < ListaSonhos.Lenght; i++)
{
    Console.WriteLine("Informe o valor;");
    int valor = Console.ReadLine();
    valorSonhos[i] = valor;
    
}
    foreach (int item in ListaSonhos)
        som += item;
         Console.WriteLine($"Seus sonhos custarão R$ {soma}");


   }
}

