namespace lab2;

class Program
{
    static void Main(string[] args)
    {
        //Declaração de varáveis
        int idade = 18;
        string nome = "Yalle Ramos Ferrari de Magalhães", esporte="Vôlei", comida ="Lasanha", curso="Análise e Desenvolvimento de Sistemas";
        double altura = 1.83, salario =30000.00;

        Console.Write("\"Meu nome");
        Console.Write(" é:\t{0}.\"\n",nome);
        Console.WriteLine($"Eu tenho {idade:D2} anos.");
        Console.Write("Minha altura é: {0,-15} | Eu jogo {1:F2,10}",altura, esporte);
        Console.WriteLine($"\nMinha comida favorita é {comida}.");
        Console.WriteLine("Para mim o salário ideal é {0:C}.",salario);
        Console.Write("Atualmente estou cursando "+ curso +" na PUC Minas.");
    }
}
