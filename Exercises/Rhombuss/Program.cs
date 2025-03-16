// See https://aka.ms/new-console-template for more information


using Multiply;

var answer = "";
var options = new List<string> { "s", "n" };

do
{


    int n = ConsoleExtension.GetInt("Ingrese el tamaño del rombo (impar): ");

    if (n % 2 == 0)
    {
        Console.WriteLine("El tamaño debe ser un número impar.");
        continue;
    }


    DibujarRombo(n);



    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Quieres continuar? (s/n): ", options);
    } while (answer is null);

} while (answer.Equals("s", StringComparison.CurrentCultureIgnoreCase));

static void DibujarRombo(int n)
{
    char[,] rombo = new char[n, n];

    
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            rombo[i, j] = ' ';
        }
    }

    int m = n / 2;

    
    for (int i = 0; i <= m; i++)
    {
        rombo[i, m - i] = '#'; 
        rombo[i, m + i] = '#'; 
        rombo[n - 1 - i, m - i] = '#'; 
        rombo[n - 1 - i, m + i] = '#'; 
    }

    
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(rombo[i, j]);
        }
        Console.WriteLine();
    }
}




