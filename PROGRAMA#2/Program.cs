// Pedir los dos números al usuario
Console.WriteLine("Introduzca el primer número:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca el segundo número:");
int num2 = int.Parse(Console.ReadLine());

// Pedir el operador al usuario
Console.WriteLine("Introduzca el operador (+, -, *, /):");
string operador = Console.ReadLine();

// Validar los datos
if (!ValidarOperador(operador))
{
    Console.WriteLine("Operador no válido. Introduzca +, -, *, /");
    return;
}

// Realizar la operación
int resultado = 0;
switch (operador)
{
    case "+":
        resultado = num1 + num2;
        break;
    case "-":
        resultado = num1 - num2;
        break;
    case "*":
        resultado = num1 * num2;
        break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("No se puede dividir por 0.");
            return;
        }
        resultado = num1 / num2;
        break;
}

// Mostrar el resultado
Console.WriteLine("El resultado de {0} {1} {2} es: {3}", num1, operador, num2, resultado);


static bool ValidarOperador(string operador)
{
    return operador == "+" || operador == "-" || operador == "*" || operador == "/";
}


