

internal class Program
{
    private static void Main(string[] args)
    {

        //
        /*
         * Ejercicio 1

        Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
        */
        Console.WriteLine("Hola! Favor escribir tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("Favor escribir tu edad");
        int edad = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Sabes programar? Si/No");
        string sabeProgramar = Console.ReadLine();
        string saludo = "Hola, " + nombre + ", tenes: " + edad + " años, " + sabeProgramar +" sabes programar";
        Console.WriteLine(saludo);

        /*
       Ejercicio 2

       Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

           Coche: puertas, ruedas, marca, ITV vigente
                        Clase coche, int puertas, int ruedas, string marca, string itv_vigente


           Mesa: peso, largo, material, color
                        Clase mesa, float peso, int largo, string o enum material, string color

       Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
       */

        /*Ejercicio 3

        Operadores Determina los operadores para verificar las siguientes condiciones:

            Un número es mayor o igual a 18 ->   >=
            Un char es ‘a’ -> if variable == 'a'
            Se cumplen dos conciones a la vez (ambas verdaderas) -> &&
            Se cumple una de dos condiciones a la vez (una true y otra false) -> ||
         */


    }
}

