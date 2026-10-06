using Arreglos.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nArreglos");

        MiArreglo oMiArreglo = new MiArreglo(5);

        try
        {
            oMiArreglo.Agregar(10);
            oMiArreglo.Agregar(5);
            oMiArreglo.Agregar(-4);

           

            Console.WriteLine(oMiArreglo);
            Console.ReadKey();

            oMiArreglo.Insertar(200, 50);


        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(oMiArreglo);

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