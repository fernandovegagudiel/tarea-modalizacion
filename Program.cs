Console.WriteLine("Bienvenido al programa \n");
//Console.Clear();
int opcion = 10;
do
{
    Console.WriteLine("  Opciones  ");
    Console.WriteLine(" (1) Calculadora Básica ");
    Console.WriteLine(" (2) Validación de contraseña ");
    Console.WriteLine(" (3) Números primos ");
    Console.WriteLine(" (4) Suma de números pares ");
    Console.WriteLine(" (5) Conversión de temperatura ");
    Console.WriteLine(" (6) Contador de vocales ");
    Console.WriteLine(" (7) Cálculo de factorial ");
    Console.WriteLine(" (8) Juego de adivinanza ");
    Console.WriteLine(" (9) Paso por referencia ");
    Console.WriteLine(" (10) Tabla de multiplicar ");
    Console.Write("Seleccione una opción: ");

} while (!int.TryParse(Console.ReadLine(), out opcion));

switch (opcion)
{
    case 1:
        {
            calculadorabasic();
        }
        break;
    case 2:
        {
            validacioncontra();
         }
        break;
    case 3:
        {
            numerosprimo();
        }
        break;
    case 4:
        {
            sumanumerospares();
        }
        break;
    case 5:
        {
            conversiondetempe();
        }
        break;
    case 6:
        {
            contadorvocales();
        }
        break;
    case 7:
        {
            factorial();
        }
        break;
    case 8:
        {
            juegoadivinaza();
        }
        break;
    case 9:
        {
            pasoreferencia();
        }
        break;
    case 10:
        {
            tablamultiplicar();
        }
        break;
    default:
        Console.WriteLine("Opcion no valida: ");
        break;
}


static void calculadorabasic()
{  // Funciones de la calculadora
    static int Suma(int nu1 = 0, int nu2 = 0)
    {
        return nu1 + nu2;
    }

    static int Resta(int nu1 = 0, int nu2 = 0)
    {
        return nu1 - nu2;
    }

    static int Multiplicar(int nu1 = 1, int nu2 = 1)
    {
        return nu1 * nu2;
    }

    static double Dividir(int nu1 = 0, int nu2 = 1)
    {
        return nu2 != 0 ? (double)nu1 / nu2 : double.NaN;
    }
    Console.WriteLine("Seleccionaste Calculadora Básica:");
    Console.WriteLine("Ingrese el primer número:");
    int nu1, nu2;
    while (!int.TryParse(Console.ReadLine(), out nu1))
    {
        Console.WriteLine("Entrada no válida. Ingrese un número entero:");
    }
    Console.WriteLine("Ingrese el segundo número:");
    while (!int.TryParse(Console.ReadLine(), out nu2))
    {
        Console.WriteLine("Entrada no válida. Ingrese un número entero:");
    }
    Console.WriteLine("Elige una opción (1 al 4):");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. División");

    int op;
    while (!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 4)
    {
        Console.WriteLine("Entrada no válida. Elige una opción (1 al 4):");
    }
    switch (op)
    {
        case 1:
            Console.WriteLine($"La Suma es: {Suma(nu1, nu2)}");
            break;
        case 2:
            Console.WriteLine($"La Resta es: {Resta(nu1, nu2)}");
            break;
        case 3:
            Console.WriteLine($"La Multiplicación es: {Multiplicar(nu1, nu2)}");
            break;
        case 4:
            if (nu2 != 0)
            {
                Console.WriteLine($"La División es: {Dividir(nu1, nu2)}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
            break;
    }
}
        
static void validacioncontra()
{
    Console.WriteLine("Seleccionaste Validacion de contraseña: ");
    string contra = "fernando123";

    Console.WriteLine("ingrese la contraseña : ");
    contra = Console.ReadLine();

    if (contra == "fernando123")
    {
        Console.WriteLine("contraseña correcta ");
    }
    else
    {
        Console.WriteLine("contraseña incorrecta");
    }

}
 
static void numerosprimo ()
{
    Console.WriteLine("Seleccionaste Números primos: ");
    Console.WriteLine("ingrese un numero: ");
    int num = int.Parse(Console.ReadLine());
    bool primo = true;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            primo = false;
            break;
        }
    }
    if (primo)
    {
        Console.WriteLine("El numero es primo ");
    }
    else
    {
        Console.WriteLine("El numero no es primo ");
    }
}

static void sumanumerospares()
{
    int numero;
    int sumaPares = 0;
    Console.WriteLine("Ingrese números enteros (ingrese 0 para terminar):");
    while (true)
    {
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida. Ingrese un número entero:");
        }

        if (numero == 0)
        {
            break;
        }

        if (numero % 2 == 0)
        {
            sumaPares += numero;
        }
    }
    Console.WriteLine($"La suma de todos los números pares ingresados es: {sumaPares}");
}

static void conversiondetempe()
{
    Console.WriteLine("Seleccionaste Conversión de temperatura: ");
    static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
    int opc;
    double grados, resultado;
    Console.WriteLine("Seleccione la opción de conversión:");
    Console.WriteLine("1. Celsius a Fahrenheit");
    Console.WriteLine("2. Fahrenheit a Celsius");

    // Validar la opción seleccionada
    while (true)
    {
        Console.Write("Opción: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out opc) && (opc == 1 || opc == 2))
            break;
        else
            Console.WriteLine("Por favor ingrese una opción válida (1 o 2).");
    }
    // Solicitar el valor a convertir
    Console.Write("Ingrese el valor a convertir: ");
    while (!double.TryParse(Console.ReadLine(), out grados))
    {
        Console.Write("Por favor ingrese un número válido: ");
    }
    // Realizar la conversión según la opción seleccionada
    if (opc == 1)
    {
        resultado = CelsiusAFahrenheit(grados);
        Console.WriteLine($"{grados} grados Celsius equivalen a {resultado} grados Fahrenheit.");
    }
    else
    {
        resultado = FahrenheitACelsius(grados);
        Console.WriteLine($"{grados} grados Fahrenheit equivalen a {resultado} grados Celsius.");
    }
}

static void contadorvocales()
{
    Console.WriteLine("Seleccionaste Contador de vocales:");

    // Función para contar vocales
    int ContarVocales(string texto)
    {
        int contador = 0;
        foreach (char c in texto)
        {
            if ("aeiouAEIOU".Contains(c))
            {
                contador++;
            }
        }
        return contador;
    }

    Console.Write("Introduce una palabra: ");
    string palabra = Console.ReadLine();  // Leer una palabra
    int vocales = ContarVocales(palabra);
    Console.WriteLine("El número de vocales es: " + vocales);
}

static void factorial()
{
    Console.WriteLine("Seleccionaste Contador de vocales:");

    // Función para contar vocales
    int ContarVocales(string texto)
    {
        int contador = 0;
        foreach (char c in texto)
        {
            if ("aeiouAEIOU".Contains(c))
            {
                contador++;
            }
        }
        return contador;
    }

    Console.Write("Introduce una palabra: ");
    string palabra = Console.ReadLine();  // Leer una palabra
    int vocales = ContarVocales(palabra);
    Console.WriteLine("El número de vocales es: " + vocales);
}

static void juegoadivinaza()
{
    Random random = new Random();
    int numeroAleatorio = random.Next(1, 101); // El número aleatorio estará entre 1 y 100.

    Console.WriteLine("Adivina el número entre 1 y 100: ");

    while (true)
    {
        int numeroIngresado;
        // Verificamos si la entrada es válida
        if (int.TryParse(Console.ReadLine(), out numeroIngresado))
        {
            if (numeroIngresado == numeroAleatorio)
            {
                Console.WriteLine("¡Felicidades, adivinaste el número!");
                break; // Termina el juego si el número es adivinado
            }
            else if (numeroIngresado > numeroAleatorio)
            {
                Console.WriteLine("La densidad es alta. Intenta con un número más bajo.");
            }
            else
            {
                Console.WriteLine("La densidad es baja. Intenta con un número más alto.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingresa un número válido.");
        }
    }
}

static void pasoreferencia()
{
    Console.WriteLine("Seleccionaste Paso por referencia: ");
    static void Intercambiar(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    int num1, num2;

    // Solicitar los números al usuario
    Console.Write("Ingrese el primer número: ");
    num1 = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el segundo número: ");
    num2 = int.Parse(Console.ReadLine());

    // Mostrar valores originales
    Console.WriteLine("\nValores originales:");
    Console.WriteLine("Num1: {0}, Num2: {1}", num1, num2);

    // Llamar a la función para intercambiar los valores
    Intercambiar(ref num1, ref num2);

    // Mostrar valores intercambiados
    Console.WriteLine("\nValores intercambiados:");
    Console.WriteLine("Num1: {0}, Num2: {1}", num1, num2);
}

static void tablamultiplicar ()
{
    Console.WriteLine("Seleccionaste Tabla de multiplicar:");
    // Función para generar la tabla de multiplicar
    int[] GenerarTabla(int numero)
    {
        int[] tabla = new int[10];
        for (int i = 0; i < 10; i++)
        {
            tabla[i] = numero * (i + 1);
        }
        return tabla;
    }

    // Función para mostrar la tabla de multiplicar
    void MostrarTabla(int[] tabla, int numero)
    {
        for (int i = 0; i < tabla.Length; i++)
        {
            Console.WriteLine($"{numero} x {i + 1} = {tabla[i]}");
        }
    }

    int numeroTabla;
    Console.WriteLine("Ingrese un número para mostrar su tabla de multiplicar:");
    while (!int.TryParse(Console.ReadLine(), out numeroTabla))
    {
        Console.WriteLine("Entrada no válida. Ingrese un número entero:");
    }
    int[] tablaMultiplicar = GenerarTabla(numeroTabla);
    MostrarTabla(tablaMultiplicar, numeroTabla);
}