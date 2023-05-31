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


Console.WriteLine("Ingrese una operacion: \n1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Valor Absoluto\n6-El cuadrado\n7-La raiz cuadrada\n8-El seno\n9-El coseno\n10-La parte entera de un tipo float");
int op;
double n1, n2, resultado;
string? opcion = Console.ReadLine();
string? operando1;
string? operando2 = "0";
do
{

    //verifico que la opcion sea un numero valido
    if (int.TryParse(opcion, out op) && op<10 && op>0)
    {
        if (op<5)
        {
            Console.WriteLine("Ingrese los dos numeros a operar");
            //Ingresa por teclado un string para poder validar si es un numero 
            operando1 = Console.ReadLine();
            operando2 = Console.ReadLine();
        } else
        {
            Console.WriteLine("Ingrese un numero calculadora");
            //Ingresa por teclado un string para poder validar si es un numero 
            operando1 = Console.ReadLine();
        }
        if(double.TryParse(operando1, out n1) && double.TryParse(operando2, out n2))
        {
            switch (op)
            {
                 case 1:
                    resultado = sumar(n1, n2);
                    Console.WriteLine("El resultado es " + resultado);
                    break;
                case 2:
                    resultado = restar(n1, n2);
                    Console.WriteLine("El resultado es " + resultado);
                    break;
                case 3:
                    resultado = multiplicar(n1, n2);
                    Console.WriteLine("El resultado es " + resultado);
                    break;
                case 4:
                    resultado = dividir(n1, n2);
                    Console.WriteLine("El resultado es " + resultado);
                    break;
                case 5:
                    resultado = valorAbsoluto(n1);
                    Console.WriteLine("Valor absoluto: " + resultado); 
                    break;
                case 6:
                    resultado = cuadrado(n1);
                    Console.WriteLine("Cuadrado: " + resultado);
                    break;
                case 7:
                    resultado = raizCuadrada(n1);
                    Console.WriteLine("Raíz cuadrada: " + resultado);
                    break;
                case 8:
                    resultado = seno(n1);
                    Console.WriteLine("Seno: " + resultado);
                    break;
                case 9:
                    resultado = coseno(n1);
                    Console.WriteLine("Coseno: " + resultado);
                    break;
                case 10:
                    resultado = parteEntera(n1);
                    Console.WriteLine("Parte entera: " + resultado);
                    break;
            }
        }
    Console.WriteLine("Ingrese una operacion: \n1-Sumar\n2-Restar\n3-Multiplicar\n4-Dividir\n5-Valor Absoluto\n6-El cuadrado\n7-La raiz cuadrada\n8-El seno\n9-El coseno\n10-La parte entera de un tipo float"); 
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


double dividir(double a, double b)
{
    double resultado = a/b;
    return resultado;

}
double sumar(double a, double b)
{
    return a + b;
}
double restar(double a, double b)
{
    return a - b;
}

double multiplicar(double a, double b)
{
    return a * b;
}