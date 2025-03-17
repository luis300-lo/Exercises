// See https://aka.ms/new-console-template for more information
using Multiply;



var answer = "";
var options = new List<string> { "s", "n" };

do
{


    int m = ConsoleExtension.GetInt("Ingrese el valor de m:");
    int n = ConsoleExtension.GetInt("Ingrese el valor de n:");
    int p = ConsoleExtension.GetInt("Ingrese el valor de p:");

    int[,] resultado = MultiplyMatrices(m, n, p);


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Quieres continuar? (s/n): ", options);
    } while (answer is null);

} while (answer.Equals("s", StringComparison.CurrentCultureIgnoreCase));

static int[,] MultiplyMatrices(int m, int n, int p)
{
    
    int[,] A = new int[m, n];
    int[,] B = new int[n, p];
    int[,] C = new int[m, p];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            A[i, j] = (i + 1) * j;
        }
    }

   
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < p; j++)
        {
            B[i, j] = (j + 1) * i;
        }
    }

   
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < p; j++)
        {
            C[i, j] = 0;
            for (int k = 0; k < n; k++)
            {
                C[i, j] += A[i, k] * B[k, j];
            }
        }
    }

   
    Console.WriteLine("\n*** A ***");
    PrintMatrix(A);

    Console.WriteLine("\n*** B ***");
    PrintMatrix(B);

    Console.WriteLine("\n*** C ***");
    PrintMatrix(C);

    return C;
}


static void PrintMatrix(int[,] matriz)
{
    int filas = matriz.GetLength(0);
    int columnas = matriz.GetLength(1);

    for (int i = 0; i < filas; i++)
    {
        for (int j = 0; j < columnas; j++)
        {
            Console.Write(matriz[i, j] + " ");
        }
        Console.WriteLine();
    }
}
