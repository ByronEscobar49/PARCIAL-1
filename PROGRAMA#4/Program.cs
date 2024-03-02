// Generar un número secreto aleatorio
Random random = new Random();
int numeroSecreto = random.Next(1, 101);

// Bucle para adivinar el número
while (true)
{
    // Pedir un número al usuario
    Console.WriteLine("Introduzca un número del 1 al 100:");
    int numeroUsuario = int.Parse(Console.ReadLine());

    // Si el número secreto es mayor
    if (numeroUsuario < numeroSecreto)
    {
        Console.WriteLine("El número secreto es mayor.");
    }
    // Si el número secreto es menor
    else if (numeroUsuario > numeroSecreto)
    {
        Console.WriteLine("El número secreto es menor.");
    }
    // Si el número secreto es igual
    else
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número secreto.");
        break;
    }
}

