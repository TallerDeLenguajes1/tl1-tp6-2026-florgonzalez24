// Console.WriteLine("Hello, World!");

// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

int num, invertido = 0;
Console.WriteLine("Ingrese un numero entero: ");

string numString = Console.ReadLine()??"";
bool resultado = int.TryParse(numString, out num);

if (resultado)
{
    Console.WriteLine("El numero ingresado es: " + num);
    if (num > 0)
    {
        while (num != 0)
        {
            int aux = num % 10;
            invertido = (invertido * 10) + aux;
            num /= 10;
        }
        string salida = "El numero invertido es: " + invertido;
        Console.WriteLine(salida);
    }
}
else
{
    Console.WriteLine("Error");
}

