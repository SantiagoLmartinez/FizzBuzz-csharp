/*
Paso 1: implementar las reglas del desafío FizzBuzz
Con el editor de .NET, implemente cada una de las reglas.

Reglas de FizzBuzz:

Valores de salida entre 1 y 100; un número por línea.
Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.
*/
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($" {i} - FizzBuzz -");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz -");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($" {i} - Buzz -");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}