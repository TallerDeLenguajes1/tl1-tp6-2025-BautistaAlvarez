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
string? num1Str = Console.ReadLine();
string? num2Str = Console.ReadLine();
int num1, num2;

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

