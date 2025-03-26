namespace DiamanteDeX.ConsoleApp;

public class Diamante
{
    public static int Menu()
    {
        int numeroValido;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.Write("De quantos quilates será o seu diamante? ");
            Console.WriteLine("\n*Digite um número inteiro ímpar*");
            Console.WriteLine("--------------------------------------");
            Console.SetCursorPosition(41, 1);

            string num = Console.ReadLine()!;

            Console.Clear();



            if (int.TryParse(num, out numeroValido))
            {
                if (numeroValido % 2 != 0)
                {
                    Console.WriteLine("Criando seu lindo diamante");
                    Console.SetCursorPosition(26, 0);

                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(500);
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Digite apenas números ímpares");
                    Console.WriteLine("-----------------------------");
                    Console.ReadLine();
                    continue;
                }
            }
            else
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Digite apenas números");
                Console.WriteLine("---------------------");
                Console.ReadLine();
                continue;
            }

            return numeroValido;
        }
    }

    public static void CriacaoDeDiamantes(int numeroValido)
    {
        int quantidadeDeLinhas = (numeroValido - 1) / 2;
        int quantidadeDeEspacos = (numeroValido - 1) / 2;
        int quantidadeDeX = 1;

        for (int x = 0; x < quantidadeDeLinhas; x++)
        {
            for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                Console.Write(" ");

            for (int i = 0; i < quantidadeDeX; i++)
                Console.Write("x");

            quantidadeDeX += 2;
            quantidadeDeEspacos--;

            Console.WriteLine();
        }


        //meio

        for (int y = 1; y <= numeroValido; y++)
            Console.Write("x");

        Console.WriteLine();

        //inferior

        quantidadeDeX -= 2;
        quantidadeDeEspacos = 1;

        for (int x = 0; x < quantidadeDeLinhas; x++)
        {
            for (int espacos = 0; espacos < quantidadeDeEspacos; espacos++)
                Console.Write(" ");

            for (int i = 1; i <= quantidadeDeX; i++)
                Console.Write("x");

            quantidadeDeX -= 2;
            quantidadeDeEspacos++;

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Aqui está seu diamante ;D");
        Console.ReadLine();
    }

}
