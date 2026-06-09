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
float num1 = 0, num2 = 0;
bool resultado, EsNumero1, EsNumero2;

Console.Write("Ingrese una cadena de texto: ");
string CadenaTexto = Console.ReadLine() ?? "";
int longitud = CadenaTexto.Length;
Console.WriteLine($"La longitud de la cadena de texto ingresada es: {longitud}\n");

Console.Write("Ingrese una cadena de texto: ");
string CadenaTexto2 = Console.ReadLine() ?? "";
Console.WriteLine($"Cadenas concatendas: {CadenaTexto} {CadenaTexto2}\n");

string subCadena = CadenaTexto.Substring(longitud - 1); //extrae desde el indice 1 hasta el final
Console.WriteLine($"Subcadena de la primera cadena: {subCadena}\n");

foreach (char letra in CadenaTexto2)
{
    Console.WriteLine(letra);
}

Console.Write("\nIngrese la palabra que quiere buscar en la cadena de texto: ");
string BuscarPalabra = Console.ReadLine() ?? "";

int contador = 0, posicion = 0;

while ((posicion = CadenaTexto.IndexOf(BuscarPalabra, posicion)) != -1)
{
    contador++;
    posicion += BuscarPalabra.Length;
}

if (contador > 0)
{
    Console.WriteLine($"La palabra {BuscarPalabra} fue encontrada {contador} veces en el texto\n");
}
else
{
    Console.WriteLine($"La palabra {BuscarPalabra} NO fue encontrada en el texto\n");

}

string textoMayuscula = CadenaTexto2.ToUpper();
Console.WriteLine($"La cadena en mayuscula: {textoMayuscula}");

string textoMinuscula = CadenaTexto2.ToLower();
Console.WriteLine($"La cadena en mayuscula: {textoMinuscula}\n");

string[] palabras = CadenaTexto.Split('o');

foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}

do
{
    //verifica que este entre las opciones
    do
    {
        Console.WriteLine("\n1. Sumar \n2. Restar \n3. Multiplicar \n4. Dividir \n5. Maximo \n6. Minimo \n7. Valor Absoluto\n8. Cuadrado \n9. Raiz cuadrada \n10. Seno \n11. Coseno \n12. Parte entera de un tipo float\n");
        Console.Write("\nSeleccione una opcion: ");
        string numString = Console.ReadLine() ?? "";
        resultado = int.TryParse(numString, out opcion);

    } while (!resultado || opcion < 1 || opcion > 12);


    double operacion = 0;

    if (opcion >= 1 && opcion <= 6)
    {
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
    }
    else
    {
        do
        {
            Console.Write("\nIngrese un numero: ");
            string num1String = Console.ReadLine() ?? "";
            EsNumero1 = float.TryParse(num1String, out num1);

        } while (!EsNumero1);
    }

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

        case 5:
            operacion = Math.Round(Math.Max(num1, num2), 2);
            break;

        case 6:
            operacion = Math.Round(Math.Min(num1, num2), 2);
            break;

        case 7:
            operacion = Math.Round(Math.Abs(num1), 2);
            break;

        case 8:
            operacion = Math.Round(Math.Pow(num1, 2), 2);
            break;

        case 9:
            if (num1 >= 0)
            {
                operacion = Math.Round(Math.Sqrt(num1), 2);
            }
            else
            {
                Console.WriteLine("No se puede realizar la raiz cuadrada de un numero negativo");
                continue;
            }
            break;

        case 10:
            operacion = Math.Round(Math.Sin(num1), 2);
            break;

        case 11:
            operacion = Math.Round(Math.Cos(num1), 2);
            break;

        case 12:
            operacion = (int)num1;
            break;

    }
    string resultadoString = operacion.ToString();
    Console.WriteLine("\nRESULTADO = " + resultadoString);

    Console.Write("\nDesea volver a operar? (1. SI // 2. NO) --> ");
    string respuestaString = Console.ReadLine() ?? "";
    int.TryParse(respuestaString, out volver);

} while (volver == 1);

float resultadoEcuacion = 0;
Console.WriteLine("Ingrese la ecuacion que desea resolver: ");
string ecuacion = Console.ReadLine() ?? "";
char operador = ' ';

if (ecuacion.Contains('+'))
    operador = '+';
else if (ecuacion.Contains('-'))
    operador = '-';
else if (ecuacion.Contains('*'))
    operador = '*';
else if (ecuacion.Contains('/'))
    operador = '/';

string[] partes = ecuacion.Split(operador);

float numero1 = float.Parse(partes[0]);
float numero2 = float.Parse(partes[1]);

switch (operador)
{
    case '+':
        resultadoEcuacion = numero1 + numero2;
        break;

    case '-':
        resultadoEcuacion = numero1 - numero2;
        break;

    case '*':
        resultadoEcuacion = numero1 * numero2;
        break;

    case '/':
        if (num2 != 0)
        {
            resultadoEcuacion = numero1 / numero2;
        }
        else
        {
            Console.WriteLine("No se puede realizar la division en 0");
        }
        break;
}

Console.WriteLine($"Resultado = {resultadoEcuacion}");