namespace DiamanteDeX.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // menu
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.Write("De quantos quilates será o seu diamante? ");
            Console.WriteLine("\n*Digite um número inteiro ímpar*");
            Console.WriteLine("--------------------------------------");
            Console.SetCursorPosition(41, 1);

            string num = Console.ReadLine()!;

            Console.Clear();

            int numeroValido;

            if (int.TryParse(num, out numeroValido))
            {
                if (numeroValido % 2 != 0)
                {
                    Console.WriteLine("Criando seu lindo diamante");
                    Console.SetCursorPosition(26, 0);

                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(00);
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

            //diamante superior
            for (int i = 1; i <= numeroValido; i+=2)
            {

                for (int y = 1; y <= numeroValido; y+=2)
                {
                    Console.Write(" ");

                    if (y == i)
                    {
                        Console.Write(" ");
                    }
                }

                for (int y = 1; y <= i; y++)
                {
                    if (i % 2 != 0)
                        Console.Write("x");
                }

                if (i % 2 != 0)
                    Console.WriteLine();
            }

            //diamante inferior
            for (int i = 1; i <= numeroValido; i -= 2)
            {

                for (int y = 1; y >= numeroValido; y--)
                {
                    Console.Write(" ");

                    if (y == i)
                    {
                        Console.Write(" ");
                    }
                }

                for (int y = numeroValido; y >= i; y--)
                {
                    if (i % 2 != 0)
                        Console.Write("x");
                }

                if (i % 2 != 0)
                    Console.WriteLine();
            }

            Console.WriteLine("Aqui está seu diamante ;D");

            //opcaoSair
            Console.Write("Deseja continuar? [S/N]");
            string continuar = Console.ReadLine()!.ToUpper();
            Console.Clear();

            if (continuar != "S")
                break;
        }
    }

    static void Menu()
    {


    }
}
