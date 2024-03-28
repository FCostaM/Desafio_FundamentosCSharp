namespace Exercicio5;
public class Exercicio5
{
    public static void Main()
    {
        /* Exercício 5:
         * 
         * Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
         * 
         * - A placa deve ter 7 caracteres alfanuméricos;
         * - Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
         * - Os quatro últimos caracteres são números; 
         * 
         * Ao final, o programa deve exibir Verdadeiro se a placa for válida e Falso caso contrário.
         */

        Console.WriteLine("Digite a placa do carro:");
        string? placa = Console.ReadLine();

        if (ValidaPlaca(placa))
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }

    public static bool ValidaPlaca(string placa)
    {
        //Valida se a placa informada tem 7 caracteres (valores nulos também entrerão nessa condição)
        if (placa.Length != 7)
        {
            return false;
        }
        else
        {
            //Valida se os três primeiros caracteres são letras
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placa[i]))
                {
                    return false;
                }
            }

            //Valida se ss quatro últimos caracteres são números
            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(placa[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}