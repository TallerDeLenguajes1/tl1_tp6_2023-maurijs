// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);
/*Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el
texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del
número sólo si éste es mayor a 0.*/
string? s;
int n, resto;
/*bool resultado;

Console.WriteLine("Ingrese un numero: ");
s = Console.ReadLine();

resultado = int.TryParse(s, out n); 
if (resultado)
{
    Console.WriteLine(n);
    if (n>0)
    {
        while (n > 0)  {
            resto = n % 10;
            n = n / 10;
            Console.Write(resto);
        }

    }
}*/

int inicio, longSubcadena;
// Obtener la longitud de la cadena y mostrar por pantalla
string cadena = "Hola, soy una cadena";
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
string subcadena = cadena.Substring(inicio, longSubcadena);
Console.WriteLine("Subcadena extraída: " + subcadena);

// Realizar operaciones utilizando la calculadora
double num1, num2, resultado;

Console.Write("Ingrese el primer número: ");
double.TryParse(Console.ReadLine(), out num1);

Console.Write("Ingrese el segundo número: ");
double.TryParse(Console.ReadLine(), out num2);

resultado = sumar(num1, num2);
Console.WriteLine("la suma de " + num1 + " y de "+ num2 +" es igual a: " + resultado);


double sumar(double a, double b)
{
    return a + b;
}
