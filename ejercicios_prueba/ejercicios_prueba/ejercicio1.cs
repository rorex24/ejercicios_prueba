namespace ejercicios_prueba
{
    public class ejercicio1
    {
        public static void Main()
        {

            Console.WriteLine("Cuantas cabinas hay");
            int total = int.Parse(Console.ReadLine());
            Console.WriteLine("Cabinas de la Línea Roja de Mi Teleférico:");
            ContarCabinas(1, total);
        }

        // MÉTODO RECURSIVO: no devuelve nada (void), solo muestra
        static void ContarCabinas(int actual, int total)
        {
            if (actual > total) // CASO BASE: ya no quedan cabinas
            {
                Console.WriteLine("Todas las cabinas revisadas.");
                return;
            }

            Console.WriteLine("Cabina " + actual + " lista");

            ContarCabinas(actual + 1, total); // CASO RECURSIVO: avanza a la siguiente
        }




    }
}
