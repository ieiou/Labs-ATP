namespace Lab3;

class Program
{
    static void Main()
    {
        // Declaração de variáveis
        double a, b, c, delta, x1, x2, x;
        Console.WriteLine("Digite os coeficientes a, b e c da equação de segundo grau:");

        // Entrada de dados
        Console.Write("Coeficiente a: ");
        a = double.Parse(Console.ReadLine()!);
        Console.Write("Coeficiente b: ");
        b = double.Parse(Console.ReadLine()!);
        Console.Write("Coeficiente c: ");
        c = double.Parse(Console.ReadLine()!);
        // Processamento
        delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta > 0)
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"As raízes são: \nx1 = {x1:F2}\nx2 = {x2:F2}");
        }
        else if (delta == 0)
        {
            x = -b / (2 * a);
            Console.WriteLine($"A única raiz é: x = {x:F2}");
        }
        else
        {
            Console.WriteLine("As raízes são complexas:");
        }
        /* Professor eu não consegui fazer pra achar valores imaginários, mas consegui para os casos de delta positivo, vou deixar alguns exemplos de valores para você testar o código.*/
        /* a = 1, b = -5, c = 6
           a = 2, b = -7, c = 3
           a = 3, b = -10, c = 7*/
    }
}
