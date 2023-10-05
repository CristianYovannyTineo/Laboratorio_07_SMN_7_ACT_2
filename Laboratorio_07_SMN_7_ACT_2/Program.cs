// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese un número límite: ");
int limite = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Divisores de Omar Orlandini en el rango del 1 al {limite}:");

for (int i = 1; i <= limite; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine($"Divisor de Omar Orlandini {i / 3}: {i}");
    }
}
Console.WriteLine("Limite alcanzado: " + limite);
