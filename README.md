[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

¿String es un tipo por valor o por referencia?
string es un tipo por referencia, pero se comporta como inmutable.
Esto significa que cuando modificás una cadena, en realidad se crea una nueva instancia en memoria, y la original no cambia.


string a = "hola";
string b = a;
a = "chau";
Console.WriteLine(b); // "hola" (no cambia, aunque es por referencia)

Qué secuencias de escape tiene el tipo string?
Las secuencias de escape comienzan con \ e indican caracteres especiales dentro de una cadena. Algunas comunes:

Secuencia	Significado
\n	    Salto de línea
\t	    Tabulación
\\	    Barra invertida (\)
\"	    Comillas dobles (")
\'	    Comillas simples (')
\r	    Retorno de carro
\b	    Retroceso
\a	    Alerta (beep)

¿Qué sucede cuando se utiliza el carácter @ y $ antes de una cadena de texto?
@ (verbatim string)
Permite escribir la cadena tal como está, sin interpretar las secuencias de escape.
Muy útil para rutas de archivos o cadenas largas.


string ruta = @"C:\Users\Nombre\Documentos";
$ (interpolación de cadenas)
Permite insertar variables dentro de una cadena usando {}.

string nombre = "Juan";
string saludo = $"Hola, {nombre}";
Se pueden usar juntos: $@"..."
Para usar interpolación y texto literal sin escapar barras:

string carpeta = "Documentos";
string ruta = $@"C:\Users\Nombre\{carpeta}";