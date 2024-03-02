string nombre = "Byron Escobar";
int edad = 24;
Console.WriteLine("Cadena Principal\t" + nombre);
Console.ReadLine();

// Obtener la longitud de la cadena
int longitud = nombre.Length; // 13
Console.WriteLine("longuitud de cadena usando length\t" + longitud);
Console.ReadLine();

// Convertir la cadena a mayúsculas
string nombremayus = nombre.ToUpper(); // BYRON ESCOBAR 
Console.WriteLine("usando ToUpper\t"+nombremayus);
Console.ReadLine();

// Convertir la cadena a minusculas 
string nombremini = nombre.ToLower(); // byron escobar
Console.WriteLine("usando ToLower\t" + nombremini);
Console.ReadLine();

//Busca la primera Ocurrencia de un caaracter o cadena
int nombreindex = nombre.IndexOf('e');
Console.WriteLine("usando IndexOf\t" + nombreindex);
Console.ReadLine();

//Busca la última Ocurrencia de un caaracter o cadena
int nombrelast= nombre.LastIndexOf('b');
Console.WriteLine("usando LastIndexOf\t" + nombrelast);
Console.ReadLine();

// Obtener una subcadena de la cadena
string apellido = nombre.Substring(5); // "escobar"
Console.WriteLine("usando Substring\t" + apellido);
Console.ReadLine();

// remplaza una subcadena por otra
string nuevacadena = nombre.Replace("byron", "escobar"); // "byron por escobar"
Console.WriteLine("usando Replace\t" + nuevacadena);
Console.ReadLine();

// Eliminar los espacios en blanco al principio y al final de la cadena
string nombreTrim = nombre.Trim(); // "byron escobar"
Console.WriteLine("usando Trim\t" + nombreTrim);
Console.ReadLine();

// indicar si una cadena comienza con otra
bool start = nombre.StartsWith(nombre); // ""
Console.WriteLine("usando StartsWith\t" + start);
Console.ReadLine();

// indicar si una cadena termina con otra
bool end = nombre.EndsWith(nombre);
Console.WriteLine("usando EndsWith\t" + end);
Console.ReadLine();

// Comparar dos cadenas
bool sonIguales = nombre.Equals("byron escobar"); // true
Console.WriteLine("usando Equals\t" + sonIguales);
Console.ReadLine();

// Formatear una cadena con valores de variables
string saludo = String.Format("Hola, {0}!", nombre); // "Hola, Byron Escobar!"
Console.WriteLine("usando Format\t" + saludo);
Console.ReadLine();

// Interpolación de cadenas
string mensaje = $"Hola, {nombre}! Tienes {edad} años."; // "Hola, Byron Escobar! Tienes 30 años."
Console.WriteLine("Interpolacion de cadenas\t" + mensaje);
Console.ReadLine();

//PROPIEDADES DE DATOS STRING 
Console.ForegroundColor =ConsoleColor.Green;
Console.WriteLine("PROPIEDADES DE DATOS STRING");
Console.ResetColor();
int longitud1 = nombre.Length; // 13
Console.WriteLine("longuitud de cadena usando length\t" + longitud1);
Console.ReadLine();

// Muesttra un caracter de la cadena
string nombre2 = "Byron Escobar";
char primerCaracter = nombre2[0];
Console.WriteLine("muestra el primer caracter de la cadena\t" + primerCaracter);
Console.ReadLine();
