namespace Exercicio3;
public class Exercicio3
{
    public static void Main()
    {
        /* Exercício 3:
         * 
         * Crie um programa com 2 valores do tipo double já declarados que retorne:
         * 
         * - A soma entre esses dois números;
         * - A subtração entre os dois números;
         * - A multiplicação entre os dois números;
         * - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
         * - A média entre os dois números.
         * 
         * Você pode ir além e permitir que o usuário insira dois números aleatórios! 
         */

        Console.WriteLine("Valor 1:");
        double v1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Valor 2:");
        double v2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine($"\nSoma: {Soma(valor1: v1, valor2: v2)}");
        
        Console.WriteLine($"Substracao: {Substracao(valor1: v1, valor2: v2)}");
        
        Console.WriteLine($"Multiplicação: {Multiplicacao(valor1: v1, valor2: v2)}");

        if (v2 != 0)
        {
            Console.WriteLine($"Divisão: {Divisao(valor1: v1, valor2: v2)}");
        }
        else
        {
            Console.WriteLine($"Erro. Divisão por zero");
        }
                
        Console.WriteLine($"Media: {Media(valor1: v1, valor2: v2)}");
    }

    public static double Soma(double valor1, double valor2)
    {
        return valor1 + valor2;
    }

    public static double Substracao(double valor1, double valor2)
    {
        return valor1 - valor2;
    }

    public static double Multiplicacao(double valor1, double valor2)
    {
        return valor1 * valor2;
    }

    public static double Divisao(double valor1, double valor2)
    {
        if (valor1 != 0)
            return valor1 / valor2;
        else
            return 0;
    }

    public static double Media(double valor1, double valor2)
    {
        return Soma(valor1, valor2) / 2;
    }
}
