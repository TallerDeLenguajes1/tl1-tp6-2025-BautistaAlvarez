// See https://aka.ms/new-console-template for more information
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
int  continuar = 0;
do
{
    Console.WriteLine("Ingrese 1 para Sumar, 2 para Restar, 3 para Multiplicar o 4 para Dividir");
    string? operacionStr = Console.ReadLine();
    string? num1Str, num2Str;
    int num1, num2, resultado, operacion;
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
                    Console.WriteLine("La suma de " + num1 + " y de " + num2 + " es: " + resultado);
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
                    Console.WriteLine("La resta de " + num1 + " y de " + num2 + " es: " + resultado);
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
                    Console.WriteLine("El resultado de " + num1 + " y de " + num2 + " es: " + resultado);
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
                        resultado = num1 / num2;
                        Console.WriteLine("El resultado de " + num1 + " y de " + num2 + " es: " + resultado);
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
