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

/*string? s;
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
}  */

Console.WriteLine("Operacion: \n1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir");
string? opcion = Console.ReadLine();
Console.WriteLine("Ingrese los dos numeros a operar");
string? operando1 = Console.ReadLine();
string? operando2 = Console.ReadLine();
int op, n1, n2;

float result;
if(int.TryParse(operando1, out n1) && int.TryParse(operando2, out n2)  && int.TryParse(opcion, out op) && op<4 && op >=0)
{
    Console.WriteLine("El resultado es: ");
    switch (op)
    {
        case 1:
            result = sumar(n1, n2);
            Console.Write(result);
            break;
        case 2:
            result = restar(n1, n2);
            Console.Write(result);
            break;
        case 3:
            result = multiplicar(n1, n2);
            Console.Write(result);
            break;
        case 4:
            result = dividir(n1, n2);
            Console.Write(result);
            break;
    }

}
//declaracion de funciones
float dividir(int a, int b)
{
    float resultado = (float)a / b;
    return resultado;

}
int sumar(int a, int b)
{
    return a + b;

}
float restar(int a, int b)
{
    return a - b;

}
float multiplicar(int a, int b)
{
    return a * b;

}