// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b=a;

Console.WriteLine("Valor de a:"+a);
Console.WriteLine("Valor de b:"+b);

//ejercicio1, instalar extension devkit 
Console.WriteLine("Ingrese un numero de 2 cifras mayor a 0:");
int valIngresado;
int ultimoNum;
int numInvertido = 0;
string? stringIngresado = Console.ReadLine();
if(int.TryParse(stringIngresado, out valIngresado)){

    while (valIngresado > 0)
    {
            ultimoNum = valIngresado%10;
            numInvertido = numInvertido*10 + ultimoNum;
            valIngresado /= 10;
    }
    Console.WriteLine($"Numero invertido: {numInvertido}");
}else{
    Console.WriteLine("Invalido");
}

//ejercicio2
string? num1Str, num2Str;
int num1, num2;
int  continuar = 0;
do
{
    Console.WriteLine("Ingrese 1 para Sumar, 2 para Restar, 3 para Multiplicar o 4 para Dividir");
    string? operacionStr = Console.ReadLine();
    int operacion;
    double resultado;
    if (int.TryParse(operacionStr, out operacion) && operacion > 0 && operacion < 5)
    {
        switch (operacion)
        {

            case 1:
                Console.WriteLine("Ingrese 2 numeros para la operacion:");
                num1Str = Console.ReadLine();
                num2Str = Console.ReadLine();
                if (int.TryParse(num1Str, out num1) && int.TryParse(num2Str, out num2))
                {
                    resultado = num1 + num2;
                    Console.WriteLine("La suma de " + num1.ToString() + " y de " + num2.ToString() + " es: " + resultado.ToString());
                }
                else
                {
                    Console.WriteLine("Numeros invalidos");
                }
                break;
            case 2:
                Console.WriteLine("Ingrese 2 numeros para la operacion:");
                num1Str = Console.ReadLine();
                num2Str = Console.ReadLine();
                if (int.TryParse(num1Str, out num1) && int.TryParse(num2Str, out num2))
                {
                    resultado = num1 - num2;
                    Console.WriteLine("La resta de " + num1.ToString() + " y de " + num2.ToString() + " es: " + resultado.ToString());
                }
                else
                {
                    Console.WriteLine("Numeros invalidos");
                }
                break;
            case 3:
                Console.WriteLine("Ingrese 2 numeros para la operacion:");
                num1Str = Console.ReadLine();
                num2Str = Console.ReadLine();
                if (int.TryParse(num1Str, out num1) && int.TryParse(num2Str, out num2))
                {
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de " + num1.ToString() + " y de " + num2.ToString() + " es: " + resultado.ToString());
                }
                else
                {
                    Console.WriteLine("Numero Invalido");
                }
                break;
            case 4:
                Console.WriteLine("Ingrese 2 numeros para la operacion:");
                num1Str = Console.ReadLine();
                num2Str = Console.ReadLine();
                if (int.TryParse(num1Str, out num1) && int.TryParse(num2Str, out num2))
                {
                    if (num2 != 0)
                    {
                        resultado = (double)num1 / num2;
                        Console.WriteLine("El resultado de " + num1.ToString() + " y de " + num2.ToString() + " es: " + resultado.ToString("0.00"));
                    }
                    else
                    {
                        Console.WriteLine("El divisor no puede ser 0");
                    }
                }
                else
                {
                    Console.WriteLine("Numeros invalidos");
                }
                break;
        }
        Console.WriteLine("Desea realizar otra operacion? Ingrese 0 para terminar y otro numero para repetir");
        string? continuarStr = Console.ReadLine();
        int.TryParse(continuarStr, out continuar);
    }
    else
    {
        Console.WriteLine("Numero invalido");
    }
} while (continuar != 0);

//ejercicio3
float numFloat;
Console.WriteLine("Ingrese un numero para hacerle unas operaciones:");
string? numFloatStr = Console.ReadLine();
if (float.TryParse(numFloatStr, out numFloat))
{
    double valAbs = Math.Abs(numFloat);
    double cuadrado = Math.Pow(numFloat, 2);
    double seno = Math.Sin(numFloat);
    double coseno = Math.Cos(numFloat);
    int partEntera = (int)Math.Truncate(numFloat);

    Console.WriteLine("Valor absoluto del numero: " + valAbs);
    Console.WriteLine("Cuadrado del numero: " + cuadrado);
    if (numFloat >= 0)
    {
        double raizCuadrada = Math.Sqrt(numFloat);
        Console.WriteLine("Raiz cuadrada del numero " + raizCuadrada);
    }
    else
    {
        Console.WriteLine("No existe su raiz cuadrada, numero negativo");
    }
    Console.WriteLine("Seno del numero: " + seno);
    Console.WriteLine("Coseno del numero: " + coseno);
    Console.WriteLine("Parte entera del numero: " + partEntera);
}
else
{
    Console.WriteLine("Numero invalido");
}
Console.WriteLine("Ingrese ahora 2 numeros:");
num1Str = Console.ReadLine();
num2Str = Console.ReadLine();


if (int.TryParse(num1Str, out num1) && int.TryParse(num2Str, out num2))
{
    int max = Math.Max(num1, num2);
    int min = Math.Min(num1, num2);
    Console.WriteLine($"Numero maximo: {max}");
    Console.WriteLine($"Numero minimo: {min}");
}
else
{
    Console.WriteLine("Numero invalidos");
}

//ejercicio4
Console.WriteLine("Ingrese una cadena de texto:");
string? cadena = Console.ReadLine();
if (cadena != null)
{
    int longitud = cadena.Length;
    Console.WriteLine($"La longitud de {cadena} es {longitud}");
    Console.WriteLine("Ingrese una segunda cadena para concatenar:");
    string? cadena2 = Console.ReadLine();
    if (cadena2 != null)
    {

        string cadenaYCadena2 = cadena + " " + cadena2;
        Console.WriteLine($"La cadena concatenada es {cadenaYCadena2}");
        Console.WriteLine($"Otra forma concatenada es {cadena} {cadena2}");
    }
    else
    {
        Console.WriteLine("Segunda cadena invalida");
    }

    int subLong = longitud - 2; //con esto coloco el resto de la palabra que ingrese
    string subCadena = cadena.Substring(2, subLong);//lo coloco aqui
    Console.WriteLine($"La subcadena resultante es --{subCadena}--");

    Console.WriteLine("Caracter por caracter usando foreach");
    foreach (char caracter in cadena)
    {
        Console.WriteLine($"{caracter}");
    }

    int posicionStrBuscada = cadena.IndexOf("mundo");
    if (posicionStrBuscada != -1)
    {
        Console.WriteLine($"La palabra mundo fue encontrada en la posicion: {posicionStrBuscada}");
    }
    else
    {
        Console.WriteLine("La palabra mundo no fue encontrada");
    }

    Console.WriteLine("Cadena en mayuscula:");
    Console.WriteLine(cadena.ToUpper());
    Console.WriteLine("Cadena en minusculas:");
    Console.WriteLine(cadena.ToLower());
}
else
{
    Console.WriteLine("No ingreso cadena valida");
}
