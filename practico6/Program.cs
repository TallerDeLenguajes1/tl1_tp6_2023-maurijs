// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

int inicio, longSubcadena;
// Obtener la longitud de la cadena y mostrar por pantalla
Console.WriteLine("Ingrese una cadena\n");
string? cadena = Console.ReadLine();
int longitud = cadena.Length;
Console.WriteLine("Longitud de la cadena: " + longitud);

// Concatenar dos cadenas distintas
Console.Write("Ingrese una segunda cadena: ");
string? segundaCadena = Console.ReadLine();
string? concatenacion = cadena + segundaCadena;
Console.WriteLine("Concatenación de ambas cadenas: " + concatenacion);

// Extraer una subcadena de la cadena ingresada
Console.Write("Ingrese el índice de inicio: ");
int.TryParse(Console.ReadLine(), out inicio);
Console.Write("Ingrese la longitud de la subcadena: ");
int.TryParse(Console.ReadLine(), out longSubcadena);
string subcadena = concatenacion.Substring(inicio,longSubcadena);
Console.WriteLine("Subcadena extraída: " + subcadena);

// Realizar operaciones utilizando la calculadora
double num1, num2, resultado;

Console.Write("Ingrese el primer número: ");
double.TryParse(Console.ReadLine(), out num1);

Console.Write("Ingrese el segundo número: ");
double.TryParse(Console.ReadLine(), out num2);

resultado = sumar(num1, num2);
Console.WriteLine("la suma de " + num1 + " y de "+ num2 +" es igual a: " + resultado);


Console.Write("Ingrese una cadena de texto: ");
cadena = Console.ReadLine();

// Recorriendo la cadena con un ciclo foreach
Console.WriteLine("Recorriendo cada caracter de la cadena de texto:");
foreach (char? letra in cadena)
{
    Console.WriteLine(letra);
}   

Console.Write("Ingrese la palabra a buscar de la anterior cadena: ");
string? palabraBuscada = Console.ReadLine();

// Buscando la ocurrencia de una palabra en la cadena
if (cadena.Contains(palabraBuscada))
{
    Console.WriteLine($"La palabra '{palabraBuscada}' se encontró en la cadena.");
}
else
{
    Console.WriteLine($"La palabra '{palabraBuscada}' no se encontró en la cadena.");
}

// Convirtiendo la cadena a mayúsculas y minúsculas
string? cadenaMayusculas = cadena.ToUpper();
Console.WriteLine("Cadena en mayúsculas: " + cadenaMayusculas);

string? cadenaMinusculas = cadena.ToLower();
Console.WriteLine("Cadena en minúsculas: " + cadenaMinusculas);


Console.Write("Ingrese una cadena separada por un delimitador: ");
string? cadenaSeparada = Console.ReadLine();

Console.Write("Ingrese el delimitador: ");
string? delimitador = Console.ReadLine();

// Dividiendo la cadena por caracteres utilizando Split(delimitador)
string[] elementos = cadenaSeparada.Split(delimitador); //Si el argumento es vacio el delimitador es el espacio en blanco
Console.WriteLine("Elementos separados:\n");

foreach (string elemento in elementos)
{
    Console.WriteLine(elemento);
}

Console.Write("Ingrese una ecuación simple: ");
string? ecuacion = Console.ReadLine();
ecuacion = ecuacion.Trim();

// Evaluando y resolviendo la ecuación
string?[] partes;
float operando1, operando2;
foreach (char numero in ecuacion)
{
    if (numero == '+')
    {
        partes = ecuacion.Split('+');
        if (float.TryParse(partes[0], out operando1)  && float.TryParse(partes[1], out operando2))
        {
            resultado = operando1 + operando2;
            Console.WriteLine(operando1 + " + " + operando2 + " = " + resultado);
        }
    }
    if (numero == '-')
    {
        partes = ecuacion.Split('-');
        if (float.TryParse(partes[0], out operando1)  && float.TryParse(partes[1], out operando2))
        {
            resultado = operando1 - operando2;
            Console.WriteLine(operando1 + " - " + operando2 + " = " + resultado);
        }
    }
    if (numero == '*')
    {
         partes = ecuacion.Split('*');
        if (float.TryParse(partes[0], out operando1)  && float.TryParse(partes[1], out operando2))
        {
            resultado = operando1 * operando2;
            Console.WriteLine(operando1 + " * " + operando2 + " = " + resultado);
        }
    }
    if (numero == '/')
    {
         partes = ecuacion.Split('/');
        if (float.TryParse(partes[0], out operando1)  && float.TryParse(partes[1], out operando2))
        {
            if (operando2 != 0)
            {
                resultado = operando1 / operando2;
                Console.WriteLine(operando1 + " / " + operando2 + " = " + resultado);
            } else
            {
                Console.WriteLine("No se puede dividir por cero");
            }
        }
    }
}

/*Funcion trim()
string cadena = "***Hola mundo!!!";
char[] caracteresAEliminar = { '*', '!' };
string cadenaSinCaracteres = cadena.Trim(caracteresAEliminar);

Console.WriteLine(cadenaSinCaracteres);

escribira: Hola mundo
Elimina los otros caracteres
*/



// declaracion de funciones


double sumar(double a, double b)
{
    return a + b;
}
 