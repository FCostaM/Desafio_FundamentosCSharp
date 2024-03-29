namespace Exercicio4;
public class Exercicio4
{
    public static void Main()
    {
        /* Exercício 4:
         * 
         * Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
         */

        Console.WriteLine("Digite uma palavra ou frase:");
        string input = Console.ReadLine();

        //Opção de resposta 1:

        Console.WriteLine($"Quantidade de caracteres: { input.Replace(" ", "").Count()}");

        //Opção de resposta 2:

        int count = 0;

        for ( int i = 0; i < input.Length; i++ )
        {
            if (char.IsLetter(input[0]))
            {
                count++;
            }
        }

        Console.WriteLine($"Quantidade de caracteres: {count}");
    }
}
