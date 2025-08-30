// HENDRIX DEVADIP AGUIRRE ZAMORA
// PRIMER EJERCICIO:

Console.WriteLine("----Bienvenido al programa para calcular el área total de un terreno----");
Console.WriteLine("* El terreno tiene un ancho de 5 varas");
Console.Write("Ingrese la longitud del terreno en varas: "); float longitud = float.Parse(Console.ReadLine() ?? "0");
float area_total = 5 * longitud;
float manzanas = area_total / 1428.8F;
Console.WriteLine($"- El área total del terreno es: {area_total} varas");
Console.WriteLine($"- El área total de terreno es de: {manzanas} manzanas");
Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// SEGUNDO EJERCICIO:

Console.WriteLine("----Bienvenido al programa para calcular el tiempo total de un viaje----");
Console.WriteLine("La distancia que se recorrerá es de 40 km");
int distanciaRecorrida = 40;
Console.Write("Ingrese la velocidad promedio en km/h: "); double velocidad_promedio = double.Parse(Console.ReadLine() ?? "0");
double tiempo_total = distanciaRecorrida / velocidad_promedio;
Console.WriteLine($"- El tiempo total del viaje es de: {tiempo_total} horas");
Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// TERCER EJERCICIO:

Console.WriteLine("----Bienvenido al programa para calcular la distancia total recorrida por un ciclista----");
Console.Write("Ingrese la velocidad promedio en km/h: "); double velocidadPromedio = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Ingrese el tiempo recorrido en horas: "); double tiempoRecorrido = double.Parse(Console.ReadLine() ?? "0");
double distanciarecorrida = velocidadPromedio * tiempoRecorrido;
Console.WriteLine($"- La distancia total recorrida por el ciclista es de: {distanciarecorrida} km");
Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// CUARTO EJERCICIO:

Console.WriteLine("----Bienvenido al programa para calcular el volumen total de un tanque de agua----");
Console.Write("Ingrese la longitud del tanque en metros: "); double longitudTanque = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Ingrese el ancho del tanque en metros: "); double anchoTanque = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Ingrese la altura del tanque en metros: "); double alturaTanque = double.Parse(Console.ReadLine() ?? "0");
double volumenTanque = longitudTanque * anchoTanque * alturaTanque;
Console.WriteLine($"El volumen total de agua recolectada en el tanque es de: {volumenTanque} m³");
Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// QUINTO EJERCICIO:

Console.WriteLine("----Bienvenido al programa para calcular la cantidad total de baldes de leche producida en un día----");
Console.Write("Ingrese el volumen promedio de leche producida por vaca, en litros: "); double volumenVaca = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Ingrese el número total de vacas ordeñadas: "); int numeroVacas = int.Parse(Console.ReadLine() ?? "0");
double totalLitros = volumenVaca * numeroVacas;
double totalBaldes = totalLitros / 20;
Console.WriteLine($"- La cantidad total de baldes de leche producida en un día es de: {totalBaldes} baldes");
Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// SEXTO EJERCICIO:

Console.WriteLine("----Bienvenido al programa para determinar si un número es positivo, negativo o cero----");
Console.Write("Ingrese un número: "); int numero = int.Parse(Console.ReadLine() ?? "0");

if (numero > 0)
{
    Console.WriteLine("El número es positivo");
}
else if (numero == 0)
{
    Console.WriteLine("El número es igual a cero");
}
else
{
    Console.WriteLine("El número es negativo");
}

Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// SEPTIMO EJERCICIO:

Console.WriteLine("----Bienvenido al programa para determinar el día de la semana----");
int dia;
Console.Write("Ingrese un número del 1 al 7, para determinar el día de la semana: "); dia = int.Parse(Console.ReadLine() ?? "0");
switch (dia)
{
    case 1:
        Console.WriteLine("El día es Lunes");
        break;
    case 2:
        Console.WriteLine("El día es Martes");
        break;
    case 3:
        Console.WriteLine("El día es Miércoles");
        break;
    case 4:
        Console.WriteLine("El día es Jueves");
        break;
    case 5:
        Console.WriteLine("El día es Viernes");
        break;
    case 6:
        Console.WriteLine("El día es Sábado");
        break;
    case 7:
        Console.WriteLine("El día es Domingo");
        break;
    default:
        Console.WriteLine("El número ingresado no es válido, por favor ingrese un número del 1 al 7");
        break;
}

Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// OCTAVO EJERCICIO:

Console.WriteLine("----Bienvenido al programa para evaluar la calificación de un estudiante----");
Console.Write("Ingrese la calificación del estudiante (0-100): "); int calificacion = int.Parse(Console.ReadLine() ?? "0");
if (calificacion >= 70 && calificacion <= 100)
{
    Console.WriteLine("El estudiante aprobó la clase");
}
else if (calificacion <= 69 && calificacion >= 50)
{
    Console.WriteLine("El estudiante debe entrar en recuperación de la clase");
}
else if (calificacion < 50 && calificacion >= 0)
{
    Console.WriteLine("El estuidante reprobó la clase");
}
else
{
    Console.WriteLine("La calificación ingresada no es válida");
}
Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// NOVENO EJERCICIO:

Console.WriteLine("----Bienvenido al programa para evaluar la calificación de un estudiante----");
Console.Write("Ingrese la calificación del estudiante (0-100): "); int calificacion1 = int.Parse(Console.ReadLine() ?? "0");

switch (calificacion1)
{
    case int n when n >= 70 && n <= 100:
        Console.WriteLine("El estudiante aprobó la clase");
        break;
    case int n when n <= 69 && n >= 50:
        Console.WriteLine("El estudiante debe entrar en recuperación de la clase");
        break;
    case int n when n < 50 && n >= 0:
        Console.WriteLine("El estudiante reprobó la clase");
        break;
    default:
        Console.WriteLine("La calificación ingresada no es válida");
        break;
}

Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// DECIMO EJERCICIO:

Console.WriteLine("----Bienvenido al programa para determinar si un año es bisiesto o no----");
Console.Write("Ingrese un año: "); int año = int.Parse(Console.ReadLine() ?? "0");
if (año % 4 == 0)
{
    Console.WriteLine("El año es bisiesto");
}
else
{
    Console.WriteLine("El año no es bisiesto");
}
Console.WriteLine("----Gracias por utilizar el programa----");
Console.WriteLine(" ");

// EJERCICIO CLASE

Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine() ?? "0");
if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");

}
else
{
    Console.WriteLine("Eres menor de edad");
}
Console.WriteLine("----Gracias por utilizar el programa----");

// PRIMER EJERCICIO CLASE

int num1 = 0, num2 = 0, suma = 0;
Console.Write("- Dame el primer valor: ");
num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("- Dame el segundo valor: ");
num2 = int.Parse(Console.ReadLine() ?? "0");
suma = num1 + num2;
Console.WriteLine($"- La suma es: {suma}");

// SEGUNDO EJERCICIO CLASE

Console.WriteLine("Programa utilizando switch");
Console.Write("- Ingrese un número del 1 al 3: ");
string opcion = Console.ReadLine() ?? "";
switch (opcion)
{
    case "1":
        Console.WriteLine("Tu carrera es: Medicina");
        break;
    case "2":
        Console.WriteLine("Tu carrera es: Sistemas");
        break;
    case "3":
        Console.WriteLine("Has decidido ser emprendedor");
        break;
    default:
        Console.WriteLine("Ingrese un valor del rango de 1 a 3");
        break;
}

// TERCER EJERCICIO CLASE

int suma2 = 0;
Console.Write("Ingrese un número: "); numero = int.Parse(Console.ReadLine() ?? "0");
while (numero >= 0)
{
    suma2 += numero;
    Console.Write("Dime un #: ");
    numero = int.Parse(Console.ReadLine() ?? "0");
}

Console.WriteLine($"La suma es:" + suma);

// CUARTO EJERCICIO CLASE

string opcion2;
do
{
    Console.WriteLine("1. Bienvenido.");
    Console.WriteLine("2. Saluda");
    Console.WriteLine("3. Salir");
    Console.Write("Digite su opción: ");
    opcion2 = Console.ReadLine() ?? "";
} while (opcion2 != "3");



