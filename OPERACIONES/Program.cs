//Comparación de cadenas.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Comparación de cadenas.");
Console.ResetColor();

string str1 = "Hola";
string str2 = "Hola";


bool sonIguales = str1 == str2; // True
Console.WriteLine(sonIguales);

bool sonDistintos = str1 != str2; // False
Console.WriteLine(sonDistintos);


//Concatenación de cadenas.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nConcatenación de cadenas\n");
Console.ResetColor();

string nombre = "Alvaro";
string apellido = "Gomez";

string nombreCompleto = nombre + " " + apellido;

Console.WriteLine(nombreCompleto);

//Búsqueda de patrones.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nBúsqueda de patrones.\n");
Console.ResetColor();

string cadena = "Hola mundo!";

int indice = cadena.IndexOf("mundo");
if (indice != -1)
{
    Console.WriteLine("La palabra 'mundo' se encuentra en la posición {0}", indice);
}

bool contiene = cadena.Contains("Hola");
if (contiene)
{
    Console.WriteLine("La cadena contiene la palabra 'Hola'");
}

//Formateo de cadenas.

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nFormateo de cadenas.\n");
Console.ResetColor();

string nombre4 = "Ana";
int edad = 25;
double altura = 1.65;

string saludo = String.Format("Hola, {0}! Tienes {1} años y mides {2} metros.", nombre4, edad, altura);

string mensaje = $"Hola, {nombre4}! Tienes {edad} años y mides {altura:F2} metros.";

Console.WriteLine(saludo);
Console.WriteLine(mensaje);