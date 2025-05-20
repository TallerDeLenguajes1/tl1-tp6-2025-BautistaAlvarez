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
