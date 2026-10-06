using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");

        MiArreglo oMiArreglo = new MiArreglo(5);

        try
        {

            for (int i = 0; i < oMiArreglo.N; i++)
            {
                oMiArreglo.Agregar(i * 3);
            }
       

        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("oMiArreglo");

        //oMiArreglo.Llenar(5, 20);

        //Console.WriteLine("\nArreglo desordenado");
        //Console.WriteLine(oMiArreglo);

        //Console.WriteLine("\nArreglo ordenado ascendente");
        //oMiArreglo.Ordenar();
        //Console.WriteLine(oMiArreglo);

        //Console.WriteLine("\nArreglo ordenado desendente");
        //oMiArreglo.Ordenar(false);
        //Console.WriteLine(oMiArreglo);

        Console.ReadKey();
    }
}