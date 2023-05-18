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
bool resultado;

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
}