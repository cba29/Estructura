// See https://aka.ms/new-console-template for more information

////Suma de Dígitos: 
////15) Toma un número entero y calcula la suma de sus dígitos. 
////declaracion d evariables
//Console.WriteLine("Ingrese un número entero:");
//int numero = Convert.ToInt32(Console.ReadLine());
//int sumaDigitos = 0;
//// algoritmo
//while (numero != 0)
//{
//    sumaDigitos += numero % 10; // Sumar el último dígito al resultado
//    numero /= 10; // Eliminar el último dígito
//}
////resultados
//Console.WriteLine("La suma de los dígitos es: " + sumaDigitos);


////Cálculo del Área de un Círculo: 
////14) Pide el radio de un círculo al usuario y calcula su área. 
////declaracion d evariables
//Console.WriteLine("Ingrese el radio del círculo:");
//double radio = Convert.ToDouble(Console.ReadLine());
////algoritmo
//double area = Math.PI * radio * radio;
//// Mostrar el resultado
//Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);


////Generador de Tablas de Multiplicar: 
////13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario. 
////declaración de  variables
//Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
//int numero = Convert.ToInt32(Console.ReadLine());
////resuktado
//Console.WriteLine("Tabla de multiplicar de " + numero + ":");
////algoritmo
//for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine(numero + " x " + i + " = " + (numero * i));
// }


////Palíndromo: 
////12) Verifica si una palabra ingresada por el usuario es un palíndromo.
////declaraciion d evariables
//Console.WriteLine("Ingrese una palabra:");
//string palabra = Console.ReadLine().ToLower();

//bool esPalindromo = true;
////algoritmo
//for (int i = 0; i < palabra.Length / 2; i++)
//{
//    if (palabra[i] != palabra[palabra.Length - i - 1])
//    {
//        esPalindromo = false;
//        break;
//    }
//}
////resultados
//if (esPalindromo)
//{
//    Console.WriteLine("La palabra \"" + palabra + "\" es un palíndromo.");
//}
//else
//{
//    Console.WriteLine("La palabra \"" + palabra + "\" no es un palíndromo.");
//}


////Ordenamiento de Lista: 
////11) Ordena una lista de números ingresados por el usuario de menor a mayor. 
//declaracion de variables
//Console.WriteLine("Ingrese los números separados por espacios:");
//string[] numerosStr = Console.ReadLine().Split(' ');
////algoritmo
//List<int> numeros = new List<int>();
//foreach (string numStr in numerosStr)
//{
//    if (int.TryParse(numStr, out int num))
//    {
//        numeros.Add(num);
//    }
//    else
//    {
//        Console.WriteLine("Se ha ingresado un valor no válido: " + numStr);
//    }
//}
//numeros = numeros.OrderBy(num => num).ToList();
////resuktados
//Console.WriteLine("La lista ordenada de menor a mayor es:");
//foreach (int num in numeros)
//{
//    Console.Write(num + " ");
//        }


////Números de la Serie Fibonacci: 
////10) Genera los primeros 10 números de la serie Fibonacci. 
////declaración de variables
//int n = 10;
//int a = 0; 
//int b = 1; 
////resultado
//Console.WriteLine("Los primeros " + n + " números de la serie Fibonacci son:");
//Console.Write(a + " " + b + " ");
////algoritmo
//for (int i = 2; i < n; i++)
//{
//    int temp = a + b;
//    Console.Write(temp + " ");
//    a = b;
//    b = temp;
//}


////Contador de Vocales: 
////9) Cuenta el número de vocales en una cadena de texto. 
////declartacion d evariables
//Console.WriteLine("Ingrese un texto:");
//string texto = Console.ReadLine().ToLower();
//int contadorVocales = 0;
////algoritmo
//foreach (char c in texto)
//{
//    if ("aeiou".Contains(c))
//    {
//        contadorVocales++;
//    }
//}
////resultado
//Console.WriteLine("El número de vocales en la cadena de texto es: {0}", contadorVocales);


////Lista de Cuadrados: 
////8) Crea una lista de los cuadrados de los primeros 10 números naturales. 
////declaracion de variables
//List<int> cuadrados = new List<int>();
////algoritmo
//for (int i = 1; i <= 10; i++)
//{
//    int cuadrado = i * i;
//    cuadrados.Add(cuadrado);
//}
////resultado
//Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
//foreach (int cuadrado in cuadrados)
//{
//    Console.WriteLine(cuadrado);
//}


////Suma de Números Pares: 
////7) Calcula la suma de los números pares en un rango especificado por el usuario. 
////declaración de variables
//Console.WriteLine("Ingrese el número inicial del rango:");
//int inicio = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Ingrese el número final del rango:");
//int fin = Convert.ToInt32(Console.ReadLine());

//int sumaPares = 0;
////algoritmo
//for (int i = inicio; i <= fin; i++)
//{
//    if (i % 2 == 0)
//    {
//        sumaPares += i;
//    }
//}
////resultado
//Console.WriteLine("La suma de los números pares en el rango de [{0}, {1}] es: {2}", inicio, fin, sumaPares);


////Inversión de Cadena: 
////6) Toma una cadena de texto y muestra su inversión. 
//// inverso de una palabra
////declaración de variabeles
//Console.WriteLine("Ingrese una oración:");
//string cadena = Console.ReadLine();
//string cadenaInvertida = InvertirCadena(cadena);
////resultADO
//Console.WriteLine("La cadena invertida es: " + cadenaInvertida);
////algoritmo
//static string InvertirCadena(string cadena)
//{
//    char[] caracteres = cadena.ToCharArray();
//    Array.Reverse(caracteres);
//    return new string(caracteres);
//}


////Número Primo: 
////5) Verifica si un número ingresado por el usuario es primo o no. 
////declaracion de variables
//Console.WriteLine("=== Número primo ===");
//Console.WriteLine("Ingrese un número:");
//var numero = int.Parse(Console.ReadLine());
//// Algoritmo
//bool esPrimo = true;

//if (numero <= 1)
//{
//    esPrimo = false; // Los números menores o iguales a 1 no son primos
//}
//else
//{
//    for (int i = 2; i * i <= numero; i++)
//    {
//        if (numero % i == 0)
//        {
//            esPrimo = false; // Si encuentra un divisor diferente de 1 y del propio número, no es primo
//            break; // No es necesario seguir verificando
//        }
//    }
//}
//// Resultado
//if (esPrimo)
//{
//    Console.WriteLine("El número ingresado es primo.");
//}
//else
//{
//    Console.WriteLine("El número ingresado NO es primo.");
//}


////Calculadora de Factorial: 
////4) Crea una función que calcule la factorial de un número. 
//Console.WriteLine("=====Programa Factorial=====");
//Console.WriteLine("Ingrese un número para calcular el factorial:");
//int numero = int.Parse(Console.ReadLine());
//double factorial = 1;
////algoritmo
//if (numero < 0)
//{
//    Console.WriteLine("No se puede calcular el factorial su número es negativo.");
//}
//else
//{
//    for (int i = 1; i <= numero; i++)
//    {
//        factorial *= i;
//    }
//  //  resultado
//    Console.WriteLine($"El factorial de {numero} es: {factorial}");
//    Console.Read();
//}


////Área de un Triángulo: 
////3) Pide la base y la altura de un triángulo al usuario y calcula su área. 
////ejercicio 3
//Console.WriteLine("==== area triangulo ====");
//Console.WriteLine("Ingrese la altura: ");
//var altura = double.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese la base el triangulo: ");
//var numero = double.Parse(Console.ReadLine());
////algoritmo
//var area = (altura * numero) / 2;
////resultado
//Console.WriteLine($"El area de el triangulo es: {area}");
//Console.Read();


////Verificación de Número Par o Impar: 
////2) Solicita un número al usuario y determina si es par o impar. 
////Declaración de variables y asignación
//Console.WriteLine("=====Programa1=====");
//Console.Write("hola escribe un numero: ");
//var numero = Console.ReadLine();
//var nint = int.Parse(numero);
//var espar = false;
////resolver colocar algoritmo
//if (nint % 2 == 0)
//{
//    espar = true;
//}
////mostrar resultado
//Console.WriteLine(espar ? "Es Par " : "Es impar");
//Console.Read();


////Ejercicio parte 01: 
////Operaciones Básicas: 
////1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario. 
////variables
//Console.WriteLine("ingrese El primer numero: ");
//var numero1 = double.Parse(Console.ReadLine());
//Console.WriteLine("ingrese El SEgundo numero: ");
//var numero2 = double.Parse(Console.ReadLine());
////algoritmo
//var suma = numero1 + numero2;
//var resta = numero1 - numero2;
//var multiplicacion = numero1 * numero2;
////var division = numero1 / numero2;
//var division = 0.0; // Initialize division variable
//if (numero2 != 0) // Check if numero2 is not zero before performing division
//{
//    division = numero1 / numero2;
//}
//else
//{
//    Console.WriteLine("La división es indeterminada porque el segundo número es cero.");
//}
//// Resultados
//Console.WriteLine($"La suma de los números es: {suma}");
//Console.WriteLine($"La resta de los números es: {resta}");
//Console.WriteLine($"La multiplicación de los números es: {multiplicacion}");

//// Only display division result if it's not indeterminable
//if (numero2 != 0)
//{
//    Console.WriteLine($"La división de los números es: " + Math.Round(division, 2));
//}

