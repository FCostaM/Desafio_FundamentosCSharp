namespace Exercicio2;
public class Exercicio2
{
    public static void Main()
    {
        /* Exercicio 2:
         * 
         * Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
         */

        Console.WriteLine("Digite seu nome:");
        string? firstName = Console.ReadLine();

        Console.WriteLine("\nDigite seu sobrenome:");
        string? lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;

        Console.WriteLine($"\nNome completo: {fullName}");

    }
}
