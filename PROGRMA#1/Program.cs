// Pedir un número entero positivo al usuario
Console.WriteLine("Introduzca un número entero positivo:");
int numero = int.Parse(Console.ReadLine());

// Mostrar el menú
while (true)
{
    Console.WriteLine("\nElija una opción:");
    Console.WriteLine("1. Calcular el factorial de un número");
    Console.WriteLine("2. Calcular la raíz cuadrada del número");
    Console.WriteLine("3. Salir del programa");

    // Leer la opción del usuario
    int opcion = int.Parse(Console.ReadLine());

    // Seleccionar la opción
    switch (opcion)
    {
        case 1:
            // Calcular el factorial
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("El factorial de {0} es: {1}", numero, factorial);
            break;
        case 2:
            // Calcular la raíz cuadrada
            double raizCuadrada = Math.Sqrt(numero);
            Console.WriteLine("La raíz cuadrada de {0} es: {1}", numero, raizCuadrada);
            break;
        case 3:
            // Salir del programa
            Console.WriteLine("Saliendo del programa...");
            return;
        default:
            // Opción no válida
            Console.WriteLine("Opción no válida. Introduzca un número del 1 al 3.");
            break;

    }
}

