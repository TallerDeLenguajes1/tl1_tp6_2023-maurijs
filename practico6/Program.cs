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


Console.WriteLine("Ingrese una operacion: \n1-Valor Absoluto\n2-El cuadrado\n3-La raiz cuadrada\n4-El seno\n5-El coseno\n6-La parte entera de un tipo float");
int op;
double n1, resultado;
string? opcion = Console.ReadLine();

do
{

    //verifico que la opcion sea un numero valido
    if (int.TryParse(opcion, out op) && op<6 && op >0)
    {
        Console.WriteLine("Ingrese un numero calculadora");
        //Ingresa por teclado un string para poder validar si es un numero 
        string? operando1 = Console.ReadLine();
        if(double.TryParse(operando1, out n1))
        {
            Console.WriteLine("El resultado es: ");
            switch (op)
            {
                case 1:
                    resultado = valorAbsoluto(n1);
                    Console.WriteLine("Valor absoluto: " + resultado); 
                    break;
                case 2:
                    resultado = cuadrado(n1);
                    Console.WriteLine("Cuadrado: " + resultado);
                    break;
                case 3:
                    resultado = raizCuadrada(n1);
                    Console.WriteLine("Raíz cuadrada: " + resultado);
                    break;
                case 4:
                    resultado = seno(n1);
                    Console.WriteLine("Seno: " + resultado);
                    break;
                case 5:
                    resultado = coseno(n1);
                    Console.WriteLine("Coseno: " + resultado);
                    break;
                case 6:
                    resultado = parteEntera(n1);
                    Console.WriteLine("Parte entera: " + resultado);
                    break;
            }
        }
    Console.WriteLine("Ingrese una operacion: \n0-Salir\n1-Valor Absoluto\n2-El cuadrado\n3-La raiz cuadrada\n4-El seno\n5-El coseno\n6-La parte entera de un tipo float");
    opcion = Console.ReadLine();
    }

} while (op != 0);


Console.WriteLine("\nIngrese dos numeros a comparar:\n");
string? numero1 = Console.ReadLine();
string? numero2 = Console.ReadLine();
float num1, num2;

if(float.TryParse(numero1, out num1) && float.TryParse(numero2, out num2))
{
    if(num1 > num2)
    {
        Console.WriteLine("\n El " + num1 + " es mayor que " + num2);
    } else if (num2 > num1)
    {
        Console.WriteLine("\n El " + num2 + " es mayor que " + num1);
    } else
    {
        Console.WriteLine("\nLos dos numeros son iguales");
    }  
}


//declaracion de funciones
double valorAbsoluto(double a)
{
    double resultado = Math.Abs(a);
    return resultado;
}

double cuadrado(double a)
{
    return a*a;
}

double raizCuadrada(double a)
{
    double resultado = (double)Math.Sqrt(a);
    return a;
}

double seno(double a)
{
    double resultado = Math.Sin(a);
    return resultado;
}
double coseno(double a)
{
    double resultado = (float)Math.Cos(a);
    return resultado;
}

double parteEntera(double a)
{
    return (int)a;
}
