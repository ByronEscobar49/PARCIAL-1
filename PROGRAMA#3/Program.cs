// Pedir un número al usuario
Console.WriteLine("Introduzca un número:");
int numero3 = int.Parse(Console.ReadLine());

// Imprimir la tabla de multiplicar
Console.WriteLine("Tabla de multiplicar del {0}", numero3);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", numero3, i, numero3 * i);
}
Console.ReadLine();
