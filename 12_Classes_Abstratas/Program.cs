//Classe Pai que será herdada - SuperClasse
class Animal
{
    public string cor { get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");        
    }
}

//Classe filha que herdará da classe Animal
class Cachorro : Animal 
{
    //Sobrescrevendo O método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor} está latindo! Au au au");
    }
}
//Class Pai que será herdada  - SuperClasse
class Gato : Animal
{
    //Sobrescrevendo O método EmitirSom
    public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando! Miau miau");
    }

    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando!");
    }
}

class Program
{
    public static void Main()
    {
        /*
        //Não é permetido criar um objeto de uma classe abstrata
       //Só conseguimos criar de sua classe derívada
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
       */

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();

        //meuCachorro.Ronronar();  // Não posso chamar este método pois não existe nessa classe
        Gato meuGato = new Gato();
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}