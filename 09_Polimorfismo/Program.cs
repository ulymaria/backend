//Classe Pai que será herada - SuperClasse

class Animal
{
    //Sobrescrevendo o método EmitirSom
    public string cor(get; set; )
    public virtualvoid EmitirSom()
    {
        Console.WriteLine("Animal da cor {cor}  está miando!fazendo algum som");
    }
}

//Classes filha que herdará da classe Animal

class Cachorro : Animal
{

}
class Gato : Animal
{

}

class Program
{
    public static void Main()
    {
        Animal animalGenero = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        //meuCachorro.Ronronar(); //Não posso chamr este método pois não existe nessa classe
        Gato meuGato = new Gato();
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
        



    }
} 