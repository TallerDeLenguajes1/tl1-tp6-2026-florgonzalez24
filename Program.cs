// Console.WriteLine("Hello, World!");

// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

// int num, invertido = 0;
// Console.WriteLine("Ingrese un numero entero: ");

// string numString = Console.ReadLine()??"";
// bool resultado = int.TryParse(numString, out num);

// if (resultado)
// {
//     Console.WriteLine("El numero ingresado es: " + num);
//     if (num > 0)
//     {
//         while (num != 0)
//         {
//             int aux = num % 10;
//             invertido = (invertido * 10) + aux;
//             num /= 10;
//         }
//         string salida = "El numero invertido es: " + invertido;
//         Console.WriteLine(salida);
//     }
// }
// else
// {
//     Console.WriteLine("Error");
// }


//CALCULADORA V1
int opcion, volver = 1;
float num1, num2;
bool resultado, EsNumero1, EsNumero2;

do
{
    //verifica que este entre las opciones
    do
    {
        Console.WriteLine("1. Sumar \n2. Restar \n3. Multiplicar \n4. Dividir ");
        Console.Write("\nSeleccione una opcion: ");
        string numString = Console.ReadLine() ?? "";
        resultado = int.TryParse(numString, out opcion);

    } while (opcion < 1 || opcion > 4);

    //verifica que sea numero lo q me ingreso el usuario
    do
    {
        //num1
        Console.Write("\nIngrese num1: ");
        string num1String = Console.ReadLine() ?? "";
        EsNumero1 = float.TryParse(num1String, out num1);

    } while (!EsNumero1);

    do
    {
        //num2
        Console.Write("Ingrese num2: ");
        string num2String = Console.ReadLine() ?? "";
        EsNumero2 = float.TryParse(num2String, out num2);
    } while (!EsNumero2);

    double operacion = 0;

    switch (opcion)
    {
        case 1:
            operacion = Math.Round(num1 + num2, 2);
            break;

        case 2:
            operacion = Math.Round(num1 - num2, 2);
            break;

        case 3:
            operacion = Math.Round(num1 * num2, 2);
            break;

        case 4:
            if (num2 != 0)
            {
                operacion = Math.Round(num1 / num2, 2);

            }
            else
            {
                Console.WriteLine("No se puede realizar la division en 0");
                continue;
            }
            break;
    }

    Console.WriteLine("\nRESULTADO = " + operacion);

    Console.Write("\nDesea volver a operar? (1. SI // 2. NO) --> ");
    string respuestaString = Console.ReadLine() ?? "";
    int.TryParse(respuestaString, out volver);

} while (volver == 1);
