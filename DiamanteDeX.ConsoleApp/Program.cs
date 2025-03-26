namespace DiamanteDeX.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // menu
            int tamanhoDoDiamante = Diamante.Menu();

            Diamante.CriacaoDeDiamantes(tamanhoDoDiamante);

            Console.Write("Deseja continuar? [S/N]");
            string continuar = Console.ReadLine()!.ToUpper();
            Console.Clear();

            if (continuar != "S")
                break;
        }
    }
}


