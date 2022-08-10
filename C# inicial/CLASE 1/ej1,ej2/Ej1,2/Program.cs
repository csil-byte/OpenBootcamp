internal class Program
{
    private static void Main(string[] args)
    {

        /*
         * Ejercicio 1
         *    Escribe un programa que reciba tu nombre y lo escriba por consola.
         */
        Console.WriteLine("Hola! Favor escribir tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("Hola, " + nombre);


        /*
         *Ejercicio 2
         *    Escribe un programa que tome la hora y la escriba por pantalla. 
         */

        string hora = DateTime.Now.ToString("h:mm tt");
        Console.WriteLine("Son las {0}", hora);

    }
}