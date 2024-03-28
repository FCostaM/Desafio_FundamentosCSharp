namespace Exercicio1;
public class Exercicio1
{
    public static void Main()
    {
        /* Exercicio 1:
         * 
         * Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  
         * Olá, Welisson! Seja muito bem-vindo!
         */

        Console.WriteLine("Digite seu nome:");
        string? name = Console.ReadLine();

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }
}
