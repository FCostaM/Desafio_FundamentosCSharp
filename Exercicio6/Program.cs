namespace Exercicio6
{
    public class Exercicio6
    {
        public static void Main()
        {
            /* Exercício 6:
             * 
             * Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
             * 
             * - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
             * - Apenas a data no formato "01/03/2024".
             * - Apenas a hora no formato de 24 horas.
             * - A data com o mês por extenso.
             */

            DateTime now = DateTime.Now;

            Console.WriteLine("Escolha o formato de data que deseja exibir:\n");
            Console.WriteLine("1 - Formato completo");
            Console.WriteLine("2 - Apenas a data no formato '01/03/2024'");
            Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
            Console.WriteLine("4 - A data com o mês por extenso");

            Console.WriteLine("\nOpção:");

            int option;

            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Formato completo: {now}");
                        break;
                    case 2:
                        Console.WriteLine($"Apenas a data: {now.ToString("dd/MM/yyyy")}");
                        break;
                    case 3:
                        Console.WriteLine($"Apenas a hora: {now.ToString("HH:mm:ss")}");
                        break;
                    case 4:
                        Console.WriteLine($"Data com o mês por extenso: {now.ToString("dd/MMMMM/yyyy")}");
                        break;
                    default:
                        Console.WriteLine("Escolha inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }
    }
}
