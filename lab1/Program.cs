namespace lab1;

class Atv1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab 01 - Atividade 1");
        Console.WriteLine("Yalle Ramos Ferrari de Magalhães\n\n");
    
        Console.WriteLine("Lab 01 - Atividade 2.1");
        //Declaração de variáveis
        int num1 = 0, num2 = 0, soma = 0;
        // Entrada de dados
        Console.WriteLine("Digite o primeiro número inteiro: ");
        num1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo número inteiro: ");
        num2 = int.Parse(Console.ReadLine()!);
        // Processamento
        soma = num1 + num2 ;
        // Saída
        Console.WriteLine("Resultado: {0} + {1} = {2}",num1 , num2 , soma);

        Console.WriteLine("\n\nLab 01 - Atividade 2.2");
        //Declaração de variáveis
        double media, n1 = 0.0, n2 = 0.0, quadrado1, quadrado2, sub = 0.0;
        // Entrada de dados
        Console.WriteLine("Digite o primeiro número: ");
        n1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o segundo número: ");
        n2 = double.Parse(Console.ReadLine()!);
        // Processamento
        sub = num1 - num2;
        quadrado1 = n1 * n1;
        quadrado2 = n2 * n2; 
        media = (n1 + n2)/2;
        // Saída
        Console.WriteLine("Resultado: {0} - {1} = {2}",n1 , n2 , sub);
        Console.WriteLine("O quadrado de {0} = {1}",n1 , quadrado1);
        Console.WriteLine("O quadrado de {0} = {1}",n2 , quadrado2);
        Console.WriteLine("A média de {0} e {1} = {2}",n1 , n2 , media);
    }
}
